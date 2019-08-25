using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }



        private void btn_ogrKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciKayit ogrenciKayıt = new OgrenciKayit();
            ogrenciKayıt.Show();

        }

        private void btn_ogrBilgi_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri();
            ogrenciBilgileri.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            KullaniciGiris frm1 = new KullaniciGiris();
            frm1.Show();
        }

        private void btn_notGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotGirisi notGiris = new NotGirisi();
            notGiris.Show();
        }

        private void btn_basariList_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasariListesi basariListesi = new BasariListesi();
            basariListesi.Show();
        }

        private void btn_persKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelKayit personelKayit = new PersonelKayit();
            personelKayit.Show();
        }

        private void btn_persBilgi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelBilgileri personelBilgileri = new PersonelBilgileri();
            personelBilgileri.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinifKaydet sinifKaydet = new SinifKaydet();
            sinifKaydet.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullaniciGiris frm1 = new KullaniciGiris();
            frm1.Show();
        }
    }
}
