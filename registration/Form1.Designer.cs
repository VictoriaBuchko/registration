namespace registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelNane = new Label();
            TextBoxName = new TextBox();
            LabelLastName = new Label();
            TextBoxLastName = new TextBox();
            LabelEmail = new Label();
            TextBoxEmail = new TextBox();
            TextBoxPhone = new TextBox();
            LabelPhone = new Label();
            ComboBoxEvent = new ComboBox();
            LabelEvent = new Label();
            MonthCalendarDate = new MonthCalendar();
            LabelDate = new Label();
            DateTimePickerTime = new DateTimePicker();
            RadioButtonOnline = new RadioButton();
            RadioButtonOffline = new RadioButton();
            LabelEventFormat = new Label();
            CheckedListBoxTopic = new CheckedListBox();
            LabelTopic = new Label();
            CheckBoxYes = new CheckBox();
            LabelAgreement = new Label();
            CheckBoxNo = new CheckBox();
            ButtonRegistration = new Button();
            ButtonClear = new Button();
            LabelTime = new Label();
            SuspendLayout();
            // 
            // LabelNane
            // 
            LabelNane.AutoSize = true;
            LabelNane.Location = new Point(28, 24);
            LabelNane.Name = "LabelNane";
            LabelNane.Size = new Size(87, 20);
            LabelNane.TabIndex = 0;
            LabelNane.Text = "Enter name:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(28, 47);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(125, 27);
            TextBoxName.TabIndex = 1;
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(28, 88);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(114, 20);
            LabelLastName.TabIndex = 2;
            LabelLastName.Text = "Enter last name:";
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new Point(28, 119);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(125, 27);
            TextBoxLastName.TabIndex = 3;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(28, 163);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(87, 20);
            LabelEmail.TabIndex = 4;
            LabelEmail.Text = "Enter Email:";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(28, 199);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(125, 27);
            TextBoxEmail.TabIndex = 5;
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(28, 285);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(125, 27);
            TextBoxPhone.TabIndex = 6;
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Location = new Point(28, 251);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(144, 20);
            LabelPhone.TabIndex = 7;
            LabelPhone.Text = "Enter phone number";
            // 
            // ComboBoxEvent
            // 
            ComboBoxEvent.FormattingEnabled = true;
            ComboBoxEvent.Items.AddRange(new object[] { "webinar", "conference", "master class" });
            ComboBoxEvent.Location = new Point(293, 46);
            ComboBoxEvent.Name = "ComboBoxEvent";
            ComboBoxEvent.Size = new Size(151, 28);
            ComboBoxEvent.TabIndex = 8;
            // 
            // LabelEvent
            // 
            LabelEvent.AutoSize = true;
            LabelEvent.Location = new Point(293, 23);
            LabelEvent.Name = "LabelEvent";
            LabelEvent.Size = new Size(45, 20);
            LabelEvent.TabIndex = 9;
            LabelEvent.Text = "Event";
            // 
            // MonthCalendarDate
            // 
            MonthCalendarDate.Location = new Point(293, 119);
            MonthCalendarDate.Name = "MonthCalendarDate";
            MonthCalendarDate.TabIndex = 10;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Location = new Point(294, 88);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(150, 20);
            LabelDate.TabIndex = 11;
            LabelDate.Text = "The date of the event";
            // 
            // DateTimePickerTime
            // 
            DateTimePickerTime.Format = DateTimePickerFormat.Time;
            DateTimePickerTime.Location = new Point(294, 367);
            DateTimePickerTime.Name = "DateTimePickerTime";
            DateTimePickerTime.ShowUpDown = true;
            DateTimePickerTime.Size = new Size(250, 27);
            DateTimePickerTime.TabIndex = 12;
            // 
            // RadioButtonOnline
            // 
            RadioButtonOnline.AutoSize = true;
            RadioButtonOnline.Location = new Point(607, 72);
            RadioButtonOnline.Name = "RadioButtonOnline";
            RadioButtonOnline.Size = new Size(71, 24);
            RadioButtonOnline.TabIndex = 13;
            RadioButtonOnline.TabStop = true;
            RadioButtonOnline.Text = "online";
            RadioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOffline
            // 
            RadioButtonOffline.AutoSize = true;
            RadioButtonOffline.Location = new Point(607, 102);
            RadioButtonOffline.Name = "RadioButtonOffline";
            RadioButtonOffline.Size = new Size(73, 24);
            RadioButtonOffline.TabIndex = 14;
            RadioButtonOffline.TabStop = true;
            RadioButtonOffline.Text = "offline";
            RadioButtonOffline.UseVisualStyleBackColor = true;
            // 
            // LabelEventFormat
            // 
            LabelEventFormat.AutoSize = true;
            LabelEventFormat.Location = new Point(595, 49);
            LabelEventFormat.Name = "LabelEventFormat";
            LabelEventFormat.Size = new Size(94, 20);
            LabelEventFormat.TabIndex = 15;
            LabelEventFormat.Text = "Event format";
            // 
            // CheckedListBoxTopic
            // 
            CheckedListBoxTopic.FormattingEnabled = true;
            CheckedListBoxTopic.Items.AddRange(new object[] { "topic 1", "topic 2", "topic 3", "topic 4", "topic 5" });
            CheckedListBoxTopic.Location = new Point(595, 176);
            CheckedListBoxTopic.Name = "CheckedListBoxTopic";
            CheckedListBoxTopic.Size = new Size(141, 114);
            CheckedListBoxTopic.TabIndex = 16;
            // 
            // LabelTopic
            // 
            LabelTopic.AutoSize = true;
            LabelTopic.Location = new Point(595, 140);
            LabelTopic.Name = "LabelTopic";
            LabelTopic.Size = new Size(89, 20);
            LabelTopic.TabIndex = 17;
            LabelTopic.Text = "Event topics";
            // 
            // CheckBoxYes
            // 
            CheckBoxYes.AutoSize = true;
            CheckBoxYes.Location = new Point(52, 472);
            CheckBoxYes.Name = "CheckBoxYes";
            CheckBoxYes.Size = new Size(52, 24);
            CheckBoxYes.TabIndex = 18;
            CheckBoxYes.Text = "Yes";
            CheckBoxYes.UseVisualStyleBackColor = true;
            CheckBoxYes.CheckedChanged += CheckBoxYes_CheckedChanged;
            // 
            // LabelAgreement
            // 
            LabelAgreement.AutoSize = true;
            LabelAgreement.Location = new Point(46, 435);
            LabelAgreement.Name = "LabelAgreement";
            LabelAgreement.Size = new Size(449, 20);
            LabelAgreement.TabIndex = 19;
            LabelAgreement.Text = "Do you agree with the terms of participation and data processing?";
            // 
            // CheckBoxNo
            // 
            CheckBoxNo.AutoSize = true;
            CheckBoxNo.Location = new Point(50, 502);
            CheckBoxNo.Name = "CheckBoxNo";
            CheckBoxNo.Size = new Size(51, 24);
            CheckBoxNo.TabIndex = 20;
            CheckBoxNo.Text = "No";
            CheckBoxNo.UseVisualStyleBackColor = true;
            CheckBoxNo.CheckedChanged += CheckBoxNo_CheckedChanged;
            // 
            // ButtonRegistration
            // 
            ButtonRegistration.Location = new Point(155, 562);
            ButtonRegistration.Name = "ButtonRegistration";
            ButtonRegistration.Size = new Size(94, 29);
            ButtonRegistration.TabIndex = 21;
            ButtonRegistration.Text = "Registration";
            ButtonRegistration.UseVisualStyleBackColor = true;
            ButtonRegistration.Click += ButtonRegistration_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(455, 562);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(139, 29);
            ButtonClear.TabIndex = 22;
            ButtonClear.Text = "Clear the form";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Location = new Point(294, 335);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(42, 20);
            LabelTime.TabIndex = 23;
            LabelTime.Text = "Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(LabelTime);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonRegistration);
            Controls.Add(CheckBoxNo);
            Controls.Add(LabelAgreement);
            Controls.Add(CheckBoxYes);
            Controls.Add(LabelTopic);
            Controls.Add(CheckedListBoxTopic);
            Controls.Add(LabelEventFormat);
            Controls.Add(RadioButtonOffline);
            Controls.Add(RadioButtonOnline);
            Controls.Add(DateTimePickerTime);
            Controls.Add(LabelDate);
            Controls.Add(MonthCalendarDate);
            Controls.Add(LabelEvent);
            Controls.Add(ComboBoxEvent);
            Controls.Add(LabelPhone);
            Controls.Add(TextBoxPhone);
            Controls.Add(TextBoxEmail);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxLastName);
            Controls.Add(LabelLastName);
            Controls.Add(TextBoxName);
            Controls.Add(LabelNane);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNane;
        private TextBox TextBoxName;
        private Label LabelLastName;
        private TextBox TextBoxLastName;
        private Label LabelEmail;
        private TextBox TextBoxEmail;
        private TextBox TextBoxPhone;
        private Label LabelPhone;
        private ComboBox ComboBoxEvent;
        private Label LabelEvent;
        private MonthCalendar MonthCalendarDate;
        private Label LabelDate;
        private DateTimePicker DateTimePickerTime;
        private RadioButton RadioButtonOnline;
        private RadioButton RadioButtonOffline;
        private Label LabelEventFormat;
        private CheckedListBox CheckedListBoxTopic;
        private Label LabelTopic;
        private CheckBox CheckBoxYes;
        private Label LabelAgreement;
        private CheckBox CheckBoxNo;
        private Button ButtonRegistration;
        private Button ButtonClear;
        private Label LabelTime;
    }
}
