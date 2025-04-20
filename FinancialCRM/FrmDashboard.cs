using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCRM.Models;

namespace FinancialCRM
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        int count = 0;
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var billList2 = db.TblBill.First();
            lblBillTitle.Text = billList2.BillTitle;
            lblBillAmount.Text = billList2.BillAmount.ToString() + "TL";
            TotalBalance();
            LastProcess();
            chard1Method();
            chard2Method();
        }

        // calculate the total balance by summing up the BankBalance from TblBank
        public void TotalBalance()
        {
            var totalBalance = db.TblBank.Sum(a => a.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "TL";
        }

        // this method is used to change the bill title and amount every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            var billList = db.TblBill.ToList();
            if (billList.Count > 0)
            {
                var bill = billList[count % billList.Count];
                lblBillTitle.Text = bill.BillTitle;
                lblBillAmount.Text = bill.BillAmount.ToString() + "TL";
            }
            else
            {
                lblBillTitle.Text = "--Fatura Yok--";
                lblBillAmount.Text = "0 TL";
            }
        }

        // this method is used to get the last process from the database
        public void LastProcess()
        {
            var lastProcess = db.TblProcess.OrderByDescending(a => a.ProcessDate).FirstOrDefault();
            lblLastProcess.Text = lastProcess.ProcessDescription;
        }

        // this method is used to create a chart1
        public void chard1Method()
        {
            var dataBank = db.TblBank.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bakiyeler");
            foreach (var item in dataBank)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

        }

        // this method is used to create a chart2
        public void chard2Method()
        {
            var dataBill = db.TblBill.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series = chart2.Series.Add("Faturalar");
            foreach (var item in dataBill)
            {
                series.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void BtnBillForm_Click(object sender, EventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            frmBills.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnProcessForm_Click(object sender, EventArgs e)
        {
            FrmProcess frmProcess = new FrmProcess();
            frmProcess.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlar Olabilecek En Ýyi Þekilde Oynamamak Daha Ýyi ", "Yapmadým", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çýkmak Ýstediðinize Emin Misiniz?", "Çýkýþ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ýyi Günler Dilerim");
            }
        }
    }

}