namespace lab2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.InfoHistoryBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SaveHistoryButton = new System.Windows.Forms.Button();
            this.LoadHistoryButton = new System.Windows.Forms.Button();
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.OperationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "История операций:";
            // 
            // InfoHistoryBox
            // 
            this.InfoHistoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoHistoryBox.FormattingEnabled = true;
            this.InfoHistoryBox.HorizontalScrollbar = true;
            this.InfoHistoryBox.ItemHeight = 29;
            this.InfoHistoryBox.Location = new System.Drawing.Point(19, 50);
            this.InfoHistoryBox.Name = "InfoHistoryBox";
            this.InfoHistoryBox.Size = new System.Drawing.Size(785, 700);
            this.InfoHistoryBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 869);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавление операции:";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(-4, 848);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(825, 1);
            this.label14.TabIndex = 33;
            // 
            // SaveHistoryButton
            // 
            this.SaveHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveHistoryButton.Location = new System.Drawing.Point(19, 756);
            this.SaveHistoryButton.Name = "SaveHistoryButton";
            this.SaveHistoryButton.Size = new System.Drawing.Size(283, 89);
            this.SaveHistoryButton.TabIndex = 34;
            this.SaveHistoryButton.Text = "Сохранить";
            this.SaveHistoryButton.UseVisualStyleBackColor = true;
            this.SaveHistoryButton.Click += new System.EventHandler(this.SaveHistoryButton_Click);
            // 
            // LoadHistoryButton
            // 
            this.LoadHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadHistoryButton.Location = new System.Drawing.Point(308, 756);
            this.LoadHistoryButton.Name = "LoadHistoryButton";
            this.LoadHistoryButton.Size = new System.Drawing.Size(258, 89);
            this.LoadHistoryButton.TabIndex = 35;
            this.LoadHistoryButton.Text = "Загрузить";
            this.LoadHistoryButton.UseVisualStyleBackColor = true;
            this.LoadHistoryButton.Click += new System.EventHandler(this.LoadHistoryButton_Click);
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearHistoryButton.Location = new System.Drawing.Point(572, 756);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(232, 89);
            this.ClearHistoryButton.TabIndex = 36;
            this.ClearHistoryButton.Text = "Очистить";
            this.ClearHistoryButton.UseVisualStyleBackColor = true;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDown.Location = new System.Drawing.Point(17, 949);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(332, 35);
            this.NumericUpDown.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 917);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Сумма:";
            // 
            // OperationType
            // 
            this.OperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationType.FormattingEnabled = true;
            this.OperationType.Location = new System.Drawing.Point(365, 948);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(268, 37);
            this.OperationType.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(360, 916);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Тип операции:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(649, 917);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 68);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 1026);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OperationType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.ClearHistoryButton);
            this.Controls.Add(this.LoadHistoryButton);
            this.Controls.Add(this.SaveHistoryButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoHistoryBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(838, 1082);
            this.MinimumSize = new System.Drawing.Size(838, 1082);
            this.Name = "Form2";
            this.Text = "Твой банк - История операций";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox InfoHistoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SaveHistoryButton;
        private System.Windows.Forms.Button LoadHistoryButton;
        private System.Windows.Forms.Button ClearHistoryButton;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OperationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}