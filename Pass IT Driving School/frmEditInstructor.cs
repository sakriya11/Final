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
    public partial class frmEditInstructor : Form
    {
        public frmEditInstructor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEditInstructor_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Address", 150);
            listView1.Columns.Add("Number", 150);

            ListViewItem newItem = new ListViewItem("Sakriya");
            newItem.SubItems.Add("Khadka");
            newItem.SubItems.Add("birmingham");
            newItem.SubItems.Add("987654");
            newItem.SubItems.Add("sakriya@gmail.com");
            listView1.Items.Add(newItem);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                DataGridViewRow dataGrid = dataGridView1.CurrentRow;
                txtFirstName.Text = dataGrid.Cells[0].Value.ToString();
                txtLastName.Text = dataGrid.Cells[1].Value.ToString();
                txtEmail.Text = dataGrid.Cells[2].Value.ToString();
                txtAddress.Text = dataGrid.Cells[3].Value.ToString();
                txtPhone.Text = dataGrid.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name can not be empty");
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name can not be empty");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address can not be empty");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone can not be empty");
            }
            else
            {
                MessageBox.Show("Record is Successfully Updated");
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking frmBook = new frmBooking();
            frmBook.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtFirstName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            MessageBox.Show("Deleted succesfully", "Delect Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
    }
}
