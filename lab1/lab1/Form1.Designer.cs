namespace lab1
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
            this.headLabel1 = new System.Windows.Forms.Label();
            this.headLabel2 = new System.Windows.Forms.Label();
            this.number1text = new System.Windows.Forms.TextBox();
            this.number2text = new System.Windows.Forms.TextBox();
            this.buttonAND = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonNOT = new System.Windows.Forms.Button();
            this.headLabel3 = new System.Windows.Forms.Label();
            this.comboListUnit = new System.Windows.Forms.ComboBox();
            this.headLabel4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headLabel1
            // 
            this.headLabel1.AutoSize = true;
            this.headLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel1.Location = new System.Drawing.Point(12, 107);
            this.headLabel1.Name = "headLabel1";
            this.headLabel1.Size = new System.Drawing.Size(258, 37);
            this.headLabel1.TabIndex = 0;
            this.headLabel1.Text = "Введите 1 число:";
            // 
            // headLabel2
            // 
            this.headLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.headLabel2.AutoSize = true;
            this.headLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel2.Location = new System.Drawing.Point(12, 276);
            this.headLabel2.Name = "headLabel2";
            this.headLabel2.Size = new System.Drawing.Size(260, 37);
            this.headLabel2.TabIndex = 1;
            this.headLabel2.Text = "Введите 2 число:";
            // 
            // number1text
            // 
            this.number1text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1text.Location = new System.Drawing.Point(17, 158);
            this.number1text.Name = "number1text";
            this.number1text.Size = new System.Drawing.Size(251, 35);
            this.number1text.TabIndex = 2;
            // 
            // number2text
            // 
            this.number2text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.number2text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2text.Location = new System.Drawing.Point(18, 333);
            this.number2text.Name = "number2text";
            this.number2text.Size = new System.Drawing.Size(251, 35);
            this.number2text.TabIndex = 3;
            // 
            // buttonAND
            // 
            this.buttonAND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAND.Location = new System.Drawing.Point(472, 85);
            this.buttonAND.MaximumSize = new System.Drawing.Size(75, 75);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(75, 75);
            this.buttonAND.TabIndex = 4;
            this.buttonAND.Text = "И";
            this.buttonAND.UseVisualStyleBackColor = true;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOR.Location = new System.Drawing.Point(472, 201);
            this.buttonOR.MaximumSize = new System.Drawing.Size(75, 75);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(75, 75);
            this.buttonOR.TabIndex = 5;
            this.buttonOR.Text = "ИЛИ";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // buttonXOR
            // 
            this.buttonXOR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR.Location = new System.Drawing.Point(472, 318);
            this.buttonXOR.MaximumSize = new System.Drawing.Size(75, 75);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(75, 75);
            this.buttonXOR.TabIndex = 6;
            this.buttonXOR.Text = "!ИЛИ";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonNOT
            // 
            this.buttonNOT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNOT.Location = new System.Drawing.Point(472, 435);
            this.buttonNOT.MaximumSize = new System.Drawing.Size(75, 75);
            this.buttonNOT.Name = "buttonNOT";
            this.buttonNOT.Size = new System.Drawing.Size(75, 75);
            this.buttonNOT.TabIndex = 7;
            this.buttonNOT.Text = "НЕ";
            this.buttonNOT.UseVisualStyleBackColor = true;
            this.buttonNOT.Click += new System.EventHandler(this.buttonNOT_Click);
            // 
            // headLabel3
            // 
            this.headLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headLabel3.AutoSize = true;
            this.headLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel3.Location = new System.Drawing.Point(696, 107);
            this.headLabel3.Name = "headLabel3";
            this.headLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.headLabel3.Size = new System.Drawing.Size(238, 37);
            this.headLabel3.TabIndex = 8;
            this.headLabel3.Text = "Форма вывода:";
            // 
            // comboListUnit
            // 
            this.comboListUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboListUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboListUnit.FormattingEnabled = true;
            this.comboListUnit.Items.AddRange(new object[] {
            "Восьмеричный",
            "Двоичный",
            "Десятичный",
            "Шестнадцатеричный"});
            this.comboListUnit.Location = new System.Drawing.Point(703, 158);
            this.comboListUnit.Name = "comboListUnit";
            this.comboListUnit.Size = new System.Drawing.Size(264, 37);
            this.comboListUnit.TabIndex = 10;
            this.comboListUnit.SelectedIndexChanged += new System.EventHandler(this.comboListUnit_SelectedIndexChanged);
            // 
            // headLabel4
            // 
            this.headLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.headLabel4.AutoSize = true;
            this.headLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel4.Location = new System.Drawing.Point(696, 276);
            this.headLabel4.Name = "headLabel4";
            this.headLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.headLabel4.Size = new System.Drawing.Size(171, 37);
            this.headLabel4.TabIndex = 11;
            this.headLabel4.Text = "Результат:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(703, 333);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(264, 35);
            this.resultTextBox.TabIndex = 12;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(427, 553);
            this.buttonClear.MaximumSize = new System.Drawing.Size(160, 78);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(160, 78);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.headLabel4);
            this.Controls.Add(this.comboListUnit);
            this.Controls.Add(this.headLabel3);
            this.Controls.Add(this.buttonNOT);
            this.Controls.Add(this.buttonXOR);
            this.Controls.Add(this.buttonOR);
            this.Controls.Add(this.buttonAND);
            this.Controls.Add(this.number2text);
            this.Controls.Add(this.number1text);
            this.Controls.Add(this.headLabel2);
            this.Controls.Add(this.headLabel1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(716, 627);
            this.Name = "MainForm";
            this.Text = "Бинарный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headLabel1;
        private System.Windows.Forms.Label headLabel2;
        private System.Windows.Forms.TextBox number1text;
        private System.Windows.Forms.TextBox number2text;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonNOT;
        private System.Windows.Forms.Label headLabel3;
        private System.Windows.Forms.ComboBox comboListUnit;
        private System.Windows.Forms.Label headLabel4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button buttonClear;
    }
}

