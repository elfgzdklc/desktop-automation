using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        private void PersonelKaydet()
        {
            Kullanicilar kln = new Kullanicilar()
            {
                Gorev = gorev_comboBox.GetItemText(gorev_comboBox.SelectedItem),
                TCKN = Convert.ToDecimal(tc_textBox.Text),
                Adi = Adi_textBox.Text,
                Soyadi = soyadi_textBox.Text,
                Mail = mail_textBox.Text,
                Telefon = telefon_maskedTextBox.Text,
                Adres = adres_textBox.Text,
                K_Adi = kAdi_textBox.Text,
                Sifre = kSifre_textBox.Text
            };
            KullanicilarDAL.KullanicilarEkle(kln);
            MessageBox.Show("Kullanıcı başarı ile kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (true)
            {
                this.Hide();
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
            }
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (KullanicilarDAL.KullaniciAdiKontrol(kAdi_textBox.Text))
            {
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı sistemde mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kAdi_textBox.Text = "";
                return;
            }
            if (tc_textBox.Text != string.Empty && KullanicilarDAL.KullaniciTCKontrol(Convert.ToDecimal(tc_textBox.Text)))
            {
                MessageBox.Show("Girmiş olduğunuz TC kimlik numarası sistemde mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tc_textBox.Text = "";
                return;
            }
            try
            {
                int uzunluk = tc_textBox.Text.Length;
                if (uzunluk == 11)
                {
                    PersonelKaydet();
                }
                else
                {
                    MessageBox.Show("TC alanını eksik bıraktınız. Lütfen doldurun.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sizden istenen tüm eksik alanları doldurun!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ana_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            if (tc_textBox.Text != string.Empty || Adi_textBox.Text != string.Empty || soyadi_textBox.Text != string.Empty)
            {
                DialogResult dr = MessageBox.Show("Kayıt yapılmadan çıkılsın mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kayda devam ediliyor.");
                }
            }

            else
            {
                this.Hide();
                frm.Show();
            }

        }

        private void PersonelKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            if (tc_textBox.Text != string.Empty || Adi_textBox.Text != string.Empty || soyadi_textBox.Text != string.Empty)
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

        private void tc_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kAdi_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);//boşluk engelleme
        }

        
    }
}
