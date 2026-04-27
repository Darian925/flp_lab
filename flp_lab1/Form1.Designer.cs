namespace flp_lab1
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNumbers = new System.Windows.Forms.TabPage();
            this.tabRecipient = new System.Windows.Forms.TabPage();
            this.tabContent = new System.Windows.Forms.TabPage();

            // Вкладка "Номера и даты"
            this.lblOutgoingNumber = new System.Windows.Forms.Label();
            this.txtOutgoingNumber = new System.Windows.Forms.TextBox();
            this.lblIncomingNumber = new System.Windows.Forms.Label();
            this.txtIncomingNumber = new System.Windows.Forms.TextBox();
            this.lblIncomingDate = new System.Windows.Forms.Label();
            this.txtIncomingDate = new System.Windows.Forms.TextBox();

            // Вкладка "Получатель"
            this.lblRecipientOrganization = new System.Windows.Forms.Label();
            this.txtRecipientOrganization = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblShortName = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();

            // Вкладка "Содержание"
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabNumbers);
            this.tabControl1.Controls.Add(this.tabRecipient);
            this.tabControl1.Controls.Add(this.tabContent);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 380);
            this.tabControl1.TabIndex = 0;

            // tabNumbers
            this.tabNumbers.Text = "Номера и даты";
            this.tabNumbers.Controls.Add(this.lblOutgoingNumber);
            this.tabNumbers.Controls.Add(this.txtOutgoingNumber);
            this.tabNumbers.Controls.Add(this.lblIncomingNumber);
            this.tabNumbers.Controls.Add(this.txtIncomingNumber);
            this.tabNumbers.Controls.Add(this.lblIncomingDate);
            this.tabNumbers.Controls.Add(this.txtIncomingDate);

            int y = 25;
            this.lblOutgoingNumber.AutoSize = true;
            this.lblOutgoingNumber.Location = new System.Drawing.Point(30, y);
            this.lblOutgoingNumber.Size = new System.Drawing.Size(160, 20);
            this.lblOutgoingNumber.Text = "Исходящий номер:";
            this.txtOutgoingNumber.Location = new System.Drawing.Point(210, y);
            this.txtOutgoingNumber.Size = new System.Drawing.Size(230, 22);

            y += 45;
            this.lblIncomingNumber.AutoSize = true;
            this.lblIncomingNumber.Location = new System.Drawing.Point(30, y);
            this.lblIncomingNumber.Size = new System.Drawing.Size(155, 20);
            this.lblIncomingNumber.Text = "Входящий номер:";
            this.txtIncomingNumber.Location = new System.Drawing.Point(210, y);
            this.txtIncomingNumber.Size = new System.Drawing.Size(230, 22);

            y += 45;
            this.lblIncomingDate.AutoSize = true;
            this.lblIncomingDate.Location = new System.Drawing.Point(30, y);
            this.lblIncomingDate.Size = new System.Drawing.Size(165, 20);
            this.lblIncomingDate.Text = "Дата входящего:";
            this.txtIncomingDate.Location = new System.Drawing.Point(210, y);
            this.txtIncomingDate.Size = new System.Drawing.Size(230, 22);

            // tabRecipient
            this.tabRecipient.Text = "Получатель";
            this.tabRecipient.Controls.Add(this.lblRecipientOrganization);
            this.tabRecipient.Controls.Add(this.txtRecipientOrganization);
            this.tabRecipient.Controls.Add(this.lblPosition);
            this.tabRecipient.Controls.Add(this.txtPosition);
            this.tabRecipient.Controls.Add(this.lblFullName);
            this.tabRecipient.Controls.Add(this.txtFullName);
            this.tabRecipient.Controls.Add(this.lblShortName);
            this.tabRecipient.Controls.Add(this.txtShortName);

            y = 25;
            this.lblRecipientOrganization.AutoSize = true;
            this.lblRecipientOrganization.Location = new System.Drawing.Point(30, y);
            this.lblRecipientOrganization.Size = new System.Drawing.Size(175, 20);
            this.lblRecipientOrganization.Text = "Организация получателя:";
            this.txtRecipientOrganization.Location = new System.Drawing.Point(220, y);
            this.txtRecipientOrganization.Size = new System.Drawing.Size(220, 22);

            y += 45;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(30, y);
            this.lblPosition.Size = new System.Drawing.Size(135, 20);
            this.lblPosition.Text = "Должность:";
            this.txtPosition.Location = new System.Drawing.Point(220, y);
            this.txtPosition.Size = new System.Drawing.Size(220, 22);

            y += 45;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, y);
            this.lblFullName.Size = new System.Drawing.Size(135, 20);
            this.lblFullName.Text = "ФИО адресата:";
            this.txtFullName.Location = new System.Drawing.Point(220, y);
            this.txtFullName.Size = new System.Drawing.Size(220, 22);

            y += 45;
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(30, y);
            this.lblShortName.Size = new System.Drawing.Size(160, 20);
            this.lblShortName.Text = "Обращение (по имени):";
            this.txtShortName.Location = new System.Drawing.Point(220, y);
            this.txtShortName.Size = new System.Drawing.Size(220, 22);

            // tabContent
            this.tabContent.Text = "Содержание";
            this.tabContent.Controls.Add(this.lblSubject);
            this.tabContent.Controls.Add(this.txtSubject);
            this.tabContent.Controls.Add(this.lblStudentName);
            this.tabContent.Controls.Add(this.txtStudentName);
            this.tabContent.Controls.Add(this.lblBody);
            this.tabContent.Controls.Add(this.txtBody);

            y = 25;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(30, y);
            this.lblSubject.Size = new System.Drawing.Size(105, 20);
            this.lblSubject.Text = "Тема письма:";
            this.txtSubject.Location = new System.Drawing.Point(160, y);
            this.txtSubject.Size = new System.Drawing.Size(270, 22);

            y += 50;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(30, y);
            this.lblStudentName.Size = new System.Drawing.Size(115, 20);
            this.lblStudentName.Text = "ФИО студента:";
            this.txtStudentName.Location = new System.Drawing.Point(160, y);
            this.txtStudentName.Size = new System.Drawing.Size(270, 22);

            y += 50;
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(30, y);
            this.lblBody.Size = new System.Drawing.Size(115, 20);
            this.lblBody.Text = "Текст письма:";
            this.txtBody.Location = new System.Drawing.Point(30, y + 30);
            this.txtBody.Multiline = true;
            this.txtBody.Size = new System.Drawing.Size(400, 200);
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Buttons
            this.btnGenerate.BackColor = System.Drawing.Color.LightGreen;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(12, 440);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.btnClear.Location = new System.Drawing.Point(172, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnDefault.Location = new System.Drawing.Point(332, 440);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(160, 45);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "Заполнить примером";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);

            // Form1
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 35);
            this.lblTitle.Text = "Генератор писем DOCX";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор писем DOCX";
            this.ResumeLayout(false);
        }

        // Объявления всех контролов
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNumbers;
        private System.Windows.Forms.TabPage tabRecipient;
        private System.Windows.Forms.TabPage tabContent;

        // Номера и даты
        private System.Windows.Forms.Label lblOutgoingNumber;
        private System.Windows.Forms.TextBox txtOutgoingNumber;
        private System.Windows.Forms.Label lblIncomingNumber;
        private System.Windows.Forms.TextBox txtIncomingNumber;
        private System.Windows.Forms.Label lblIncomingDate;
        private System.Windows.Forms.TextBox txtIncomingDate;

        // Получатель
        private System.Windows.Forms.Label lblRecipientOrganization;
        private System.Windows.Forms.TextBox txtRecipientOrganization;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.TextBox txtShortName;

        // Содержание
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
    }
}

