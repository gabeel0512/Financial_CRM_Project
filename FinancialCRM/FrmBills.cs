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
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBills_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            // Load the bills from the database and display them in the DataGridView
            ShowDataGw();
        }

        // When a row header is double-clicked, load the selected bill's details into the text boxes
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtBillId.Text = row.Cells[0].Value.ToString();
                txtBillTitle.Text = row.Cells[1].Value.ToString();
                txtBillAmount.Text = row.Cells[2].Value.ToString();
                dateBillDate.Value = Convert.ToDateTime(row.Cells[3].Value);
            }
        }

        // Load the bills from the database and display them in the DataGridView
        private void btnBillList_Click(object sender, EventArgs e)
        {
            ShowDataGw();
        }

        // Load the bills from the database and display them in the DataGridView (Method)
        private void ShowDataGw()
        {
            dataGridView1.DataSource = db.TblBill.ToList();
            dataGridView1.Columns[0].HeaderText = "Fatura ID";
            dataGridView1.Columns[1].HeaderText = "Fatura Adý";
            dataGridView1.Columns[2].HeaderText = "Fatura Tutarý";
            dataGridView1.Columns[3].HeaderText = "Fatura Tarihi";
        }

        // Add the new bill to the database
        private void btnBillAdd_Click(object sender, EventArgs e) 
        {
            try
            {
                // Validate the input fields
                string title = txtBillTitle.Text;
                decimal amount = decimal.Parse(txtBillAmount.Text);
                DateTime date = dateBillDate.Value;
                string amountControl = txtBillAmount.Text;

                // Check if the fields are empty or not
                if (string.IsNullOrEmpty(title) || dateBillDate.Value == null || string.IsNullOrEmpty(amountControl))
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the new bill to the database
                else
                {
                    TblBill bill = new TblBill
                    {
                        BillTitle = title,
                        BillAmount = amount,
                        BillPeriod = date
                    };
                    db.TblBill.Add(bill);
                    db.SaveChanges();
                    MessageBox.Show("Fatura baþarýyla eklendi.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDataGw();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lütfen Verileri Kontrol Edin !!","Hata !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete the selected bill from the database
        private void btnBillDel_Click(object sender, EventArgs e)
        {
            // Validate the input fields
            int id = int.Parse(txtBillId.Text);
            var bill = db.TblBill.FirstOrDefault(b => b.BillId == id);

            // Check if the bill exists
            if (bill != null)
            {
                db.TblBill.Remove(bill);
                db.SaveChanges();
                MessageBox.Show("Fatura baþarýyla silindi.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGw();
            }
            else
            {
                MessageBox.Show("Fatura bulunamadý.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Update the bill's details
        private void btnBillUpd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var bill = db.TblBill.FirstOrDefault(b => b.BillId == id);

            //Check if the bill exists
            if (bill != null)
            {
                bill.BillTitle = txtBillTitle.Text;
                bill.BillAmount = decimal.Parse(txtBillAmount.Text);
                bill.BillPeriod = dateBillDate.Value;
                db.SaveChanges();
                MessageBox.Show("Fatura baþarýyla güncellendi.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGw();
            }
            else
            {
                MessageBox.Show("Fatura bulunamadý.", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
