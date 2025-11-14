namespace PresentationLayer_WindowForm
{
    partial class AddNewUserUserControl
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLoginRegister = new System.Windows.Forms.CheckBox();
            this.chkCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkManageClient = new System.Windows.Forms.CheckBox();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(56, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 41);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(125, 395);
            this.mtxtPhone.Mask = "000-000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(123, 20);
            this.mtxtPhone.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(125, 321);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(353, 244);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 20);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLastName.Location = new System.Drawing.Point(125, 244);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 31;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFirstName.Location = new System.Drawing.Point(125, 160);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(-3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Permission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(355, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(355, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(122, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(122, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(122, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(122, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add New User";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserName.Location = new System.Drawing.Point(353, 160);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(123, 20);
            this.txtUserName.TabIndex = 34;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(43, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Give Full Access?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLoginRegister);
            this.groupBox1.Controls.Add(this.chkCurrencyExchange);
            this.groupBox1.Controls.Add(this.chkManageUsers);
            this.groupBox1.Controls.Add(this.chkTransaction);
            this.groupBox1.Controls.Add(this.chkManageClient);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(309, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 170);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkLoginRegister
            // 
            this.chkLoginRegister.AutoSize = true;
            this.chkLoginRegister.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoginRegister.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkLoginRegister.Location = new System.Drawing.Point(6, 145);
            this.chkLoginRegister.Name = "chkLoginRegister";
            this.chkLoginRegister.Size = new System.Drawing.Size(115, 19);
            this.chkLoginRegister.TabIndex = 43;
            this.chkLoginRegister.Text = "Login Register";
            this.chkLoginRegister.UseVisualStyleBackColor = true;
            this.chkLoginRegister.CheckedChanged += new System.EventHandler(this.chkLoginRegister_CheckedChanged);
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.AutoSize = true;
            this.chkCurrencyExchange.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrencyExchange.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkCurrencyExchange.Location = new System.Drawing.Point(139, 116);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.Size = new System.Drawing.Size(146, 19);
            this.chkCurrencyExchange.TabIndex = 42;
            this.chkCurrencyExchange.Text = "Currency Exchange";
            this.chkCurrencyExchange.UseVisualStyleBackColor = true;
            this.chkCurrencyExchange.CheckedChanged += new System.EventHandler(this.chkCurrencyExchange_CheckedChanged);
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkManageUsers.Location = new System.Drawing.Point(139, 80);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(112, 19);
            this.chkManageUsers.TabIndex = 41;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            this.chkManageUsers.CheckedChanged += new System.EventHandler(this.chkManageUsers_CheckedChanged);
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransaction.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkTransaction.Location = new System.Drawing.Point(6, 116);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(104, 19);
            this.chkTransaction.TabIndex = 40;
            this.chkTransaction.Text = "Transactions";
            this.chkTransaction.UseVisualStyleBackColor = true;
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.chkTransaction_CheckedChanged);
            // 
            // chkManageClient
            // 
            this.chkManageClient.AutoSize = true;
            this.chkManageClient.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageClient.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkManageClient.Location = new System.Drawing.Point(6, 79);
            this.chkManageClient.Name = "chkManageClient";
            this.chkManageClient.Size = new System.Drawing.Size(114, 19);
            this.chkManageClient.TabIndex = 39;
            this.chkManageClient.Text = "Manage Client";
            this.chkManageClient.UseVisualStyleBackColor = true;
            this.chkManageClient.CheckedChanged += new System.EventHandler(this.chkManageClient_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbYes.Location = new System.Drawing.Point(63, 41);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 19);
            this.rbYes.TabIndex = 37;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbNo.Location = new System.Drawing.Point(126, 42);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(42, 19);
            this.rbNo.TabIndex = 38;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(549, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 41);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.Save;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // AddNewUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUserUserControl";
            this.Size = new System.Drawing.Size(835, 505);
            this.Load += new System.EventHandler(this.AddNewUserUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.CheckBox chkLoginRegister;
        private System.Windows.Forms.CheckBox chkCurrencyExchange;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkManageClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
