using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class OgrenciBilgileri : Form
    {
        public OgrenciBilgileri()
        {
            InitializeComponent();
        }

        private int SeciliSatirIDKolonu()
        {
            if (ogrBilgi_dataGridView.SelectedCells.Count > 0)
            {
                int satirNo = ogrBilgi_dataGridView.SelectedCells[0].RowIndex;

                return Convert.ToInt32(ogrBilgi_dataGridView.Rows[satirNo].Cells["ID"].Value);
            }
            return 0;
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            ogrBilgi_dataGridView.DataSource = OgrenciDAL.Listele().ToArray();
        }

        private void ogrBilgi_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ogBilgi_groupBox.Enabled = true;
            kayitGüncelle_button.Enabled = true;

            Ogrenci ogr = OgrenciDAL.ID(SeciliSatirIDKolonu());

            tckn_maskedTextBox.Text = Convert.ToString(ogr.TCKN);
            adi_textBox.Text = ogr.Adi;
            soyadi_textBox.Text = ogr.Soyadi;
            telefon_maskedTextBox.Text = ogr.Telefon;
            mail_textBox.Text = ogr.Mail;
            adres_textBox.Text = ogr.Adres;
            veliAdi_textBox.Text = ogr.VeliAdi;
            veliTelefonu_maskedTextBox.Text = ogr.Telefon;
            sinif_comboBox.Items.Clear();
            sinif_comboBox.Items.AddRange(SinifDAL.Listele().ToArray());
        }

        private void OgrenciGuncelle()
        {
            Ogrenci ogr = OgrenciDAL.ID(SeciliSatirIDKolonu());

            ogr.Adi = adi_textBox.Text;
            ogr.Soyadi = soyadi_textBox.Text;
            ogr.Telefon = telefon_maskedTextBox.Text;
            ogr.Mail = mail_textBox.Text;
            ogr.Adres = adres_textBox.Text;
            ogr.VeliAdi = veliAdi_textBox.Text;
            ogr.VeliTelefonu = veliTelefonu_maskedTextBox.Text;
            ogr.SinifID = (sinif_comboBox.SelectedItem as Sinif).ID;

            OgrenciDAL.OgrenciGuncelle(ogr);

            MessageBox.Show("Öğrenci başarı ile güncellendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (true)
            {
                this.Close();
                AnaSayfa frm2 = new AnaSayfa();
                frm2.Show();
            }
        }

        private void kayitSil_button_Click(object sender, EventArgs e)
        {

            Ogrenci ogr = OgrenciDAL.ID(SeciliSatirIDKolonu());

            List<Notlar> SeciliOgrenciNotlari = NotlarDAL.Listele();
            List<Notlar> SeciliOgrenciNotu = new List<Notlar>();

            foreach (Notlar item in SeciliOgrenciNotlari)
            {
                if (item.OgrenciID == ogr.ID)
                {
                    SeciliOgrenciNotu.Add(item);
                    NotlarDAL.NotlarSil(item);
                }
                
            }
           

            if (ogr.ID == 0) return;

            if (MessageBox.Show(ogr.Adi + " " + ogr.Soyadi + " adlı öğrenciyi silmek istediğinize emin misiniz?", "ÖĞRENCİ SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                OgrenciDAL.OgrenciSil(ogr);

                MessageBox.Show(ogr.Adi + " " + ogr.Soyadi + " adlı öğrenci sistemden silinmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ogrBilgi_dataGridView.DataSource = OgrenciDAL.Listele().ToArray();
            }
        }

        private void kayitGüncelle_button_Click(object sender, EventArgs e)
        {
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
            if (adres_textBox.Text == string.Empty & veliAdi_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (veliAdi_textBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (veliTelefonu_maskedTextBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sinif_comboBox.Text == string.Empty)
            {
                MessageBox.Show("Hiç bir alan boş geçilemez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            OgrenciGuncelle();
        }

        private void OgrenciBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
        }

        private void mail_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);//boşluk engelleme
        }
    }
}
