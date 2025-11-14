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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

       private void DisplayLables()
        {
            lbInvalid1.Visible = true;
            lbInvalid2.Visible = true;
            lbInvalide3.Visible = true;
            lbAttempcount.Visible = true;
        }
        private void _Hidelabels()
        {

            lbInvalid1.Visible = false;
            lbInvalid2.Visible = false;
            lbInvalide3.Visible =false;
            lbAttempcount.Visible = false;
        }
        int NumberOfTry = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            NumberOfTry++;
            if (NumberOfTry >= 3)
            {

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                _Hidelabels();
                MessageBox.Show("Your Account is Locked!", "Locked Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                ClsUser CurrentUser = ClsUser.Find(txtUserName.Text, txtPassword.Text);
                if (CurrentUser != null&&NumberOfTry<=3)
                {
                _Hidelabels();
                    DateTime CurrentTime = DateTime.Now;
                    clsLoginRecord.LoginRegister(CurrentUser.ID, CurrentUser.UserName, CurrentUser.Password, CurrentUser.Permission, CurrentTime);
                    FrmMainScreen frm = new FrmMainScreen(txtUserName.Text, txtPassword.Text);
                    frm.ShowDialog();
                    NumberOfTry = 0;
                }
                else
                {

                    MessageBox.Show("Invalid UserName or Password! try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisplayLables();
                    lbAttempcount.Text = (3 - NumberOfTry).ToString();
                 
                   
                    
                }
          
                
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                pboxHideAndShow.Image = Properties.Resources.ClosedEye;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pboxHideAndShow.Image = Properties.Resources.eye;

            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
