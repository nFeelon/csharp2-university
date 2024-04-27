using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace lab4_5
{
    public partial class MainWindow : Window
    {
        private string connectionString = "Data Source=NFILON;Initial Catalog=OOP;Integrated Security=True";

        private string lastAction_text = "Last action: ";

        private ObservableCollection<Product> items;
        private readonly List<ObservableCollection<Product>> _elements = new List<ObservableCollection<Product>>();
        private int cursor = 0;


        public MainWindow()
        {
            InitializeComponent();
            this.items = new ObservableCollection<Product>()
            {
                new Product(
                    "iPhone", DeviceType.Phone, "Невероятно крутой телефон для самых настоящих ценителей", 699, @"D:\Программирование\4 sem\lab4-5\Database\Icons\iPhone_1.jpg")
            };

            ShopDataGrid.ItemsSource = items;
            _elements.Add(new ObservableCollection<Product>(items));
        }


        //Кнопки добавления элементов
        private void AddPriceSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AddPriceLabel.Content = "$: " + (int)AddPriceSlider.Value;
        }

        private void AddExplorerButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == true)
                DeviceImage.Source = new BitmapImage(new System.Uri(openFileDialog.FileName));
        }
        private void AddFinalButton_Click(object sender, RoutedEventArgs e)
        {
            DeviceType type = (DeviceType)AddTypeComboBox.SelectedIndex;
            if (AddTypeComboBox.SelectedIndex == -1)
                type = DeviceType.Other;

            string fotoUrl = DeviceImage.Source != null ? DeviceImage.Source.ToString() : "";

            var newProduct = new Product(AddNameTextBox.Text, type, AddDescriptionTextBox.Text, (int)AddPriceSlider.Value, fotoUrl);

            items.Add(newProduct);

            InsertDataIntoDatabase(newProduct); // Вставка данных в базу данных

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "add element";
        }

        private void InsertDataIntoDatabase(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Изменяем запрос на включение столбца Id
                    string query = "INSERT INTO Devicess (Id, Name, Type, Description, Price, FotoUrl) VALUES ((SELECT ISNULL(MAX(Id), 0) + 1 FROM Devicess), @Name, @Type, @Description, @Price, @FotoUrl)";
                    SqlCommand command = new SqlCommand(query, connection);
                    // Заполнение параметров запроса
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Type", product.Type.ToString());
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@FotoUrl", product.FotoUrl);
                    // Выполнение запроса
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных в базу данных: " + ex.Message);
            }
        }

        //удаление из БД
        private void AddDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ShopDataGrid.SelectedItem;
            if (selectedItem != null)
            {
                // Удаление из интерфейса WPF
                items.Remove(selectedItem as Product);

                // Удаление из базы данных
                DeleteDataFromDatabase((selectedItem as Product).Id);

                _elements.Add(new ObservableCollection<Product>(items));
                cursor++;

                LastAction.Content = lastAction_text + "remove element";
            }
        }

        private void DeleteDataFromDatabase(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Devicess WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных из базы данных: " + ex.Message);
            }
        }

        //апдейт в БД
        private void AddUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ShopDataGrid.SelectedItem;
            if (selectedItem == null) return;

            int itemNumberInCollection = items.IndexOf(selectedItem as Product);
            if (itemNumberInCollection == -1) return;

            DeviceType type = (DeviceType)AddTypeComboBox.SelectedIndex;
            if (AddTypeComboBox.SelectedIndex == -1)
                type = DeviceType.Other;

            string fotoUrl = DeviceImage.Source != null ? DeviceImage.Source.ToString() : "";

            var ChangedProduct = new Product(AddNameTextBox.Text, type, AddDescriptionTextBox.Text, (int)AddPriceSlider.Value, fotoUrl);

            // Обновляем данные в коллекции WPF
            items[itemNumberInCollection] = ChangedProduct;

            // Обновляем данные в базе данных
            UpdateDataInDatabase(ChangedProduct);

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "update element";
        }

        private void UpdateDataInDatabase(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Devicess SET Name = @Name, Type = @Type, Description = @Description, Price = @Price, FotoUrl = @FotoUrl WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Type", product.Type.ToString());
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@FotoUrl", product.FotoUrl);
                    command.Parameters.AddWithValue("@Id", product.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных в базе данных: " + ex.Message);
            }
        }

        //Кнопки фильтрации
        private void FilterSearchButton_Click(object sender, RoutedEventArgs e)
        {
            int searchingCost = int.TryParse(FilterPriceTextBox.Text, out int result) ? result : 0;

            DeviceType type = (DeviceType)FilterTypeComboBox.SelectedIndex;
            if (FilterTypeComboBox.SelectedIndex == -1)
                type = DeviceType.Other;

            var filteredItems = items.Where(x => x.Price <= searchingCost || x.Type == type || x.Name == FilterNameTextBox.Text);

            ShopDataGrid.ItemsSource = filteredItems;

            LastAction.Content = lastAction_text + "filter data base";
        }

        private void FilterClearButton_Click(object sender, RoutedEventArgs e)
        {
            ShopDataGrid.ItemsSource = items;

            LastAction.Content = lastAction_text + "reset filter results";
        }

        //Кнопки верхнего меню
        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            if (cursor == 0) return;

            cursor--;
            items = new ObservableCollection<Product>(_elements[cursor]);
            ShopDataGrid.ItemsSource = items;

            LastAction.Content = lastAction_text + "undo action";
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            if (cursor == _elements.Count - 1) return;

            cursor++;
            items = new ObservableCollection<Product>(_elements[cursor]);
            ShopDataGrid.ItemsSource = items;

            LastAction.Content = lastAction_text + "redo action";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var items = ShopDataGrid.ItemsSource;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (var sw = new StreamWriter(@"../../Database/List.json", false, new UTF8Encoding(false)))
            {
                string jsonString = JsonSerializer.Serialize(items, options);
                sw.Write(jsonString);
            }

            LastAction.Content = lastAction_text + "save file";
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader(@"../../Database/List.json"))
            {
                var json = reader.ReadToEnd();

                var serailizedItems = JsonSerializer.Deserialize<List<Product>>(json);
                items.Clear();

                foreach (var serailizedItem in serailizedItems)
                    items.Add(serailizedItem);
            }

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "load file";
        }

        private void NewProjectButton_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            _elements.Clear();
            ShopDataGrid.ItemsSource = items;
            cursor = 0;

            LastAction.Content = lastAction_text + "create new file";
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FStore\nActual version: 1.0\nDeveloper: Filon Nikita, 10 group. \n\nThank you!");
        }

        private void LanguageChangeButton_Click(object sender, RoutedEventArgs e)
        {
            var buttonName = (sender as MenuItem).Name;

            Uri sourceUri;
            switch (buttonName)
            {
                case "EnglishButton":
                    sourceUri = new Uri(@"../../Resources/Languages/English.xaml", UriKind.Relative);
                    break;
                case "RussianButton":
                    sourceUri = new Uri(@"../../Resources/Languages/Russian.xaml", UriKind.Relative);
                    break;
                default:
                    sourceUri = new Uri(@"../../Resources/Languages/English.xaml", UriKind.Relative);
                    break;
            }

            if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == sourceUri) != null) return;

            var newLanguageResource = new ResourceDictionary() { Source = sourceUri };

            var englishLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == new Uri("../Resources/Languages/English.xaml", UriKind.Relative));

            var russianLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == new Uri("../Resources/Languages/Russian.xaml", UriKind.Relative));

            if (englishLanguageResource != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(englishLanguageResource);
            }
            else
            {
                if (russianLanguageResource != null) Application.Current.Resources.MergedDictionaries.Remove(russianLanguageResource);
            }

            Application.Current.Resources.MergedDictionaries.Add(newLanguageResource);
        }

        private void AddNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ShowDB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Devicess";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Product> products = new List<Product>();
                    while (reader.Read())
                    {
                        var product = new Product(reader.GetString(1), 0, reader.GetString(4),  reader.GetInt32(3), reader.GetString(5));
                        product.Id = reader.GetInt32(0);
                        product.TypeString = reader.GetString(2);
                        products.Add(product);
                    }
                    reader.Close();

                    ShopDataGrid.ItemsSource = products;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выводе данных из базы данных: " + ex.Message);
            }
        }

    }
}
