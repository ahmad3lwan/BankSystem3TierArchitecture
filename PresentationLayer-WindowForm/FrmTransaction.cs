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
    public partial class FrmTransaction : Form
    {
        ClsUser CurrentUser=new ClsUser();
        public FrmTransaction(string UserName,string Password)
        {
            InitializeComponent();
            CurrentUser = ClsUser.Find(UserName, Password);
            lbUserName.Text = CurrentUser.UserName;
            cbxAccountNumber.Items.Clear();
            
            Combox2.Items.Clear();

            CbxFrom.Items.Clear();
            cbxTo.Items.Clear();
            _FillComboBoxWithAccountNumbers(cbxAccountNumber);
        
            _FillComboBoxWithAccountNumbers(Combox2);
            _FillComboBoxWithAccountNumbers(CbxFrom);
            _FillComboBoxWithAccountNumbers(cbxTo);

            _FillDataGridViewWithTotalBalances();
            _FillDataGridViewWithTransactions();
            _FillDataGridViewWithTransfers();
        }
        private void _FillDataGridViewWithTotalBalances()
        {

            dgvBalances.DataSource = ClsClient.GetTotalBalances();
            dgvBalances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            lbBalancesCount.Text=dgvBalances.Rows.Count.ToString    ();

        }
        private void _FillDataGridViewWithTransactions()
        {
            
            dgvTransactions.DataSource=clsTransactionRecord.GetAllTransactionRecord();
            dgvTransactions.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            lbTransactionCount.Text = dgvTransactions.Rows.Count.ToString();
        }

        ClsClient _clientFrom=new ClsClient();

        ClsClient _clientTo = new ClsClient();
       
        float _Amount;
        
        private void _FillComboBoxWithAccountNumbers(ComboBox comboBox)
        {
            DataTable dataTable=ClsClient.GetAllClients();

            foreach (DataRow row in dataTable.Rows)
            {
                comboBox.Items.Add(row["AccountNumber"].ToString());
            }
        }

        private void _FillDataGridViewWithTransfers()
        {

            dgvTransfers.DataSource = ClsUser.GetAllTransfers();
            dgvTransfers.Columns["UserID"].Width = 60;
            dgvTransfers.Columns["UserName"].Width = 80;
            dgvTransfers.Columns["SourceAccNo"].Width = 95;
            dgvTransfers.Columns["DestinationAccNo"].Width = 115;
            dgvTransfers.Columns["SourceBalance"].Width = 95;
            dgvTransfers.Columns["DestinationBalance"].Width = 125;
            dgvTransfers.Columns["Amount"].Width = 80;
            dgvTransfers.Columns["DateTime"].Width = 140;



            lbTransfersCount.Text=dgvTransfers.Rows.Count.ToString ();


        }
        private void cbxAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientFrom=ClsClient.FindByAccountNumber(cbxAccountNumber.SelectedItem.ToString());
            
           
            lbCurrentBalance.Visible = true;
            
            
           lbCurrentAmount.Visible = true;

            
            lbCurrentAmount.Text=_clientFrom.AccountBalance.ToString()+" $ ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float.TryParse(mtxtAmount.Text, out _Amount);
            
            if(_clientFrom.Deposit(_Amount))
            {
                if (MessageBox.Show("Are You Sure Do You Want To Confirm This Operation", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Amount Added Successfully!", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    lbNewBalance.Visible = true;

                    lbNew.Visible = true;

                    lbNew.Text = _clientFrom.AccountBalance.ToString() + " $ ";
                    _FillDataGridViewWithTotalBalances();
                    _FillDataGridViewWithTransactions();
                    _ClearScreen();
                }
               
            }
            
            else
            {
                MessageBox.Show("Something Wrong","Deposit",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
        private void _ClearScreen()
        {
            mtxtAmount.Clear();
            lbCurrentAmount.Visible = false;
            lbCurrentBalance.Visible = false;
            lbNew.Visible = false;
            lbNewBalance.Visible = false;
        }

        private void _ClearWithDrawScreen()
        {
            lbCurrent1.Visible = false;
            lbCurrent2.Visible = false;
            lbNew1.Visible  =false;
            lbNew2.Visible = false;
            mtxtWithdraw.Clear();
        }
        private void Combox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientFrom = ClsClient.FindByAccountNumber(Combox2.SelectedItem.ToString());


            lbCurrent1.Visible = true;


            lbCurrent2.Visible = true;


            lbCurrent2.Text = _clientFrom.AccountBalance.ToString() + " $ ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float.TryParse(mtxtWithdraw.Text, out _Amount);

            if (_clientFrom.WithDraw(_Amount))
            {
                if (MessageBox.Show("Are You Sure Do You Want To Confirm This Operation", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Amount Withdraw Successfully!", "WithDraw", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    lbNew1.Visible = true;

                    lbNew2.Visible = true;

                    lbNew2.Text = _clientFrom.AccountBalance.ToString() + " $ ";
                    _FillDataGridViewWithTotalBalances();
                    _FillDataGridViewWithTransactions();
                    _ClearWithDrawScreen();
                }

            }

            else
            {
                MessageBox.Show("Something Wrong", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _FillDataGridViewWithTransactions();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Delete?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsTransactionRecord.DeleteTransActionRecord((int)dgvTransactions.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Record Deleted Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _FillDataGridViewWithTransactions();

                }
            }
           
        }

        private void CbxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientFrom = ClsClient.FindByAccountNumber(CbxFrom.SelectedItem.ToString());
            lbFrom.Visible = true;
            lbMoneyFrom.Visible = true;
            lbMoneyFrom.Text=_clientFrom.AccountBalance.ToString()+" $";

        }

        private void cbxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientTo = ClsClient.FindByAccountNumber(cbxTo.SelectedItem.ToString());
            lbTo.Visible = true;
            lbMoneyTo.Visible = true;
            lbMoneyTo.Text = _clientTo.AccountBalance.ToString() + " $";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
           
            float.TryParse(txtAmount.Text, out _Amount);

            if (MessageBox.Show($"Are You Sure Do You Want To Transfer {_Amount}  From {_clientFrom.AccountNumber} To {_clientTo.AccountNumber} ","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                
               if(_clientFrom.Transfer(CurrentUser.ID,CurrentUser.UserName,_Amount,_clientTo))
               {
                    MessageBox.Show("Amount Transfer Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _ClearTransferScreen();
               } 
               else
                {
                    MessageBox.Show("SomeThing Wrong Happen Please Check Amount And Try Again!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                _FillDataGridViewWithTotalBalances();
                _FillDataGridViewWithTransactions();
                _FillDataGridViewWithTransfers();

            }
        }
        private void _ClearTransferScreen()
        {
            lbFrom.Visible = false;
            lbTo.Visible = false;
            lbMoneyTo.Visible = false;
            lbMoneyFrom.Visible = false;
            txtAmount.Clear();
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Delete?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsTransfersRecord.DeleteTransferRecord((DateTime)dgvTransfers.CurrentRow.Cells[7].Value))
                {
                    MessageBox.Show("Record Deleted Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _FillDataGridViewWithTransfers();

                }
            }
        }
    }
}
