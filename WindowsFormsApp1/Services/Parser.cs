using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class Parser
    {
        private int count = 1000;
        private long countMembers;

        private Boolean userFilterAge = false;
        int startRange;
        int endRange;

        private List<String> phonesMale = new List<string>(); //Мужской 
        private List<String> phonesFemale = new List<string>(); // Женский

        public Parser(Boolean UserFilterAge, int StartRange, int EndRange)
        {
            userFilterAge = UserFilterAge;
            startRange = StartRange;
            endRange = EndRange;
        }

        public ExportLists StartParse(List<String> groups)
        {
            for(int g = 0; g < groups.Count; g++)
            {
                VkCollection<User> members = VK.Api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All });
                GetPhones(members);
                countMembers = (long)members.TotalCount;

                if (countMembers > 1000)
                {
                    long i = 999;

                    while (true)
                    {
                        GetPhones(VK.Api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = groups[g], Fields = UsersFields.All, Count = count, Offset = i }));

                        if ((i + count) > countMembers)
                        {
                            break;
                        }

                        i += count;
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
    }
}
