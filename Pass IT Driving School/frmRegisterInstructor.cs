using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class frmRegisterInstructor : Form
    {
        public frmRegisterInstructor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("First Name is required!!!");
                txtname.Focus();
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Last Name is required!!!");
                txtLname.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required!!!");
                txtEmail.Focus();
            }
            else

            {
                MessageBox.Show("Record stored Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLname.Text = "";
                txtEmail.Text = "";
                txtname.Text = "";
                txtnumber.Text = "";


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmRegisterInstructor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 180);
            listView1.Columns.Add("Last Name", 180);
            listView1.Columns.Add("Email", 180);
            listView1.Columns.Add("Number", 180);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 180);
            listView1.Columns.Add("Last Name", 180);
            listView1.Columns.Add("Email", 180);
            listView1.Columns.Add("Number", 180);
        }
    }
}
