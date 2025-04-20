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
    public partial class FrmLogin : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var user = db.TblUser.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);
            if (user != null)
            {
                // User found, proceed to the main form
                FrmDashboard mainForm = new FrmDashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // User not found, show error message
                MessageBox.Show("Kullanýcý Adý veya Þifre Yanlýþ","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
