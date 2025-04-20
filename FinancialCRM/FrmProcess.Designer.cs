namespace FinancialCRM
{
    partial class FrmProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSpendingForm = new System.Windows.Forms.Button();
            this.btnProcessForm = new System.Windows.Forms.Button();
            this.BtnBillForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.dateProcessDate = new System.Windows.Forms.DateTimePicker();
            this.btnProcessUpd = new System.Windows.Forms.Button();
            this.btnProcessDel = new System.Windows.Forms.Button();
            this.btnProcessAdd = new System.Windows.Forms.Button();
            this.btnBProcessList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBankForm = new System.Windows.Forms.Button();
            this.txtProcessDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpendingForm
            // 
            this.btnSpendingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpendingForm.Location = new System.Drawing.Point(68, 192);
            this.btnSpendingForm.Name = "btnSpendingForm";
            this.btnSpendingForm.Size = new System.Drawing.Size(158, 44);
            this.btnSpendingForm.TabIndex = 5;
            this.btnSpendingForm.Text = "Giderler";
            this.btnSpendingForm.UseVisualStyleBackColor = true;
            this.btnSpendingForm.Click += new System.EventHandler(this.btnSpendingForm_Click);
            // 
            // btnProcessForm
            // 
            this.btnProcessForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcessForm.Location = new System.Drawing.Point(68, 248);
            this.btnProcessForm.Name = "btnProcessForm";
            this.btnProcessForm.Size = new System.Drawing.Size(158, 44);
            this.btnProcessForm.TabIndex = 4;
            this.btnProcessForm.Text = "Ýþlemler";
            this.btnProcessForm.UseVisualStyleBackColor = true;
            this.btnProcessForm.Click += new System.EventHandler(this.btnProcessForm_Click);
            // 
            // BtnBillForm
            // 
            this.BtnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBillForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBillForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBillForm.Location = new System.Drawing.Point(68, 142);
            this.BtnBillForm.Name = "BtnBillForm";
            this.BtnBillForm.Size = new System.Drawing.Size(158, 44);
            this.BtnBillForm.TabIndex = 2;
            this.BtnBillForm.Text = "Faturalar";
            this.BtnBillForm.UseVisualStyleBackColor = true;
            this.BtnBillForm.Click += new System.EventHandler(this.BtnBillForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategoryForm.Location = new System.Drawing.Point(68, 36);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(158, 44);
            this.btnCategoryForm.TabIndex = 0;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // dateProcessDate
            // 
            this.dateProcessDate.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateProcessDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateProcessDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateProcessDate.Location = new System.Drawing.Point(659, 122);
            this.dateProcessDate.Name = "dateProcessDate";
            this.dateProcessDate.Size = new System.Drawing.Size(219, 35);
            this.dateProcessDate.TabIndex = 13;
            // 
            // btnProcessUpd
            // 
            this.btnProcessUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessUpd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessUpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.btnProcessUpd.Location = new System.Drawing.Point(669, 223);
            this.btnProcessUpd.Name = "btnProcessUpd";
            this.btnProcessUpd.Size = new System.Drawing.Size(195, 44);
            this.btnProcessUpd.TabIndex = 12;
            this.btnProcessUpd.Text = "Ýþlem Güncelle";
            this.btnProcessUpd.UseVisualStyleBackColor = true;
            this.btnProcessUpd.Click += new System.EventHandler(this.btnProcessUpd_Click);
            // 
            // btnProcessDel
            // 
            this.btnProcessDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessDel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.btnProcessDel.Location = new System.Drawing.Point(468, 173);
            this.btnProcessDel.Name = "btnProcessDel";
            this.btnProcessDel.Size = new System.Drawing.Size(195, 44);
            this.btnProcessDel.TabIndex = 11;
            this.btnProcessDel.Text = "Ýþlem Sil";
            this.btnProcessDel.UseVisualStyleBackColor = true;
            this.btnProcessDel.Click += new System.EventHandler(this.btnProcessDel_Click);
            // 
            // btnProcessAdd
            // 
            this.btnProcessAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.btnProcessAdd.Location = new System.Drawing.Point(468, 223);
            this.btnProcessAdd.Name = "btnProcessAdd";
            this.btnProcessAdd.Size = new System.Drawing.Size(195, 44);
            this.btnProcessAdd.TabIndex = 10;
            this.btnProcessAdd.Text = "Ýþlem Ekle";
            this.btnProcessAdd.UseVisualStyleBackColor = true;
            this.btnProcessAdd.Click += new System.EventHandler(this.btnProcessAdd_Click);
            // 
            // btnBProcessList
            // 
            this.btnBProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBProcessList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBProcessList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.btnBProcessList.Location = new System.Drawing.Point(669, 173);
            this.btnBProcessList.Name = "btnBProcessList";
            this.btnBProcessList.Size = new System.Drawing.Size(195, 44);
            this.btnBProcessList.TabIndex = 9;
            this.btnBProcessList.Text = "Ýþlem Listesi";
            this.btnBProcessList.UseVisualStyleBackColor = true;
            this.btnBProcessList.Click += new System.EventHandler(this.btnBProcessList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label5.Location = new System.Drawing.Point(454, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ýþlem Zamaný :";
            // 
            // txtProcessType
            // 
            this.txtProcessType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessType.Location = new System.Drawing.Point(223, 72);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(219, 35);
            this.txtProcessType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label4.Location = new System.Drawing.Point(72, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ýþem Tipi :";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(68, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Çýkýþ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSet.Location = new System.Drawing.Point(68, 348);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(158, 44);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Ayarlar";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Location = new System.Drawing.Point(68, 298);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(158, 44);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnSpendingForm);
            this.panel1.Controls.Add(this.btnProcessForm);
            this.panel1.Controls.Add(this.BtnBillForm);
            this.panel1.Controls.Add(this.btnBankForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 621);
            this.panel1.TabIndex = 10;
            // 
            // btnBankForm
            // 
            this.btnBankForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBankForm.Location = new System.Drawing.Point(68, 89);
            this.btnBankForm.Name = "btnBankForm";
            this.btnBankForm.Size = new System.Drawing.Size(158, 44);
            this.btnBankForm.TabIndex = 1;
            this.btnBankForm.Text = "Bankalar";
            this.btnBankForm.UseVisualStyleBackColor = true;
            this.btnBankForm.Click += new System.EventHandler(this.btnBankForm_Click);
            // 
            // txtProcessDescription
            // 
            this.txtProcessDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessDescription.Location = new System.Drawing.Point(10, 164);
            this.txtProcessDescription.Multiline = true;
            this.txtProcessDescription.Name = "txtProcessDescription";
            this.txtProcessDescription.Size = new System.Drawing.Size(432, 103);
            this.txtProcessDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ýþlem Açýklama :";
            // 
            // txtProcessId
            // 
            this.txtProcessId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessId.Location = new System.Drawing.Point(223, 28);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(219, 35);
            this.txtProcessId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(86, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ýþlem Id :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.cmbBank);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtProcessAmount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateProcessDate);
            this.panel3.Controls.Add(this.btnProcessUpd);
            this.panel3.Controls.Add(this.btnProcessDel);
            this.panel3.Controls.Add(this.btnProcessAdd);
            this.panel3.Controls.Add(this.btnBProcessList);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtProcessType);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtProcessDescription);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtProcessId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(236, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 277);
            this.panel3.TabIndex = 8;
            // 
            // cmbBank
            // 
            this.cmbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(654, 76);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(224, 37);
            this.cmbBank.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label6.Location = new System.Drawing.Point(468, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ýþlem Banka :";
            // 
            // txtProcessAmount
            // 
            this.txtProcessAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessAmount.Location = new System.Drawing.Point(654, 32);
            this.txtProcessAmount.Name = "txtProcessAmount";
            this.txtProcessAmount.Size = new System.Drawing.Size(224, 35);
            this.txtProcessAmount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label7.Location = new System.Drawing.Point(462, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ýþem Miktarý :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ýþlemler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 63);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(236, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 322);
            this.panel4.TabIndex = 9;
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "FrmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ýþlem Formu";
            this.Load += new System.EventHandler(this.FrmProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpendingForm;
        private System.Windows.Forms.Button btnProcessForm;
        private System.Windows.Forms.Button BtnBillForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.DateTimePicker dateProcessDate;
        private System.Windows.Forms.Button btnProcessUpd;
        private System.Windows.Forms.Button btnProcessDel;
        private System.Windows.Forms.Button btnProcessAdd;
        private System.Windows.Forms.Button btnBProcessList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBankForm;
        private System.Windows.Forms.TextBox txtProcessDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcessAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBank;
    }
}