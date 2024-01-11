namespace WinFormsApp5
{
    partial class frmRegisterInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterInstructor));
            label5 = new Label();
            button1 = new Button();
            txtnumber = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(275, 37);
            label5.Name = "label5";
            label5.Size = new Size(250, 29);
            label5.TabIndex = 19;
            label5.Text = "Instructor registration";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(347, 341);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtnumber
            // 
            txtnumber.Location = new Point(251, 266);
            txtnumber.Name = "txtnumber";
            txtnumber.Size = new Size(321, 31);
            txtnumber.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 31);
            txtEmail.TabIndex = 16;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(251, 168);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(321, 31);
            txtLname.TabIndex = 15;
            txtLname.KeyPress += textBox2_KeyPress;
            // 
            // txtname
            // 
            txtname.Location = new Point(251, 121);
            txtname.Name = "txtname";
            txtname.Size = new Size(321, 31);
            txtname.TabIndex = 14;
            txtname.TextChanged += textBox1_TextChanged;
            txtname.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 272);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 13;
            label4.Text = "Number";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 224);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 12;
            label3.Text = "Email*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 171);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 11;
            label2.Text = "Last name*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 121);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 10;
            label1.Text = "First name*";
            // 
            // listView1
            // 
            listView1.Location = new Point(72, 391);
            listView1.Name = "listView1";
            listView1.Size = new Size(653, 237);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // frmRegisterInstructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 640);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtnumber);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterInstructor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegisterInstructor";
            Load += frmRegisterInstructor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private TextBox txtnumber;
        private TextBox txtEmail;
        private TextBox txtLname;
        private TextBox txtname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
    }
}