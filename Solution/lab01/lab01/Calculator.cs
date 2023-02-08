using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace lab01
{
    internal class Calculator : ILogicalOperations
    {
        public static string LeftOperand = string.Empty;
        public static string RightOperand = string.Empty;
        private static bool tempLeft = false;
        private static bool tempRight = false;
        private static string result = string.Empty;

        public void CalculatorInit(string left, string right = " ")
        {
            
            LeftOperand = left;
            RightOperand = right;
        }
        public string AND()
        {
            for (int i = 0; i < LeftOperand.Length; i++)
            {
                if (LeftOperand[i] == '1')
                    tempLeft = true;
                if (RightOperand[i] == '1')
                    tempRight = true;

                if (tempLeft & tempRight)
                    result += '1';
                else
                    result += '0';
            }
            return result;
        }
        public string OR()
        {
            for (int i = 0; i < LeftOperand.Length; i++)
            {
                if (LeftOperand[i] == '1')
                    tempLeft = true;
                if (RightOperand[i] == '1')
                    tempRight = true;

                if (tempLeft | tempRight)
                    result += '1';
                else
                    result += '0';
            }
            return result;
        }
        public string XOR()
        {
            for (int i = 0; i < LeftOperand.Length; i++)
            {
                if (LeftOperand[i] == '1')
                    tempLeft = true;
                if (RightOperand[i] == '1')
                    tempRight = true;

                if (tempLeft ^ tempRight)
                    result += '1';
                else
                    result += '0';
            }
            return result;
        }
        public string NOT()
        {
            for (int i = 0; i < LeftOperand.Length; i++)
            {
                if (LeftOperand[i] == '0')
                    result += '1';
                else
                    result += '0';
            }
            return result;
        }
    }
}
