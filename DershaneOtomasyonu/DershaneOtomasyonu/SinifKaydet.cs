using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class SinifKaydet : Form
    {
        public SinifKaydet()
        {
            InitializeComponent();
        }

        private void btn_sinifKaydet_Click(object sender, EventArgs e)
        {
            if (SinifDAL.SinifKontrol(txt_sinif.Text, txt_bolum.Text, txt_sube.Text))
            {
                MessageBox.Show("Girmiş olduğunuz Sınıf sistemde mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_bolum.Text = "";
                txt_sinif.Text = "";
                txt_sube.Text = "";
                return;
            }
            SinifKayit();
            SinifGetir();
        }

        private void SinifKayit()
        {
            if (txt_sinif.Text != "" & txt_sube.Text != "" & txt_bolum.Text != "")
            {

                Sinif snf = new Sinif()
                {
                    SinifDurumu = txt_sinif.Text,
                    SubeAdi = txt_sube.Text,
                    BolumAdi = txt_bolum.Text
                };
                DialogResult dr = MessageBox.Show("Sınıf Kaydedilsin mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SinifDAL.SinifEkle(snf);
                    MessageBox.Show("Sınıf başarı ile kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    txt_bolum.Text = "";
                    txt_sinif.Text = "";
                    txt_sube.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Eksik Alanları Lütfen Doldurun!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SinifGetir()
        {
            sinif_dataGridView.DataSource = SinifDAL.Listele().ToArray();
        }

        private void SinifKaydet_Load(object sender, EventArgs e)
        {
            SinifGetir();
            sinif_dataGridView.Columns["SubeAdi"].HeaderText = "Şube Adı";
            sinif_dataGridView.Columns["BolumAdi"].HeaderText = "Bölüm Adı";
            sinif_dataGridView.Columns["SinifDurumu"].HeaderText = "Sınıf Adı";
        }

        private int SeciliSatirIDKolonu()
        {
            if (sinif_dataGridView.SelectedCells.Count > 0)
            {
                int satirNo = sinif_dataGridView.SelectedCells[0].RowIndex;

                return Convert.ToInt32(sinif_dataGridView.Rows[satirNo].Cells["ID"].Value);
            }
            return 0;
        }
        private void btn_sinifSil_Click(object sender, EventArgs e)
        {
            Sinif snf = SinifDAL.ID(SeciliSatirIDKolonu());

            if (snf.ID == 0) return;
            try
            {

                if (MessageBox.Show(snf.SinifDurumu + " " + snf.BolumAdi + " " + snf.SubeAdi + " sınıfını silmek istediğinize emin misiniz?", "SINIF SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SinifDAL.SinifSil(snf);
                    MessageBox.Show(snf.SinifDurumu + " " + snf.BolumAdi + " " + snf.SubeAdi + " sınıfı başarı ile silinmiştir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sinif_dataGridView.DataSource = SinifDAL.Listele().ToArray();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silmek istediğiniz sınıf mevcut öğrencilerin kayıtlı olduğu sınıftır. SİLİNEMEZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SinifKaydet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
        }
    }
}

