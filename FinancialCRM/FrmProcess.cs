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
    public partial class FrmProcess : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmProcess()
        {
            InitializeComponent();
        }

        private void FrmProcess_Load(object sender, EventArgs e)
        {
            cmbBank.DataSource = db.TblBank.ToList();
            cmbBank.DisplayMember = "BankTitle";
            cmbBank.ValueMember = "BankId";
            ListProcess();
        }

        // this method retrieves all process records from the database and binds them to the DataGridView
        private void ListProcess()
        {
            var listProcess = db.TblProcess.
                OrderByDescending(x => x.ProcessDate).
                Select(x => new
            {
                x.ProcessId,
                x.ProcessDescription,
                x.ProcessDate,
                x.ProcessAmount,
                x.ProcessType,
                x.BankId,
                BankTitle = x.TblBank.BankTitle,
            }).ToList();
            dataGridView1.DataSource = listProcess;
            dataGridView1.Columns[0].HeaderText = "��lem �d";
            dataGridView1.Columns[1].HeaderText = "��lem A��klamas�";
            dataGridView1.Columns[2].HeaderText = "��lem Tarihi";
            dataGridView1.Columns[3].HeaderText = "��lem Tutar�";
            dataGridView1.Columns[4].HeaderText = "��lem T�r�";
            dataGridView1.Columns[5].HeaderText = "Banka �d";
            dataGridView1.Columns[6].HeaderText = "Banka Ad�";
        }

        // this method deletes a process record from the database based on the ID entered in the text box
        private void btnProcessDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            var process = db.TblProcess.Find(id);
            try
            {
                if (process != null)
                {
                    db.TblProcess.Remove(process);
                    db.SaveChanges();
                    MessageBox.Show("��lem Silindi");
                    ListProcess();
                }
                else
                {
                    MessageBox.Show("��lem Bulunamad�");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata: " + exception.Message);
            }
        }

        // this method adds a new process record to the database with the values entered in the text boxes
        private void btnProcessAdd_Click(object sender, EventArgs e)
        {
            string description = txtProcessDescription.Text;
            DateTime date = dateProcessDate.Value;
            decimal amount = decimal.Parse(txtProcessAmount.Text);
            string type = txtProcessType.Text;
            int bankId = (int)cmbBank.SelectedValue;
            try
            {
                var selectedBank = db.TblBank.Find(bankId);
                if (selectedBank == null)
                {
                    MessageBox.Show("Banka bulunamad�.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (type == "Giden")
                {
                    if (selectedBank.BankBalance < amount)
                    {
                        MessageBox.Show("Banka bakiyesi yetersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        selectedBank.BankBalance -= amount;
                    }

                }
                else if (type == "Gelen")
                {
                    selectedBank.BankBalance += amount;
                }

                TblProcess process = new TblProcess
                {
                    ProcessDescription = description,
                    ProcessDate = date,
                    ProcessAmount = amount,
                    ProcessType = type,
                    BankId = bankId
                };
                db.TblProcess.Add(process);
                db.SaveChanges();
                MessageBox.Show("��lem Eklendi","Ba�ar�l�",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata: " + exception.Message);
            }

        }

        // this method retrieves all process records from the database and binds them to the DataGridView
        private void btnBProcessList_Click(object sender, EventArgs e)
        {
            ListProcess();
        }

        // this method updates an existing process record in the database with the values entered in the text boxes
        private void btnProcessUpd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            var process = db.TblProcess.Find(id);
            try
            {
                if (process != null)
                {
                    process.ProcessDescription = txtProcessDescription.Text;
                    process.ProcessDate = dateProcessDate.Value;
                    process.ProcessAmount = decimal.Parse(txtProcessAmount.Text);
                    process.ProcessType = txtProcessType.Text;
                    process.BankId = (int)cmbBank.SelectedValue;
                    db.SaveChanges();
                    MessageBox.Show("��lem G�ncellendi");
                    ListProcess();
                }
                else
                {
                    MessageBox.Show("��lem Bulunamad�");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata: " + exception.Message);
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
            MessageBox.Show("Ayarlar Olabilecek En �yi �ekilde Oynamamak Daha �yi ", "Yapmad�m", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("��kmak �stedi�inize Emin Misiniz?", "��k��", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("�yi G�nler Dilerim");
            }
        }
    }
}
