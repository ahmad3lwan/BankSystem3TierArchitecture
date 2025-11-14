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
    public partial class FrmCurrencies : Form
    {
        clsCurrencies currency=new clsCurrencies();
        clsCurrencies CurrencyTo = new clsCurrencies();
        ClsUser _CurrentUser = new ClsUser();

        decimal _CurrenciesAmount = 0;

        decimal _AmountInDollar = 0;
        public FrmCurrencies(string UserName,string Password)
        {
            InitializeComponent();
            _CurrentUser = ClsUser.Find(UserName, Password);
            lbUserName.Text = _CurrentUser.UserName;
        }

        private void _FillCurrenciesDataGridView()
        {
            dgvCurrencies.DataSource=clsCurrencies.GetAllCurrencies();
            dgvCurrencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbCurrenciesCount.Text=dgvCurrencies.RowCount.ToString();
        }

      
        private void _FillComboBoxCode(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            DataTable dataTable = clsCurrencies.GetAllCurrencies();
            foreach(DataRow row in dataTable.Rows )
            {
                comboBox.Items.Add(row["Code"].ToString());
            }
        }
        private void FrmCurrencies_Load(object sender, EventArgs e)
        {
            _FillCurrenciesDataGridView();
            _FillComboBoxCode(CBXCode);
            _FillComboBoxCode(CBXFrom);
            _FillComboBoxCode(CBXTo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss t- yyyy/MM/dd");

        }

        private void CBXCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
            lb4.Visible=true;

            lbCode.Visible = true;
            lbCountry.Visible = true;
            lbName.Visible = true;
            lbRate.Visible = true;

             currency=clsCurrencies.Find(CBXCode.SelectedItem.ToString());
            if (currency != null)
            {
                lbCode.Text=currency.Code;
                lbCountry.Text=currency.Country;
                lbName.Text=currency.Name;
                lbRate.Text = currency.Rate.ToString();
            }
        }

        private void UpdateCurrency_Click(object sender, EventArgs e)
        {

        }
        private void _ClearUpdateScreenAndRefresh()
        {
            _FillCurrenciesDataGridView();
            _HideLabels(lb1, lb2, lb3, lb4);
            _HideLabels(lbCode, lbCountry, lbName, lbRate); 
            CBXCode.Text = "";
            numericUpDown1.Value=0;
        }

        private void _DisplayLabels(Label l1,Label l2,Label l3,Label l4)
        {
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
        }
        private void _HideLabels(Label l1,Label l2,Label l3,Label l4)
        {
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
        }                
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsCurrencies.UpdateRate(currency.Code, numericUpDown1.Value))
            {
                MessageBox.Show("Rate Updated Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                _ClearUpdateScreenAndRefresh();

            }
            else
            {
                MessageBox.Show("SomeThing Wrong Happen!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void CurrencyExchange_Click(object sender, EventArgs e)
        {

        }

        private void CBXFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = clsCurrencies.Find(CBXFrom.SelectedItem.ToString());
            if(currency != null)
            {
                _DisplayLabels(lbCountryTextFrom, lbCodeTextFrom, lbNameTextFrom, lbRateTextFrom);
                _DisplayLabels(lbCodeFromValue, lbRateFromValue, lbNameFromValue, lbCountryFromValue);
                lbCodeFromValue.Text =currency.Code.ToString();
                lbNameFromValue.Text =currency.Name.ToString();
                lbRateFromValue.Text = currency.Rate.ToString();
                lbCountryFromValue.Text=currency.Country.ToString();



            }
            else
            {
                MessageBox.Show("Error SomeThing Happen!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBXTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrencyTo = clsCurrencies.Find(CBXTo.SelectedItem.ToString());
            if (CurrencyTo != null)
            {
                _DisplayLabels(lbCountryToText, lbCodeToText, lbNameToText, lbRateToText);
                _DisplayLabels(lbCodeToValue, lbRateToValue, lbNameToValue, lbCountryToValue);
              
               lbCodeToValue.Text=CurrencyTo.Code.ToString();
               lbCountryToValue.Text=CurrencyTo.Country.ToString();
                lbNameToValue.Text=CurrencyTo.Name.ToString();
                lbRateToValue.Text=CurrencyTo.Rate.ToString();


            }
            else
            {
                MessageBox.Show("Error SomeThing Happen!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (NumbericAmount.Value > 0)
            {
                _AmountInDollar = (NumbericAmount.Value / currency.Rate);

                _CurrenciesAmount = _AmountInDollar * (CurrencyTo.Rate);


                _DisplayLabels(lbCoinName, lbCoin2Name, lbAmountAfterExchange, lbAmountBeforeExchange);
                lbEquall.Visible = true;
                lbCoinName.Text = currency.Name.ToString();
                lbCoin2Name.Text = CurrencyTo.Name.ToString();
                lbAmountBeforeExchange.Text = NumbericAmount.Value.ToString();
                lbAmountAfterExchange.Text = _CurrenciesAmount.ToString("F4");
            }
            else
            {
                MessageBox.Show("Error SomeThing Happen!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
