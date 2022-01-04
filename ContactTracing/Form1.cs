using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        Records fgrid;
        public Form1(Records fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }



        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if (asciiCode != 8)
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        public void btnSubmit_Click(object sender, EventArgs e)

        {

            string value1 = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value1 = radioButton1.Text;
            else
                value1 = radioButton2.Text;


            string value2 = "";
            bool Checked = radioButton6.Checked;
            if (Checked)
                value2 = radioButton6.Text;
            else
                value2 = radioButton5.Text;

            String ClientString = String.Empty;

            if (checkBox1.Checked)
                ClientString = checkBox1.Text;
            if (checkBox2.Checked)
                ClientString += ", " + checkBox2.Text;
            if (checkBox3.Checked)
                ClientString += ", " + checkBox3.Text;
            if (checkBox4.Checked)
                ClientString += ", " + checkBox4.Text;


            

            MessageBox.Show("Data Submitted Successfully");

            fgrid.dataGridView1.Rows.Add(dateTimePicker1.Value, textBoxTemp.Text, textboxName.Text, textBoxAdd.Text, textBoxCity.Text, textboxAge.Text, comboBoxGender.SelectedItem, textboxNumber.Text, textboxEmail.Text, ClientString, value1, value2);


            textBoxAdd.Text = textboxName.Text = textboxEmail.Text = textboxAge.Text = textboxNumber.Text = textBoxCity.Text = textBoxTemp.Text = "";

        }




        private void label3_Click(object sender, EventArgs e)
        {
            Records form2 = new Records();
            form2.Visible = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        
    }
}