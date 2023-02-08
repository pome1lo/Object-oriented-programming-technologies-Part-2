namespace lab01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ORButton = new System.Windows.Forms.Button();
            this.ANDButton = new System.Windows.Forms.Button();
            this.XORButton = new System.Windows.Forms.Button();
            this.NOTButton = new System.Windows.Forms.Button();
            this.TextBoxIO = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.OctalRadioButton = new System.Windows.Forms.RadioButton();
            this.BinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.DecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.HexadecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ORButton
            // 
            this.ORButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ORButton.Location = new System.Drawing.Point(12, 123);
            this.ORButton.Name = "ORButton";
            this.ORButton.Size = new System.Drawing.Size(99, 33);
            this.ORButton.TabIndex = 0;
            this.ORButton.Text = "ИЛИ";
            this.ORButton.UseVisualStyleBackColor = false;
            this.ORButton.Click += new System.EventHandler(this.ORButtonClick);
            // 
            // ANDButton
            // 
            this.ANDButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ANDButton.Location = new System.Drawing.Point(12, 45);
            this.ANDButton.Name = "ANDButton";
            this.ANDButton.Size = new System.Drawing.Size(99, 33);
            this.ANDButton.TabIndex = 1;
            this.ANDButton.Text = "И";
            this.ANDButton.UseVisualStyleBackColor = false;
            this.ANDButton.Click += new System.EventHandler(this.ANDButtonClick);
            // 
            // XORButton
            // 
            this.XORButton.BackColor = System.Drawing.SystemColors.Menu;
            this.XORButton.Location = new System.Drawing.Point(12, 162);
            this.XORButton.Name = "XORButton";
            this.XORButton.Size = new System.Drawing.Size(99, 33);
            this.XORButton.TabIndex = 2;
            this.XORButton.Text = "Искл. ИЛИ";
            this.XORButton.UseVisualStyleBackColor = false;
            this.XORButton.Click += new System.EventHandler(this.XORButtonClick);
            // 
            // NOTButton
            // 
            this.NOTButton.BackColor = System.Drawing.SystemColors.Menu;
            this.NOTButton.Location = new System.Drawing.Point(12, 84);
            this.NOTButton.Name = "NOTButton";
            this.NOTButton.Size = new System.Drawing.Size(99, 33);
            this.NOTButton.TabIndex = 3;
            this.NOTButton.Text = "НЕ";
            this.NOTButton.UseVisualStyleBackColor = false;
            this.NOTButton.Click += new System.EventHandler(this.NOTButtonClick);
            // 
            // TextBoxIO
            // 
            this.TextBoxIO.Location = new System.Drawing.Point(12, 17);
            this.TextBoxIO.Name = "TextBoxIO";
            this.TextBoxIO.Size = new System.Drawing.Size(287, 22);
            this.TextBoxIO.TabIndex = 8;
            this.TextBoxIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedIO);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Menu;
            this.Clear.Location = new System.Drawing.Point(136, 162);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 33);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Очистка";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // OctalRadioButton
            // 
            this.OctalRadioButton.AutoSize = true;
            this.OctalRadioButton.Location = new System.Drawing.Point(136, 77);
            this.OctalRadioButton.Name = "OctalRadioButton";
            this.OctalRadioButton.Size = new System.Drawing.Size(123, 20);
            this.OctalRadioButton.TabIndex = 11;
            this.OctalRadioButton.Text = "Восьмиричная";
            this.OctalRadioButton.UseVisualStyleBackColor = true;
            this.OctalRadioButton.CheckedChanged += new System.EventHandler(this.OctalRadioButtonCheckedChanged);
            // 
            // BinaryRadioButton
            // 
            this.BinaryRadioButton.AutoSize = true;
            this.BinaryRadioButton.Location = new System.Drawing.Point(136, 51);
            this.BinaryRadioButton.Name = "BinaryRadioButton";
            this.BinaryRadioButton.Size = new System.Drawing.Size(92, 20);
            this.BinaryRadioButton.TabIndex = 12;
            this.BinaryRadioButton.Text = "Двоичная";
            this.BinaryRadioButton.UseVisualStyleBackColor = true;
            this.BinaryRadioButton.CheckedChanged += new System.EventHandler(this.BinaryRadioButtonCheckedChanged);
            // 
            // DecimalRadioButton
            // 
            this.DecimalRadioButton.AutoSize = true;
            this.DecimalRadioButton.Checked = true;
            this.DecimalRadioButton.Location = new System.Drawing.Point(136, 103);
            this.DecimalRadioButton.Name = "DecimalRadioButton";
            this.DecimalRadioButton.Size = new System.Drawing.Size(105, 20);
            this.DecimalRadioButton.TabIndex = 13;
            this.DecimalRadioButton.TabStop = true;
            this.DecimalRadioButton.Text = "Десятичная";
            this.DecimalRadioButton.UseVisualStyleBackColor = true;
            this.DecimalRadioButton.CheckedChanged += new System.EventHandler(this.DecimalRadioButtonCheckedChanged);
            // 
            // HexadecimalRadioButton
            // 
            this.HexadecimalRadioButton.AutoSize = true;
            this.HexadecimalRadioButton.Location = new System.Drawing.Point(136, 129);
            this.HexadecimalRadioButton.Name = "HexadecimalRadioButton";
            this.HexadecimalRadioButton.Size = new System.Drawing.Size(163, 20);
            this.HexadecimalRadioButton.TabIndex = 14;
            this.HexadecimalRadioButton.Text = "Шестнадцатиричная";
            this.HexadecimalRadioButton.UseVisualStyleBackColor = true;
            this.HexadecimalRadioButton.CheckedChanged += new System.EventHandler(this.HexadecimalRadioButtonCheckedChanged);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.EqualsButton.Location = new System.Drawing.Point(241, 162);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(38, 33);
            this.EqualsButton.TabIndex = 15;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.HexadecimalRadioButton);
            this.Controls.Add(this.DecimalRadioButton);
            this.Controls.Add(this.BinaryRadioButton);
            this.Controls.Add(this.OctalRadioButton);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextBoxIO);
            this.Controls.Add(this.NOTButton);
            this.Controls.Add(this.XORButton);
            this.Controls.Add(this.ANDButton);
            this.Controls.Add(this.ORButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Binary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ORButton;
        private System.Windows.Forms.Button ANDButton;
        private System.Windows.Forms.Button XORButton;
        private System.Windows.Forms.Button NOTButton;
        private System.Windows.Forms.TextBox TextBoxIO;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RadioButton OctalRadioButton;
        private System.Windows.Forms.RadioButton BinaryRadioButton;
        private System.Windows.Forms.RadioButton DecimalRadioButton;
        private System.Windows.Forms.RadioButton HexadecimalRadioButton;
        private System.Windows.Forms.Button EqualsButton;
    }
}

