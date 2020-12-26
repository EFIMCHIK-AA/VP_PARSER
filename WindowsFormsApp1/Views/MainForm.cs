using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ulong countMan;
        int count = 1000;
        long countMembers;

        List<String> phones = new List<string>();

        private void Start_B_Click(object sender, EventArgs e)
        {
            ListNumbers_L.DataSource = null;
            ListNumbers_L.Items.Clear();

            String nameGroup = ID_Group_TB.Text.Trim();

            VkCollection<User> members = VK.Api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = nameGroup, Fields = UsersFields.All });
            GetPhones(members);
            countMembers = (long)members.TotalCount;

            if(countMembers > 1000)
            {
                long i = 999;

                while (true)
                {
                    GetPhones(VK.Api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = nameGroup, Fields = UsersFields.All, Count = count, Offset = i }));

                    if((i + count) > countMembers)
                    {
                        break;
                    }

                    i += count;
                }
            }

            CountMale_TB.Text = (countMembers - (int)countMan).ToString();
            CountFemale_TB.Text = countMan.ToString();
            CountMembers_TB.Text = countMembers.ToString();
            ListNumbers_L.DataSource = phones;
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
                if (members[i].Sex == VkNet.Enums.Sex.Male)
                {
                    countMan++;
                }

                if (members[i].HasMobile != null && (bool)members[i].HasMobile && !String.IsNullOrWhiteSpace(members[i].MobilePhone))
                {
                    String phone = ValidateNumber(members[i].MobilePhone.Trim());

                    if (phone != null)
                    {
                        phones.Add(phone);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
