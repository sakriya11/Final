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
    public partial class frmViewStudent : Form
    {
        public frmViewStudent()
        {
            InitializeComponent();
        }

        private void frmViewStudent_Load(object sender, EventArgs e)
        {
            Object[] instructorList = new Object[] { "Sujan", "Mahato", "email@gmail.com", "birmingham", "9876543" };
            dataGridView1.Rows.Add(instructorList);
            instructorList = new Object[] { "Sakriya", "Khadka", "sk@gmail.com", "Coventry", "0000223443" };
            dataGridView1.Rows.Add(instructorList);
        }
    }
}
