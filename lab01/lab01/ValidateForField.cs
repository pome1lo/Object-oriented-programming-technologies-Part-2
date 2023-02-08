using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{
    internal static class ValidateForField
    {
        public static void CheckingForHexadecimal(KeyPressEventArgs key)
        {
            if (!Char.IsDigit(key.KeyChar) && (key.KeyChar <= 64 || key.KeyChar >= 71))
            {
                key.Handled = true;
            }
        }
        public static void CheckingForBinary(KeyPressEventArgs key)
        {
            if (key.KeyChar != 48 && key.KeyChar != 49)
            {
                key.Handled = true;
            }
        }
        public static void CheckingForOctal(KeyPressEventArgs key)
        {
            if (key.KeyChar <= 47 || key.KeyChar >= 56)
            {
                key.Handled = true;
            }
        }
        public static void CheckingForDecimal(KeyPressEventArgs key)
        {
            if (!Char.IsDigit(key.KeyChar))
            {
                key.Handled = true;
            }
        }
    }
}
