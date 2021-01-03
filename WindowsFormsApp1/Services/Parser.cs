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
using VK_PARSER.Models;

namespace VK_PARSER.Services
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

                LogViewer.WriteLog($"Обработка группы {groups[g]}...");

                VkCollection<User> members = null;

                IsWork = true;

                try
                {
                    members = await VK.Api.Groups.GetMembersAsync(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All });
                }
                catch (VkNet.Exception.CannotBlacklistYourselfException mex)
                {
                    LogViewer.WriteLog($"Владелец группы {groups[g]} скрыл пользователей");
                    logger.Error(mex, $"Владелец группы {groups[g]} скрыл пользователей");
                }
                catch (VkNet.Exception.GroupAccessDeniedException gex)
                {
                    LogViewer.WriteLog($"Группа {groups[g]} в доступе к группе отказано");
                    logger.Error(gex, $"Группа {groups[g]} в доступе к группе отказано");
                }
                catch (VkNet.Exception.InvalidGroupIdException ex)
                {
                    LogViewer.WriteLog($"Группа {groups[g]} не найдена");
                    logger.Error(ex, $"Группа {groups[g]} не найдена");
                }
                catch (Exception exc)
                {
                    LogViewer.WriteLog($"Ошибка при работе программы. Дополнительная информация указана в папке Logs");
                    logger.Error(exc, $"ERROR_CRITICAL" + exc.StackTrace);
                }

                if (members != null && IsWork)
                {
                    GetPhones(members);
                    countMembers = (long)members.TotalCount;

                    if (countMembers > 1000)
                    {
                        long i = 999;

                        LogViewer.WriteLog($"Группа : {groups[g]}. Обработано {i + 1} из {countMembers}");

                        while (IsWork)
                        {
                            GetPhones(await VK.Api.Groups.GetMembersAsync(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All, Count = count, Offset = i }));

                            if ((i + count) > countMembers)
                            {
                                IsWork = false;
                                break;
                            }

                            i += count;

                            LogViewer.WriteLog($"Группа : {groups[g]}. Обработано {i + 1} из {countMembers}");
                        }
                    }
                    else
                    {
                        LogViewer.WriteLog($"Группа : {groups[g]}. Обработано {countMembers} из {countMembers}");
                    }
                }

                if (!IsWork)
                {
                    break;
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
                    String phone = GetValidatePhone(phonesMale, members[i]);

                    if(!String.IsNullOrWhiteSpace(phone))
                    {
                        PhonesViewer.SetMalePhone(phone);
                    }
                }
                else if (members[i].Sex == VkNet.Enums.Sex.Female)
                {
                    String phone = GetValidatePhone(phonesFemale, members[i]); ;

                    if (!String.IsNullOrWhiteSpace(phone))
                    {
                        PhonesViewer.SetFemalePhone(phone);
                    }
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

        private String GetValidatePhone(List<String> Target, User user)
        {
            String phone = null;

            if (user.HasMobile != null && (bool)user.HasMobile && !String.IsNullOrWhiteSpace(user.MobilePhone))
            {
                phone = ValidateNumber(user.MobilePhone.Trim());

                if (phone != null)
                {
                    Target.Add(phone);
                    LogViewer.WriteLog($"{user.FirstNameNom} {user.LastNameNom} - {phone}");
                }
            }

            return phone;
        }

        public void ExportData()
        {
            try
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
            catch(Exception ex)
            {
                logger.Error(ex.StackTrace);

                LogViewer.WriteLog("Ошибка при экспорте номеров. Дополнительные сведения смотреть в Logs");
            }       
        }

        public void ExportSplitData()
        {   
            try
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

                    using (StreamWriter sw = new StreamWriter(File.Open(path + "_М.txt", FileMode.Create)))
                    {
                        for (int i = 0; i < phonesMale.Count; i++)
                        {
                            sw.WriteLine(phonesMale[i]);
                        }
                    }

                    using (StreamWriter sw = new StreamWriter(File.Open(path + "_Ж.txt", FileMode.Create)))
                    {
                        for (int i = 0; i < phonesFemale.Count; i++)
                        {
                            sw.WriteLine(phonesFemale[i]);
                        }
                    }

                    LogViewer.WriteLog("Номера раздельно успешно экспортированы");
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.StackTrace);

                LogViewer.WriteLog("Ошибка при экспорте номеров. Дополнительные сведения смотреть в Logs");
            }
        }

        public void StopWork()
        {
            IsWork = false;
        }
    }
}
