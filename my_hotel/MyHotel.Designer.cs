namespace my_hotel
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
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numberLabel = new System.Windows.Forms.Label();
            this.cardButton = new System.Windows.Forms.Button();
            this.viezdLabel = new System.Windows.Forms.Label();
            this.zaezdLabel = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guestsListBox = new System.Windows.Forms.ListBox();
            this.listLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(3, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 13);
            this.time.TabIndex = 0;
            this.time.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 396);
            this.panel1.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 153);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(102, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "выписываются";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "занято";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "свободно";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "зарезервировано";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(42, 32);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 24);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Статус";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(152, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 390);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numberLabel);
            this.panel3.Controls.Add(this.cardButton);
            this.panel3.Controls.Add(this.viezdLabel);
            this.panel3.Controls.Add(this.zaezdLabel);
            this.panel3.Controls.Add(this.fioLabel);
            this.panel3.Controls.Add(this.statusComboBox);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.status2Label);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(428, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 396);
            this.panel3.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(121, 32);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(23, 23);
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Text = "...";
            // 
            // cardButton
            // 
            this.cardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cardButton.Location = new System.Drawing.Point(52, 341);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(137, 23);
            this.cardButton.TabIndex = 8;
            this.cardButton.Text = "Посмотреть карточку";
            this.cardButton.UseVisualStyleBackColor = false;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // viezdLabel
            // 
            this.viezdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viezdLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viezdLabel.Location = new System.Drawing.Point(130, 285);
            this.viezdLabel.Name = "viezdLabel";
            this.viezdLabel.Size = new System.Drawing.Size(96, 50);
            this.viezdLabel.TabIndex = 7;
            this.viezdLabel.Text = "Дата выезда";
            // 
            // zaezdLabel
            // 
            this.zaezdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zaezdLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zaezdLabel.Location = new System.Drawing.Point(9, 285);
            this.zaezdLabel.Name = "zaezdLabel";
            this.zaezdLabel.Size = new System.Drawing.Size(87, 50);
            this.zaezdLabel.TabIndex = 6;
            this.zaezdLabel.Text = "Дата заезда";
            // 
            // fioLabel
            // 
            this.fioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fioLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(9, 246);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(217, 23);
            this.fioLabel.TabIndex = 5;
            this.fioLabel.Text = "ФИО";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "зарезервировано",
            "свободно",
            "занято",
            "выписываются"});
            this.statusComboBox.Location = new System.Drawing.Point(88, 207);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(138, 21);
            this.statusComboBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // status2Label
            // 
            this.status2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status2Label.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2Label.Location = new System.Drawing.Point(9, 204);
            this.status2Label.Name = "status2Label";
            this.status2Label.Size = new System.Drawing.Size(60, 28);
            this.status2Label.TabIndex = 2;
            this.status2Label.Text = "статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер №";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.guestsListBox);
            this.panel4.Controls.Add(this.listLabel);
            this.panel4.Location = new System.Drawing.Point(153, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 396);
            this.panel4.TabIndex = 3;
            // 
            // guestsListBox
            // 
            this.guestsListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.guestsListBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsListBox.FormattingEnabled = true;
            this.guestsListBox.ItemHeight = 26;
            this.guestsListBox.Location = new System.Drawing.Point(8, 71);
            this.guestsListBox.Name = "guestsListBox";
            this.guestsListBox.Size = new System.Drawing.Size(260, 290);
            this.guestsListBox.TabIndex = 9;
            this.guestsListBox.SelectedIndexChanged += new System.EventHandler(this.guestsListBox_SelectedIndexChanged);
            this.guestsListBox.DoubleClick += new System.EventHandler(this.guestsListBox_DoubleClick);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(33, 32);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(113, 24);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "Список гостей";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 377);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "отель \"в гостях у нэстистпнв\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status2Label;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label zaezdLabel;
        public System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.Label viezdLabel;
        private System.Windows.Forms.ListBox guestsListBox;
        private System.Windows.Forms.Label numberLabel;
    }
}

