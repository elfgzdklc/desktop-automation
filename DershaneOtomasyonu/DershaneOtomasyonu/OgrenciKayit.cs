using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKaydet()
        {
            Ogrenci ogr = new Ogrenci()
            {
                TCKN = Convert.ToDecimal(tc_textBox.Text),
                Adi = adi_textBox.Text,
                Soyadi = soyadi_textBox.Text,
                Mail = mail_textBox.Text,
                Telefon = telefon_maskedTextBox.Text,
                Adres = adres_textBox.Text,
                VeliAdi = veliAdi_textBox.Text,
                VeliTelefonu = veliTelefonu_maskedTextBox.Text,
                //SinifID = Convert.ToInt32(sinif_comboBox.SelectedItem)
                SinifID = (sinif_comboBox.SelectedItem as Sinif).ID
            };

            OgrenciDAL.OgrenciEkle(ogr);

            MessageBox.Show("Öğrenci başarı ile kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (true)
            {
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
                this.Hide();
            }
        }
        private void anaSayfa_button_Click(object sender, EventArgs e)
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

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            if (tc_textBox.Text != string.Empty && OgrenciDAL.OgrenciTCKontrol(Convert.ToDecimal(tc_textBox.Text)))
            {
                MessageBox.Show("Girmiş olduğunuz TC kimlik numarası sistemde mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int uzunluk = tc_textBox.Text.Length;
                if (uzunluk == 11)
                {
                    OgrenciKaydet();
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

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            sinif_comboBox.Items.Clear();
            sinif_comboBox.Items.AddRange(SinifDAL.Listele().ToArray());
        }

        private void OgrenciKayit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void mail_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }
}
