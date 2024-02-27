namespace lab2
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchDepositType = new System.Windows.Forms.ComboBox();
            this.SearchUsernameTextbox = new System.Windows.Forms.TextBox();
            this.SearchIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchListBox
            // 
            this.searchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.HorizontalScrollbar = true;
            this.searchListBox.ItemHeight = 29;
            this.searchListBox.Location = new System.Drawing.Point(342, 12);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(622, 352);
            this.searchListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер счёта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип вклада:";
            // 
            // searchDepositType
            // 
            this.searchDepositType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchDepositType.Items.AddRange(new object[] {
            "Простой",
            "Сберегательный",
            "Накопительный",
            "Целевой"});
            this.searchDepositType.Location = new System.Drawing.Point(19, 315);
            this.searchDepositType.Name = "searchDepositType";
            this.searchDepositType.Size = new System.Drawing.Size(308, 45);
            this.searchDepositType.TabIndex = 27;
            this.searchDepositType.SelectedIndexChanged += new System.EventHandler(this.SearchDepositType_SelectedIndexChanged);
            // 
            // SearchUsernameTextbox
            // 
            this.SearchUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchUsernameTextbox.Location = new System.Drawing.Point(19, 180);
            this.SearchUsernameTextbox.Name = "SearchUsernameTextbox";
            this.SearchUsernameTextbox.Size = new System.Drawing.Size(308, 44);
            this.SearchUsernameTextbox.TabIndex = 28;
            this.SearchUsernameTextbox.TextChanged += new System.EventHandler(this.SearchUserSurname_TextChanged);
            // 
            // SearchIdTextBox
            // 
            this.SearchIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchIdTextBox.Location = new System.Drawing.Point(19, 61);
            this.SearchIdTextBox.Name = "SearchIdTextBox";
            this.SearchIdTextBox.Size = new System.Drawing.Size(308, 44);
            this.SearchIdTextBox.TabIndex = 29;
            this.SearchIdTextBox.TextChanged += new System.EventHandler(this.SearchIdTextBox_TextChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 374);
            this.Controls.Add(this.SearchIdTextBox);
            this.Controls.Add(this.SearchUsernameTextbox);
            this.Controls.Add(this.searchDepositType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchListBox);
            this.Name = "Search";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox searchDepositType;
        private System.Windows.Forms.TextBox SearchUsernameTextbox;
        private System.Windows.Forms.TextBox SearchIdTextBox;
    }
}