namespace VkMeSendMessages
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
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.chatIdField = new System.Windows.Forms.NumericUpDown();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.chatTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chatIdField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            this.SuspendLayout();
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(12, 193);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(263, 23);
            this.sendMessageButton.TabIndex = 0;
            this.sendMessageButton.Text = "Отправить сообщение";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(85, 12);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(190, 20);
            this.tokenBox.TabIndex = 1;
            // 
            // chatIdField
            // 
            this.chatIdField.Location = new System.Drawing.Point(86, 65);
            this.chatIdField.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.chatIdField.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.chatIdField.Name = "chatIdField";
            this.chatIdField.Size = new System.Drawing.Size(189, 20);
            this.chatIdField.TabIndex = 2;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(86, 117);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(189, 70);
            this.messageBox.TabIndex = 3;
            this.messageBox.Text = "";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(281, 38);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(261, 149);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // chatTypeBox
            // 
            this.chatTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chatTypeBox.FormattingEnabled = true;
            this.chatTypeBox.Items.AddRange(new object[] {
            "Пользователь",
            "Диалог",
            "Сообщество"});
            this.chatTypeBox.Location = new System.Drawing.Point(85, 38);
            this.chatTypeBox.Name = "chatTypeBox";
            this.chatTypeBox.Size = new System.Drawing.Size(190, 21);
            this.chatTypeBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип чата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ИД чата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сообщение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логи:";
            // 
            // timeField
            // 
            this.timeField.Location = new System.Drawing.Point(85, 91);
            this.timeField.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(189, 20);
            this.timeField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Время:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(368, 198);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Разработчик: vk.com/id99551920";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 228);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatTypeBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.chatIdField);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.sendMessageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VkMeSendMessages";
            ((System.ComponentModel.ISupportInitialize)(this.chatIdField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.NumericUpDown chatIdField;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox chatTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timeField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

