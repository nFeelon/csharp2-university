using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        //Текстовые поля
        private void SearchDepositType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCleared = false;

            searchListBox.Items.Clear();

            if (searchDepositType.Text != "")
                foreach (var elem in AccountList.Elements.GetAccounts())
                    if (elem.DepositType == searchDepositType.Text)
                    {
                        searchListBox.Items.Add(elem.Info);
                        isCleared = true;
                    }

            if (!isCleared)
                searchListBox.Items.Clear();
        }

        private void SearchIdTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCleared = false;
            string result = Regex.Replace(SearchIdTextBox.Text, "[^0-9]", "");
            SearchIdTextBox.Text = result;

            searchListBox.Items.Clear();

            if (SearchIdTextBox.Text != "")
            {
                int searchID = Convert.ToInt32(SearchIdTextBox.Text);

                foreach (var elem in AccountList.Elements.GetAccounts())
                    if (elem.Number == searchID)
                    {
                        searchListBox.Items.Add(elem.Info);
                        isCleared = true;
                    }
            }

            if (!isCleared)
                searchListBox.Items.Clear();
        }

        private void SearchUserSurname_TextChanged(object sender, EventArgs e)
        {
            bool isCleared = false;

            searchListBox.Items.Clear();

            if (SearchUsernameTextbox.Text != "")
                foreach (var elem in AccountList.Elements.GetAccounts())
                    if (elem.Owner.UserSurname == SearchUsernameTextbox.Text)
                    {
                        searchListBox.Items.Add(elem.Info);
                        isCleared = true;
                    }

            if (!isCleared)
                searchListBox.Items.Clear();
        }
    }
}
