using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class Parser
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private int count = 1000;
        private long countMembers;

        private Boolean userFilterAge = false;
        int startRange;
        int endRange;

        bool IsWork = false;

        private List<String> phonesMale = new List<string>(); //Мужской 
        private List<String> phonesFemale = new List<string>(); // Женский

        public Parser(Boolean UserFilterAge, int StartRange, int EndRange)
        {
            userFilterAge = UserFilterAge;
            startRange = StartRange;
            endRange = EndRange;
        }

        public async Task<ExportLists> StartParse(List<String> groups)
        {
            for(int g = 0; g < groups.Count; g++)
            {
                if(IsContainsGroupByName(groups[g], groups.GetRange(0,g)))
                {
                    LogViewer.WriteLog($"Группа {groups[g]} уже проходила обработку");
                    continue;
                }

                VkCollection<User> members = null;

                try
                {
                    members = await VK.Api.Groups.GetMembersAsync(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All });
                }
                catch (VkNet.Exception.GroupAccessDeniedException gex)
                {
                    LogViewer.WriteLog($"Группа {groups[g]} в доступе к группе отказано");
                    logger.Info(gex, $"Группа {groups[g]} в доступе к группе отказано");
                }
                catch (VkNet.Exception.InvalidGroupIdException ex)
                {
                    LogViewer.WriteLog($"Группа {groups[g]} не найдена");
                    logger.Info(ex, $"Группа {groups[g]} не найдена");
                }

                if (members != null)
                {
                    GetPhones(members);
                    countMembers = (long)members.TotalCount;

                    if (countMembers > 1000)
                    {
                        long i = 999;

                        IsWork = true;

                        while (IsWork)
                        {
                            GetPhones(await VK.Api.Groups.GetMembersAsync(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All, Count = count, Offset = i }));

                            if ((i + count) > countMembers)
                            {
                                IsWork = false;
                                break;
                            }

                            i += count;
                        }
                    }
                }       
            }

            return new ExportLists
            {
                phonesFemale = phonesFemale,
                phonesMale = phonesMale,
            };
        }

        private String ValidateNumber(String number)
        {
            String cleaned = RemoveNonNumeric(number);

            if (cleaned.Length == 11)
            {
                return cleaned;
            }

            return null;
        }

        private bool IsContainsGroupByName(String groupName, List<String> groups)
        {
            for (int g = 0; g < groups.Count; g++)
            {
                if(groups[g] == groupName)
                {
                    return true;
                }
            }

            return false;
        }

        private string RemoveNonNumeric(string phone)
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
        }

        private void GetPhones(VkCollection<User> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (userFilterAge)
                {
                    if (!ValidateAge(startRange, endRange, members[i]))
                    {
                        continue;
                    }
                }

                if (members[i].Sex == VkNet.Enums.Sex.Male)
                {
                    GetValidatePhone(phonesMale, members[i]);
                }
                else if (members[i].Sex == VkNet.Enums.Sex.Female)
                {
                    GetValidatePhone(phonesFemale, members[i]);
                }
            }
        }

        private Boolean ValidateAge(int Start, int End, User user)
        {
            if(user.BirthdayVisibility == VkNet.Enums.BirthdayVisibility.Invisible || user.BirthdayVisibility == VkNet.Enums.BirthdayVisibility.OnlyDayAndMonth)
            {
                return false;
            }

            string[] tempAge = user.BirthDate.Split('.');

            if (tempAge.Length == 3)
            {
                try
                {
                    int currAge = DateTime.Now.Year - Convert.ToInt32(tempAge[2]);

                    if (currAge < Start || currAge > End)
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        private void GetValidatePhone(List<String> Target, User user)
        {
            if (user.HasMobile != null && (bool)user.HasMobile && !String.IsNullOrWhiteSpace(user.MobilePhone))
            {
                String phone = ValidateNumber(user.MobilePhone.Trim());

                if (phone != null)
                {
                    Target.Add(phone);
                }
            }
        }

        public void ExportData()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.Filter = "Текстовый файл(*.txt)|*.txt";
            sfd.FilterIndex = 0;
            sfd.FileName = $"export{DateTime.Now.GetHashCode()}";
            sfd.SupportMultiDottedExtensions = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(File.Open(sfd.FileName, FileMode.Create)))
                {
                    for (int i = 0; i < phonesMale.Count; i++)
                    {
                        sw.WriteLine(phonesMale[i]);
                    }

                    for (int i = 0; i < phonesFemale.Count; i++)
                    {
                        sw.WriteLine(phonesFemale[i]);
                    }

                }

                LogViewer.WriteLog("Номера вместе успешно экспортированы");
            }
        }

        public void ExportSplitData()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.Filter = "Текстовый файл(*.txt)|*.txt";
            sfd.FilterIndex = 0;
            sfd.FileName = $"export{DateTime.Now.GetHashCode()}";
            sfd.SupportMultiDottedExtensions = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName.Substring(0, sfd.FileName.Length - 4);

                using (StreamWriter sw = new StreamWriter(File.Open(path + "(Муж).txt", FileMode.Create)))
                {
                    for (int i = 0; i < phonesMale.Count; i++)
                    {
                        sw.WriteLine(phonesMale[i]);
                    }
                }

                using (StreamWriter sw = new StreamWriter(File.Open(path + "(Жен).txt", FileMode.Create)))
                {
                    for (int i = 0; i < phonesFemale.Count; i++)
                    {
                        sw.WriteLine(phonesFemale[i]);
                    }
                }

                LogViewer.WriteLog("Номера раздельно успешно экспортированы");
            }
        }

        public void StopWork()
        {
            IsWork = false;
        }
    }
}
