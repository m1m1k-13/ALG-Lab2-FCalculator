using System.Data;
using System.Globalization;

namespace lab_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            trigMode.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработка текстовых полей
        /// </summary>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar == '\b')
                return;

            if (char.IsDigit(e.KeyChar))
            {
                if (tb.SelectionLength == tb.Text.Length)
                    return;

                if (tb.Text == "0")
                {
                    if (e.KeyChar == '0')
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        tb.Text = e.KeyChar.ToString();
                        tb.SelectionStart = tb.Text.Length;
                        e.Handled = true;
                        return;
                    }
                }

                if (tb.SelectionStart == 0 && tb.Text.StartsWith("0") && !tb.Text.StartsWith("0,"))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            if (e.KeyChar == ',' && !tb.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.Text = "0,";
                    tb.SelectionStart = tb.Text.Length;
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains("-"))
                return;

            e.Handled = true;
        }

        /// <summary>
        /// Вставка нуля при удалении символов
        /// </summary>
        private void TextBox_EmptyToZero(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text == "")
            {
                tb.TextChanged -= TextBox_EmptyToZero;

                tb.Text = "0";
                tb.SelectionStart = tb.Text.Length;

                tb.TextChanged += TextBox_EmptyToZero;
            }
        }

        /// <summary>
        /// Очистка полей калькулятора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                input.Text = "0";
                accuracy.Text = "0,001";
                result.Clear();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Получение значения аргумента
        /// </summary>
        /// <returns>x</returns>
        private decimal GetX()
        {
            return decimal.Parse(input.Text);
        }

        /// <summary>
        /// Получение погрешности
        /// </summary>
        /// <returns>eps</returns>
        private decimal GetAccuracy()
        {
            decimal eps = decimal.Parse(accuracy.Text);
            if (eps <= 0) throw new Exception("Неверный ввод");
            return eps;
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления показательной функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Ex(GetX(), GetAccuracy()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления квадратного корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Sqrt(GetX(), GetAccuracy()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления натурального логарифма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Ln(GetX(), GetAccuracy()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления десятичного логарифма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void LgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Lg(GetX(), GetAccuracy()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Получение режима вычисления
        /// </summary>
        /// <returns>true, если в радианах; false, если в градусах</returns>
        private bool GetMode()
        {
            if (trigMode.SelectedIndex == 0) return true;
            return false;
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления синуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Sin(GetX(), GetAccuracy(), GetMode()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления косинуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Cos(GetX(), GetAccuracy(), GetMode()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления тангенса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Tg(GetX(), GetAccuracy(), GetMode()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки вычисления котангенса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CtgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = MathLib.Ctg(GetX(), GetAccuracy(), GetMode()).ToString();
            }
            catch (Exception err)
            {
                result.Text = err.Message;
            }
        }
    }
}
