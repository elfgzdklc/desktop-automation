using DershaneOtomasyonu.DAL;
using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DershaneOtomasyonu
{
    public partial class BasariListesi : Form
    {
        public BasariListesi()
        {
            InitializeComponent();
        }

        private void BasariListesi_Load(object sender, EventArgs e)
        {
            sinif_comboBox.Items.Clear();
            sinif_comboBox.Items.AddRange(SinifDAL.Listele().ToArray());
        }

        private void sinif_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_button.Enabled = true;
        }

        List<Ogrenci> Ogrenciler = OgrenciDAL.Listele();

        private void list_button_Click(object sender, EventArgs e)
        {
            ogr_listBox.Items.Clear();

            int _SeciliSinifID = (sinif_comboBox.SelectedItem as Sinif).ID; // comboboxta seçili item a sınıf şeklinde davrandık ve id sini aldık.

            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.SinifID == _SeciliSinifID)
                {
                    ogr_listBox.Items.Add(item);
                }
            }

            lbl_bilgi.Visible = true;
            lbl_bilgi.Text = sinif_comboBox.SelectedItem.ToString() + " sınıfındaki öğrenciler listelenmektedir.";
            
        }

        private void ogr_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci SeciliOgrenci = new Ogrenci();

            if (ogr_listBox.SelectedIndex != -1)
            {
                SeciliOgrenci = ogr_listBox.SelectedItem as Ogrenci;
            }

            List<Notlar> SeciliOgrenciNotlari = NotlarDAL.Listele();

            List<Notlar> SeciliOgrenciNotu = new List<Notlar>();

            foreach (Notlar item in SeciliOgrenciNotlari)
            {
                if (item.OgrenciID == SeciliOgrenci.ID)
                {
                    SeciliOgrenciNotu.Add(item);
                }
            }

            basariList_dataGridView.DataSource = SeciliOgrenciNotu;

            basariList_dataGridView.Columns[4].Visible = false;
            basariList_dataGridView.Columns[0].Visible = false;
        }

        private void BasariListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            AnaSayfa frm = new AnaSayfa();
            frm.Show();

        }
    }
}
