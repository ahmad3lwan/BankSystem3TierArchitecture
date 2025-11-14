namespace PresentationLayer_WindowForm
{
    partial class FindUserUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPermission = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPassowrd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(59, 327);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 70;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Enabled = false;
            this.mtxtPhone.Location = new System.Drawing.Point(59, 401);
            this.mtxtPhone.Mask = "000-000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(123, 20);
            this.mtxtPhone.TabIndex = 71;
            // 
            // mtxtPermission
            // 
            this.mtxtPermission.Enabled = false;
            this.mtxtPermission.Location = new System.Drawing.Point(287, 327);
            this.mtxtPermission.Mask = "00";
            this.mtxtPermission.Name = "mtxtPermission";
            this.mtxtPermission.Size = new System.Drawing.Size(123, 20);
            this.mtxtPermission.TabIndex = 74;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.Enabled = false;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(287, 250);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 20);
            this.txtPassword.TabIndex = 73;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Enabled = false;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLastName.Location = new System.Drawing.Point(59, 250);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 69;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFirstName.Location = new System.Drawing.Point(59, 166);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(289, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Permission";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbPassword.Location = new System.Drawing.Point(289, 210);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(72, 16);
            this.lbPassword.TabIndex = 66;
            this.lbPassword.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(289, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(56, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(56, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(56, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Find User";
            // 
            // txtSearchPassowrd
            // 
            this.txtSearchPassowrd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchPassowrd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSearchPassowrd.Location = new System.Drawing.Point(586, 148);
            this.txtSearchPassowrd.Multiline = true;
            this.txtSearchPassowrd.Name = "txtSearchPassowrd";
            this.txtSearchPassowrd.Size = new System.Drawing.Size(77, 20);
            this.txtSearchPassowrd.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label12.Location = new System.Drawing.Point(583, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 79;
            this.label12.Text = "Password";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(56, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 31);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSearchUserName.Location = new System.Drawing.Point(476, 148);
            this.txtSearchUserName.Multiline = true;
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(77, 20);
            this.txtSearchUserName.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(454, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Search By UserName And Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(473, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.Enabled = false;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserName.Location = new System.Drawing.Point(287, 166);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(123, 20);
            this.txtUserName.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(513, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 41);
            this.panel1.TabIndex = 82;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.Find;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // FindUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtSearchPassowrd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.mtxtPermission);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindUserUserControl";
            this.Size = new System.Drawing.Size(837, 556);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtPermission;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPassowrd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
