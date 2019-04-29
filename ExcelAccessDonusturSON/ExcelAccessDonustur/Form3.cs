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

namespace ExcelAccessDonustur
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string gelenAy;
        // İşlem sonucu veritabanı tablosunu göstererek raporlama yapar.
        private void Form3_Load(object sender, EventArgs e)
        {
                OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Burak.accdb");
                string sorgu = "SELECT* from tah_puantaj";
                OleDbDataAdapter data_adp = new OleDbDataAdapter(sorgu, baglanti);

                DataTable dt = new DataTable();
                data_adp.Fill(dt);

                dGridVT.DataSource = dt;
        }
        string saha,firma,sicil,yil,ay;
        int sayac1,sayac2; // sayac1 işleme girenleri, sayac2 işleme girmeyenleri saydırır.

        // dGridVTdeki sahaları kontrol edip boş olan sicilleri yazdırır.
        private void BtnSahaAra_Click(object sender, EventArgs e)
        {
            try
            {
                labelguncel.Text = null; // Önceki istenen aramanın sonuçlarını silmek için.
                labelgunceldegil.Text = null;
                sayac1 = 0;
                sayac2 = 0;
                listBoxSicil.Items.Clear();
                saha = textBoxSaha.Text.ToUpper();
                if (saha != "")
                {
                    if (saha != "SAHA ADI GİRİNİZ.")
                    {
                        for (int i = 0; i < dGridVT.Rows.Count; i++)
                        {
                            if (Convert.ToString(dGridVT.Rows[i].Cells["" + saha + ""].Value) != "")
                            {
                                firma = dGridVT.Rows[i].Cells["Firma"].Value.ToString();
                                sicil = dGridVT.Rows[i].Cells["Sicil"].Value.ToString();
                                yil = dGridVT.Rows[i].Cells["Yil"].Value.ToString();
                                ay = dGridVT.Rows[i].Cells["Ay"].Value.ToString();

                                if (ay == gelenAy)
                                {
                                    sayac1++;
                                }
                            }
                            else
                            {
                                firma = dGridVT.Rows[i].Cells["Firma"].Value.ToString();
                                sicil = dGridVT.Rows[i].Cells["Sicil"].Value.ToString();
                                yil = dGridVT.Rows[i].Cells["Yil"].Value.ToString();
                                ay = dGridVT.Rows[i].Cells["Ay"].Value.ToString();

                                if (ay == gelenAy)
                                {
                                    // Boş kayıtları listboxa atan kod satırı.
                                    listBoxSicil.Items.Add("\nFirma: " + firma + " Sicil: " + sicil + " Yıl: " + yil + " Ay: " + ay);
                                    sayac2++;
                                }
                            }
                            labelguncel.Visible = true;
                            labelgunceldegil.Visible = true;
                            labelguncel.Text = sayac1.ToString();
                            labelgunceldegil.Text = sayac2.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aranacak sahayı giriniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Aranacak sahayı giriniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBoxSaha.Text = "Saha adı giriniz.";
            }
            catch (Exception)
            {
            }
            
        }
        // Açıklama metnini butonun üzerine gelince ekranda gösterir.
        private void BtnSahaAra_MouseHover(object sender, EventArgs e)
        {
            labelSaha.Visible = true;
        }
        // Açıklama metnini gizler.
        private void BtnSahaAra_MouseLeave(object sender, EventArgs e)
        {
            labelSaha.Visible = false;
        }
        // textBoxSaha içindeki yazıyı sıfırlar.
        private void textBoxSaha_Click(object sender, EventArgs e)
        {
            textBoxSaha.Text = null;
            textBoxSaha.Clear();
        }
    }
}