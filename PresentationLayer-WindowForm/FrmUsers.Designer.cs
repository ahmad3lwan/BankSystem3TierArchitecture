namespace PresentationLayer_WindowForm
{
    partial class FrmUsers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsersList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelUserScreen = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 474);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 226);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 229);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnUsersList);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnUsersList
            // 
            this.btnUsersList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersList.FlatAppearance.BorderSize = 0;
            this.btnUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersList.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersList.ForeColor = System.Drawing.Color.Transparent;
            this.btnUsersList.Location = new System.Drawing.Point(69, 0);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.Size = new System.Drawing.Size(170, 36);
            this.btnUsersList.TabIndex = 5;
            this.btnUsersList.Text = "Users List";
            this.btnUsersList.UseVisualStyleBackColor = false;
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.btnUpdateUser);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(3, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 36);
            this.panel4.TabIndex = 5;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Location = new System.Drawing.Point(69, 0);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(170, 36);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.btnAddNewUser);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(3, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 36);
            this.panel3.TabIndex = 4;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Location = new System.Drawing.Point(69, 0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(170, 36);
            this.btnAddNewUser.TabIndex = 5;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Controls.Add(this.btnFindUser);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(3, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 36);
            this.panel5.TabIndex = 6;
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindUser.Location = new System.Drawing.Point(69, 0);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(170, 36);
            this.btnFindUser.TabIndex = 5;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(15, 198);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 25);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Time";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbUserName.Location = new System.Drawing.Point(122, 153);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(108, 25);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelUserScreen
            // 
            this.PanelUserScreen.Location = new System.Drawing.Point(293, 9);
            this.PanelUserScreen.Name = "PanelUserScreen";
            this.PanelUserScreen.Size = new System.Drawing.Size(707, 474);
            this.PanelUserScreen.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.UserList;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox5.Image = global::PresentationLayer_WindowForm.Properties.Resources.UpdateUser;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox4.Image = global::PresentationLayer_WindowForm.Properties.Resources.AddUser;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Image = global::PresentationLayer_WindowForm.Properties.Resources.FindUser;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer_WindowForm.Properties.Resources.Bank2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 495);
            this.Controls.Add(this.PanelUserScreen);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsersList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelUserScreen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}