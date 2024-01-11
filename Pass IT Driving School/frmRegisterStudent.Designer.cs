namespace WinFormsApp5
{
    partial class frmRegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterStudent));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnSubmit = new Button();
            label5 = new Label();
            txtNumber = new TextBox();
            label6 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 77);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "First name*";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 127);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Last name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 174);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Email*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 225);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(270, 77);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(321, 31);
            txtFname.TabIndex = 4;
            txtFname.TextChanged += textBox1_TextChanged;
            txtFname.KeyPress += textBox1_KeyPress;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(270, 127);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(321, 31);
            txtLname.TabIndex = 5;
            txtLname.TextChanged += txtLname_TextChanged;
            txtLname.KeyPress += textBox2_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(270, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 31);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(270, 225);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(321, 31);
            txtAddress.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(369, 333);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(314, 22);
            label5.Name = "label5";
            label5.Size = new Size(228, 29);
            label5.TabIndex = 9;
            label5.Text = "Student registration";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(270, 272);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(321, 31);
            txtNumber.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 272);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 11;
            label6.Text = "Number";
            // 
            // listView1
            // 
            listView1.Location = new Point(56, 393);
            listView1.Name = "listView1";
            listView1.Size = new Size(696, 200);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // frmRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 605);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(txtNumber);
            Controls.Add(label5);
            Controls.Add(btnSubmit);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegisterStudent";
            Load += frmRegisterStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Button btnSubmit;
        private Label label5;
        private TextBox txtNumber;
        private Label label6;
        private ListView listView1;
    }
}