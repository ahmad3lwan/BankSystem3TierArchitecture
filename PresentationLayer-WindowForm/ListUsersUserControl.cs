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
    public partial class ListUsersUserControl : UserControl
    {
        public ListUsersUserControl()
        {
            InitializeComponent();
            
        }

        private void _RefreshUserDataGridView()
        {
            dgvListUsers.DataSource = ClsUser.GetAllUsers();
           
           dgvListUsers.Columns["ID"].Width = 40;
           dgvListUsers.Columns["FirstName"].Width = 80;
           dgvListUsers.Columns["LastName"].Width = 80;
           dgvListUsers.Columns["Email"].Width = 125;
           dgvListUsers.Columns["Phone"].Width = 95;
           dgvListUsers.Columns["UserName"].Width = 80;
           dgvListUsers.Columns["Password"].Width = 85;
            dgvListUsers.Columns["Permission"].Width = 85;
            lbUserCount.Text = dgvListUsers.RowCount.ToString();


        }
        private void ListUsersUserControl_Load(object sender, EventArgs e)
        {
            _RefreshUserDataGridView();   
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Delete This User?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                ClsUser.Delete(dgvListUsers.CurrentRow.Cells[5].Value.ToString(), dgvListUsers.CurrentRow.Cells[6].Value.ToString());

                MessageBox.Show("User Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                _RefreshUserDataGridView();
            }
        }
    }
}
