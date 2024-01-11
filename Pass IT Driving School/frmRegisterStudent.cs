using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp5
{
    public partial class frmRegisterStudent : Form
    {
        public frmRegisterStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            if (txtFname.Text == "")
            {
                MessageBox.Show("First Name is required!!!");
                txtFname.Focus();
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
                ListViewItem newItem = new ListViewItem(txtFname.Text);
                newItem.SubItems.Add(txtLname.Text);
                newItem.SubItems.Add(txtAddress.Text);
                newItem.SubItems.Add(txtNumber.Text);
                newItem.SubItems.Add(txtEmail.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Student is added successfully!!!");
                txtLname.Text = "";
                txtEmail.Text = "";
                txtFname.Text = "";
                txtNumber.Text = "";
                txtAddress.Text = "";


            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegisterStudent_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Address", 150);
            listView1.Columns.Add("Number", 150);
        }
    }
}
