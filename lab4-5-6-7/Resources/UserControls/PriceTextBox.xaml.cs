using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace lab4_5.Resources.UserControls
{
    public partial class PriceTextBox : UserControl
    {
        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
        public PriceTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public static readonly DependencyProperty SliderValueProperty =
            DependencyProperty.Register("SliderValue", typeof(int), typeof(PriceTextBox),
                new FrameworkPropertyMetadata(0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    new PropertyChangedCallback(OnSliderValueChanged),
                    new CoerceValueCallback(CorrectValue)),
                    new ValidateValueCallback(ValidateSliderValue));

        public int SliderValue
        {
            get
            {
                return (int)GetValue(SliderValueProperty);
            }
            set
            {
                SetValue(SliderValueProperty, value);
            }
        }

        private static void OnSliderValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)  // если больше 100, возвращаем 100
                return 1000;
            if (currentValue < 0)
                return 0;

            return currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateSliderValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue > 0 && currentValue < 1000) // если текущее значение от нуля и выше
                return false;
            return true;
        }
    }
}