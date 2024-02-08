using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{

    public partial class MainForm : Form
    {
        int unit = 8;
        private Calculator calculator;
        public delegate void PerformBitwiseOperation(int num1, int num2);
        public event PerformBitwiseOperation BitwiseAndPerformed;
        public event PerformBitwiseOperation BitwiseOrPerformed;
        public event PerformBitwiseOperation BitwiseXorPerformed;
        public event Action<int> BitwiseNotPerformed;

        public MainForm()
        {
            InitializeComponent();
            calculator = new Calculator();

            BitwiseAndPerformed += (num1, num2) =>
            {
                int result = calculator.BitwiseAnd(num1, num2);
                resultTextBox.Text = Convert.ToString(result, unit);
            };

            BitwiseOrPerformed += (num1, num2) =>
            {
                int result = calculator.BitwiseOr(num1, num2);
                resultTextBox.Text = Convert.ToString(result, unit);
            };

            BitwiseXorPerformed += (num1, num2) =>
            {
                int result = calculator.BitwiseXor(num1, num2);
                resultTextBox.Text = Convert.ToString(result, unit);
            };

            BitwiseNotPerformed += (num1) =>
            {
                int result = calculator.BitwiseNot(num1);
                resultTextBox.Text = Convert.ToString(result, unit);
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboListUnit.SelectedIndex = 0;
            unit = 8;
        }

        private void comboListUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboListUnit.SelectedIndex)
            {
                case 0:
                    unit = 8;
                    break;
                case 1:
                    unit = 2;
                    break;
                case 2:
                    unit = 10;
                    break;
                case 3:
                    unit = 16;
                    break;
                default:
                    unit = 8;
                    break;

            }
        }

        private void buttonAND_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(number1text.Text);
                int num2 = Convert.ToInt32(number2text.Text);
                BitwiseAndPerformed?.Invoke(num1, num2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод чисел.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(number1text.Text);
                int num2 = Convert.ToInt32(number2text.Text);
                BitwiseOrPerformed?.Invoke(num1, num2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод чисел.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(number1text.Text);
                int num2 = Convert.ToInt32(number2text.Text);
                BitwiseXorPerformed?.Invoke(num1, num2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод чисел.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonNOT_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(number1text.Text);
                BitwiseNotPerformed?.Invoke(num1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод чисел.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number1text.Text = "";
            number2text.Text = "";
            resultTextBox.Text = "";
            comboListUnit.SelectedIndex = 0;
            unit = 8;
        }

    }

    public class Calculator
    {
        public int BitwiseAnd(int num1, int num2)
        {
            return num1 & num2;
        }

        public int BitwiseOr(int num1, int num2)
        {
            return num1 | num2;
        }

        public int BitwiseXor(int num1, int num2)
        {
            return num1 ^ num2;
        }

        public int BitwiseNot(int num1)
        {
            return ~num1;
        }
    }
}
