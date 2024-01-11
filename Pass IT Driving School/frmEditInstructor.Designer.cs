namespace WinFormsApp5
{
    partial class frmEditInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditInstructor));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnUpdate = new Button();
            btnBooking = new Button();
            btnDelete = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 72);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 3;
            label3.Text = "Address:*";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 32);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 2;
            label4.Text = "Email:*";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 109);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Phone:*";
            label5.Click += label5_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(160, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(221, 31);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(160, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 31);
            txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(591, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(591, 69);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(221, 31);
            txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(160, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(221, 31);
            txtPhone.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(118, 198);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 55);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBooking.Location = new Point(356, 198);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(112, 55);
            btnBooking.TabIndex = 12;
            btnBooking.Text = "&Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(591, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 55);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(24, 308);
            listView1.Name = "listView1";
            listView1.Size = new Size(788, 195);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // frmEditInstructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(825, 515);
            Controls.Add(listView1);
            Controls.Add(btnDelete);
            Controls.Add(btnBooking);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditInstructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditInstructor";
            Load += frmEditInstructor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnUpdate;
        private Button btnBooking;
        private Button btnDelete;
        private ListView listView1;
    }
}