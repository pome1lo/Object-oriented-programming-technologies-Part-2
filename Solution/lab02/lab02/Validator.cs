using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab02
{
    internal class Validatator
    {
        public static bool Text(ref TextBox textBox)
        {
            if (textBox.Text.Any(char.IsDigit) || String.IsNullOrEmpty(textBox.Text))
            {
                Failure(ref textBox);
                return false;
            }
            Success(ref textBox);
            return true;
        }
        public static bool Number(ref TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text) || textBox.Text.Any(char.IsLetter))
            {
                Failure(ref textBox);
                return false;
            }
            else if (long.Parse(textBox.Text) < 0)
            {
                Failure(ref textBox);
                return false;
            }
            Success(ref textBox);
            return true;
        }
        public static bool Date(ref DateTimePicker timePicker)
        {
            if (DateTime.Parse(timePicker.Value.ToString()) > DateTime.Now)
            {
                timePicker.CalendarTitleBackColor = Color.Red;
                return false;
            }
            timePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            return true;
        }
        public static bool Combo(ref ComboBox comboBox, String[] arr)
        {
            if (!arr.Contains(comboBox.SelectedItem))
            {
                comboBox.BackColor = Color.Red;
                return false;
            }
            comboBox.BackColor = Color.White;
            return true;

        }
        private static void Failure(ref TextBox textBox) => textBox.BackColor = System.Drawing.Color.Crimson;
        private static void Success(ref TextBox textBox) => textBox.BackColor = System.Drawing.Color.White;
    }
}
