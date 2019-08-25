using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class NotGirisi : Form
    {
        public NotGirisi()
        {
            InitializeComponent();
        }

        List<Ogrenci> Ogrenciler = OgrenciDAL.Listele();

        private void OgrGetir()
        {
            if (tc_textBox.Text != string.Empty)
            {
                foreach (Ogrenci itemOgrenci in Ogrenciler)
                {
                    if (itemOgrenci.TCKN.ToString().Contains(tc_textBox.Text))
                    {
                        adi_textBox.Text = itemOgrenci.Adi;
                        soyadi_textBox.Text = itemOgrenci.Soyadi;
                    }
                    sinavBilgi_groupBox.Enabled = true;
                }
                if (!OgrenciDAL.OgrenciTCKontrol(Convert.ToDecimal(tc_textBox.Text)))
                {
                    MessageBox.Show("Girilen TC numarası sistemde kayıtlı değildir.");
                    adi_textBox.Text = "";
                    soyadi_textBox.Text = "";
                    sinavTarih_dateTimePicker.Value = DateTime.Now;
                    sinavPuan_maskedTextBox.Text = "";
                    sinav_comboBox.SelectedText = "";
                    sinavBilgi_groupBox.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Öğrenci TC alanı boş geçilemez");
            }
        }

        private void ogrGetir_button_Click(object sender, EventArgs e)
        {
            int uzunluk = tc_textBox.Text.Length;
            if (uzunluk == 11)
            {
                OgrGetir();
            }
            else
            {
                MessageBox.Show("TC alanını eksik veya yalnış girdiniz. Lütfen kontrol edip tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NotKayit()
        {

            foreach (Ogrenci itemOgrenci in Ogrenciler)
            {

                if (itemOgrenci.TCKN.ToString().Contains(tc_textBox.Text))
                {
                    Notlar nt = new Notlar()
                    {
                        SinavTarihi = sinavTarih_dateTimePicker.Value.Date,
                        Notu = Convert.ToDecimal(sinavPuan_maskedTextBox.Text),
                        OgrenciID = itemOgrenci.ID,
                        SinavAdi = sinav_comboBox.SelectedItem.ToString()

                    };
                    NotlarDAL.NotlarEkle(nt);
                }
            }

            MessageBox.Show("Öğrencinin notu başarı ile kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (true)
            {
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
                this.Hide();
            }

        }

        private void kayit_button_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = Convert.ToDouble(sinavPuan_maskedTextBox.Text);
                if (sinavPuan_maskedTextBox.Text != string.Empty && sayi > 500)
                {
                    MessageBox.Show("Sınav notu 500,000'dan daha büyük girilemez!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NotKayit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sizden istenen tüm eksik alanları doldurun!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NotGirisi_Load(object sender, EventArgs e)
        {

            sinavBilgi_groupBox.Enabled = false;
        }

        private void NotGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();

            if (tc_textBox.Text != string.Empty || adi_textBox.Text != string.Empty || soyadi_textBox.Text != string.Empty)
            {
                DialogResult dr = MessageBox.Show("Kayıt yapılmadan çıkılsın mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    frm.Show();

                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("Kayda devam ediliyor.");
                    e.Cancel = true; //kapatma işleminin iptali
                }
            }

            else
            {
                this.Hide();
                frm.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)//ASCII tablosunundan
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
    }
}
