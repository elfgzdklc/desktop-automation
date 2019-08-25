using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }      

        private int SeciliSatirIDKolonu()
        {
            if (personel_dataGridView.SelectedCells.Count > 0)
            {
                int satirNo = personel_dataGridView.SelectedCells[0].RowIndex;

                return Convert.ToInt32(personel_dataGridView.Rows[satirNo].Cells["ID"].Value);
            }
            return 0;
        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            
            personel_dataGridView.DataSource = KullanicilarDAL.Listele().ToArray();

            personel_dataGridView.Columns["K_Adi"].HeaderText = "Kullanıcı Adı";
            personel_dataGridView.Columns["Sifre"].HeaderText = "Kullanıcı Şifre";
            personel_dataGridView.Columns["Gorev"].HeaderText = "Görevi";
            personel_dataGridView.Columns["Adi"].HeaderText = "Adı";
            personel_dataGridView.Columns["Soyadi"].HeaderText = "Soyadı";
        }

        private void personel_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pbilgileri_groupBox.Enabled = true;
            kayitGüncelle_button.Enabled = true;

            Kullanicilar k = KullanicilarDAL.ID(SeciliSatirIDKolonu());

            pozisyon_textBox.Text = k.Gorev;
            tckn_maskedTextBox.Text = Convert.ToString(k.TCKN);
            adi_textBox.Text = k.Adi;
            soyadi_textBox.Text = k.Soyadi;
            telefon_maskedTextBox.Text = k.Telefon;
            mail_textBox.Text = k.Mail;
            adres_textBox.Text = k.Adres;
            kAdi_textBox.Text = k.K_Adi;
            kSifre_textBox.Text = k.Sifre;
        }

        private void KullaniciGuncel()
        {
            Kullanicilar k = KullanicilarDAL.ID(SeciliSatirIDKolonu());            

            k.Adi = adi_textBox.Text;
            k.Soyadi = soyadi_textBox.Text;
            k.Telefon = telefon_maskedTextBox.Text;
            k.Mail = mail_textBox.Text;
            k.Adres = adres_textBox.Text;
            k.K_Adi = kAdi_textBox.Text==string.Empty?k.K_Adi:(kAdi_textBox.Text);
            k.Sifre = kSifre_textBox.Text == string.Empty ? k.Sifre : (kSifre_textBox.Text);

            KullanicilarDAL.KullanicilarGuncelle(k);

            MessageBox.Show("Kullanıcı başarı ile güncellendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (true)
            {
                this.Close();
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
            }
            
        }
        private void kayitGüncelle_button_Click(object sender, EventArgs e)
        {
            if (KullanicilarDAL.KullaniciAdiKontrol(kAdi_textBox.Text))
            {
                MessageBox.Show("Kullanıcı adını değiştirmek istemiyorsanız kutucuğu boş bırakarak ilerleyiniz. İlk hali geçerli olacaktır.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı sistemde mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kAdi_textBox.Text = "";
                return;
            }

            #region BOŞ MU KONTROLLERİ


            if (adi_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (soyadi_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (telefon_maskedTextBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mail_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (adres_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            #endregion

            KullaniciGuncel();
        }

        private void kayitSil_button_Click(object sender, EventArgs e)
        {
            Kullanicilar k = KullanicilarDAL.ID(SeciliSatirIDKolonu());

            if (k.ID == 0) return;

            if (MessageBox.Show(k.Adi + " " + k.Soyadi + " adlı kullanıcıyı silmek istediğinize emin misiniz?", "KULLANICI SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                KullanicilarDAL.KullanicilarSil(k);
                MessageBox.Show(k.Adi + " " + k.Soyadi + " adlı Kullanıcı sistemden silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personel_dataGridView.DataSource = KullanicilarDAL.Listele().ToArray();
            }
        }

        private void PersonelBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
        }

        private void kSifre_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

