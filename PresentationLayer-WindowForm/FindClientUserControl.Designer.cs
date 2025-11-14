namespace PresentationLayer_WindowForm
{
    partial class FindClientUserControl
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAccountBalance = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPinCode = new System.Windows.Forms.MaskedTextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(54, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 31);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(518, 144);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 20);
            this.txtSearch.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(505, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Find By Account Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(136, 357);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Enabled = false;
            this.mtxtPhone.Location = new System.Drawing.Point(136, 431);
            this.mtxtPhone.Mask = "000-000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(123, 20);
            this.mtxtPhone.TabIndex = 52;
            // 
            // mtxtAccountBalance
            // 
            this.mtxtAccountBalance.Enabled = false;
            this.mtxtAccountBalance.Location = new System.Drawing.Point(364, 357);
            this.mtxtAccountBalance.Mask = "0000000000";
            this.mtxtAccountBalance.Name = "mtxtAccountBalance";
            this.mtxtAccountBalance.Size = new System.Drawing.Size(123, 20);
            this.mtxtAccountBalance.TabIndex = 55;
            // 
            // mtxtPinCode
            // 
            this.mtxtPinCode.Enabled = false;
            this.mtxtPinCode.Location = new System.Drawing.Point(364, 196);
            this.mtxtPinCode.Mask = "000000";
            this.mtxtPinCode.Name = "mtxtPinCode";
            this.mtxtPinCode.Size = new System.Drawing.Size(123, 20);
            this.mtxtPinCode.TabIndex = 53;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAccountNumber.Location = new System.Drawing.Point(364, 280);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(123, 20);
            this.txtAccountNumber.TabIndex = 54;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Enabled = false;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLastName.Location = new System.Drawing.Point(136, 280);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 50;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFirstName.Location = new System.Drawing.Point(136, 196);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(366, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Account Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(366, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Account Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(366, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Pin Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(133, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(133, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(133, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(133, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Find Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(518, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 41);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.Find;
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // FindClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.mtxtAccountBalance);
            this.Controls.Add(this.mtxtPinCode);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindClientUserControl";
            this.Size = new System.Drawing.Size(836, 538);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtAccountBalance;
        private System.Windows.Forms.MaskedTextBox mtxtPinCode;
        private System.Windows.Forms.TextBox txtAccountNumber;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
