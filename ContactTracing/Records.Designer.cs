namespace ContactTracing
{
    partial class Records
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptomps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Travel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Temperature,
            this.Name,
            this.Address,
            this.dataGridViewTextBoxColumn1,
            this.Age,
            this.Gender,
            this.Number,
            this.Email,
            this.Symptomps,
            this.Stay,
            this.Travel});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.FillWeight = 108.756F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Temperature
            // 
            this.Temperature.FillWeight = 37.46937F;
            this.Temperature.HeaderText = "Temp";
            this.Temperature.Name = "Temperature";
            // 
            // Name
            // 
            this.Name.FillWeight = 208.8956F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Address
            // 
            this.Address.FillWeight = 208.8956F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 91.37054F;
            this.dataGridViewTextBoxColumn1.HeaderText = "City";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Age
            // 
            this.Age.FillWeight = 34.05173F;
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Gender
            // 
            this.Gender.FillWeight = 56.09372F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Number
            // 
            this.Number.FillWeight = 78.29256F;
            this.Number.HeaderText = "Mobile Number";
            this.Number.Name = "Number";
            // 
            // Email
            // 
            this.Email.FillWeight = 92.58156F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Symptomps
            // 
            this.Symptomps.FillWeight = 93.20541F;
            this.Symptomps.HeaderText = "Symptomps";
            this.Symptomps.Name = "Symptomps";
            // 
            // Stay
            // 
            this.Stay.FillWeight = 95.59984F;
            this.Stay.HeaderText = "Stayed with confirmed Covid-19 case?";
            this.Stay.Name = "Stay";
            // 
            // Travel
            // 
            this.Travel.FillWeight = 94.78804F;
            this.Travel.HeaderText = "Travelled outside PH within 14 days?";
            this.Travel.Name = "Travel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(115, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 2);
            this.panel1.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1533, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);

            this.Text = "Contact Tracing Form Records";
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Symptomps;
        private DataGridViewTextBoxColumn Stay;
        private DataGridViewTextBoxColumn Travel;
    }
}