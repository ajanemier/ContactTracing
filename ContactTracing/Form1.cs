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
     
        public Form1()
        {
            InitializeComponent();
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
            MessageBox.Show("Data Submitted Successfully");

            Records form2 = new Records();
            dataGridView1.Rows.Add(dateTimePicker1.Text, textboxName.Text, textBoxAdd.Text, textboxAge.Text, comboBoxGender.SelectedIndex, textboxNumber.Text, textboxEmail.Text);

            textBoxAdd.Text = textboxName.Text = textboxEmail.Text = textboxAge.Text = textboxName.Text = " ";

        }

        private void label3_Click(object sender, EventArgs e)
        {
           Records form2 = new Records();
            form2.Visible = true;

            this.Hide();
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
    }
}