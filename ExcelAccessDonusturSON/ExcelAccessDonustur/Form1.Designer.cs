namespace ExcelAccessDonustur
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dSet1 = new System.Data.DataSet();
            this.burakDataSet = new ExcelAccessDonustur.BurakDataSet();
            this.tah_puantajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tah_puantajTableAdapter = new ExcelAccessDonustur.BurakDataSetTableAdapters.tah_puantajTableAdapter();
            this.tableAdapterManager = new ExcelAccessDonustur.BurakDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtDosyaUzanti = new System.Windows.Forms.TextBox();
            this.BtnDosyaAc = new System.Windows.Forms.Button();
            this.BtnIleri1 = new System.Windows.Forms.Button();
            this.BtnIptal1 = new System.Windows.Forms.Button();
            this.dGrid1 = new System.Windows.Forms.DataGridView();
            this.labelfileinfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelfileisimtxt = new System.Windows.Forms.Label();
            this.labelsontarihvalue = new System.Windows.Forms.Label();
            this.labelisimvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tah_puantajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSet1
            // 
            this.dSet1.DataSetName = "NewDataSet";
            // 
            // burakDataSet
            // 
            this.burakDataSet.DataSetName = "BurakDataSet";
            this.burakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tah_puantajBindingSource
            // 
            this.tah_puantajBindingSource.DataMember = "tah_puantaj";
            this.tah_puantajBindingSource.DataSource = this.burakDataSet;
            // 
            // tah_puantajTableAdapter
            // 
            this.tah_puantajTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tah_puantajTableAdapter = this.tah_puantajTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExcelAccessDonustur.BurakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TxtDosyaUzanti
            // 
            this.TxtDosyaUzanti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDosyaUzanti.Location = new System.Drawing.Point(3, 7);
            this.TxtDosyaUzanti.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.TxtDosyaUzanti.Name = "TxtDosyaUzanti";
            this.TxtDosyaUzanti.Size = new System.Drawing.Size(333, 20);
            this.TxtDosyaUzanti.TabIndex = 12;
            this.TxtDosyaUzanti.TextChanged += new System.EventHandler(this.TxtDosyaUzanti_TextChanged);
            // 
            // BtnDosyaAc
            // 
            this.BtnDosyaAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDosyaAc.Location = new System.Drawing.Point(342, 5);
            this.BtnDosyaAc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnDosyaAc.MinimumSize = new System.Drawing.Size(71, 25);
            this.BtnDosyaAc.Name = "BtnDosyaAc";
            this.BtnDosyaAc.Size = new System.Drawing.Size(71, 25);
            this.BtnDosyaAc.TabIndex = 18;
            this.BtnDosyaAc.Text = "Dosya Aç";
            this.BtnDosyaAc.UseVisualStyleBackColor = true;
            this.BtnDosyaAc.Click += new System.EventHandler(this.BtnDosyaAc_Click_1);
            // 
            // BtnIleri1
            // 
            this.BtnIleri1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIleri1.Location = new System.Drawing.Point(7, 0);
            this.BtnIleri1.Margin = new System.Windows.Forms.Padding(3, 0, 1, 3);
            this.BtnIleri1.MinimumSize = new System.Drawing.Size(71, 25);
            this.BtnIleri1.Name = "BtnIleri1";
            this.BtnIleri1.Size = new System.Drawing.Size(71, 25);
            this.BtnIleri1.TabIndex = 20;
            this.BtnIleri1.Text = "İleri >";
            this.BtnIleri1.UseVisualStyleBackColor = true;
            this.BtnIleri1.Click += new System.EventHandler(this.BtnIleri1_Click_1);
            // 
            // BtnIptal1
            // 
            this.BtnIptal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIptal1.Location = new System.Drawing.Point(82, 0);
            this.BtnIptal1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.BtnIptal1.MinimumSize = new System.Drawing.Size(71, 25);
            this.BtnIptal1.Name = "BtnIptal1";
            this.BtnIptal1.Size = new System.Drawing.Size(71, 25);
            this.BtnIptal1.TabIndex = 21;
            this.BtnIptal1.Text = "İptal";
            this.BtnIptal1.UseVisualStyleBackColor = true;
            this.BtnIptal1.Click += new System.EventHandler(this.BtnIptal1_Click_1);
            // 
            // dGrid1
            // 
            this.dGrid1.AllowUserToAddRows = false;
            this.dGrid1.AllowUserToDeleteRows = false;
            this.dGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid1.Location = new System.Drawing.Point(14, 44);
            this.dGrid1.Margin = new System.Windows.Forms.Padding(6, 4, 8, 4);
            this.dGrid1.MinimumSize = new System.Drawing.Size(409, 229);
            this.dGrid1.Name = "dGrid1";
            this.dGrid1.ReadOnly = true;
            this.dGrid1.Size = new System.Drawing.Size(409, 233);
            this.dGrid1.TabIndex = 2;
            // 
            // labelfileinfo
            // 
            this.labelfileinfo.AutoSize = true;
            this.labelfileinfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelfileinfo.Location = new System.Drawing.Point(0, 23);
            this.labelfileinfo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelfileinfo.Name = "labelfileinfo";
            this.labelfileinfo.Size = new System.Drawing.Size(131, 13);
            this.labelfileinfo.TabIndex = 17;
            this.labelfileinfo.Text = "Dosya son değişiklik tarihi:";
            this.labelfileinfo.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.dGrid1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 331);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Controls.Add(this.TxtDosyaUzanti, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDosyaAc, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 34);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.68675F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.31325F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 284);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(415, 44);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnIptal1);
            this.flowLayoutPanel1.Controls.Add(this.BtnIleri1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(259, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel4.Controls.Add(this.labelfileisimtxt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelfileinfo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelsontarihvalue, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelisimvalue, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(253, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelfileisimtxt
            // 
            this.labelfileisimtxt.AutoSize = true;
            this.labelfileisimtxt.Location = new System.Drawing.Point(0, 3);
            this.labelfileisimtxt.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelfileisimtxt.Name = "labelfileisimtxt";
            this.labelfileisimtxt.Size = new System.Drawing.Size(61, 13);
            this.labelfileisimtxt.TabIndex = 18;
            this.labelfileisimtxt.Text = "Dosya İsmi:";
            this.labelfileisimtxt.Visible = false;
            // 
            // labelsontarihvalue
            // 
            this.labelsontarihvalue.AutoSize = true;
            this.labelsontarihvalue.Location = new System.Drawing.Point(136, 23);
            this.labelsontarihvalue.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.labelsontarihvalue.Name = "labelsontarihvalue";
            this.labelsontarihvalue.Size = new System.Drawing.Size(35, 13);
            this.labelsontarihvalue.TabIndex = 20;
            this.labelsontarihvalue.Text = "label2";
            this.labelsontarihvalue.Visible = false;
            // 
            // labelisimvalue
            // 
            this.labelisimvalue.AutoSize = true;
            this.labelisimvalue.Location = new System.Drawing.Point(136, 3);
            this.labelisimvalue.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.labelisimvalue.Name = "labelisimvalue";
            this.labelisimvalue.Size = new System.Drawing.Size(35, 13);
            this.labelisimvalue.TabIndex = 19;
            this.labelisimvalue.Text = "label1";
            this.labelisimvalue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 331);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(453, 369);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Access Aktarma Sihirbazı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.ExelAccessDonustur1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tah_puantajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dSet1;
        private BurakDataSet burakDataSet;
        private System.Windows.Forms.BindingSource tah_puantajBindingSource;
        private BurakDataSetTableAdapters.tah_puantajTableAdapter tah_puantajTableAdapter;
        private BurakDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtDosyaUzanti;
        private System.Windows.Forms.Button BtnDosyaAc;
        private System.Windows.Forms.Button BtnIleri1;
        private System.Windows.Forms.Button BtnIptal1;
        private System.Windows.Forms.DataGridView dGrid1;
        private System.Windows.Forms.Label labelfileinfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelfileisimtxt;
        private System.Windows.Forms.Label labelisimvalue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelsontarihvalue;
    }
}

