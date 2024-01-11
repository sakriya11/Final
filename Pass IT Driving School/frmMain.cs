namespace WinFormsApp5
{
    public partial class frmMainform : Form
    {
        public frmMainform()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterStudent registerStudent = new frmRegisterStudent();
            registerStudent.ShowDialog();
        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterInstructor registerInstructor = new frmRegisterInstructor();
            registerInstructor.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditStudent student = new frmEditStudent();
            student.ShowDialog();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditInstructor instructor = new frmEditInstructor();
            instructor.ShowDialog();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewStudent student = new frmViewStudent();
            student.ShowDialog();
        }

        private void instructorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewInstructor instructor = new frmViewInstructor();
            instructor.ShowDialog();
        }

        private void frmMainform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}