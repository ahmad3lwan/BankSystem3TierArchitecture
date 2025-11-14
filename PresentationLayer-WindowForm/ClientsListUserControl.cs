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
    public partial class ClientsListUserControl : UserControl
    {
        public ClientsListUserControl()
        {
            InitializeComponent();

        }
      
        private void _RefreshDataGridView()
        {
            dataGridView1.DataSource = ClsClient.GetAllClients();

            dataGridView1.Columns["ID"].Width = 40;
            dataGridView1.Columns["FirstName"].Width = 80;
            dataGridView1.Columns["LastName"].Width = 80;
            dataGridView1.Columns["Email"].Width =125 ;
            dataGridView1.Columns["Phone"].Width = 95;
            dataGridView1.Columns["AccountNumber"].Width = 110;
            dataGridView1.Columns["PinCode"].Width = 60;
            dataGridView1.Columns["AccountBalance"].Width = 120;


            lbClientCount.Text = dataGridView1.Rows.Count.ToString();

        }
        private void ClientsListUserControl_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();
           
        }
       

        

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure Do You Want To Delete this Client","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
              {
               if( ClsClient.DeleteClient((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Successfully");
                }
            }
            _RefreshDataGridView() ;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
