namespace ContactTracing
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
            this.labelName = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.labelques1 = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.labelques2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelques3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.labelAgreement = new System.Windows.Forms.Label();
            this.checkBoxAgreement = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(275, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Fulll Name (Last  Name, First Name, Middle Name)";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(28, 172);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(495, 23);
            this.textboxName.TabIndex = 1;
            // 
            // textboxAge
            // 
            this.textboxAge.Location = new System.Drawing.Point(237, 249);
            this.textboxAge.Name = "textboxAge";
            this.textboxAge.Size = new System.Drawing.Size(47, 23);
            this.textboxAge.TabIndex = 2;
            this.textboxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(206, 252);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(31, 15);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(28, 284);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 15);
            this.labelGender.TabIndex = 9;
            this.labelGender.Tag = "";
            this.labelGender.Text = "Gender:";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Location = new System.Drawing.Point(290, 251);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(94, 15);
            this.labelMobileNumber.TabIndex = 20;
            this.labelMobileNumber.Text = "Mobile Number:";
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(240, 282);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(283, 23);
            this.textboxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(195, 285);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // textboxNumber
            // 
            this.textboxNumber.Location = new System.Drawing.Point(390, 249);
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.Size = new System.Drawing.Size(133, 23);
            this.textboxNumber.TabIndex = 21;
            this.textboxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // labelques1
            // 
            this.labelques1.AutoSize = true;
            this.labelques1.Location = new System.Drawing.Point(26, 282);
            this.labelques1.Name = "labelques1";
            this.labelques1.Size = new System.Drawing.Size(0, 15);
            this.labelques1.TabIndex = 24;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(28, 202);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(188, 15);
            this.labelAdd.TabIndex = 39;
            this.labelAdd.Text = "Address ( House No., Street, Brgy.)";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(28, 220);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(495, 23);
            this.textBoxAdd.TabIndex = 40;
            // 
            // labelques2
            // 
            this.labelques2.AutoSize = true;
            this.labelques2.Location = new System.Drawing.Point(26, 356);
            this.labelques2.Name = "labelques2";
            this.labelques2.Size = new System.Drawing.Size(0, 15);
            this.labelques2.TabIndex = 52;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 19);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 19);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelques3
            // 
            this.labelques3.AutoSize = true;
            this.labelques3.Location = new System.Drawing.Point(12, 516);
            this.labelques3.Name = "labelques3";
            this.labelques3.Size = new System.Drawing.Size(0, 15);
            this.labelques3.TabIndex = 55;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 675);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 33);
            this.btnSubmit.TabIndex = 58;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 604);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(484, 15);
            this.label16.TabIndex = 73;
            this.label16.Text = "I hereby authorize [name of Office] to collect and process the data indicated her" +
    "ein for the ";
            // 
            // labelAgreement
            // 
            this.labelAgreement.AutoSize = true;
            this.labelAgreement.Location = new System.Drawing.Point(30, 622);
            this.labelAgreement.Name = "labelAgreement";
            this.labelAgreement.Size = new System.Drawing.Size(493, 15);
            this.labelAgreement.TabIndex = 74;
            this.labelAgreement.Text = "purpose of contact tracing effecting control of the COVID-19 transmission. I unde" +
    "rstand that";
            // 
            // checkBoxAgreement
            // 
            this.checkBoxAgreement.AutoSize = true;
            this.checkBoxAgreement.Location = new System.Drawing.Point(32, 605);
            this.checkBoxAgreement.Name = "checkBoxAgreement";
            this.checkBoxAgreement.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAgreement.TabIndex = 75;
            this.checkBoxAgreement.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 641);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(437, 15);
            this.label18.TabIndex = 76;
            this.label18.Text = "my personal information is protected by RA 10173 or the Data Privacy Act of 2012." +
    "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "Records";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(28, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 2);
            this.panel1.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(83, 281);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(91, 23);
            this.comboBoxGender.TabIndex = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 76);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Are you experiencing any of the Following?";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(222, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 19);
            this.checkBox4.TabIndex = 105;
            this.checkBox4.Text = "Sore Throat";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(222, 22);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 19);
            this.checkBox3.TabIndex = 104;
            this.checkBox3.Text = "Body Pain";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 19);
            this.checkBox2.TabIndex = 103;
            this.checkBox2.Text = "Cough and Colds";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 102;
            this.checkBox1.Text = "Fever";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Date/Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "City:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(65, 249);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(129, 23);
            this.textBoxCity.TabIndex = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(31, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 63);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Have you stayed together in the same close environment with a confirmed  COVID" +
    "-19 case?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(31, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 49);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Have you travelled outside the Philippines in the last 14 days?";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(147, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(44, 19);
            this.radioButton5.TabIndex = 54;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "No ";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(29, 22);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(45, 19);
            this.radioButton6.TabIndex = 53;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Yes ";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Answer the ff. questions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Temperature:";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(461, 82);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTemp.Size = new System.Drawing.Size(43, 23);
            this.textBoxTemp.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 727);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkBoxAgreement);
            this.Controls.Add(this.labelAgreement);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelques3);
            this.Controls.Add(this.labelques2);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelques1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textboxNumber);
            this.Controls.Add(this.labelMobileNumber);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textboxAge);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Contact Tracing Form Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private TextBox textboxName;
        private TextBox textboxAge;
        private Label labelAge;
        private Label labelGender;
        private Label labelMobileNumber;
        private TextBox textboxEmail;
        private Label labelEmail;
        private TextBox textboxNumber;
        private Label labelques1;
        private Label labelAdd;
        private TextBox textBoxAdd;
        private Label labelques2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label labelques3;
        private Button btnSubmit;
        private Label label16;
        private Label labelAgreement;
        private CheckBox checkBoxAgreement;
        private Label label18;
        private Label label14;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxGender;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox textBoxCity;
        public TextBox textBoxTemp;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}