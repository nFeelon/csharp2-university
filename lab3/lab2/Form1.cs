using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    public partial class MainForm : Form
    {
        const string STATUS_LASTDO = "Последнее действие: ";
        const string STATUS_QUANTITY = "Количество объектов: ";
        const string STATUS_DATETIME = "Дата и время: ";

        public Account banking;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banking = new Account();
            DepositType.SelectedIndex = 0;
        }

        //Кнопки нижние
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

            ChangeStatusBar("очистка данных");

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsNullTextboxes())
            {
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
                    UserBirthday = UserBirthday.Text,
                    PassportNumber = UserPassportNumber.Text
                }
            };

            var validationContext = new ValidationContext(account);
            var validationContext2 = new ValidationContext(account.Owner);
            var validationResults = new List<ValidationResult>();
            bool isValidDeposit = Validator.TryValidateObject(account, validationContext, validationResults, true) && Validator.TryValidateObject(account.Owner, validationContext2, validationResults, true);

            if (!isValidDeposit)
            {
                foreach (var val in validationResults)
                    MessageBox.Show(val.ErrorMessage);
            }
            else
            {
                account.Info = "Владелец: " + account.Owner.UserSurname + ", Баланс: " + account.Balance + " рублей, " + "Тип депозита: " + account.DepositType + ", " + "Номер счёта: " + account.Number;

                banking.DepositList.Add(account);
                AccountList.Elements.AddElem(account);
                InfoList.Items.Add(account.Info);

                ChangeStatusBar("добавление объекта");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(Account));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.OpenOrCreate))
                serializer.Serialize(stream, banking);

            ChangeStatusBar("сериализация");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(Account));
            using (FileStream stream = new FileStream("Bank.xml", FileMode.Open))
                banking = serializer.Deserialize(stream) as Account;

            foreach (Deposit data in banking.DepositList)
            {
                InfoList.Items.Add(data.Info);
                AccountList.Elements.AddElem(data);
            }

            ChangeStatusBar("десериализация");
        }

        private void OpenHistoryForm_Click(object sender, EventArgs e)
        {
            Form2 formHistory = new Form2();
            formHistory.Show();
        }

        //Кнопки меню верхнего
        private void ToolStripButtonSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.Show();
        }

        private void ToolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: 1.3 (редакция 3 лабы)\nРазработчик: Филон Никита");
        }

        private void ToolStripHide_Click(object sender, EventArgs e)
        {
            if (ToolStripButtonAbout.Visible)
            {
                ToolStripButtonSearch.Visible = false;
                ToolStripButtonAbout.Visible = false;
                ToolStripButtonSort.Visible = false;
                ToolStripHide.Text = ">>>";
            }
            else
            {
                ToolStripButtonAbout.Visible = true;
                ToolStripButtonSearch.Visible = true;
                ToolStripButtonSort.Visible = true;
                ToolStripHide.Text = "<<<";
            }
        }


        //Функции
        private void ChangeStatusBar(string value)
        {
            StatusBarLast.Text = STATUS_LASTDO + value;
            StatusBarQuantity.Text = STATUS_QUANTITY + InfoList.Items.Count;
            StatusBarDate.Text = STATUS_DATETIME + DateTime.Now;
        }

        private bool IsNullTextboxes() => UserName.Text.Equals("") || UserSurname.Text.Equals("") || UserFathername.Text.Equals("") || UserPassportNumber.Text.Equals("");

    }
}
