using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void KGiris()
        {
            Kullanicilar k = new Kullanicilar();

            try
            {
                k = KullanicilarDAL.KullanicilarKontrol(kAdi_textBox.Text, kSifre_textBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik veya yalnış bilgi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (k.ID != 0)
            {
                k.K_Adi = kAdi_textBox.Text;
                k.Sifre = kSifre_textBox.Text;

                KullaniciGiris frm1 = new KullaniciGiris();
                frm1.Close();
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Eksik veya yalnış bilgi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            KGiris();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programdan çıkmak istediğine emin misiniz?", "", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void kSifre_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
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
