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
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAccessDonustur
{ 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string TxtDosyaUzanti2;  // form1den gelen uzantıyı değer alır.
        public string TxtDosyaIsim;     // form1den gelen dosya ismini değer alır.
        string temp;
        public bool sayac1;     // Ekle işlemine girildiğinin bilgisini almak için değişken.
        public bool sayac2;     // İptal işlemine girildiğinin bilgisini almak için değişken.
        public bool sayacAy;    // Ay bilgisi var mı yok mu almak için değişken.
        public bool sayacYil;   // Yil bilgisi var mı yok mu almak için değişken.

        private void Form2_Load_1(object sender, EventArgs e)
        {
            try
            {
                // listBox1e Veritabanının tablosundaki saha adlarını alan bağlantı.

                this.tah_puantajTableAdapter.Fill(this.burakDataSet.tah_puantaj);
                OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Burak.accdb");
                baglanti1.Open();
                OleDbCommand komut1 = new OleDbCommand("select * from [tah_puantaj]", baglanti1);
                OleDbDataReader reader = komut1.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Clear(); // Sahalar birden fazla saydırılıyordu bu kod onu önlüyor.

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        listBox1.Items.Add(reader.GetName(i));
                    }
                }

                baglanti1.Close();

                // listBox2ye Excel tablosundaki saha adlarını alan bağlantı.

                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Open(TxtDosyaUzanti2);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
                string sayfa2;
                sayfa2 = worksheet.Name;
                int satirSay;
                satirSay = worksheet.UsedRange.Columns.Count;

                for (int j = 0; j < satirSay; j++)
                {
                    listBox2.Items.Add(worksheet.Cells[1, j + 1].Value);
                }
                workbook.Close();
                app.Quit();

                // dataGridview1 için alınan bağlantı.
                OleDbConnection baglanti2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TxtDosyaUzanti2 + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");

                baglanti2.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + sayfa2 + "$]", baglanti2); // Buradaki 'sayfa2' excel tablosunun sayfa isimi. 

                DataSet dt = new DataSet();
                da.Fill(dt, "Excel");

                dataGridView1.DataSource = dt.Tables["Excel"].DefaultView;

                baglanti2.Close();
            }
            catch (Exception)
            {

               
            }
            
        }
        // Çift tıklama ile listBox1deki seçilen itemleri diğer listboxa atar.
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("İşlem yapılamadı!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string listItemnext1= listBox1.SelectedItem.ToString();
                if (!listBox3.Items.Contains(listItemnext1))
                { 
                    listBox3.Items.Add(listBox1.SelectedItem.ToString());
                    BtnSifirla.Visible = true;
                }
                else
                {   // Listboxta aynı isimli olan sahaları seçilmemesi için.
                    MessageBox.Show("Aynı Veritabanı sahasını iki defa işleme alamazsınız!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("İşlem yapılamadı!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                  
                listBox4.Items.Add(listBox2.SelectedItem.ToString());
                BtnSifirla.Visible = true;
            }
        }
        // listBox3 ve ya listBox4 de boş bir alana tıklayınca verilen hatayı düzelten koşul.
        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null)
            {
                MessageBox.Show("İşlem yapılamadı!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox3.Items.Remove(listBox3.SelectedItem.ToString());
                BtnSifirla.Visible = true;
            }
        }
        private void listBox4_DoubleClick(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem == null)
            {
                MessageBox.Show("İşlem yapılamadı!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox4.Items.Remove(listBox4.SelectedItem.ToString());
                BtnSifirla.Visible = true;
            }
        }
        // textBoxArama.Text değerini üzerine tıklayınca sildiren eylem.
        private void textBoxArama_Click(object sender, EventArgs e)
        {
            textBoxArama.Text = null;
            textBoxArama.Clear();
        }
        // Bir şey yazmıyorken textboxı default yazıyla dolduran eylem.
        private void textBoxArama_Leave(object sender, EventArgs e)
        {
            textBoxArama.Text = "Aranacak sahayı giriniz.";
        }
        // textBoxArama'dan listbox1deki saha adlarını bulan eylem.
        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            if (textBoxArama.Text != "" & textBoxArama.Text != "Aranacak sahayı giriniz.")
            {
                listBox1.SelectedIndex = listBox1.FindString(textBoxArama.Text);
            }
        }
        // Listboxların içindeki sahaları sıfırlayan buton.
        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }
        // textBoxAy tıklanınca içindeki yazıyı siler.
        private void textBoxAy_Click(object sender, EventArgs e)
        {
            textBoxAy.Text = "";
        }
        // textBoxYil tıklanınca içindeki yazıyı siler.
        private void textBoxYil_Click(object sender, EventArgs e)
        {
            textBoxYil.Text = "";
        }
        // KullaniciKontrol() , EslemeIslemi() fonksiyonlarını çalıştıran buton.
        private void BtnIleri2_Click(object sender, EventArgs e)
        {
            KullaniciKontrol();
            Form3 frm3 = new Form3();
            if(sayac1 == true)
            {   
                sayac1 = false; // Bir sonraki işlem de problem olmaması için sıfırlanır.
                frm3.gelenAy = temp;
                frm3.Show();
            }
            
        }
        // IslemIptal() fonksiyonunu çalıştıran buton.
        private void BtnIptal2_Click(object sender, EventArgs e)
        {
            IslemIptal();
            Form3 frm3 = new Form3();
            if (sayac2 == true)
            {
                sayac2 = false; // Bir sonraki işlem de problem olmaması için sıfırlanır.
                frm3.gelenAy = temp;
                frm3.Show();
            }
        }
        // Kullanıcınıyı kontrol eden fonksiyon.
        private void KullaniciKontrol()
        {
            DialogResult Soru;
            Soru = MessageBox.Show("İşleme devam etmek istiyor musunuz?","Kontrol Mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Soru == DialogResult.Yes)
            {
                EslemeIslemi();
            }
        }
        // Yapılan veritabanı işlemini geri alıp iptal eden fonksiyon.
        private void IslemIptal()
        {
            DialogResult Soru2;
            Soru2 = MessageBox.Show("Son yaptığınız işlemi iptal etmek istiyor musunuz?", "Kontrol Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Soru2 == DialogResult.Yes)
            {
                sayac2 = true;
                EslemeIslemi();
            }
        }
        // Veritabanı ile excel tablosundaki sahaları eşleyip değerlerini ekleyen fonksiyon.
        public void EslemeIslemi()
        {
            try
            {
                int j = 0;
                string listItem1, listItem2;

                if (listBox3.Items.Count != 0 & listBox4.Items.Count != 0 & (textBoxAy.Text != "" || textBoxAy.Text == "İstenilen ayı giriniz.") & (textBoxYil.Text != "" || textBoxYil.Text == "İstenilen yılı giriniz."))
                {
                    for (; j < listBox3.Items.Count; j++)
                    {
                        listItem1 = listBox3.Items[j].ToString();
                        listItem2 = listBox4.Items[j].ToString();

                        if (listBox3.Items.Count == listBox4.Items.Count & listBox3.Items[j] != null & listBox4.Items[j] != null)
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                OleDbCommand komut2 = new OleDbCommand();
                                OleDbCommand komut3 = new OleDbCommand();
                                OleDbCommand komut4 = new OleDbCommand();
                                OleDbConnection baglanti3 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Burak.accdb");
                                komut2 = new OleDbCommand("SELECT* FROM tah_puantaj", baglanti3); // Reader'ın çalışması için tanımlanan komut.
                                komut3 = new OleDbCommand("select* from tah_puantaj", baglanti3); // Sorgunun çalışması için tanımlanan komut.
                                komut4 = new OleDbCommand("select* from tah_puantaj", baglanti3);
                                baglanti3.Open();
                                OleDbDataReader reader = komut2.ExecuteReader();
                                string sicil = dataGridView1.Rows[i].Cells["Sicil"].Value.ToString();
                                string firma = dataGridView1.Rows[i].Cells["Firma"].Value.ToString();
                                string ay = dataGridView1.Rows[i].Cells["Ay"].Value.ToString();
                                string yil = dataGridView1.Rows[i].Cells["Yıl"].Value.ToString();

                                if (yil == textBoxYil.Text)
                                {
                                    yil = textBoxYil.Text;
                                    sayacYil = true;


                                    if (ay == textBoxAy.Text)
                                    {
                                        ay = textBoxAy.Text;
                                        sayacAy = true;
                                        temp = ay;

                                        if (reader.HasRows)
                                        {
                                            while (reader.Read())
                                            {
                                                string sicil_ = reader["Sicil"].ToString();
                                                string firma_ = reader["Firma"].ToString();
                                                string ay_ = reader["Ay"].ToString();
                                                string yil_ = reader["Yil"].ToString();
                                                string deger = dataGridView1.Rows[i].Cells["" + listItem2 + ""].Value.ToString();

                                                if (sicil == sicil_ & firma == firma_ & ay == ay_ & yil == yil_)
                                                {
                                                    if (sayac2 == true)
                                                    {                                                                  //' ' bu kısımda farklı saha tipleri olduğundan hata verebiliyor denemek için manuel olarak yeni değeri değiştir.   string için:' ', double için:'0,00'          
                                                        komut4.CommandText = "UPDATE tah_puantaj SET " + listItem1 + " = ' ' WHERE Sicil = " + sicil_ + " AND Firma = " + firma_ + " AND Ay = " + ay_ + " AND Yil = " + yil_ + "";
                                                        komut4.ExecuteNonQuery();
                                                        /* 
                                                          DialogResult Soru3;
                                                          Soru3 = MessageBox.Show(" Firma: " + "'" + firma_ + "'" + " Sicili: " + "'" + sicil_ + "'" + " Yılı: " + "'" + yil_ + "'" + " Ay: " + "'" + ay_ + "'" + " Sahası: " + "'" + listItem1 + "'" + "\n ile eşlenen " + "'" + listItem2 + "'" + " excel sahasının: " + "'" + deger + "'" + "\n değerinin silinmesini istiyor musunuz?", "Kontrol Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                                          if (Soru3 == DialogResult.Yes){}
                                                        */
                                                    }
                                                    else
                                                    {
                                                        komut3.CommandText = "UPDATE tah_puantaj SET " + listItem1 + " = '" + deger + "' WHERE Sicil=" + sicil_ + "AND Firma=" + firma_ + "AND Ay=" + ay_ + "AND Yil=" + yil_ + "";
                                                        komut3.ExecuteNonQuery();
                                                        sayac1 = true;
                                                        /*
                                                        DialogResult Soru3;
                                                        Soru3 = MessageBox.Show(" Firma: " + "'" + firma_ + "'" + " Sicili: " + "'" + sicil_ + "'" + " Yılı: " + "'" + yil_ + "'" + " Ay: " + "'" + ay_ + "'" + " Sahası: " + "'" + listItem1 + "'" + "\n ile eşlenen " + "'" + listItem2 + "'" + " excel sahasının: " + "'" + deger + "'" + "\n değerinin eklenmesini istiyor musunuz?",
                                                        "Kontrol Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                                        if (Soru3 == DialogResult.Yes){}
                                                        */
                                                    }
                                                }
                                            }
                                            komut2.Connection = baglanti3;
                                            baglanti3.Close();
                                            reader.Close();
                                        }
                                    }
                                }
                            }
                            if (sayacYil != true)
                            {
                                MessageBox.Show("'" + textBoxYil.Text + "' Yılına ait '" + TxtDosyaIsim + "' dosyasında kayıt bulunmamaktadır\n ve ya tabloyla eşleşmeyen kayıtlar vardır!\n\n Lütfen excel tablonuzu kontrol ediniz.", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (sayacAy != true)
                            {
                                MessageBox.Show("'" + textBoxYil.Text + "' Yılının" + " '" + textBoxAy.Text + "'. ayına ait '" + TxtDosyaIsim + "' dosyasında kayıt bulunmamaktadır\n ve ya tabloyla eşleşmeyen kayıtlar vardır!\n\n Lütfen excel tablonuzu kontrol ediniz.", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sahalar eşit değil kontrol ediniz.", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (sayac1 == true)
                    {
                        MessageBox.Show("Veritabanına aktarım işlemi başarıyla gerçekleşti!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (sayac2 == true)
                    {
                        MessageBox.Show("Veritabanından silme işlemi başarıyla gerçekleşti!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alanlar var ve ya Sahalar eksik kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
            
        }
    }
}
