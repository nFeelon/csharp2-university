using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void ButtonSaveSort_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(ListBox.ObjectCollection));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
                serializer.Serialize(stream, searchListBox.Items);
        }

        private void ButtonSortByDate_Click(object sender, EventArgs e)
        {
            var elememts = AccountList.Elements.GetAccounts().OrderBy(el => el.DateDeposit);
            searchListBox.Items.Clear();

            foreach (var element in elememts)
                searchListBox.Items.Add(element.DateDeposit + " " + element.Info);
        }

        private void ButtonSortByType_Click(object sender, EventArgs e)
        {
            var elememts = AccountList.Elements.GetAccounts().OrderBy(el => el.DepositType);
            searchListBox.Items.Clear();

            foreach (var elememt in elememts)
                searchListBox.Items.Add(elememt.Info);
        }
    }
}
