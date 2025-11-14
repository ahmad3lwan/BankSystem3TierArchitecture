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
    public partial class UpdateClientUserControl : UserControl
    {
        public UpdateClientUserControl()
        {
            InitializeComponent();
        }
      

        ClsClient Client;
        private void UpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsClient UpdatedClient=ClsClient.FindByAccountNumber(txtSearch.Text);
            if (UpdatedClient != null)
            {
                Client = UpdatedClient;
                txtFirstName.Text = UpdatedClient.FirstName;
                txtLastName.Text = UpdatedClient.LastName;
                txtEmail.Text = UpdatedClient.Email;
                mtxtPhone.Text = UpdatedClient.Phone;
                mtxtPinCode.Text = UpdatedClient.PinCode.ToString();
                txtAccountNumber.Text = UpdatedClient.AccountNumber;
                mtxtAccountBalance.Text = UpdatedClient.AccountBalance.ToString();
            }
            else
            {
                MessageBox.Show($"Client With Account Number {txtSearch.Text} is not found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || (string.IsNullOrEmpty(txtLastName.Text)
              || (string.IsNullOrEmpty(txtEmail.Text)) || (string.IsNullOrEmpty(mtxtPhone.Text)) ||
              (string.IsNullOrEmpty(mtxtPinCode.Text)) || (string.IsNullOrEmpty(mtxtAccountBalance.Text)) || (string.IsNullOrEmpty(txtAccountNumber.Text))))
            {
                MessageBox.Show("You Must Fill All Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client.FirstName = txtFirstName.Text;
            Client.LastName = txtLastName.Text;
            Client.Email = txtEmail.Text;
            Client.Phone = mtxtPhone.Text;

            int.TryParse(mtxtPinCode.Text, out int PinCodeR);

            Client.PinCode = PinCodeR;

            Client.AccountNumber = txtAccountNumber.Text;

            float.TryParse(mtxtAccountBalance.Text, out float Balance);


            Client.AccountBalance = Balance;

          

            if (Client.Save())
            {
                MessageBox.Show("Client Updated Successfully", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Error! SomeThing Wrong", "Add Client" , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
