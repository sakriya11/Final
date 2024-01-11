namespace WinFormsApp5
{
    partial class frmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStudent));
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnProgress = new Button();
            btnBooking = new Button();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-139, 85);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 18;
            label5.Text = "Phone:*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-139, 38);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 15;
            label2.Text = "Last Name:*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-139, -4);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 14;
            label1.Text = "First Name:*";
            // 
            // btnProgress
            // 
            btnProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProgress.Location = new Point(563, 165);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(112, 55);
            btnProgress.TabIndex = 32;
            btnProgress.Text = "&Delete";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBooking.Location = new Point(339, 165);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(112, 55);
            btnBooking.TabIndex = 31;
            btnBooking.Text = "&Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(114, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 55);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(517, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 31);
            txtAddress.TabIndex = 27;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(517, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 31);
            txtEmail.TabIndex = 26;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(142, 69);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(246, 31);
            txtLastName.TabIndex = 25;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(142, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(246, 31);
            txtFirstName.TabIndex = 24;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 72);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 22;
            label4.Text = "Address:*";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 33);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 21;
            label6.Text = "Email:*";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 69);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 20;
            label7.Text = "Last Name:*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 27);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 19;
            label8.Text = "First Name:*";
            // 
            // listView1
            // 
            listView1.Location = new Point(14, 257);
            listView1.Name = "listView1";
            listView1.Size = new Size(749, 227);
            listView1.TabIndex = 33;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // frmEditStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(772, 513);
            Controls.Add(listView1);
            Controls.Add(btnProgress);
            Controls.Add(btnBooking);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEditStudent";
            Load += frmEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label2;
        private Label label1;
        private Button btnProgress;
        private Button btnBooking;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListView listView1;
    }
}