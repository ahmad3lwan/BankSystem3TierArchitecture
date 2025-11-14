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
    

    public  partial class FrmClients : Form
    {
       public ClsClient _Client;
         enum enMode { enAddNew=0,enUpdate=1}
        enMode _CurrentMode;

        ClsUser _CurrentUser = new ClsUser();
        public FrmClients(string UserName,string Password)
        {

            InitializeComponent();
            _CurrentUser = ClsUser.Find(UserName, Password);
            lbUserName.Text = UserName;
            _ResizePanales();
        }
       
        public  void _LoadUserControl(UserControl userControl)
        {
            PanelContainer.Controls.Clear();
         
            userControl.Dock= DockStyle.Fill;

            PanelContainer.Controls.Add(userControl);
            
        }
        private void FrmClients_Load(object sender, EventArgs e)
        {

        }       

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new UpdateClientUserControl());
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ClientsListUserControl());
            
           

        }

        private void btnAddNewClient_Click_1(object sender, EventArgs e)
        {
            _LoadUserControl(new AddNewClientUserControl());

        }
        private void _ResizePanales()
        {
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 5);

            foreach (Panel pnl in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.Margin = new Padding(10, 5, 10, 5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");

        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new FindClientUserControl());


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
