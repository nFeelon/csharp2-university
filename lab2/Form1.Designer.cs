namespace lab2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserPassportNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositType = new System.Windows.Forms.ComboBox();
            this.BalancePicker = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateDeposit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AddSMS = new System.Windows.Forms.CheckBox();
            this.AddBanking = new System.Windows.Forms.CheckBox();
            this.AddAds = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserSurname = new System.Windows.Forms.TextBox();
            this.UserFathername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UserBirthday = new System.Windows.Forms.MonthCalendar();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.InfoList = new System.Windows.Forms.ListBox();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BalancePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер счёта:";
            // 
            // UserPassportNumber
            // 
            this.UserPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPassportNumber.Location = new System.Drawing.Point(521, 771);
            this.UserPassportNumber.Name = "UserPassportNumber";
            this.UserPassportNumber.Size = new System.Drawing.Size(397, 44);
            this.UserPassportNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вклада:";
            // 
            // DepositType
            // 
            this.DepositType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositType.Items.AddRange(new object[] {
            "Простой",
            "Сберегательный",
            "Накопительный",
            "Целевой"});
            this.DepositType.Location = new System.Drawing.Point(19, 182);
            this.DepositType.Name = "DepositType";
            this.DepositType.Size = new System.Drawing.Size(469, 45);
            this.DepositType.TabIndex = 3;
            // 
            // BalancePicker
            // 
            this.BalancePicker.Location = new System.Drawing.Point(19, 303);
            this.BalancePicker.Maximum = 1000;
            this.BalancePicker.Name = "BalancePicker";
            this.BalancePicker.Size = new System.Drawing.Size(469, 69);
            this.BalancePicker.TabIndex = 7;
            this.BalancePicker.Value = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Баланс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(423, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата открытия:";
            // 
            // DateDeposit
            // 
            this.DateDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDeposit.Location = new System.Drawing.Point(19, 445);
            this.DateDeposit.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.DateDeposit.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DateDeposit.Name = "DateDeposit";
            this.DateDeposit.Size = new System.Drawing.Size(469, 35);
            this.DateDeposit.TabIndex = 12;
            this.DateDeposit.Value = new System.DateTime(2024, 2, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Опции:";
            // 
            // AddSMS
            // 
            this.AddSMS.AutoSize = true;
            this.AddSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSMS.Location = new System.Drawing.Point(19, 640);
            this.AddSMS.Name = "AddSMS";
            this.AddSMS.Size = new System.Drawing.Size(385, 33);
            this.AddSMS.TabIndex = 14;
            this.AddSMS.Text = "Подключить смс оповещения";
            this.AddSMS.UseVisualStyleBackColor = true;
            // 
            // AddBanking
            // 
            this.AddBanking.AutoSize = true;
            this.AddBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBanking.Location = new System.Drawing.Point(19, 601);
            this.AddBanking.Name = "AddBanking";
            this.AddBanking.Size = new System.Drawing.Size(401, 33);
            this.AddBanking.TabIndex = 15;
            this.AddBanking.Text = "Подключить интернет банкинг";
            this.AddBanking.UseVisualStyleBackColor = true;
            // 
            // AddAds
            // 
            this.AddAds.AutoSize = true;
            this.AddAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAds.Location = new System.Drawing.Point(19, 562);
            this.AddAds.Name = "AddAds";
            this.AddAds.Size = new System.Drawing.Size(469, 33);
            this.AddAds.TabIndex = 16;
            this.AddAds.Text = "Подключить рекламные объявления";
            this.AddAds.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(514, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Имя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(514, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Фамилия:";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(521, 61);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(397, 44);
            this.UserName.TabIndex = 19;
            // 
            // UserSurname
            // 
            this.UserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurname.Location = new System.Drawing.Point(521, 183);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(397, 44);
            this.UserSurname.TabIndex = 20;
            // 
            // UserFathername
            // 
            this.UserFathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFathername.Location = new System.Drawing.Point(521, 316);
            this.UserFathername.Name = "UserFathername";
            this.UserFathername.Size = new System.Drawing.Size(397, 44);
            this.UserFathername.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(514, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Отчество:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(514, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Дата рождения:";
            // 
            // UserBirthday
            // 
            this.UserBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserBirthday.Location = new System.Drawing.Point(521, 445);
            this.UserBirthday.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.UserBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.UserBirthday.Name = "UserBirthday";
            this.UserBirthday.TabIndex = 24;
            this.UserBirthday.TodayDate = new System.DateTime(2005, 5, 15, 0, 0, 0, 0);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(19, 61);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(469, 44);
            this.Number.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(514, 728);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 37);
            this.label12.TabIndex = 26;
            this.label12.Text = "Номер паспорта:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(975, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 37);
            this.label13.TabIndex = 28;
            this.label13.Text = "Информация:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(521, 894);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(228, 67);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(755, 894);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(213, 67);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(1190, 894);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 67);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "X";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(501, 864);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(825, 1);
            this.label14.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(498, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 983);
            this.label15.TabIndex = 33;
            // 
            // InfoList
            // 
            this.InfoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoList.FormattingEnabled = true;
            this.InfoList.HorizontalScrollbar = true;
            this.InfoList.ItemHeight = 29;
            this.InfoList.Items.AddRange(new object[] {
            "Здесь будут данные"});
            this.InfoList.Location = new System.Drawing.Point(982, 61);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(325, 758);
            this.InfoList.TabIndex = 34;
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(974, 894);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(210, 67);
            this.LoadButton.TabIndex = 35;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 1010);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.InfoList);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.UserBirthday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UserFathername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UserSurname);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddAds);
            this.Controls.Add(this.AddBanking);
            this.Controls.Add(this.AddSMS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateDeposit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BalancePicker);
            this.Controls.Add(this.DepositType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserPassportNumber);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1353, 1066);
            this.MinimumSize = new System.Drawing.Size(1353, 1066);
            this.Name = "MainForm";
            this.Text = "Твой банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalancePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPassportNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DepositType;
        private System.Windows.Forms.TrackBar BalancePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AddSMS;
        private System.Windows.Forms.CheckBox AddBanking;
        private System.Windows.Forms.CheckBox AddAds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserSurname;
        private System.Windows.Forms.TextBox UserFathername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar UserBirthday;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox InfoList;
        private System.Windows.Forms.Button LoadButton;
    }
}

