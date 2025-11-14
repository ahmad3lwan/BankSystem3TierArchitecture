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
    public partial class FindClientUserControl : UserControl
    {
        public FindClientUserControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClsClient UpdatedClient = ClsClient.FindByAccountNumber(txtSearch.Text);
            if (UpdatedClient != null)
            {
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
    }
}
