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
    public partial class FrmMainScreen : Form
    {
        ClsUser _CurrentUser=new ClsUser();
        public FrmMainScreen(string UserName,string Password)
        {
            InitializeComponent();
            _CurrentUser = ClsUser.Find(UserName, Password);
            lbUserName.Text = _CurrentUser.UserName;
            _HideAndDisplayButtonByUserPermission();
            _ResizeAndOrderPanales();
        }
      private void _ResizeAndOrderPanales()
        {
            flowLayoutPanel1.Padding = new Padding(10,5,10,5);

            foreach (Panel pnl in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.Margin= new Padding(10,5,10,5);
            }
        }
        private void _HideAndDisplayButtonByUserPermission()
        {
            if (_CurrentUser.CheckUserPermission(ClsUser.enPermissions.pManageClient))
            {
                PnlManageClients.Visible = true;
            }
            if (_CurrentUser.CheckUserPermission(ClsUser.enPermissions.pTransaction))
            {
                PnlTransactions.Visible = true;

            }
            if (_CurrentUser.CheckUserPermission(ClsUser.enPermissions.pManageUsers))
            {
                PnlManageUsers.Visible = true;
            }
            if (_CurrentUser.CheckUserPermission(ClsUser.enPermissions.pCurrencyExchange))
            {
                PnlCurrencies.Visible = true;
            }
            if (_CurrentUser.CheckUserPermission(ClsUser.enPermissions.pLoginRegister))
            {
                PnlLoginRegister.Visible = true;
            }
        }
        private void btnManageClient_Click(object sender, EventArgs e)
        {
            
           FrmClients frm = new FrmClients(_CurrentUser.UserName, _CurrentUser.Password);
            frm.ShowDialog();
        }
        
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            
                FrmTransaction frm = new FrmTransaction(_CurrentUser.UserName, _CurrentUser.Password);
                frm.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
             FrmUsers frm = new FrmUsers(_CurrentUser.UserName, _CurrentUser.Password);
                frm.ShowDialog();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");

        }

        private void button1_Click(object sender, EventArgs e)
        {
                LoginRegisterForm frm = new LoginRegisterForm(_CurrentUser.UserName, _CurrentUser.Password);
                frm.ShowDialog();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

                FrmCurrencies frm = new FrmCurrencies(_CurrentUser.UserName, _CurrentUser.Password);
                frm.ShowDialog();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
