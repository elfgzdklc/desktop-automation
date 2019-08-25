namespace DershaneOtomasyonu
{
    partial class PersonelBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.personel_dataGridView = new System.Windows.Forms.DataGridView();
            this.kayitGüncelle_button = new System.Windows.Forms.Button();
            this.pbilgileri_groupBox = new System.Windows.Forms.GroupBox();
            this.pozisyon_textBox = new System.Windows.Forms.TextBox();
            this.kSifre_textBox = new System.Windows.Forms.TextBox();
            this.kAdi_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telefon_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adres_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.soyadi_textBox = new System.Windows.Forms.TextBox();
            this.adi_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tckn_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kayitSil_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personel_dataGridView)).BeginInit();
            this.pbilgileri_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personel_dataGridView
            // 
            this.personel_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.personel_dataGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.personel_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personel_dataGridView.Location = new System.Drawing.Point(34, 59);
            this.personel_dataGridView.Name = "personel_dataGridView";
            this.personel_dataGridView.ReadOnly = true;
            this.personel_dataGridView.Size = new System.Drawing.Size(666, 150);
            this.personel_dataGridView.TabIndex = 16;
            this.personel_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personel_dataGridView_CellDoubleClick);
            // 
            // kayitGüncelle_button
            // 
            this.kayitGüncelle_button.BackColor = System.Drawing.Color.Teal;
            this.kayitGüncelle_button.Enabled = false;
            this.kayitGüncelle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitGüncelle_button.ForeColor = System.Drawing.Color.White;
            this.kayitGüncelle_button.Location = new System.Drawing.Point(571, 442);
            this.kayitGüncelle_button.Name = "kayitGüncelle_button";
            this.kayitGüncelle_button.Size = new System.Drawing.Size(129, 23);
            this.kayitGüncelle_button.TabIndex = 19;
            this.kayitGüncelle_button.Text = "Kayıt Güncelle";
            this.kayitGüncelle_button.UseVisualStyleBackColor = false;
            this.kayitGüncelle_button.Click += new System.EventHandler(this.kayitGüncelle_button_Click);
            // 
            // pbilgileri_groupBox
            // 
            this.pbilgileri_groupBox.Controls.Add(this.pozisyon_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.kSifre_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.kAdi_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.label8);
            this.pbilgileri_groupBox.Controls.Add(this.label2);
            this.pbilgileri_groupBox.Controls.Add(this.telefon_maskedTextBox);
            this.pbilgileri_groupBox.Controls.Add(this.adres_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.label14);
            this.pbilgileri_groupBox.Controls.Add(this.mail_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.soyadi_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.adi_textBox);
            this.pbilgileri_groupBox.Controls.Add(this.label7);
            this.pbilgileri_groupBox.Controls.Add(this.tckn_maskedTextBox);
            this.pbilgileri_groupBox.Controls.Add(this.label6);
            this.pbilgileri_groupBox.Controls.Add(this.label5);
            this.pbilgileri_groupBox.Controls.Add(this.label4);
            this.pbilgileri_groupBox.Controls.Add(this.label3);
            this.pbilgileri_groupBox.Controls.Add(this.label10);
            this.pbilgileri_groupBox.Enabled = false;
            this.pbilgileri_groupBox.ForeColor = System.Drawing.Color.White;
            this.pbilgileri_groupBox.Location = new System.Drawing.Point(34, 224);
            this.pbilgileri_groupBox.Name = "pbilgileri_groupBox";
            this.pbilgileri_groupBox.Size = new System.Drawing.Size(666, 189);
            this.pbilgileri_groupBox.TabIndex = 1;
            this.pbilgileri_groupBox.TabStop = false;
            this.pbilgileri_groupBox.Text = "Personel Bilgileri";
            // 
            // pozisyon_textBox
            // 
            this.pozisyon_textBox.Location = new System.Drawing.Point(155, 15);
            this.pozisyon_textBox.Name = "pozisyon_textBox";
            this.pozisyon_textBox.ReadOnly = true;
            this.pozisyon_textBox.Size = new System.Drawing.Size(141, 22);
            this.pozisyon_textBox.TabIndex = 10;
            // 
            // kSifre_textBox
            // 
            this.kSifre_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kSifre_textBox.Location = new System.Drawing.Point(461, 145);
            this.kSifre_textBox.Name = "kSifre_textBox";
            this.kSifre_textBox.Size = new System.Drawing.Size(141, 22);
            this.kSifre_textBox.TabIndex = 18;
            this.kSifre_textBox.Tag = "Şifre";
            this.toolTip1.SetToolTip(this.kSifre_textBox, "Sadece rakam girilebilir!");
            this.kSifre_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kSifre_textBox_KeyPress);
            // 
            // kAdi_textBox
            // 
            this.kAdi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kAdi_textBox.Location = new System.Drawing.Point(461, 117);
            this.kAdi_textBox.Name = "kAdi_textBox";
            this.kAdi_textBox.Size = new System.Drawing.Size(141, 22);
            this.kAdi_textBox.TabIndex = 17;
            this.kAdi_textBox.Tag = "Kullanıcı Adı";
            this.kAdi_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Şifresi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kullanıcı Adı : ";
            // 
            // telefon_maskedTextBox
            // 
            this.telefon_maskedTextBox.Location = new System.Drawing.Point(155, 145);
            this.telefon_maskedTextBox.Mask = "(999) 000-0000";
            this.telefon_maskedTextBox.Name = "telefon_maskedTextBox";
            this.telefon_maskedTextBox.Size = new System.Drawing.Size(141, 22);
            this.telefon_maskedTextBox.TabIndex = 14;
            this.telefon_maskedTextBox.Tag = "Telefon";
            // 
            // adres_textBox
            // 
            this.adres_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adres_textBox.Location = new System.Drawing.Point(461, 52);
            this.adres_textBox.Multiline = true;
            this.adres_textBox.Name = "adres_textBox";
            this.adres_textBox.Size = new System.Drawing.Size(141, 60);
            this.adres_textBox.TabIndex = 16;
            this.adres_textBox.Tag = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "TC : ";
            // 
            // mail_textBox
            // 
            this.mail_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mail_textBox.Location = new System.Drawing.Point(461, 15);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(141, 22);
            this.mail_textBox.TabIndex = 15;
            this.mail_textBox.Tag = "Mail";
            this.mail_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_textBox_KeyPress);
            // 
            // soyadi_textBox
            // 
            this.soyadi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyadi_textBox.Location = new System.Drawing.Point(155, 117);
            this.soyadi_textBox.Name = "soyadi_textBox";
            this.soyadi_textBox.Size = new System.Drawing.Size(141, 22);
            this.soyadi_textBox.TabIndex = 13;
            this.soyadi_textBox.Tag = "Soyadı";
            // 
            // adi_textBox
            // 
            this.adi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adi_textBox.Location = new System.Drawing.Point(155, 83);
            this.adi_textBox.Name = "adi_textBox";
            this.adi_textBox.Size = new System.Drawing.Size(141, 22);
            this.adi_textBox.TabIndex = 12;
            this.adi_textBox.Tag = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Adı :";
            // 
            // tckn_maskedTextBox
            // 
            this.tckn_maskedTextBox.Location = new System.Drawing.Point(155, 52);
            this.tckn_maskedTextBox.Mask = "00000000000";
            this.tckn_maskedTextBox.Name = "tckn_maskedTextBox";
            this.tckn_maskedTextBox.ReadOnly = true;
            this.tckn_maskedTextBox.Size = new System.Drawing.Size(141, 22);
            this.tckn_maskedTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyadı : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pozisyon : ";
            // 
            // kayitSil_button
            // 
            this.kayitSil_button.BackColor = System.Drawing.Color.Teal;
            this.kayitSil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitSil_button.ForeColor = System.Drawing.Color.White;
            this.kayitSil_button.Location = new System.Drawing.Point(34, 442);
            this.kayitSil_button.Name = "kayitSil_button";
            this.kayitSil_button.Size = new System.Drawing.Size(143, 23);
            this.kayitSil_button.TabIndex = 22;
            this.kayitSil_button.Text = "Kayıt Sil";
            this.kayitSil_button.UseVisualStyleBackColor = false;
            this.kayitSil_button.Click += new System.EventHandler(this.kayitSil_button_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "...";
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(729, 488);
            this.Controls.Add(this.kayitSil_button);
            this.Controls.Add(this.personel_dataGridView);
            this.Controls.Add(this.kayitGüncelle_button);
            this.Controls.Add(this.pbilgileri_groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonelBilgileri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelBilgileri_FormClosing);
            this.Load += new System.EventHandler(this.PersonelBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personel_dataGridView)).EndInit();
            this.pbilgileri_groupBox.ResumeLayout(false);
            this.pbilgileri_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView personel_dataGridView;
        private System.Windows.Forms.Button kayitGüncelle_button;
        private System.Windows.Forms.GroupBox pbilgileri_groupBox;
        private System.Windows.Forms.MaskedTextBox telefon_maskedTextBox;
        private System.Windows.Forms.TextBox adres_textBox;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox adi_textBox;
        private System.Windows.Forms.MaskedTextBox tckn_maskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox soyadi_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kSifre_textBox;
        private System.Windows.Forms.TextBox kAdi_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pozisyon_textBox;
        private System.Windows.Forms.Button kayitSil_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}