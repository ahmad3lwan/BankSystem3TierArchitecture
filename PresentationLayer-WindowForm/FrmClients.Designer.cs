namespace PresentationLayer_WindowForm
{
    partial class FrmClients
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
            this.btnClientsList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 481);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 225);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 243);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnClientsList);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnClientsList
            // 
            this.btnClientsList.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClientsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsList.FlatAppearance.BorderSize = 0;
            this.btnClientsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsList.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsList.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientsList.Location = new System.Drawing.Point(69, 0);
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.Size = new System.Drawing.Size(170, 36);
            this.btnClientsList.TabIndex = 5;
            this.btnClientsList.Text = "Clients List";
            this.btnClientsList.UseVisualStyleBackColor = false;
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.btnAddNewClient);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 36);
            this.panel3.TabIndex = 4;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.FlatAppearance.BorderSize = 0;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.Location = new System.Drawing.Point(69, 0);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(170, 36);
            this.btnAddNewClient.TabIndex = 5;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.btnUpdateClient);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(3, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 36);
            this.panel4.TabIndex = 5;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.Location = new System.Drawing.Point(69, 0);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(170, 36);
            this.btnUpdateClient.TabIndex = 5;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.btnFindClient);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(3, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 36);
            this.panel6.TabIndex = 6;
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFindClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindClient.Location = new System.Drawing.Point(69, 0);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(170, 36);
            this.btnFindClient.TabIndex = 5;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(15, 183);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.btnFind);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(18, 432);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 36);
            this.panel5.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Transparent;
            this.btnFind.Location = new System.Drawing.Point(69, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(170, 36);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find Client";
            this.btnFind.UseVisualStyleBackColor = false;
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
            // PanelContainer
            // 
            this.PanelContainer.Location = new System.Drawing.Point(307, 12);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(735, 481);
            this.PanelContainer.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.UsersList;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox4.Image = global::PresentationLayer_WindowForm.Properties.Resources.AddClient;
            this.pictureBox4.Location = new System.Drawing.Point(-6, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox5.Image = global::PresentationLayer_WindowForm.Properties.Resources.UpdateClient;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox6.Image = global::PresentationLayer_WindowForm.Properties.Resources.FindClient;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::PresentationLayer_WindowForm.Properties.Resources.ManageUSer;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 525);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClients";
            this.Text = "FrmClients";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClientsList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}