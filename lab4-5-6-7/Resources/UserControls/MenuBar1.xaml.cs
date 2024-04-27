using System;
using System.Windows;
using System.Windows.Controls;

namespace lab4_5.Resources.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MenuBar1.xaml
    /// </summary>
    public partial class MenuBar1 : UserControl
    {
        public event EventHandler NewProject;
        public event EventHandler LoadProject;
        public event EventHandler SaveProject;
        public event EventHandler UndoMove;
        public event EventHandler RedoMove;
        public event EventHandler LanguageChange;
        public event EventHandler DarkTheme;
        public event EventHandler LightTheme;
        public event EventHandler AboutProject;
        public MenuBar1()
        {
            InitializeComponent();
        }

        private void NewProjectButton_Click(object sender, RoutedEventArgs e)
        {
            NewProject?.Invoke(sender, e);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadProject?.Invoke(sender, e);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveProject?.Invoke(sender, e);
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            UndoMove?.Invoke(sender, e);
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            RedoMove?.Invoke(sender, e);
        }

        private void LanguageChangeButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageChange?.Invoke(sender, e);
        }

        private void DarkThemeButton_Click(object sender, RoutedEventArgs e)
        {
            DarkTheme?.Invoke(sender, e);
        }

        private void LightThemeButton_Click(object sender, RoutedEventArgs e)
        {
            LightTheme?.Invoke(sender, e);
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutProject?.Invoke(sender, e);
        }
    }
}
