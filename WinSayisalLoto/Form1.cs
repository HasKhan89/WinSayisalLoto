using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BoxingUnboxing()
        {
            // boxing
            //object adet = nudAdet.Value;
            //adet = "";
            //adet = false;

            //object adet = "";  // boxing
            //string metin = (string)adet;    // unboxing
            //metin.Trim();   // başta ve sondaki boşlukları kaldırır.

            //object adet = 5;   // boxing
            //int sayi = (int)adet;   // unboxing

            // cast işlemi --> unboxing
            //int tahminAdedi2 = (int)nudAdet.Value;

            //object nesne = 5;

            //if(nesne.GetType() == typeof(int))
            //{

            //}

            //if (nesne.GetType() is object)
            //{

            //}
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            decimal tahminAdedi = nudAdet.Value;
            //int tahminAdedi2 = (int)nudAdet.Value;

            // 12   34  23  26  44  9

            Random rnd = new Random();
            //string yazi = "";

            lstTahminler.Items.Clear();

            for (int i = 0; i < tahminAdedi; i++)
            {
                int[] degerler = new int[6];

                for (int j = 0; j < 6; j++)
                {
                    int sayi = rnd.Next(1, 49);
                    degerler[j] = sayi;

                    //yazi = yazi + " " + sayi;
                }

                string yazilacak = string.Join("  ", degerler);
                lstTahminler.Items.Add(yazilacak);

                //lstTahminler.Items.Add(yazi);
                //yazi = "";

            }

            //if(tahminAdedi != 0)
            //{
            //    mnuKaydet.Enabled = true;
            //}

            if (nudAdet.Value > 0)
            {
                mnuKaydet.Enabled = true;
                mnuFarkliKaydet.Enabled = true;
            }
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            Kaydet("");
        }

        private void Kaydet(string dosyaKonum)
        {
            // Dosya adı textbox'dan okundu.
            string dosyaAdi = txtDosyaAdi.Text;

            // dosyaAdi kontrol edildi.
            if (dosyaKonum == "" && string.IsNullOrEmpty(dosyaAdi))
            {
                // dosya adı boş demektir. Uyarı verildi.
                MessageBox.Show("Dosya adı boş geçilemez.. cık cık cık");
                return; // Metot dışına gönderildi. Aşağıdaki kodların çalışması engellenir.
            }

            //if (dosyaAdi != null || dosyaAdi != "")
            //{
            //    // dosya adı boş demektir.
            //    MessageBox.Show("Dosya adı boş geçilemez.. cık cık cık");
            //    return;
            //}

            // Kaydedilecek dosya konumu oluşturulur.
            // C:\asasa\asasasasa\{değişken}.txt
            string path = Application.StartupPath + "\\" + dosyaAdi + ".txt";

            if (string.IsNullOrEmpty(dosyaKonum) == false)
            {
                path = dosyaKonum;
            }

            // listbox'daki Item sayısı(satır sayısı) kadar elemanlı dizi oluşturulur.
            string[] degerler = new string[lstTahminler.Items.Count];

            // 1.Yöntem..
            // listbox'ın Items özelliğindeki elemanları tek tek kendi dizimize ekleme. 

            //for (int i = 0; i < degerler.Length; i++)
            //{
            //    degerler[i] = (string)lstTahminler.Items[i];    // unboxing
            //}


            // 2. Yöntem

            // listbox'daki items dizisini kopyala,
            // hedef dizi "degerler", 
            // kopyalamaya başlanılacak index'i "0"
            lstTahminler.Items.CopyTo(degerler, 0);

            // Dosyaya "degerler" dizisi satır satır yazdırılır.
            System.IO.File.WriteAllLines(path, degerler);

            MessageBox.Show("Dosyaya kaydedildi.");
        }

        private void mnuAc_Click(object sender, EventArgs e)
        {
            DosyaAc("");
        }

        private void DosyaAc(string dosyaKonum)
        {
            // Dosya adı alınmalı.. txtDosyaAdi (Kullanıcı burayı boş geçmemeiş olmalı, yoksa uyarı ver. Geri kalan kod çalışmamalı.)
            // Dosya varsa kontrol et yoksa uyarı ver. Geri kalan kod çalışmamalı.
            // Dosya okuma yapılır. ReadAllLines
            // Okunan dizi listbox'a atılır.

            // Her yeni dosya açılmada liste temizlenir.
            lstTahminler.Items.Clear();

            string dosyaAdi = txtDosyaAdi.Text;

            // Dosya adı boş geçilmiş ise işleyecekk..
            if (dosyaKonum =="" && string.IsNullOrEmpty(dosyaAdi))
            {
                MessageBox.Show("Dosya adı boş geçilemez.");
                return;
            }

            string path = Application.StartupPath + "\\" + dosyaAdi + ".txt";

            if(string.IsNullOrEmpty(dosyaKonum) == false)
            {
                path = dosyaKonum;
            }

            // Dosya yoksa uyarı verilir.
            if (System.IO.File.Exists(path) == false)
            {
                MessageBox.Show("Dosya bulunamadı");
                return;
            }

            // Dosyadan satırlar okunur.
            string[] tahminler = System.IO.File.ReadAllLines(path);

            // Okunan satırlar dizisinde dönülür.
            for (int i = 0; i < tahminler.Length; i++)
            {
                //Listbox'a eklenir.
                lstTahminler.Items.Add(tahminler[i]);
            }
        }

        private void mnuFarkliKaydet_Click(object sender, EventArgs e)
        {
            string path = ""; // Kullanmak üzere değişkenimi tanımladım.

            // Windows'un Kaydet penceresi.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Kaydedilecek Dosyayı Belirtin";   // Pencere başlığı..
            sfd.FileName = "tahminler.txt";         // Pencere açılınca varsayılan dosya adı.

            // Kaydetme işleminin desteklediği dosya uzantıları. uzuntı|görünen ifade
            sfd.Filter = "Metin Belgesi(.txt)|*.txt|XML Dosya(.xml)|*.xml";
            // Kaydetme işleminin desteklediği dosya uzantılardan hangisi seçili gelsin.
            sfd.FilterIndex = 1;

            // Kaydetme penceresini göster.
            sfd.ShowDialog();

            Kaydet(sfd.FileName);
        }

        private void mnuFarkliAc_Click(object sender, EventArgs e)
        {
            // Windows'un Dosya açma penceresi.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Açılacak Dosyayı Seçin";   // Pencere başlığı..

            // Dosya açma işleminin desteklediği dosya uzantıları. uzuntı|görünen ifade
            ofd.Filter = "Metin Belgesi(.txt)|*.txt|XML Dosya(.xml)|*.xml";
            // Dosya açma işleminin desteklediği dosya uzantılardan hangisi seçili gelsin.
            ofd.FilterIndex = 1;
            // Seçilen dosya varlığı kontrol edilir. Dosya adını elle yazıyorsak..
            ofd.CheckFileExists = true;

            // Dosya açma penceresini göster.
            ofd.ShowDialog();

            DosyaAc(ofd.FileName);
        }
    }
}
