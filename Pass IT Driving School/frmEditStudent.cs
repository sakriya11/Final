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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking frmBooking = new frmBooking();
            frmBooking.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("No record selected", "Select Record", MessageBoxButtons.OK);
            }
            else if (listView1.SelectedItems.Count > -1)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtFirstName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtLastName.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtEmail.Text;
                MessageBox.Show("Updated succesfully", "Delect Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }           
            else
            {
                MessageBox.Show("Unknown error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 190);
            listView1.Columns.Add("Last Name", 190);
            listView1.Columns.Add("Email", 190);
            listView1.Columns.Add("Address", 190);

            ListViewItem newItem = new ListViewItem("Sakriya");
            newItem.SubItems.Add("Khadka");
            newItem.SubItems.Add("sakriya@gmail.com");
            newItem.SubItems.Add("B3,Birmingham");
            listView1.Items.Add(newItem);
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtFirstName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            MessageBox.Show("Deleted succesfully", "Delect Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
