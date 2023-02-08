using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab01
{
    public partial class Form1 : Form
    {
        private byte StateNumberSystem = 10;
        private string Operation = string.Empty;
        private Calculator Calculator { get; } = new Calculator();

        private enum NumberSystem : byte
        {
            Decimal = 10,
            Binary = 2,
            Octal = 8,
            Hexadecimal = 16
        }

        public Form1() => InitializeComponent();

        private void TextChangedIO(object sender, KeyPressEventArgs e)
        {
            switch (StateNumberSystem)
            {
                case (byte)NumberSystem.Binary:      ValidateForField.CheckingForBinary(e); break;
                case (byte)NumberSystem.Octal:       ValidateForField.CheckingForOctal(e); break;
                case (byte)NumberSystem.Decimal:     ValidateForField.CheckingForDecimal(e); break;
                case (byte)NumberSystem.Hexadecimal: ValidateForField.CheckingForHexadecimal(e); break;
            }
        }


        private void SettingTheStatus(byte State)
        {
            StateNumberSystem = State;
            TextBoxIO.Clear();
        }
        private void ClearClick(object sender, EventArgs e)
        {
            TextBoxIO.Clear();
            TextBoxIO.ReadOnly = false;

            EnabledCheck(true);
        }
        private void BinaryRadioButtonCheckedChanged(object sender, EventArgs e) => SettingTheStatus((byte)NumberSystem.Binary);
        private void OctalRadioButtonCheckedChanged(object sender, EventArgs e) => SettingTheStatus((byte)NumberSystem.Octal);
        private void DecimalRadioButtonCheckedChanged(object sender, EventArgs e) => SettingTheStatus((byte)NumberSystem.Decimal);
        private void HexadecimalRadioButtonCheckedChanged(object sender, EventArgs e) => SettingTheStatus((byte)NumberSystem.Hexadecimal);


        private void InitializationLeftOperand(object sender)
        {
            Calculator.LeftOperand = Convert.ToString(Convert.ToUInt64(TextBoxIO.Text, StateNumberSystem));
            TextBoxIO.Clear();
            TextBoxIO.Focus();

            Operation = (sender as System.Windows.Forms.Button).Name;
        }
        private void ANDButtonClick(object sender, EventArgs e) => InitializationLeftOperand(sender);
        private void NOTButtonClick(object sender, EventArgs e)
        {
            InitializationLeftOperand(sender);
            TextBoxIO.ReadOnly= true;
        }
        private void ORButtonClick(object sender, EventArgs e) => InitializationLeftOperand(sender);
        private void XORButtonClick(object sender, EventArgs e) => InitializationLeftOperand(sender);

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            if(Operation != "NOTButton")
            {
                Calculator.RightOperand = Convert.ToString(Convert.ToUInt32(TextBoxIO.Text, StateNumberSystem));

                Calculator.CalculatorInit(
                    Convert.ToString(Convert.ToInt32(Calculator.LeftOperand), 2),
                    Convert.ToString(Convert.ToInt32(Calculator.RightOperand), 2)
                );
            }
            else
            {
                Calculator.CalculatorInit(Convert.ToString(Convert.ToInt32(Calculator.LeftOperand), 2));
            }
            TextBoxIO.Clear();

            
            switch (Operation)
            {
                case "ANDButton": TextBoxIO.Text = Calculator.AND(); break;
                case "NOTButton": TextBoxIO.Text = Calculator.NOT(); break;
                case "ORButton":  TextBoxIO.Text = Calculator.OR();  break;
                case "XORButton": TextBoxIO.Text = Calculator.XOR(); break;
            }
            EnabledCheck(false);
        }
        private void EnabledCheck(bool check)
        {
            ANDButton.Enabled = check;
            ORButton.Enabled = check;
            XORButton.Enabled = check;
            NOTButton.Enabled = check;
            BinaryRadioButton.Enabled = check;
            OctalRadioButton.Enabled = check;
            DecimalRadioButton.Enabled = check;
            HexadecimalRadioButton.Enabled = check;
            EqualsButton.Enabled = check;
        }
    }
}
