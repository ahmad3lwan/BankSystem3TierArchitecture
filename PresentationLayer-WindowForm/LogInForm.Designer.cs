namespace PresentationLayer_WindowForm
{
    partial class LogInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pboxHideAndShow = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInvalid1 = new System.Windows.Forms.Label();
            this.lbInvalid2 = new System.Windows.Forms.Label();
            this.lbAttempcount = new System.Windows.Forms.Label();
            this.lbInvalide3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHideAndShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(40, 0);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 32);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = " Enter User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(196, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 32);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer_WindowForm.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pboxHideAndShow);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(196, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 32);
            this.panel2.TabIndex = 5;
            // 
            // pboxHideAndShow
            // 
            this.pboxHideAndShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxHideAndShow.Image = global::PresentationLayer_WindowForm.Properties.Resources.eye;
            this.pboxHideAndShow.Location = new System.Drawing.Point(172, 0);
            this.pboxHideAndShow.Name = "pboxHideAndShow";
            this.pboxHideAndShow.Size = new System.Drawing.Size(41, 32);
            this.pboxHideAndShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHideAndShow.TabIndex = 7;
            this.pboxHideAndShow.TabStop = false;
            this.pboxHideAndShow.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(40, 0);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 32);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "  Enter Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(70, 0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(143, 35);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.btnLogIn);
            this.panel3.Location = new System.Drawing.Point(196, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 37);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox4.Image = global::PresentationLayer_WindowForm.Properties.Resources.LogIN;
            this.pictureBox4.Location = new System.Drawing.Point(3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer_WindowForm.Properties.Resources.home1;
            this.pictureBox1.Location = new System.Drawing.Point(196, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbInvalid1
            // 
            this.lbInvalid1.AutoSize = true;
            this.lbInvalid1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalid1.ForeColor = System.Drawing.Color.Red;
            this.lbInvalid1.Location = new System.Drawing.Point(196, 419);
            this.lbInvalid1.Name = "lbInvalid1";
            this.lbInvalid1.Size = new System.Drawing.Size(178, 15);
            this.lbInvalid1.TabIndex = 8;
            this.lbInvalid1.Text = "Invalid UserName Or Password";
            this.lbInvalid1.Visible = false;
            // 
            // lbInvalid2
            // 
            this.lbInvalid2.AutoSize = true;
            this.lbInvalid2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalid2.ForeColor = System.Drawing.Color.Red;
            this.lbInvalid2.Location = new System.Drawing.Point(196, 447);
            this.lbInvalid2.Name = "lbInvalid2";
            this.lbInvalid2.Size = new System.Drawing.Size(83, 15);
            this.lbInvalid2.TabIndex = 9;
            this.lbInvalid2.Text = "You Still Have";
            this.lbInvalid2.Visible = false;
            // 
            // lbAttempcount
            // 
            this.lbAttempcount.AutoSize = true;
            this.lbAttempcount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttempcount.ForeColor = System.Drawing.Color.Red;
            this.lbAttempcount.Location = new System.Drawing.Point(285, 447);
            this.lbAttempcount.Name = "lbAttempcount";
            this.lbAttempcount.Size = new System.Drawing.Size(14, 15);
            this.lbAttempcount.TabIndex = 10;
            this.lbAttempcount.Text = "0";
            this.lbAttempcount.Visible = false;
            // 
            // lbInvalide3
            // 
            this.lbInvalide3.AutoSize = true;
            this.lbInvalide3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalide3.ForeColor = System.Drawing.Color.Red;
            this.lbInvalide3.Location = new System.Drawing.Point(305, 447);
            this.lbInvalide3.Name = "lbInvalide3";
            this.lbInvalide3.Size = new System.Drawing.Size(208, 15);
            this.lbInvalide3.TabIndex = 11;
            this.lbInvalide3.Text = "Attempts Before Lock Your Account";
            this.lbInvalide3.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.lbInvalide3);
            this.Controls.Add(this.lbAttempcount);
            this.Controls.Add(this.lbInvalid2);
            this.Controls.Add(this.lbInvalid1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHideAndShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pboxHideAndShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbInvalid1;
        private System.Windows.Forms.Label lbInvalid2;
        private System.Windows.Forms.Label lbAttempcount;
        private System.Windows.Forms.Label lbInvalide3;
    }
}