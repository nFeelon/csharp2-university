using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    public partial class MainForm : Form
    {

        public Account banking;
        public MainForm()
        {
            InitializeComponent();
            banking = new Account();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DepositType.SelectedIndex = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Number.Value = 0;
            DepositType.SelectedIndex = 0; 
            BalancePicker.Value = 250;
            DateDeposit.Value = DateTime.Now;
            AddAds.Checked = false;
            AddBanking.Checked = false;
            AddSMS.Checked = false;

            UserName.Text = string.Empty;
            UserSurname.Text = string.Empty;
            UserFathername.Text = string.Empty;
            UserBirthday.SetDate(DateTime.Today);
            UserPassportNumber.Text = string.Empty;

            InfoList.Items.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(UserName.Text.Equals("") || UserSurname.Text.Equals("") || UserFathername.Text.Equals("") || UserPassportNumber.Text.Equals("")) {
                MessageBox.Show("Все поля должны быть заполнены!"); 
                return;
            }

            Deposit account = new Deposit()
            {
                Number = Int32.Parse(Number.Text),
                DepositType = DepositType.Text,
                Balance = BalancePicker.Value,
                DateDeposit = DateDeposit.Value,
                Ads = AddAds.Checked,
                Banking = AddBanking.Checked,
                SMS = AddSMS.Checked,
                Owner = new Owner
                {
                    UserName = UserName.Text,
                    UserSurname = UserSurname.Text,
                    UserFathername = UserFathername.Text,
                    UserBirthday = UserBirthday.Text
                }
            };

            banking.DepositList.Add(account);

            account.Info = "Владелец: " + account.Owner.UserSurname + ", Баланс: " + account.Balance + " рублей, " + "Тип депозита: " + account.DepositType + ", " + "Номер счёта: " + account.Number;
            InfoList.Items.Add(account.Info);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, banking);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
            {
                banking = serializer.Deserialize(stream) as Account;
            }
            foreach (Deposit data in banking.DepositList)
                InfoList.Items.Add(data.Info);
        }
    }
}
