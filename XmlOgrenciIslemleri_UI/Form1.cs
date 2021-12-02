using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        //Global alan 
        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BsinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();


        public Form1() //ctor
        {
            InitializeComponent();
            // isterseniz addRange ile ekleyebilirsiniz.
            //AddRange içeriye dizi yani array ister.
            // bu nedenle listenizi toarray ile diziye çevirmelisiniz.
            //   cmbBoxSinifSecimi.Items.AddRange(SiniflarListesi.ToArray());

            // isterseniz döngü kurarak ekleyebilirsiniz
            foreach (var item in SiniflarListesi)
            {
                cmbBoxSinifSecimi.Items.Add(item);
            }
            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            dateTimePickerDTarihi .TabIndex = 2;
            cmbBoxSinifSecimi.TabIndex = 3;
            btnOgrenciEkle.TabIndex = 4;
            listBoxASinifi.TabIndex = 5;
            groupBoxSecmeliDersler.Enabled = false;
            checkedListBox1.CheckOnClick = true;

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            //öğrenci ekleyeceğiz.

            // string.IsNullOrEmpty--> Hazır bir string metottur. 
            // içine verilen value'nun null ya da boş olup olmadığına bakar.
            // bool return eder.
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = dateTimePickerDTarihi.Value
                };

                // comboboxta seçtiği değer

                //if (cmbBoxSinifSecimi.SelectedIndex==-1)
                //{
                //    MessageBox.Show("Lütfen sınıf seçiniz.");
                //}
                //else
                //{
                // işlemler
                //}

                if (AsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci A sınıfına zaten kayıt olmuş!");
                }
                else if (BsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci B sınıfına zaten kayıt olmuş!");
                }
                // indexler sıfırdan başladığı için >=0 olmalıdır
                else if (cmbBoxSinifSecimi.SelectedIndex >= 0)
                {
                    // öğrencinin sınıfı comboBoxtan gelen seçili değer olacak.
                    ogr1.Sinif = cmbBoxSinifSecimi.SelectedItem.ToString();

                    //Artık öğrenciyi listeye eklemeliyiz.
                    switch (cmbBoxSinifSecimi.SelectedIndex)
                    {
                        case 0: // A sınıfıdır
                            if (AsinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                ASinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;

                        case 1: // B sınıfıdır
                            if (BsinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                BsinifiOgrencileri.Add(ogr1);
                            }
                            break;
                        default:
                            break;
                    }
                    ogr1.SecmeliDersAlıyorMu = checkBoxSecmeliDers.Checked;
                    if (ogr1.SecmeliDersAlıyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }
                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz.");
                }

            }

        }


        private bool AsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;

            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad
                    && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;

        }

        private bool BsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;

            foreach (var item in BsinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad
                    && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;

        }

        private void KontrolleriTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            cmbBoxSinifSecimi.SelectedIndex = -1;
            cmbBoxSinifSecimi.Text = "Sınıfınızı seçiniz...";
            dateTimePickerDTarihi.Value = DateTime.Now;
            foreach (int indexi  in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(indexi, CheckState.Unchecked);
            }
            SecilenSecmeliDersler.Clear();
            checkBoxSecmeliDers.Checked = false;
        }
        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.AliceBlue;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

           listBoxBSinifi .Items.Clear();
            listBoxBSinifi.BackColor = Color.Azure;
            listBoxBSinifi.Items.AddRange(BsinifiOgrencileri.ToArray());
        }

        private void btnHepsiniSagaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in BsinifiOgrencileri)
            {
                item.Sinif = "B Sınıfı";
            }
            BsinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btnSagaGonder_Click(object sender, EventArgs e)
        {
            //Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            Ogrenci transferEdilecekOgr = listBoxASinifi.SelectedItem as Ogrenci;
            if (transferEdilecekOgr!=null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinif = "B Sınıfı";
                BsinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnHepsiniSolaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinif = "A Sınıfı";
            }
            ASinifiOgrencileri.AddRange(BsinifiOgrencileri.ToArray());
            BsinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void checkBoxSecmeliDers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliDers.Checked)
            {
                groupBoxSecmeliDersler.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDersler.Enabled = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSecmeliDersler.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (SecilenSecmeliDersler.Count(x => x==item.ToString())==0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void XMLIleDisaiıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacaklar = new List<Ogrenci>();
            if (ASinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(ASinifiOgrencileri);
            }
            if (BsinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(BsinifiOgrencileri);
            }
            saveFileDialog1.Title = "Öğrenci XML dosyası kaydet";
            saveFileDialog1.Filter = "XML Formatı | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                using (TextWriter yazar=new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerializer.Serialize(yazar, DisariAktarilacaklar);
                }
                MessageBox.Show($"{DisariAktarilacaklar.Count} adet öğrenci XML dosyası olarak aktarıldı.");
            }
        }

        private void XMLIleIceriVeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontrolleriTemizle();
            openFileDialog1.Title = "XML dosyanızı seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                using (TextReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {
                   ASinifiOgrencileri= (List<Ogrenci>)myXMLSerializer.Deserialize(okuyucu);
                    //ASinifiOgrencileri= myXMLSerializer.Deserialize(okuyucu) as List<Ogrenci>;
                    MessageBox.Show(ASinifiOgrencileri.Count + " adet kişi içeri aktarıldı");
                    ListeleriDoldur();
                }
            }
        }

        private void btnSolaGonder_Click(object sender, EventArgs e)
        {
            //Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            Ogrenci transferEdilecekOgr = listBoxBSinifi.SelectedItem as Ogrenci;
            if (transferEdilecekOgr != null)
            {
                BsinifiOgrencileri.  Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinif = "A Sınıfı";
                ASinifiOgrencileri .Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
        }
    }
}
