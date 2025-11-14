using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerBankSystem;

namespace PresentationLayer_WindowForm
{
    public partial class LoginRegisterForm : Form
    {
        ClsUser CurrentUser = new ClsUser();
        public LoginRegisterForm(string UserName,string Password)
        {
            InitializeComponent();
            CurrentUser=ClsUser.Find(UserName,Password);
           
        }
        private void _RefreshLoginDataGridView()
        {
            lbUserName.Text = CurrentUser.UserName;
            dgvLoginRegister.DataSource = clsLoginRecord.GetAllLoginRecord();
            dgvLoginRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbRecordCount.Text=dgvLoginRegister.Rows.Count.ToString();
        }
        private void LoginRegisterForm_Load(object sender, EventArgs e)
        {
            _RefreshLoginDataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsLoginRecord.DeleteLoginRecord((int)dgvLoginRegister.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Record Deleted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _RefreshLoginDataGridView();
                }
            }
        }
    }
}
