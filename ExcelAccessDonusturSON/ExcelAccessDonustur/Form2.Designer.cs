namespace ExcelAccessDonustur
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.burakDataSet = new ExcelAccessDonustur.BurakDataSet();
            this.tahpuantajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tah_puantajTableAdapter = new ExcelAccessDonustur.BurakDataSetTableAdapters.tah_puantajTableAdapter();
            this.tahpuantajBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tahpuantajBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.burakDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnIleri2 = new System.Windows.Forms.Button();
            this.BtnIptal2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSifirla = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Vtlabel2 = new System.Windows.Forms.Label();
            this.Exlabel = new System.Windows.Forms.Label();
            this.Vtlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYil = new System.Windows.Forms.TextBox();
            this.textBoxAy = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelYil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 270);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // burakDataSet
            // 
            this.burakDataSet.DataSetName = "BurakDataSet";
            this.burakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahpuantajBindingSource
            // 
            this.tahpuantajBindingSource.DataMember = "tah_puantaj";
            this.tahpuantajBindingSource.DataSource = this.burakDataSet;
            // 
            // tah_puantajTableAdapter
            // 
            this.tah_puantajTableAdapter.ClearBeforeFill = true;
            // 
            // tahpuantajBindingSource1
            // 
            this.tahpuantajBindingSource1.DataMember = "tah_puantaj";
            this.tahpuantajBindingSource1.DataSource = this.burakDataSet;
            // 
            // listBox2
            // 
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(206, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 270);
            this.listBox2.TabIndex = 5;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // tahpuantajBindingSource2
            // 
            this.tahpuantajBindingSource2.DataMember = "tah_puantaj";
            this.tahpuantajBindingSource2.DataSource = this.burakDataSetBindingSource;
            // 
            // burakDataSetBindingSource
            // 
            this.burakDataSetBindingSource.DataSource = this.burakDataSet;
            this.burakDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(770, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(9, 4);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(18, 370);
            this.textBoxArama.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(182, 20);
            this.textBoxArama.TabIndex = 10;
            this.textBoxArama.Text = "Aranacak sahayı giriniz.";
            this.textBoxArama.Click += new System.EventHandler(this.textBoxArama_Click);
            this.textBoxArama.TextChanged += new System.EventHandler(this.textBoxArama_TextChanged);
            this.textBoxArama.Leave += new System.EventHandler(this.textBoxArama_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArama, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Vtlabel2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Exlabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Vtlabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYil, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAy, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 401);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnIleri2);
            this.flowLayoutPanel1.Controls.Add(this.BtnIptal2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(582, 364);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 34);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // BtnIleri2
            // 
            this.BtnIleri2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIleri2.Location = new System.Drawing.Point(0, 3);
            this.BtnIleri2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BtnIleri2.Name = "BtnIleri2";
            this.BtnIleri2.Size = new System.Drawing.Size(71, 25);
            this.BtnIleri2.TabIndex = 0;
            this.BtnIleri2.Text = "İleri >";
            this.BtnIleri2.UseVisualStyleBackColor = true;
            this.BtnIleri2.Click += new System.EventHandler(this.BtnIleri2_Click);
            // 
            // BtnIptal2
            // 
            this.BtnIptal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIptal2.Location = new System.Drawing.Point(77, 3);
            this.BtnIptal2.Name = "BtnIptal2";
            this.BtnIptal2.Size = new System.Drawing.Size(71, 25);
            this.BtnIptal2.TabIndex = 1;
            this.BtnIptal2.Text = "İptal";
            this.BtnIptal2.UseVisualStyleBackColor = true;
            this.BtnIptal2.Click += new System.EventHandler(this.BtnIptal2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BtnSifirla);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(394, 364);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 34);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // BtnSifirla
            // 
            this.BtnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSifirla.Location = new System.Drawing.Point(0, 3);
            this.BtnSifirla.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.BtnSifirla.MinimumSize = new System.Drawing.Size(71, 25);
            this.BtnSifirla.Name = "BtnSifirla";
            this.BtnSifirla.Size = new System.Drawing.Size(71, 25);
            this.BtnSifirla.TabIndex = 18;
            this.BtnSifirla.Text = "Sıfırla";
            this.BtnSifirla.UseVisualStyleBackColor = true;
            this.BtnSifirla.Visible = false;
            this.BtnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click);
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(394, 88);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(182, 270);
            this.listBox3.TabIndex = 13;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(582, 88);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(182, 270);
            this.listBox4.TabIndex = 14;
            this.listBox4.DoubleClick += new System.EventHandler(this.listBox4_DoubleClick);
            // 
            // Vtlabel2
            // 
            this.Vtlabel2.AutoSize = true;
            this.Vtlabel2.Location = new System.Drawing.Point(392, 68);
            this.Vtlabel2.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.Vtlabel2.Name = "Vtlabel2";
            this.Vtlabel2.Size = new System.Drawing.Size(159, 13);
            this.Vtlabel2.TabIndex = 15;
            this.Vtlabel2.Text = "Eşleştirilecek Veritabanı Sahaları";
            // 
            // Exlabel
            // 
            this.Exlabel.AutoSize = true;
            this.Exlabel.Location = new System.Drawing.Point(204, 68);
            this.Exlabel.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.Exlabel.Name = "Exlabel";
            this.Exlabel.Size = new System.Drawing.Size(74, 13);
            this.Exlabel.TabIndex = 12;
            this.Exlabel.Text = "Excel Sahaları";
            // 
            // Vtlabel
            // 
            this.Vtlabel.AutoSize = true;
            this.Vtlabel.Location = new System.Drawing.Point(16, 68);
            this.Vtlabel.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.Vtlabel.Name = "Vtlabel";
            this.Vtlabel.Size = new System.Drawing.Size(95, 13);
            this.Vtlabel.TabIndex = 11;
            this.Vtlabel.Text = "Veritabanı Sahaları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eşleştirilecek Excel Sahaları";
            // 
            // textBoxYil
            // 
            this.textBoxYil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYil.Location = new System.Drawing.Point(582, 43);
            this.textBoxYil.Name = "textBoxYil";
            this.textBoxYil.Size = new System.Drawing.Size(182, 20);
            this.textBoxYil.TabIndex = 21;
            this.textBoxYil.Text = "Örnek: 2018";
            this.textBoxYil.Click += new System.EventHandler(this.textBoxYil_Click);
            // 
            // textBoxAy
            // 
            this.textBoxAy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAy.Location = new System.Drawing.Point(394, 43);
            this.textBoxAy.Name = "textBoxAy";
            this.textBoxAy.Size = new System.Drawing.Size(182, 20);
            this.textBoxAy.TabIndex = 20;
            this.textBoxAy.Text = "Örnek: 8";
            this.textBoxAy.Click += new System.EventHandler(this.textBoxAy_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.labelYil);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(579, 10);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(185, 30);
            this.flowLayoutPanel3.TabIndex = 24;
            // 
            // labelYil
            // 
            this.labelYil.AutoSize = true;
            this.labelYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYil.Location = new System.Drawing.Point(1, 9);
            this.labelYil.Margin = new System.Windows.Forms.Padding(1, 9, 3, 0);
            this.labelYil.Name = "labelYil";
            this.labelYil.Size = new System.Drawing.Size(98, 13);
            this.labelYil.TabIndex = 23;
            this.labelYil.Text = "ay ve yılı giriniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 9, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "YIL";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelAy);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(395, 10);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(184, 30);
            this.flowLayoutPanel4.TabIndex = 25;
            // 
            // labelAy
            // 
            this.labelAy.AutoSize = true;
            this.labelAy.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAy.Location = new System.Drawing.Point(88, 9);
            this.labelAy.Margin = new System.Windows.Forms.Padding(1, 9, 0, 0);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(96, 16);
            this.labelAy.TabIndex = 22;
            this.labelAy.Text = "Veri eklenecek ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 9, 55, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "AY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "İşlemler";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(801, 440);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Access Aktarma Sihirbazı";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahpuantajBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burakDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private BurakDataSet burakDataSet;
        private System.Windows.Forms.BindingSource tahpuantajBindingSource;
        private BurakDataSetTableAdapters.tah_puantajTableAdapter tah_puantajTableAdapter;
        private System.Windows.Forms.BindingSource tahpuantajBindingSource1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource tahpuantajBindingSource2;
        private System.Windows.Forms.BindingSource burakDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Vtlabel;
        private System.Windows.Forms.Label Exlabel;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label Vtlabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnIleri2;
        private System.Windows.Forms.Button BtnIptal2;
        private System.Windows.Forms.Button BtnSifirla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxAy;
        private System.Windows.Forms.TextBox textBoxYil;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label labelYil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}