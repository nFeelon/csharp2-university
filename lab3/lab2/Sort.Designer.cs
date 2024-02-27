namespace lab2
{
    partial class Sort
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
            this.SortByTypeButton = new System.Windows.Forms.Button();
            this.bSortByDateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchListBox
            // 
            this.searchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.HorizontalScrollbar = true;
            this.searchListBox.ItemHeight = 29;
            this.searchListBox.Location = new System.Drawing.Point(357, 23);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(592, 352);
            this.searchListBox.TabIndex = 30;
            // 
            // SortByTypeButton
            // 
            this.SortByTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByTypeButton.Location = new System.Drawing.Point(27, 82);
            this.SortByTypeButton.Name = "SortByTypeButton";
            this.SortByTypeButton.Size = new System.Drawing.Size(304, 68);
            this.SortByTypeButton.TabIndex = 31;
            this.SortByTypeButton.Text = "По типу вклада";
            this.SortByTypeButton.UseVisualStyleBackColor = true;
            this.SortByTypeButton.Click += new System.EventHandler(this.ButtonSortByType_Click);
            // 
            // bSortByDateButton
            // 
            this.bSortByDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSortByDateButton.Location = new System.Drawing.Point(27, 165);
            this.bSortByDateButton.Name = "bSortByDateButton";
            this.bSortByDateButton.Size = new System.Drawing.Size(304, 68);
            this.bSortByDateButton.TabIndex = 32;
            this.bSortByDateButton.Text = "По дате открытия";
            this.bSortByDateButton.UseVisualStyleBackColor = true;
            this.bSortByDateButton.Click += new System.EventHandler(this.ButtonSortByDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Сортировка:";
            // 
            // SaveSortButton
            // 
            this.SaveSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSortButton.Location = new System.Drawing.Point(27, 307);
            this.SaveSortButton.Name = "SaveSortButton";
            this.SaveSortButton.Size = new System.Drawing.Size(304, 68);
            this.SaveSortButton.TabIndex = 34;
            this.SaveSortButton.Text = "Сохранить";
            this.SaveSortButton.UseVisualStyleBackColor = true;
            this.SaveSortButton.Click += new System.EventHandler(this.ButtonSaveSort_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 395);
            this.Controls.Add(this.SaveSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSortByDateButton);
            this.Controls.Add(this.SortByTypeButton);
            this.Controls.Add(this.searchListBox);
            this.Name = "Sort";
            this.Text = "Сортировка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button SortByTypeButton;
        private System.Windows.Forms.Button bSortByDateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveSortButton;
    }
}