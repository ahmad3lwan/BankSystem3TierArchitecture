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
    public partial class FrmUsers : Form
    {
        ClsUser _CurrentUser = new ClsUser();
        public FrmUsers(string UserName,string Password)
        {
            InitializeComponent();
            _CurrentUser = ClsUser.Find(UserName, Password);
            lbUserName.Text=UserName;
            _ResizePanales();
        }
        public void _LoadUserControl(UserControl userControl)
        {
            PanelUserScreen.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            PanelUserScreen.Controls.Add(userControl);

        }
       
      
        private void btnUsersList_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ListUsersUserControl());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new AddNewUserUserControl());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new UpdateUserUserContrl());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new FindUserUserControl());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void _ResizePanales()
        {
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 5);

            foreach (Panel pnl in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.Margin = new Padding(10, 5, 10, 5);
            }
        }
      
    }
}
