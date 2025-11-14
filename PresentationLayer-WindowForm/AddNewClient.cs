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
    public partial class AddNewClientUserControl : UserControl
    {
        public AddNewClientUserControl()
        {
            InitializeComponent();
        }

        ClsClient NewClient=new ClsClient();
        private void textBox1_Validating(object sender, CancelEventArgs e)
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

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                errorProvider1.SetError(txtAccountNumber, "Account Number is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, "");
            }
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                errorProvider1.SetError(txtAccountNumber, "Account Number is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, "");
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
                errorProvider1.SetError(txtAccountNumber, "");
            }
        }

        private void _ResetTextBoxes()
        {
            txtAccountNumber.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            mtxtPhone.Clear();
            mtxtPinCode.Clear();
            mtxtAccountBalance.Clear();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text)||(string.IsNullOrEmpty(txtLastName.Text)
                ||(string.IsNullOrEmpty(txtEmail.Text))||(string.IsNullOrEmpty(mtxtPhone.Text))||
                (string.IsNullOrEmpty(mtxtPinCode.Text))||(string.IsNullOrEmpty(mtxtAccountBalance.Text))||(string.IsNullOrEmpty(txtAccountNumber.Text))))
                {
                MessageBox.Show("You Must Fill All Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewClient.FirstName=txtFirstName.Text;
            NewClient.LastName=txtLastName.Text;
            NewClient.Email=txtEmail.Text;
            NewClient.Phone=mtxtPhone.Text;
            
            int.TryParse(mtxtPinCode.Text, out int PinCodeR);
            
            NewClient.PinCode = PinCodeR;
            
            NewClient.AccountNumber = txtAccountNumber.Text;

            float.TryParse(mtxtAccountBalance.Text, out float Balance);


            NewClient.AccountBalance = Balance;

            if(NewClient==null)
            {
                return;
            }

            if (NewClient.Save())
            {
                MessageBox.Show("Client Added Successfully", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetTextBoxes();
            }
            else
            {
                MessageBox.Show("Add Client", "Error! SomeThing Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void AddNewClientUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
