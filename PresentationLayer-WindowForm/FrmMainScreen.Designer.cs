namespace PresentationLayer_WindowForm
{
    partial class FrmMainScreen
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
            this.PnlManageClients = new System.Windows.Forms.Panel();
            this.btnManageClient = new System.Windows.Forms.Button();
            this.PnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.PnlManageUsers = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.PnlCurrencies = new System.Windows.Forms.Panel();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.PnlLoginRegister = new System.Windows.Forms.Panel();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PnlManageClients.SuspendLayout();
            this.PnlTransactions.SuspendLayout();
            this.PnlManageUsers.SuspendLayout();
            this.PnlCurrencies.SuspendLayout();
            this.PnlLoginRegister.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.PnlManageClients);
            this.flowLayoutPanel1.Controls.Add(this.PnlTransactions);
            this.flowLayoutPanel1.Controls.Add(this.PnlManageUsers);
            this.flowLayoutPanel1.Controls.Add(this.PnlCurrencies);
            this.flowLayoutPanel1.Controls.Add(this.PnlLoginRegister);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 258);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // PnlManageClients
            // 
            this.PnlManageClients.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlManageClients.Controls.Add(this.btnManageClient);
            this.PnlManageClients.Controls.Add(this.pictureBox3);
            this.PnlManageClients.Location = new System.Drawing.Point(3, 3);
            this.PnlManageClients.Name = "PnlManageClients";
            this.PnlManageClients.Size = new System.Drawing.Size(239, 36);
            this.PnlManageClients.TabIndex = 3;
            this.PnlManageClients.Visible = false;
            // 
            // btnManageClient
            // 
            this.btnManageClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClient.FlatAppearance.BorderSize = 0;
            this.btnManageClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClient.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnManageClient.Location = new System.Drawing.Point(69, 0);
            this.btnManageClient.Name = "btnManageClient";
            this.btnManageClient.Size = new System.Drawing.Size(170, 36);
            this.btnManageClient.TabIndex = 5;
            this.btnManageClient.Text = "Manage Clients";
            this.btnManageClient.UseVisualStyleBackColor = false;
            this.btnManageClient.Click += new System.EventHandler(this.btnManageClient_Click);
            // 
            // PnlTransactions
            // 
            this.PnlTransactions.BackColor = System.Drawing.Color.Transparent;
            this.PnlTransactions.Controls.Add(this.btnTransaction);
            this.PnlTransactions.Controls.Add(this.pictureBox4);
            this.PnlTransactions.Location = new System.Drawing.Point(3, 45);
            this.PnlTransactions.Name = "PnlTransactions";
            this.PnlTransactions.Size = new System.Drawing.Size(239, 36);
            this.PnlTransactions.TabIndex = 4;
            this.PnlTransactions.Visible = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransaction.Location = new System.Drawing.Point(69, 0);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(170, 36);
            this.btnTransaction.TabIndex = 5;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // PnlManageUsers
            // 
            this.PnlManageUsers.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlManageUsers.Controls.Add(this.btnManageUsers);
            this.PnlManageUsers.Controls.Add(this.pictureBox5);
            this.PnlManageUsers.Location = new System.Drawing.Point(3, 87);
            this.PnlManageUsers.Name = "PnlManageUsers";
            this.PnlManageUsers.Size = new System.Drawing.Size(239, 36);
            this.PnlManageUsers.TabIndex = 5;
            this.PnlManageUsers.Visible = false;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Location = new System.Drawing.Point(69, 0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(170, 36);
            this.btnManageUsers.TabIndex = 5;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.button3_Click);
            // 
            // PnlCurrencies
            // 
            this.PnlCurrencies.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlCurrencies.Controls.Add(this.btnCurrencies);
            this.PnlCurrencies.Controls.Add(this.pictureBox7);
            this.PnlCurrencies.Location = new System.Drawing.Point(3, 129);
            this.PnlCurrencies.Name = "PnlCurrencies";
            this.PnlCurrencies.Size = new System.Drawing.Size(239, 36);
            this.PnlCurrencies.TabIndex = 11;
            this.PnlCurrencies.Visible = false;
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrencies.FlatAppearance.BorderSize = 0;
            this.btnCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencies.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencies.ForeColor = System.Drawing.Color.Transparent;
            this.btnCurrencies.Location = new System.Drawing.Point(69, 0);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Size = new System.Drawing.Size(170, 36);
            this.btnCurrencies.TabIndex = 5;
            this.btnCurrencies.Text = "Currencies";
            this.btnCurrencies.UseVisualStyleBackColor = false;
            this.btnCurrencies.Click += new System.EventHandler(this.button2_Click);
            // 
            // PnlLoginRegister
            // 
            this.PnlLoginRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlLoginRegister.Controls.Add(this.btnLoginRegister);
            this.PnlLoginRegister.Controls.Add(this.pictureBox6);
            this.PnlLoginRegister.Location = new System.Drawing.Point(3, 171);
            this.PnlLoginRegister.Name = "PnlLoginRegister";
            this.PnlLoginRegister.Size = new System.Drawing.Size(239, 36);
            this.PnlLoginRegister.TabIndex = 10;
            this.PnlLoginRegister.Visible = false;
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLoginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginRegister.FlatAppearance.BorderSize = 0;
            this.btnLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegister.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegister.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginRegister.Location = new System.Drawing.Point(69, 0);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(170, 36);
            this.btnLoginRegister.TabIndex = 5;
            this.btnLoginRegister.Text = "Login Registers";
            this.btnLoginRegister.UseVisualStyleBackColor = false;
            this.btnLoginRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(12, 179);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 25);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "Time";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUserName.Location = new System.Drawing.Point(125, 136);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(108, 25);
            this.lbUserName.TabIndex = 6;
            this.lbUserName.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 136);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.btnLogIn);
            this.panel3.Location = new System.Drawing.Point(702, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 37);
            this.panel3.TabIndex = 8;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(0, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(143, 35);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.TabStop = false;
            this.btnLogIn.Text = "LOG OUT";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::PresentationLayer_WindowForm.Properties.Resources.LogOut;
            this.pictureBox8.Location = new System.Drawing.Point(146, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer_WindowForm.Properties.Resources.Bank1;
            this.pictureBox2.Location = new System.Drawing.Point(290, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 449);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.ManageClient;
            this.pictureBox3.Location = new System.Drawing.Point(0, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox4.Image = global::PresentationLayer_WindowForm.Properties.Resources.AllTransactions;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox5.Image = global::PresentationLayer_WindowForm.Properties.Resources.ManageAllUser;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox7.Image = global::PresentationLayer_WindowForm.Properties.Resources.CurrencyExchange;
            this.pictureBox7.Location = new System.Drawing.Point(3, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox6.Image = global::PresentationLayer_WindowForm.Properties.Resources.LoginRegister;
            this.pictureBox6.Location = new System.Drawing.Point(0, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
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
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMainScreen";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PnlManageClients.ResumeLayout(false);
            this.PnlTransactions.ResumeLayout(false);
            this.PnlManageUsers.ResumeLayout(false);
            this.PnlCurrencies.ResumeLayout(false);
            this.PnlLoginRegister.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlManageClients;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnManageClient;
        private System.Windows.Forms.Panel PnlTransactions;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PnlManageUsers;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PnlLoginRegister;
        private System.Windows.Forms.Button btnLoginRegister;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel PnlCurrencies;
        private System.Windows.Forms.Button btnCurrencies;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnLogIn;
    }
}

