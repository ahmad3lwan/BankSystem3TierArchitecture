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
    public partial class FindUserUserControl : UserControl
    {
        public FindUserUserControl()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClsUser CurrentUser = ClsUser.Find(txtSearchUserName.Text, txtSearchPassowrd.Text);

            if (CurrentUser != null)
            {
                txtFirstName.Text = CurrentUser.FirstName;
                txtLastName.Text = CurrentUser.LastName;
                txtEmail.Text = CurrentUser.Email;
                txtPassword.Text = CurrentUser.Password;
                mtxtPhone.Text = CurrentUser.Phone;
                txtUserName.Text = CurrentUser.UserName;
                mtxtPermission.Text = CurrentUser.Permission.ToString();
            }
            else
            {
                MessageBox.Show($"User With User Name [{txtSearchUserName.Text}] and Password [{txtSearchPassowrd.Text}] Did Not Found!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
