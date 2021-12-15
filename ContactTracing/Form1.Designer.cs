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
            this.labelFName = new System.Windows.Forms.Label();
            this.textboxFName = new System.Windows.Forms.TextBox();
            this.textboxLName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboboxAge = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.textboxMobileNumber = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(28, 120);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(275, 15);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "Fulll Name (Last  Name, First Name, Middle Name)";
            this.labelFName.Click += new System.EventHandler(this.labelFName_Click);
            // 
            // textboxFName
            // 
            this.textboxFName.Location = new System.Drawing.Point(28, 138);
            this.textboxFName.Name = "textboxFName";
            this.textboxFName.Size = new System.Drawing.Size(500, 23);
            this.textboxFName.TabIndex = 1;
            // 
            // textboxLName
            // 
            this.textboxLName.Location = new System.Drawing.Point(59, 216);
            this.textboxLName.Name = "textboxLName";
            this.textboxLName.Size = new System.Drawing.Size(47, 23);
            this.textboxLName.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(28, 219);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(31, 15);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age:";
            // 
            // comboboxAge
            // 
            this.comboboxAge.FormattingEnabled = true;
            this.comboboxAge.Location = new System.Drawing.Point(167, 216);
            this.comboboxAge.Name = "comboboxAge";
            this.comboboxAge.Size = new System.Drawing.Size(117, 23);
            this.comboboxAge.TabIndex = 8;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(116, 219);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 15);
            this.labelGender.TabIndex = 9;
            this.labelGender.Tag = "";
            this.labelGender.Text = "Gender:";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Location = new System.Drawing.Point(290, 219);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(94, 15);
            this.labelMobileNumber.TabIndex = 20;
            this.labelMobileNumber.Text = "Mobile Number:";
            // 
            // textboxMobileNumber
            // 
            this.textboxMobileNumber.Location = new System.Drawing.Point(116, 248);
            this.textboxMobileNumber.Name = "textboxMobileNumber";
            this.textboxMobileNumber.Size = new System.Drawing.Size(412, 23);
            this.textboxMobileNumber.TabIndex = 19;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(28, 251);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(84, 15);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email Address:";
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(390, 217);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(138, 23);
            this.textboxEmail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contact Tracing Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Do you experience any of the Following?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Fever";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(34, 328);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 19);
            this.checkBox6.TabIndex = 30;
            this.checkBox6.Text = "Dry cough";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(152, 304);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 19);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Sore throat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(152, 329);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(128, 19);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "Shortness of Breath";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(312, 304);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(147, 19);
            this.checkBox9.TabIndex = 38;
            this.checkBox9.Text = "Loss of Smell and Taste";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(312, 329);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(126, 19);
            this.checkBox10.TabIndex = 37;
            this.checkBox10.Text = "None of the Above";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Address ( House No., Street, Subd., Brgy, City)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 23);
            this.textBox1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Temp:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(444, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 23);
            this.textBox4.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Time:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 23);
            this.textBox2.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(489, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Have you stayed together in the same close environment with a confirmed  COVID-19" +
    " case?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 386);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 19);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(152, 386);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 19);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "Have you travelled outside the Philippines in the last 14 days?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(152, 436);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 19);
            this.radioButton3.TabIndex = 57;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(34, 436);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 19);
            this.radioButton4.TabIndex = 56;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Yes ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 58;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.labelMobileNumber);
            this.Controls.Add(this.textboxMobileNumber);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboboxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textboxLName);
            this.Controls.Add(this.textboxFName);
            this.Controls.Add(this.labelFName);
            this.Name = "Form1";
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFName;
        private TextBox textboxFName;
        private TextBox textboxLName;
        private Label labelAge;
        private ComboBox comboboxAge;
        private Label labelGender;
        private Label labelMobileNumber;
        private TextBox textboxMobileNumber;
        private Label labelEmail;
        private TextBox textboxEmail;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label7;
        private TextBox textBox2;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label10;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
    }
}