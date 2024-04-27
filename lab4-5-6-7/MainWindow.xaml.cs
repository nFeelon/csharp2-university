using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace lab4_5
{
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
    }

    public partial class MainWindow : Window
    {
        private string lastAction_text = "Last action: ";

        private ObservableCollection<Product> items;
        private readonly List<ObservableCollection<Product>> _elements = new List<ObservableCollection<Product>>();
        private int cursor = 0;

        public MainWindow()
        {
            InitializeComponent();

            menuBar_1.NewProject += NewProjectButton_Click;
            menuBar_1.LoadProject += LoadButton_Click;
            menuBar_1.SaveProject += SaveButton_Click;
            menuBar_1.UndoMove += UndoButton_Click;
            menuBar_1.RedoMove += RedoButton_Click;
            menuBar_1.LanguageChange += LanguageChangeButton_Click;
            menuBar_1.DarkTheme += DarkThemeButton_Click;
            menuBar_1.LightTheme += LightThemeButton_Click;
            menuBar_1.AboutProject += AboutButton_Click;

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

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "add element";
        }

        private void AddDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ShopDataGrid.SelectedItem;
            if (selectedItem != null)
                items.Remove(selectedItem as Product);

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "remove element";
        }

        private void AddUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ShopDataGrid.SelectedItem;
            if (selectedItem == null) return;

            var itemNumberInCollection = items.IndexOf(selectedItem as Product);
            if (itemNumberInCollection == -1) return;

            DeviceType type = (DeviceType)AddTypeComboBox.SelectedIndex;
            if (AddTypeComboBox.SelectedIndex == -1)
                type = DeviceType.Other;

            string fotoUrl = DeviceImage.Source != null ? DeviceImage.Source.ToString() : "";

            var ChangedProduct = new Product(AddNameTextBox.Text, type, AddDescriptionTextBox.Text, (int)AddPriceSlider.Value, fotoUrl);

            items.RemoveAt(itemNumberInCollection);
            items.Insert(itemNumberInCollection, ChangedProduct);

            _elements.Add(new ObservableCollection<Product>(items));
            cursor++;

            LastAction.Content = lastAction_text + "update element";
        }


        //Кнопки фильтрации
        private void FilterSearchButton_Click(object sender, RoutedEventArgs e)
        {
            int searchingCost = (int)PriceTextBox.FilterPriceTextBox.Value;

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
        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (cursor == 0) return;

            cursor--;
            items = new ObservableCollection<Product>(_elements[cursor]);
            ShopDataGrid.ItemsSource = items;

            LastAction.Content = lastAction_text + "undo action";
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (cursor == _elements.Count - 1) return;

            cursor++;
            items = new ObservableCollection<Product>(_elements[cursor]);
            ShopDataGrid.ItemsSource = items;

            LastAction.Content = lastAction_text + "redo action";
        }

        private void SaveButton_Click(object sender, EventArgs e)
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

        private void LoadButton_Click(object sender, EventArgs e)
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

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            _elements.Clear();
            ShopDataGrid.ItemsSource = items;
            cursor = 0;

            LastAction.Content = lastAction_text + "create new file";
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FStore\nActual version: 1.0\nDeveloper: Filon Nikita, 10 group. \n\nThank you!");
        }

        private void LanguageChangeButton_Click(object sender, EventArgs e)
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

        private void DarkThemeButton_Click(object sender, EventArgs e)
        {
            var uri = new Uri("/Resources/Style/Themes/Dark.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);

        }

        private void LightThemeButton_Click(object sender, EventArgs e)
        {
            var uri = new Uri("/Resources/Style/Themes/Light.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }
    }

}
