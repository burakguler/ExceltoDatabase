using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ExcelAccessDonustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ExelAccessDonustur1_Load(object sender, EventArgs e)
        {
        // TODO: Bu kod satırı 'burakDataSet.tah_puantaj' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tah_puantajTableAdapter.Fill(this.burakDataSet.tah_puantaj);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void TxtDosyaUzanti_TextChanged(object sender, EventArgs e)
        {

        }
        bool sayacYil, sayacAy; //yil ve ya ay tarihlerini kontrol etmek için bool değişkenler.
        string tarih1, tarih2;
        // Excel xlsx dosyasını seçmek için DosyaAc butonu. 
        private void BtnDosyaAc_Click_1(object sender, EventArgs e)
        {
            try
            {
                TxtDosyaUzanti.Text = ""; // Yeni bir dosya seçiminde eski dosyaların görüntüleri ve verileri kalmaması için.
                dSet1.Clear();
                dSet1.Reset();
                dGrid1.DataSource = null;
                dGrid1.Refresh();
                labelfileinfo.Visible = false;
                labelfileisimtxt.Visible = false;
                labelisimvalue.Visible = false;
                labelsontarihvalue.Visible = false;


                OpenFileDialog dosya = new OpenFileDialog();

                dosya.Filter = "Excel Dosyası |*.xlsx";
                dosya.FilterIndex = 1;
                dosya.RestoreDirectory = true;
                dosya.CheckFileExists = false;
                dosya.Title = "Excel Dosyası Seçiniz...";


                if (dosya.ShowDialog() == DialogResult.OK) // dosya seçildi ise
                {
                    string DosyaYolu = dosya.FileName;
                    string DosyaAdi = dosya.SafeFileName;
                    FileInfo dosyabilgi = new FileInfo(DosyaYolu);
                    string sonTarih = dosyabilgi.LastWriteTime.ToString();
                    TxtDosyaUzanti.Text = DosyaYolu;


                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Open(DosyaYolu);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
                    string sayfa1;
                    sayfa1 = worksheet.Name;
                    int satirSay;
                    satirSay = worksheet.UsedRange.Columns.Count;

                    for (int j = 0; j < satirSay; j++)
                    {
                        tarih1 = Convert.ToString(worksheet.Cells[1, j + 1].Value).ToUpper();
                        if (tarih1 == "YİL" || tarih1 == "YIL")
                        {
                            tarih1 = "Yıl";
                            sayacYil = true;
                            for (int i = 0; i < satirSay; i++)
                            {
                                tarih2 = Convert.ToString(worksheet.Cells[1, i + 1].Value).ToUpper();
                                if (tarih2 == "AY")
                                {
                                    sayacAy = true;
                                }
                            }
                        }
                    }
                    workbook.Close();
                    app.Quit();
                    OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DosyaYolu + ";Extended Properties=Excel 12.0"); //dosya icin baglanti                                                                                                                                                         //excel access arasi donusturucu 
                    OleDbDataAdapter kopru = new OleDbDataAdapter("select * from [" + sayfa1 + "$]", baglanti);

                    if (DosyaYolu == "")
                    {
                        MessageBox.Show("Lütfen Bir Dosya Açınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        kopru.Fill(dSet1); // Tabloyu doldurur.
                        dGrid1.DataSource = dSet1.Tables[0];
                        labelfileinfo.Visible = true; //dosya bilgilerinin olduğu kısımları gösterir.
                        labelfileisimtxt.Visible = true;
                        labelisimvalue.Text = DosyaAdi;
                        labelisimvalue.Visible = true;
                        labelsontarihvalue.Visible = true;
                        labelsontarihvalue.Text = sonTarih;
                    }
                    baglanti.Close();

                }
            }
            catch (Exception)
            {
            }
           
        }
        // 2. Forma geçmek için buton.
        private void BtnIleri1_Click_1(object sender, EventArgs e)
        {
            if (dGrid1.DataSource ==null)
            {
                 MessageBox.Show("Dosya Açmadınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { // Eksik sahaların kontrolu için koşullar.
                if (sayacYil != true)
                {
                    if(sayacAy != true)
                    {         
                        MessageBox.Show(" Excel Tablosunda eksik sahalar var!\n " + "'Yıl'"+" ve "+"'Ay'", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(" Excel Tablosunda eksik saha var!\n " + "'Yıl'", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (sayacAy != true) 
                    {    
                        MessageBox.Show(" Excel Tablosunda eksik saha var!\n " + "'Ay'", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Form2 form2 = new Form2();
                        form2.TxtDosyaUzanti2 = TxtDosyaUzanti.Text;
                        form2.TxtDosyaIsim = labelisimvalue.Text;// Textboxa gelen dosya uzantısını ikinci forma aktarabilmek için.
                        form2.ShowDialog();
                    }   
                }
            }
        }

        // Herhangi bir işlem hatasında programı yeniden başlatmak için iptal butonu.
        private void BtnIptal1_Click_1(object sender, EventArgs e)
        {
            if (dGrid1.DataSource == null)
            {
                MessageBox.Show("İşlem Yapmadınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }
        // Arkaplanda Excel programı açık kalmaması için eylem.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();          
        }
    }
}          