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
    public partial class FrmCategory : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            categoryList();
            chartShow();
        }

        private void categoryList()
        {
            var list = db.TblCategory.Select(x => new 
            {
                x.CategoryId,
                x.CategoryName
            });
            dataGridView2.DataSource = list.ToList();

        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            categoryList();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            categoryList();
            try
            {
                if (string.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Lütfen Kategori Adýný Giriniz");
                }
                else
                {
                    TblCategory category = new TblCategory();
                    category.CategoryName = categoryName;
                    db.TblCategory.Add(category);
                    db.SaveChanges();
                    MessageBox.Show("Kategori Eklendi");
                    txtCategoryName.Clear();
                    categoryList();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnCategoryDel_Click(object sender, EventArgs e)
        {
            int delId = int.Parse(txtCategoryId.Text);
            try
            {
                var category = db.TblCategory.Find(delId);
                if (category != null)
                {
                    db.TblCategory.Remove(category);
                    db.SaveChanges();
                    MessageBox.Show("Kategori Silindi");
                    txtCategoryId.Clear();
                    categoryList();
                }
                else
                {
                    MessageBox.Show("Silinecek Kategori Bulunamadý");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void btnCategoryUpd_Click(object sender, EventArgs e)
        {
            int updId = int.Parse(txtCategoryId.Text);
            string updName = txtCategoryName.Text;
            try
            {
                var category = db.TblCategory.Find(updId);
                if (category != null)
                {
                    category.CategoryName = updName;
                    db.SaveChanges();
                    MessageBox.Show("Kategori Güncellendi");
                    txtCategoryId.Clear();
                    txtCategoryName.Clear();
                    categoryList();
                }
                else
                {
                    MessageBox.Show("Güncellenecek Kategori Bulunamadý");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void chartShow()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Categories");
            var spendingData = db.TblSpending
                .GroupBy(x => x.CategoryId)
                .Select(g => new
                {
                    CategoryId = g.Key,
                    TotalAmount = g.Sum(x => x.SpendingAmount)
                })
                .ToList();
            var categoryData = db.TblCategory.ToList();
            var chartData = from s in spendingData
                            join c in categoryData on s.CategoryId equals c.CategoryId
                            select new
                            {
                                CategoryName = c.CategoryName,
                                TotalAmount = s.TotalAmount
                            };
            chart1.Series["Categories"].Points.Clear();
            foreach (var item in chartData)
            {
                chart1.Series["Categories"].Points.AddXY(item.CategoryName, item.TotalAmount);
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
