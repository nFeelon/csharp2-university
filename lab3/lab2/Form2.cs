using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    public partial class Form2 : Form
    {
        ListOperations listOperations;
        Operation operation;

        int id = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OperationType.DataSource = Enum.GetValues(typeof(EOperationTypes));
            OperationType.SelectedIndex = 0;
            listOperations = new ListOperations();
        }

        //Кнопки
        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            InfoHistoryBox.Items.Clear();

            NumericUpDown.Value = 0;
            OperationType.SelectedIndex = 0;
            id = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            operation = new Operation()
            {
                OperationType = (EOperationTypes)OperationType.SelectedIndex,
                Value = (int)NumericUpDown.Value,
                ID = id,
                Date = DateTime.Now,
                Info = "Номер: " + id++ + ", Тип операции: " + OperationType.Text + ", Сумма: " + NumericUpDown.Value + ", Дата: " + DateTime.Now.ToString()
            };

            listOperations.operations.Add(operation);
            InfoHistoryBox.Items.Add(operation.Info);
        }

        private void SaveHistoryButton_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(ListOperations));
            using (FileStream stream = new FileStream("History.xml", FileMode.OpenOrCreate))
                serializer.Serialize(stream, listOperations);
        }

        private void LoadHistoryButton_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(ListOperations));
            using (FileStream stream = new FileStream("History.xml", FileMode.Open))
                listOperations = serializer.Deserialize(stream) as ListOperations;

            foreach (Operation data in listOperations.operations)
                InfoHistoryBox.Items.Add(data.Info);

            id = listOperations.operations[listOperations.operations.Count-1].ID+1;
        }
    }
}
