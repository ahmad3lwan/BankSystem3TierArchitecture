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
    public partial class UpdateUserUserContrl : UserControl
    {
        public UpdateUserUserContrl()
        {
            InitializeComponent();
        }
        ClsUser UpdatedUser = new ClsUser();
        enum enPermission
        {
            pAll = -1, pManageClient = 1, pTransaction = 2, pManageUsers = 4, pCurrencyExchange = 8, pLoginRegister = 16
        }

        int UserPermission = 0;


        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdatedUser = ClsUser.Find(txtSearchUserName.Text, txtSearchPassowrd.Text);
            if (UpdatedUser != null)
            {
                txtFirstName.Text = UpdatedUser.FirstName;

                txtLastName.Text = UpdatedUser.LastName;

                txtEmail.Text = UpdatedUser.Email;

                mtxtPhone.Text = UpdatedUser.Phone;

                txtUserName.Text = UpdatedUser.UserName;

                txtPassword.Text = UpdatedUser.Password;
            }
            else
            {
                MessageBox.Show($"User With User Name [{txtSearchUserName}] and Password [{txtSearchPassowrd}] is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || (string.IsNullOrEmpty(txtLastName.Text))
              || (string.IsNullOrEmpty(txtEmail.Text)) || (string.IsNullOrEmpty(mtxtPhone.Text)) ||
              (string.IsNullOrEmpty(txtUserName.Text)) || (string.IsNullOrEmpty(txtPassword.Text)) || ((rbNo.Checked == false) && (rbYes.Checked == false)))
            {


                MessageBox.Show("You Must Fill All Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if ((rbNo.Checked) && (((chkCurrencyExchange.Checked == false) && (chkLoginRegister.Checked == false) && (chkManageClient.Checked == false) && (chkManageUsers.Checked == false) && (chkTransaction.Checked == false))))
            {
                MessageBox.Show("You Must at Least One Permission!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            UpdatedUser.FirstName = txtFirstName.Text;

            UpdatedUser.LastName = txtLastName.Text;

            UpdatedUser.Email = txtEmail.Text;

            UpdatedUser.Phone = mtxtPhone.Text;

            UpdatedUser.UserName = txtUserName.Text;

            UpdatedUser.Password = txtPassword.Text;

            UpdatedUser.Permission = UserPermission;
            if (UpdatedUser.Save())
            {
                MessageBox.Show("User Updated Successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("SomeThing Wrong Happen!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtPhone.Text))
            {
                errorProvider1.SetError(mtxtPhone, "Phone is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtxtPhone, "");
            }
            if (string.IsNullOrWhiteSpace(mtxtPhone.Text))
            {
                errorProvider1.SetError(mtxtPhone, "Phone Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtxtPhone, "");
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Password is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                UserPermission = (int)enPermission.pAll;

                chkCurrencyExchange.Visible = false;

                chkLoginRegister.Visible = false;

                chkManageClient.Visible = false;

                chkManageUsers.Visible = false;

                chkTransaction.Visible = false;
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                UserPermission = 0;
                chkCurrencyExchange.Visible = true;

                chkLoginRegister.Visible = true;

                chkManageClient.Visible = true;

                chkManageUsers.Visible = true;

                chkTransaction.Visible = true;



            }
        }

        private void chkManageClient_CheckedChanged(object sender, EventArgs e)
        {

            if (chkManageClient.Checked)
            {
                UserPermission += (int)(enPermission.pManageClient);
            }
            else
            {
                UserPermission -= (int)(enPermission.pManageClient);

            }

        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTransaction.Checked)
            {
                UserPermission += (int)(enPermission.pTransaction);
            }
            else
            {
                UserPermission -= (int)(enPermission.pTransaction);

            }

        }

        private void chkLoginRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoginRegister.Checked)
            {
                UserPermission += (int)(enPermission.pLoginRegister);
            }
            else
            {
                UserPermission -= (int)(enPermission.pLoginRegister);

            }
        }

        private void chkManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManageUsers.Checked)
            {
                UserPermission += (int)(enPermission.pManageUsers);
            }
            else
            {
                UserPermission -= (int)(enPermission.pManageUsers);

            }
        }
       
        private void chkCurrencyExchange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurrencyExchange.Checked)
            {
                UserPermission += (int)(enPermission.pCurrencyExchange);
            }
            else
            {
                UserPermission -= (int)(enPermission.pCurrencyExchange);

            }
        }


       
    }
}
