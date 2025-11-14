namespace PresentationLayer_WindowForm
{
    partial class FrmCurrencies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurrencies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrenciesList = new System.Windows.Forms.TabPage();
            this.lbCurrenciesCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.Cbx1 = new System.Windows.Forms.TabControl();
            this.UpdateCurrency = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.CBXCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrencyExchange = new System.Windows.Forms.TabPage();
            this.lbCoin2Name = new System.Windows.Forms.Label();
            this.lbAmountAfterExchange = new System.Windows.Forms.Label();
            this.lbEquall = new System.Windows.Forms.Label();
            this.lbCoinName = new System.Windows.Forms.Label();
            this.lbAmountBeforeExchange = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.lbCodeToValue = new System.Windows.Forms.Label();
            this.lbNameToValue = new System.Windows.Forms.Label();
            this.lbRateToValue = new System.Windows.Forms.Label();
            this.lbCountryToValue = new System.Windows.Forms.Label();
            this.lbRateToText = new System.Windows.Forms.Label();
            this.lbNameToText = new System.Windows.Forms.Label();
            this.lbCodeToText = new System.Windows.Forms.Label();
            this.lbCountryToText = new System.Windows.Forms.Label();
            this.NumbericAmount = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.CBXTo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBXFrom = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCodeFromValue = new System.Windows.Forms.Label();
            this.lbNameFromValue = new System.Windows.Forms.Label();
            this.lbRateFromValue = new System.Windows.Forms.Label();
            this.lbCountryFromValue = new System.Windows.Forms.Label();
            this.lbRateTextFrom = new System.Windows.Forms.Label();
            this.lbNameTextFrom = new System.Windows.Forms.Label();
            this.lbCodeTextFrom = new System.Windows.Forms.Label();
            this.lbCountryTextFrom = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.CurrenciesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            this.Cbx1.SuspendLayout();
            this.UpdateCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.CurrencyExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericAmount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 462);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(12, 197);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(79, 25);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "label9";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUserName.Location = new System.Drawing.Point(119, 153);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(108, 25);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 153);
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
            // CurrenciesList
            // 
            this.CurrenciesList.AutoScroll = true;
            this.CurrenciesList.Controls.Add(this.lbCurrenciesCount);
            this.CurrenciesList.Controls.Add(this.label9);
            this.CurrenciesList.Controls.Add(this.label10);
            this.CurrenciesList.Controls.Add(this.dgvCurrencies);
            this.CurrenciesList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrenciesList.ImageIndex = 0;
            this.CurrenciesList.Location = new System.Drawing.Point(4, 29);
            this.CurrenciesList.Name = "CurrenciesList";
            this.CurrenciesList.Padding = new System.Windows.Forms.Padding(3);
            this.CurrenciesList.Size = new System.Drawing.Size(791, 429);
            this.CurrenciesList.TabIndex = 2;
            this.CurrenciesList.Text = "Currencies List";
            this.CurrenciesList.UseVisualStyleBackColor = true;
            // 
            // lbCurrenciesCount
            // 
            this.lbCurrenciesCount.AutoSize = true;
            this.lbCurrenciesCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrenciesCount.Location = new System.Drawing.Point(352, 22);
            this.lbCurrenciesCount.Name = "lbCurrenciesCount";
            this.lbCurrenciesCount.Size = new System.Drawing.Size(23, 25);
            this.lbCurrenciesCount.TabIndex = 9;
            this.lbCurrenciesCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Currencey (s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Currencies";
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.dgvCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrencies.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurrencies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrencies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrencies.EnableHeadersVisualStyles = false;
            this.dgvCurrencies.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgvCurrencies.Location = new System.Drawing.Point(6, 78);
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.ReadOnly = true;
            this.dgvCurrencies.RowHeadersVisible = false;
            this.dgvCurrencies.Size = new System.Drawing.Size(779, 345);
            this.dgvCurrencies.TabIndex = 0;
            // 
            // Cbx1
            // 
            this.Cbx1.Controls.Add(this.CurrenciesList);
            this.Cbx1.Controls.Add(this.UpdateCurrency);
            this.Cbx1.Controls.Add(this.CurrencyExchange);
            this.Cbx1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx1.ImageList = this.imageList1;
            this.Cbx1.Location = new System.Drawing.Point(271, 12);
            this.Cbx1.Name = "Cbx1";
            this.Cbx1.SelectedIndex = 0;
            this.Cbx1.Size = new System.Drawing.Size(799, 462);
            this.Cbx1.TabIndex = 3;
            // 
            // UpdateCurrency
            // 
            this.UpdateCurrency.Controls.Add(this.panel3);
            this.UpdateCurrency.Controls.Add(this.numericUpDown1);
            this.UpdateCurrency.Controls.Add(this.label7);
            this.UpdateCurrency.Controls.Add(this.lbCode);
            this.UpdateCurrency.Controls.Add(this.lbName);
            this.UpdateCurrency.Controls.Add(this.lbRate);
            this.UpdateCurrency.Controls.Add(this.lbCountry);
            this.UpdateCurrency.Controls.Add(this.lb4);
            this.UpdateCurrency.Controls.Add(this.lb3);
            this.UpdateCurrency.Controls.Add(this.lb2);
            this.UpdateCurrency.Controls.Add(this.lb1);
            this.UpdateCurrency.Controls.Add(this.CBXCode);
            this.UpdateCurrency.Controls.Add(this.label4);
            this.UpdateCurrency.ImageIndex = 1;
            this.UpdateCurrency.Location = new System.Drawing.Point(4, 29);
            this.UpdateCurrency.Name = "UpdateCurrency";
            this.UpdateCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateCurrency.Size = new System.Drawing.Size(791, 429);
            this.UpdateCurrency.TabIndex = 3;
            this.UpdateCurrency.Text = "Update Currency";
            this.UpdateCurrency.UseVisualStyleBackColor = true;
            this.UpdateCurrency.Click += new System.EventHandler(this.UpdateCurrency_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(50, -1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(283, 308);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(279, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "New Rate";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCode.Location = new System.Drawing.Point(399, 175);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(15, 17);
            this.lbCode.TabIndex = 11;
            this.lbCode.Text = "0";
            this.lbCode.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbName.Location = new System.Drawing.Point(399, 205);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(15, 17);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "0";
            this.lbName.Visible = false;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRate.Location = new System.Drawing.Point(399, 229);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(15, 17);
            this.lbRate.TabIndex = 9;
            this.lbRate.Text = "0";
            this.lbRate.Visible = false;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCountry.Location = new System.Drawing.Point(399, 151);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(15, 17);
            this.lbCountry.TabIndex = 8;
            this.lbCountry.Text = "0";
            this.lbCountry.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb4.Location = new System.Drawing.Point(280, 229);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(109, 17);
            this.lb4.TabIndex = 7;
            this.lb4.Text = "Rate Per Dollar :";
            this.lb4.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb3.Location = new System.Drawing.Point(280, 202);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(108, 17);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "Name               :";
            this.lb3.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb2.Location = new System.Drawing.Point(280, 175);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(107, 17);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Code                :";
            this.lb2.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb1.Location = new System.Drawing.Point(280, 151);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 17);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "Country           :";
            this.lb1.Visible = false;
            // 
            // CBXCode
            // 
            this.CBXCode.FormattingEnabled = true;
            this.CBXCode.Location = new System.Drawing.Point(283, 92);
            this.CBXCode.Name = "CBXCode";
            this.CBXCode.Size = new System.Drawing.Size(130, 28);
            this.CBXCode.TabIndex = 3;
            this.CBXCode.SelectedIndexChanged += new System.EventHandler(this.CBXCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(279, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search By Code";
            // 
            // CurrencyExchange
            // 
            this.CurrencyExchange.Controls.Add(this.panel2);
            this.CurrencyExchange.Controls.Add(this.lbCoin2Name);
            this.CurrencyExchange.Controls.Add(this.lbAmountAfterExchange);
            this.CurrencyExchange.Controls.Add(this.lbEquall);
            this.CurrencyExchange.Controls.Add(this.lbCoinName);
            this.CurrencyExchange.Controls.Add(this.lbAmountBeforeExchange);
            this.CurrencyExchange.Controls.Add(this.lbCodeToValue);
            this.CurrencyExchange.Controls.Add(this.lbNameToValue);
            this.CurrencyExchange.Controls.Add(this.lbRateToValue);
            this.CurrencyExchange.Controls.Add(this.lbCountryToValue);
            this.CurrencyExchange.Controls.Add(this.lbRateToText);
            this.CurrencyExchange.Controls.Add(this.lbNameToText);
            this.CurrencyExchange.Controls.Add(this.lbCodeToText);
            this.CurrencyExchange.Controls.Add(this.lbCountryToText);
            this.CurrencyExchange.Controls.Add(this.NumbericAmount);
            this.CurrencyExchange.Controls.Add(this.label24);
            this.CurrencyExchange.Controls.Add(this.CBXTo);
            this.CurrencyExchange.Controls.Add(this.label15);
            this.CurrencyExchange.Controls.Add(this.CBXFrom);
            this.CurrencyExchange.Controls.Add(this.label14);
            this.CurrencyExchange.Controls.Add(this.lbCodeFromValue);
            this.CurrencyExchange.Controls.Add(this.lbNameFromValue);
            this.CurrencyExchange.Controls.Add(this.lbRateFromValue);
            this.CurrencyExchange.Controls.Add(this.lbCountryFromValue);
            this.CurrencyExchange.Controls.Add(this.lbRateTextFrom);
            this.CurrencyExchange.Controls.Add(this.lbNameTextFrom);
            this.CurrencyExchange.Controls.Add(this.lbCodeTextFrom);
            this.CurrencyExchange.Controls.Add(this.lbCountryTextFrom);
            this.CurrencyExchange.ImageIndex = 2;
            this.CurrencyExchange.Location = new System.Drawing.Point(4, 29);
            this.CurrencyExchange.Name = "CurrencyExchange";
            this.CurrencyExchange.Padding = new System.Windows.Forms.Padding(3);
            this.CurrencyExchange.Size = new System.Drawing.Size(791, 429);
            this.CurrencyExchange.TabIndex = 4;
            this.CurrencyExchange.Text = "Currency Exchange";
            this.CurrencyExchange.UseVisualStyleBackColor = true;
            this.CurrencyExchange.Click += new System.EventHandler(this.CurrencyExchange_Click);
            // 
            // lbCoin2Name
            // 
            this.lbCoin2Name.AutoSize = true;
            this.lbCoin2Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoin2Name.ForeColor = System.Drawing.Color.Lime;
            this.lbCoin2Name.Location = new System.Drawing.Point(480, 384);
            this.lbCoin2Name.Name = "lbCoin2Name";
            this.lbCoin2Name.Size = new System.Drawing.Size(48, 17);
            this.lbCoin2Name.TabIndex = 55;
            this.lbCoin2Name.Text = "Name ";
            this.lbCoin2Name.Visible = false;
            // 
            // lbAmountAfterExchange
            // 
            this.lbAmountAfterExchange.AutoSize = true;
            this.lbAmountAfterExchange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountAfterExchange.ForeColor = System.Drawing.Color.Lime;
            this.lbAmountAfterExchange.Location = new System.Drawing.Point(395, 384);
            this.lbAmountAfterExchange.Name = "lbAmountAfterExchange";
            this.lbAmountAfterExchange.Size = new System.Drawing.Size(15, 17);
            this.lbAmountAfterExchange.TabIndex = 54;
            this.lbAmountAfterExchange.Text = "0";
            this.lbAmountAfterExchange.Visible = false;
            // 
            // lbEquall
            // 
            this.lbEquall.AutoSize = true;
            this.lbEquall.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquall.ForeColor = System.Drawing.Color.Lime;
            this.lbEquall.Location = new System.Drawing.Point(283, 376);
            this.lbEquall.Name = "lbEquall";
            this.lbEquall.Size = new System.Drawing.Size(31, 32);
            this.lbEquall.TabIndex = 53;
            this.lbEquall.Text = "=";
            this.lbEquall.Visible = false;
            // 
            // lbCoinName
            // 
            this.lbCoinName.AutoSize = true;
            this.lbCoinName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoinName.ForeColor = System.Drawing.Color.Lime;
            this.lbCoinName.Location = new System.Drawing.Point(171, 388);
            this.lbCoinName.Name = "lbCoinName";
            this.lbCoinName.Size = new System.Drawing.Size(48, 17);
            this.lbCoinName.TabIndex = 52;
            this.lbCoinName.Text = "Name ";
            this.lbCoinName.Visible = false;
            // 
            // lbAmountBeforeExchange
            // 
            this.lbAmountBeforeExchange.AutoSize = true;
            this.lbAmountBeforeExchange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountBeforeExchange.ForeColor = System.Drawing.Color.Lime;
            this.lbAmountBeforeExchange.Location = new System.Drawing.Point(85, 388);
            this.lbAmountBeforeExchange.Name = "lbAmountBeforeExchange";
            this.lbAmountBeforeExchange.Size = new System.Drawing.Size(15, 17);
            this.lbAmountBeforeExchange.TabIndex = 51;
            this.lbAmountBeforeExchange.Text = "0";
            this.lbAmountBeforeExchange.Visible = false;
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.White;
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnExchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.Black;
            this.btnExchange.Location = new System.Drawing.Point(51, 0);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(102, 36);
            this.btnExchange.TabIndex = 50;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // lbCodeToValue
            // 
            this.lbCodeToValue.AutoSize = true;
            this.lbCodeToValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeToValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCodeToValue.Location = new System.Drawing.Point(514, 148);
            this.lbCodeToValue.Name = "lbCodeToValue";
            this.lbCodeToValue.Size = new System.Drawing.Size(15, 17);
            this.lbCodeToValue.TabIndex = 49;
            this.lbCodeToValue.Text = "0";
            this.lbCodeToValue.Visible = false;
            // 
            // lbNameToValue
            // 
            this.lbNameToValue.AutoSize = true;
            this.lbNameToValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameToValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNameToValue.Location = new System.Drawing.Point(514, 178);
            this.lbNameToValue.Name = "lbNameToValue";
            this.lbNameToValue.Size = new System.Drawing.Size(15, 17);
            this.lbNameToValue.TabIndex = 48;
            this.lbNameToValue.Text = "0";
            this.lbNameToValue.Visible = false;
            // 
            // lbRateToValue
            // 
            this.lbRateToValue.AutoSize = true;
            this.lbRateToValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateToValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRateToValue.Location = new System.Drawing.Point(514, 202);
            this.lbRateToValue.Name = "lbRateToValue";
            this.lbRateToValue.Size = new System.Drawing.Size(15, 17);
            this.lbRateToValue.TabIndex = 47;
            this.lbRateToValue.Text = "0";
            this.lbRateToValue.Visible = false;
            // 
            // lbCountryToValue
            // 
            this.lbCountryToValue.AutoSize = true;
            this.lbCountryToValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryToValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCountryToValue.Location = new System.Drawing.Point(514, 124);
            this.lbCountryToValue.Name = "lbCountryToValue";
            this.lbCountryToValue.Size = new System.Drawing.Size(15, 17);
            this.lbCountryToValue.TabIndex = 46;
            this.lbCountryToValue.Text = "0";
            this.lbCountryToValue.Visible = false;
            // 
            // lbRateToText
            // 
            this.lbRateToText.AutoSize = true;
            this.lbRateToText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateToText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRateToText.Location = new System.Drawing.Point(395, 202);
            this.lbRateToText.Name = "lbRateToText";
            this.lbRateToText.Size = new System.Drawing.Size(109, 17);
            this.lbRateToText.TabIndex = 45;
            this.lbRateToText.Text = "Rate Per Dollar :";
            this.lbRateToText.Visible = false;
            // 
            // lbNameToText
            // 
            this.lbNameToText.AutoSize = true;
            this.lbNameToText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameToText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNameToText.Location = new System.Drawing.Point(395, 175);
            this.lbNameToText.Name = "lbNameToText";
            this.lbNameToText.Size = new System.Drawing.Size(108, 17);
            this.lbNameToText.TabIndex = 44;
            this.lbNameToText.Text = "Name               :";
            this.lbNameToText.Visible = false;
            // 
            // lbCodeToText
            // 
            this.lbCodeToText.AutoSize = true;
            this.lbCodeToText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeToText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCodeToText.Location = new System.Drawing.Point(395, 148);
            this.lbCodeToText.Name = "lbCodeToText";
            this.lbCodeToText.Size = new System.Drawing.Size(107, 17);
            this.lbCodeToText.TabIndex = 43;
            this.lbCodeToText.Text = "Code                :";
            this.lbCodeToText.Visible = false;
            // 
            // lbCountryToText
            // 
            this.lbCountryToText.AutoSize = true;
            this.lbCountryToText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryToText.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCountryToText.Location = new System.Drawing.Point(395, 124);
            this.lbCountryToText.Name = "lbCountryToText";
            this.lbCountryToText.Size = new System.Drawing.Size(106, 17);
            this.lbCountryToText.TabIndex = 42;
            this.lbCountryToText.Text = "Country           :";
            this.lbCountryToText.Visible = false;
            // 
            // NumbericAmount
            // 
            this.NumbericAmount.DecimalPlaces = 1;
            this.NumbericAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumbericAmount.Location = new System.Drawing.Point(238, 275);
            this.NumbericAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumbericAmount.Name = "NumbericAmount";
            this.NumbericAmount.Size = new System.Drawing.Size(120, 27);
            this.NumbericAmount.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label24.Location = new System.Drawing.Point(258, 243);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 20);
            this.label24.TabIndex = 40;
            this.label24.Text = "Amount";
            // 
            // CBXTo
            // 
            this.CBXTo.FormattingEnabled = true;
            this.CBXTo.Location = new System.Drawing.Point(398, 76);
            this.CBXTo.Name = "CBXTo";
            this.CBXTo.Size = new System.Drawing.Size(130, 28);
            this.CBXTo.TabIndex = 39;
            this.CBXTo.SelectedIndexChanged += new System.EventHandler(this.CBXTo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(394, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Convert To";
            // 
            // CBXFrom
            // 
            this.CBXFrom.FormattingEnabled = true;
            this.CBXFrom.Location = new System.Drawing.Point(88, 76);
            this.CBXFrom.Name = "CBXFrom";
            this.CBXFrom.Size = new System.Drawing.Size(130, 28);
            this.CBXFrom.TabIndex = 29;
            this.CBXFrom.SelectedIndexChanged += new System.EventHandler(this.CBXFrom_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(84, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Convert From";
            // 
            // lbCodeFromValue
            // 
            this.lbCodeFromValue.AutoSize = true;
            this.lbCodeFromValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeFromValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCodeFromValue.Location = new System.Drawing.Point(204, 148);
            this.lbCodeFromValue.Name = "lbCodeFromValue";
            this.lbCodeFromValue.Size = new System.Drawing.Size(15, 17);
            this.lbCodeFromValue.TabIndex = 27;
            this.lbCodeFromValue.Text = "0";
            this.lbCodeFromValue.Visible = false;
            // 
            // lbNameFromValue
            // 
            this.lbNameFromValue.AutoSize = true;
            this.lbNameFromValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFromValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNameFromValue.Location = new System.Drawing.Point(204, 178);
            this.lbNameFromValue.Name = "lbNameFromValue";
            this.lbNameFromValue.Size = new System.Drawing.Size(15, 17);
            this.lbNameFromValue.TabIndex = 26;
            this.lbNameFromValue.Text = "0";
            this.lbNameFromValue.Visible = false;
            // 
            // lbRateFromValue
            // 
            this.lbRateFromValue.AutoSize = true;
            this.lbRateFromValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateFromValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRateFromValue.Location = new System.Drawing.Point(204, 202);
            this.lbRateFromValue.Name = "lbRateFromValue";
            this.lbRateFromValue.Size = new System.Drawing.Size(15, 17);
            this.lbRateFromValue.TabIndex = 25;
            this.lbRateFromValue.Text = "0";
            this.lbRateFromValue.Visible = false;
            // 
            // lbCountryFromValue
            // 
            this.lbCountryFromValue.AutoSize = true;
            this.lbCountryFromValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryFromValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCountryFromValue.Location = new System.Drawing.Point(204, 124);
            this.lbCountryFromValue.Name = "lbCountryFromValue";
            this.lbCountryFromValue.Size = new System.Drawing.Size(15, 17);
            this.lbCountryFromValue.TabIndex = 24;
            this.lbCountryFromValue.Text = "0";
            this.lbCountryFromValue.Visible = false;
            // 
            // lbRateTextFrom
            // 
            this.lbRateTextFrom.AutoSize = true;
            this.lbRateTextFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRateTextFrom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRateTextFrom.Location = new System.Drawing.Point(85, 202);
            this.lbRateTextFrom.Name = "lbRateTextFrom";
            this.lbRateTextFrom.Size = new System.Drawing.Size(109, 17);
            this.lbRateTextFrom.TabIndex = 23;
            this.lbRateTextFrom.Text = "Rate Per Dollar :";
            this.lbRateTextFrom.Visible = false;
            // 
            // lbNameTextFrom
            // 
            this.lbNameTextFrom.AutoSize = true;
            this.lbNameTextFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTextFrom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNameTextFrom.Location = new System.Drawing.Point(85, 175);
            this.lbNameTextFrom.Name = "lbNameTextFrom";
            this.lbNameTextFrom.Size = new System.Drawing.Size(108, 17);
            this.lbNameTextFrom.TabIndex = 22;
            this.lbNameTextFrom.Text = "Name               :";
            this.lbNameTextFrom.Visible = false;
            // 
            // lbCodeTextFrom
            // 
            this.lbCodeTextFrom.AutoSize = true;
            this.lbCodeTextFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeTextFrom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCodeTextFrom.Location = new System.Drawing.Point(85, 148);
            this.lbCodeTextFrom.Name = "lbCodeTextFrom";
            this.lbCodeTextFrom.Size = new System.Drawing.Size(107, 17);
            this.lbCodeTextFrom.TabIndex = 21;
            this.lbCodeTextFrom.Text = "Code                :";
            this.lbCodeTextFrom.Visible = false;
            // 
            // lbCountryTextFrom
            // 
            this.lbCountryTextFrom.AutoSize = true;
            this.lbCountryTextFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryTextFrom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCountryTextFrom.Location = new System.Drawing.Point(85, 124);
            this.lbCountryTextFrom.Name = "lbCountryTextFrom";
            this.lbCountryTextFrom.Size = new System.Drawing.Size(106, 17);
            this.lbCountryTextFrom.TabIndex = 20;
            this.lbCountryTextFrom.Text = "Country           :";
            this.lbCountryTextFrom.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CurrencyList.png");
            this.imageList1.Images.SetKeyName(1, "UpdateCurrency.png");
            this.imageList1.Images.SetKeyName(2, "CurrencyExchangee.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(283, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 41);
            this.panel3.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::PresentationLayer_WindowForm.Properties.Resources.UpdateCurrency;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer_WindowForm.Properties.Resources.Bank2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnExchange);
            this.panel2.Location = new System.Drawing.Point(238, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 41);
            this.panel2.TabIndex = 56;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::PresentationLayer_WindowForm.Properties.Resources.CurrencyExchangee;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // FrmCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 486);
            this.Controls.Add(this.Cbx1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCurrencies";
            this.Text = "FrmCurrencies";
            this.Load += new System.EventHandler(this.FrmCurrencies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CurrenciesList.ResumeLayout(false);
            this.CurrenciesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            this.Cbx1.ResumeLayout(false);
            this.UpdateCurrency.ResumeLayout(false);
            this.UpdateCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.CurrencyExchange.ResumeLayout(false);
            this.CurrencyExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericAmount)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage CurrenciesList;
        private System.Windows.Forms.Label lbCurrenciesCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.TabControl Cbx1;
        private System.Windows.Forms.TabPage UpdateCurrency;
        private System.Windows.Forms.TabPage CurrencyExchange;
        private System.Windows.Forms.ComboBox CBXCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbCodeFromValue;
        private System.Windows.Forms.Label lbNameFromValue;
        private System.Windows.Forms.Label lbRateFromValue;
        private System.Windows.Forms.Label lbCountryFromValue;
        private System.Windows.Forms.Label lbRateTextFrom;
        private System.Windows.Forms.Label lbNameTextFrom;
        private System.Windows.Forms.Label lbCodeTextFrom;
        private System.Windows.Forms.Label lbCountryTextFrom;
        private System.Windows.Forms.ComboBox CBXTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBXFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown NumbericAmount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbCodeToValue;
        private System.Windows.Forms.Label lbNameToValue;
        private System.Windows.Forms.Label lbRateToValue;
        private System.Windows.Forms.Label lbCountryToValue;
        private System.Windows.Forms.Label lbRateToText;
        private System.Windows.Forms.Label lbNameToText;
        private System.Windows.Forms.Label lbCodeToText;
        private System.Windows.Forms.Label lbCountryToText;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label lbCoin2Name;
        private System.Windows.Forms.Label lbAmountAfterExchange;
        private System.Windows.Forms.Label lbEquall;
        private System.Windows.Forms.Label lbCoinName;
        private System.Windows.Forms.Label lbAmountBeforeExchange;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}