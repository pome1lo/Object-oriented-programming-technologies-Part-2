namespace lab02
{
    partial class Bank
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeOfDepositСomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DateOpeningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SmsAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AmountAccountTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.FormAccount = new System.Windows.Forms.Panel();
            this.FormOwner = new System.Windows.Forms.Panel();
            this.FormHistory = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.AmountHistoryTextBox = new System.Windows.Forms.TextBox();
            this.DateOfTheEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TypeDownRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeUPRadioButton = new System.Windows.Forms.RadioButton();
            this.DataGridViewForOwner = new System.Windows.Forms.DataGridView();
            this.FormAccount.SuspendLayout();
            this.FormOwner.SuspendLayout();
            this.FormHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(141, 17);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(141, 45);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(141, 73);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(157, 22);
            this.PatronymicTextBox.TabIndex = 2;
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(141, 101);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.DateOfBirthDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(63, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(141, 129);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(157, 24);
            this.CityComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(87, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Город";
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.BackColor = System.Drawing.Color.White;
            this.HouseTextBox.Location = new System.Drawing.Point(141, 159);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(157, 22);
            this.HouseTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(100, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(92, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(150, 32);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(157, 22);
            this.IDTextBox.TabIndex = 15;
            this.IDTextBox.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(60, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Тип вклада";
            // 
            // TypeOfDepositСomboBox
            // 
            this.TypeOfDepositСomboBox.FormattingEnabled = true;
            this.TypeOfDepositСomboBox.Location = new System.Drawing.Point(150, 60);
            this.TypeOfDepositСomboBox.Name = "TypeOfDepositСomboBox";
            this.TypeOfDepositСomboBox.Size = new System.Drawing.Size(157, 24);
            this.TypeOfDepositСomboBox.TabIndex = 17;
            this.TypeOfDepositСomboBox.Tag = "Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(39, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Дата открытия";
            // 
            // DateOpeningDateTimePicker
            // 
            this.DateOpeningDateTimePicker.Location = new System.Drawing.Point(150, 90);
            this.DateOpeningDateTimePicker.Name = "DateOpeningDateTimePicker";
            this.DateOpeningDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.DateOpeningDateTimePicker.TabIndex = 19;
            // 
            // SmsAlertsCheckBox
            // 
            this.SmsAlertsCheckBox.AutoSize = true;
            this.SmsAlertsCheckBox.Location = new System.Drawing.Point(150, 152);
            this.SmsAlertsCheckBox.Name = "SmsAlertsCheckBox";
            this.SmsAlertsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.SmsAlertsCheckBox.TabIndex = 21;
            this.SmsAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(23, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "CMC оповещения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(92, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Сумма";
            // 
            // AmountAccountTextBox
            // 
            this.AmountAccountTextBox.Location = new System.Drawing.Point(150, 118);
            this.AmountAccountTextBox.Name = "AmountAccountTextBox";
            this.AmountAccountTextBox.Size = new System.Drawing.Size(157, 22);
            this.AmountAccountTextBox.TabIndex = 23;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(208, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(92, 37);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // FormAccount
            // 
            this.FormAccount.BackColor = System.Drawing.Color.Transparent;
            this.FormAccount.Controls.Add(this.TypeOfDepositСomboBox);
            this.FormAccount.Controls.Add(this.IDTextBox);
            this.FormAccount.Controls.Add(this.label12);
            this.FormAccount.Controls.Add(this.label7);
            this.FormAccount.Controls.Add(this.AmountAccountTextBox);
            this.FormAccount.Controls.Add(this.label9);
            this.FormAccount.Controls.Add(this.label11);
            this.FormAccount.Controls.Add(this.DateOpeningDateTimePicker);
            this.FormAccount.Controls.Add(this.SmsAlertsCheckBox);
            this.FormAccount.Controls.Add(this.label10);
            this.FormAccount.Location = new System.Drawing.Point(74, 42);
            this.FormAccount.Name = "FormAccount";
            this.FormAccount.Size = new System.Drawing.Size(415, 274);
            this.FormAccount.TabIndex = 26;
            // 
            // FormOwner
            // 
            this.FormOwner.BackColor = System.Drawing.Color.Transparent;
            this.FormOwner.Controls.Add(this.LastNameTextBox);
            this.FormOwner.Controls.Add(this.FirstNameTextBox);
            this.FormOwner.Controls.Add(this.PatronymicTextBox);
            this.FormOwner.Controls.Add(this.DateOfBirthDateTimePicker);
            this.FormOwner.Controls.Add(this.label6);
            this.FormOwner.Controls.Add(this.label2);
            this.FormOwner.Controls.Add(this.HouseTextBox);
            this.FormOwner.Controls.Add(this.label1);
            this.FormOwner.Controls.Add(this.label5);
            this.FormOwner.Controls.Add(this.label3);
            this.FormOwner.Controls.Add(this.CityComboBox);
            this.FormOwner.Controls.Add(this.label4);
            this.FormOwner.Location = new System.Drawing.Point(67, 63);
            this.FormOwner.Name = "FormOwner";
            this.FormOwner.Size = new System.Drawing.Size(405, 211);
            this.FormOwner.TabIndex = 27;
            // 
            // FormHistory
            // 
            this.FormHistory.BackColor = System.Drawing.Color.Transparent;
            this.FormHistory.Controls.Add(this.label15);
            this.FormHistory.Controls.Add(this.AmountHistoryTextBox);
            this.FormHistory.Controls.Add(this.DateOfTheEventDateTimePicker);
            this.FormHistory.Controls.Add(this.label14);
            this.FormHistory.Controls.Add(this.label13);
            this.FormHistory.Controls.Add(this.TypeDownRadioButton);
            this.FormHistory.Controls.Add(this.TypeUPRadioButton);
            this.FormHistory.Location = new System.Drawing.Point(62, 66);
            this.FormHistory.Name = "FormHistory";
            this.FormHistory.Size = new System.Drawing.Size(303, 247);
            this.FormHistory.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(85, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Сумма";
            // 
            // AmountHistoryTextBox
            // 
            this.AmountHistoryTextBox.Location = new System.Drawing.Point(143, 35);
            this.AmountHistoryTextBox.Name = "AmountHistoryTextBox";
            this.AmountHistoryTextBox.Size = new System.Drawing.Size(157, 22);
            this.AmountHistoryTextBox.TabIndex = 26;
            // 
            // DateOfTheEventDateTimePicker
            // 
            this.DateOfTheEventDateTimePicker.Location = new System.Drawing.Point(143, 63);
            this.DateOfTheEventDateTimePicker.Name = "DateOfTheEventDateTimePicker";
            this.DateOfTheEventDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.DateOfTheEventDateTimePicker.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(14, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Дата проведения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(36, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Тип операции";
            // 
            // TypeDownRadioButton
            // 
            this.TypeDownRadioButton.AutoSize = true;
            this.TypeDownRadioButton.Location = new System.Drawing.Point(143, 113);
            this.TypeDownRadioButton.Name = "TypeDownRadioButton";
            this.TypeDownRadioButton.Size = new System.Drawing.Size(124, 20);
            this.TypeDownRadioButton.TabIndex = 1;
            this.TypeDownRadioButton.Text = "Трата средств";
            this.TypeDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeUPRadioButton
            // 
            this.TypeUPRadioButton.AutoSize = true;
            this.TypeUPRadioButton.Checked = true;
            this.TypeUPRadioButton.Location = new System.Drawing.Point(143, 91);
            this.TypeUPRadioButton.Name = "TypeUPRadioButton";
            this.TypeUPRadioButton.Size = new System.Drawing.Size(103, 21);
            this.TypeUPRadioButton.TabIndex = 0;
            this.TypeUPRadioButton.TabStop = true;
            this.TypeUPRadioButton.Text = "Пополнение";
            this.TypeUPRadioButton.UseCompatibleTextRendering = true;
            this.TypeUPRadioButton.UseVisualStyleBackColor = true;
            // 
            // DataGridViewForOwner
            // 
            this.DataGridViewForOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewForOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewForOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewForOwner.Location = new System.Drawing.Point(-1, 0);
            this.DataGridViewForOwner.Name = "DataGridViewForOwner";
            this.DataGridViewForOwner.RowHeadersWidth = 51;
            this.DataGridViewForOwner.RowTemplate.Height = 24;
            this.DataGridViewForOwner.Size = new System.Drawing.Size(612, 463);
            this.DataGridViewForOwner.TabIndex = 29;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::lab02.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 460);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FormHistory);
            this.Controls.Add(this.FormOwner);
            this.Controls.Add(this.FormAccount);
            this.Controls.Add(this.DataGridViewForOwner);
            this.DoubleBuffered = true;
            this.Name = "Bank";
            this.Text = "Bank";
            this.FormAccount.ResumeLayout(false);
            this.FormAccount.PerformLayout();
            this.FormOwner.ResumeLayout(false);
            this.FormOwner.PerformLayout();
            this.FormHistory.ResumeLayout(false);
            this.FormHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TypeOfDepositСomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateOpeningDateTimePicker;
        private System.Windows.Forms.CheckBox SmsAlertsCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AmountAccountTextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel FormAccount;
        private System.Windows.Forms.Panel FormOwner;
        private System.Windows.Forms.Panel FormHistory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton TypeDownRadioButton;
        private System.Windows.Forms.RadioButton TypeUPRadioButton;
        private System.Windows.Forms.DateTimePicker DateOfTheEventDateTimePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AmountHistoryTextBox;
        private System.Windows.Forms.DataGridView DataGridViewForOwner;
    }
}

