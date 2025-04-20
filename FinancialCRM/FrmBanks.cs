using FinancialCRM.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace FinancialCRM
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void button6_Click(object sender, EventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            frmBills.Show();
            this.Hide();
        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // Load the bank balances from the database and display them in the labels
            var ziraatBalance = db.TblBank.Where(b => b.BankTitle == "Ziraat Bankasý").Select(b => b.BankBalance).FirstOrDefault();
            var iþBalance = db.TblBank.Where(b => b.BankTitle == "Ýþ Bankasý").Select(b => b.BankBalance).FirstOrDefault();
            var yapiBalance = db.TblBank.Where(b => b.BankTitle == "Yapý Kredi").Select(b => b.BankBalance).FirstOrDefault();
            var DenizBalance = db.TblBank.Where(b => b.BankTitle == "DenizBank").Select(b => b.BankBalance).FirstOrDefault();

            // Display the balances in the labels
            lblZiraatBalance.Text = ziraatBalance.ToString() + " \u20ba";
            lblIþBalance.Text = iþBalance.ToString() + " \u20ba";
            lblYapiBalance.Text = yapiBalance.ToString() + " \u20ba";
            lblDenizBalance.Text = DenizBalance.ToString() + " \u20ba";

            // Load the last 5 bank processes from the database and display them in the labels
            var last5BankProcesses = db.TblProcess
                .OrderByDescending(p => p.ProcessDate)
                .Take(5)
                .ToList();

            // Display the last 5 bank processes in the labels
            lblBankProcess1.Text = last5BankProcesses[0].ProcessDescription +
                                   " -- " + last5BankProcesses[0].ProcessAmount.ToString() +
                                   " -- " + last5BankProcesses[0].ProcessType +
                                   " -- " + last5BankProcesses[0].ProcessDate.ToString();
            lblBankProcess2.Text = last5BankProcesses[1].ProcessDescription +
                                   " -- " + last5BankProcesses[1].ProcessAmount.ToString() +
                                   " -- " + last5BankProcesses[1].ProcessType +
                                   " -- " + last5BankProcesses[1].ProcessDate.ToString(); ;
            lblBankProcess3.Text = last5BankProcesses[2].ProcessDescription + 
                                   " -- " + last5BankProcesses[2].ProcessAmount.ToString() +
                                   " -- " + last5BankProcesses[2].ProcessType +
                                   " -- " + last5BankProcesses[2].ProcessDate.ToString();
            lblBankProcess4.Text = last5BankProcesses[3].ProcessDescription + 
                                   " -- " + last5BankProcesses[3].ProcessAmount.ToString() +
                                   " -- " + last5BankProcesses[3].ProcessType +
                                   " -- " + last5BankProcesses[3].ProcessDate.ToString();
            lblBankProcess5.Text = last5BankProcesses[4].ProcessDescription + 
                                   " -- " + last5BankProcesses[4].ProcessAmount.ToString() +
                                   " -- " + last5BankProcesses[4].ProcessType +
                                   " -- " + last5BankProcesses[4].ProcessDate.ToString();
            changeColor();
            // Change the color of the labels based on the process type
            void changeColor()
            {
                lblBankProcess1.ForeColor = last5BankProcesses[0].ProcessType == "Gelen" ? Color.Green : Color.Red;
                lblBankProcess2.ForeColor = last5BankProcesses[1].ProcessType == "Gelen" ? Color.Green : Color.Red;
                lblBankProcess3.ForeColor = last5BankProcesses[2].ProcessType == "Gelen" ? Color.Green : Color.Red;
                lblBankProcess4.ForeColor = last5BankProcesses[3].ProcessType == "Gelen" ? Color.Green : Color.Red;
                lblBankProcess5.ForeColor = last5BankProcesses[4].ProcessType == "Gelen" ? Color.Green : Color.Red;
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
