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
    public partial class FrmSpending : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmSpending()
        {
            InitializeComponent();
        }

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            billTotal();
            spendingTotal();
            allTotal();
            chart3Show();
            chart1Show();
            chart2Show();
        }

        private void billTotal()
        {
            // Get the total amount of all bills
            var total = db.TblBill.Sum(b => b.BillAmount);
            lblTotalBill.Text = total.ToString() + " \u20ba";
        }

        private void spendingTotal()
        {
            var total = db.TblProcess.Where(p => p.ProcessType == "Giden")
                .Sum(p => p.ProcessAmount);
            lblTotalProcess.Text = total.ToString() + " \u20ba";
        }

        private void allTotal()
        {
            var total1 = db.TblBill.Sum(b => b.BillAmount);
            var total2 = db.TblProcess.Where(p => p.ProcessType == "Giden")
                .Sum(p => p.ProcessAmount);
            var total = total1 + total2;
            lblAllTotal.Text = total.ToString() + " \u20ba";
        }

        //Crate a chart to show the total amount of bills and processes
        private void chart3Show()
        {
            chart3.Series.Clear();
            chart3.Series.Add("Ýþlemler");
            chart3.Series.Add("Faturalar");
            chart3.Series["Ýþlemler"].Color = Color.Red;
            chart3.Series["Faturalar"].Color = Color.Green;
            var processTotal = db.TblProcess.Where(p => p.ProcessType == "Giden").ToList();
            var billTotal = db.TblBill.ToList();
            foreach (var item in processTotal)
            {
                chart3.Series["Ýþlemler"].Points.AddXY(item.ProcessDate, item.ProcessAmount);
            }

            foreach (var item in billTotal)
            {
                chart3.Series["Faturalar"].Points.AddXY(item.BillPeriod, item.BillAmount);
            }

            chart3.ChartAreas[0].AxisX.Title = "Ýþlemler";
            chart3.ChartAreas[0].AxisY.Title = "Miktar";
        }

        // Crate a chat to show only the bills
        private void chart1Show()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Faturalar");
            chart1.Series["Faturalar"].Color = Color.Green;
            var billTotal = db.TblBill.ToList();
            foreach (var item in billTotal)
            {
                chart1.Series["Faturalar"].Points.AddXY(item.BillPeriod, item.BillAmount);
            }

            chart1.ChartAreas[0].AxisX.Title = "Faturalar";
            chart1.ChartAreas[0].AxisY.Title = "Miktar";
        }

        // Crate a chat to show only the processes
        private void chart2Show()
        {
            chart2.Series.Clear();
            chart2.Series.Add("Ýþlemler");
            chart2.Series["Ýþlemler"].Color = Color.Red;
            var processTotal = db.TblProcess.Where(p => p.ProcessType == "Giden").ToList();
            foreach (var item in processTotal)
            {
                chart2.Series["Ýþlemler"].Points.AddXY(item.ProcessDate, item.ProcessAmount);
            }

            chart2.ChartAreas[0].AxisX.Title = "Ýþlemler";
            chart2.ChartAreas[0].AxisY.Title = "Miktar";

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
