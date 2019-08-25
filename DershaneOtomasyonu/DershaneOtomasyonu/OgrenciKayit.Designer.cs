namespace DershaneOtomasyonu
{
    partial class OgrenciKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tc_textBox = new System.Windows.Forms.TextBox();
            this.sinif_comboBox = new System.Windows.Forms.ComboBox();
            this.kaydet_button = new System.Windows.Forms.Button();
            this.anaSayfa_button = new System.Windows.Forms.Button();
            this.veliTelefonu_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefon_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.veliAdi_textBox = new System.Windows.Forms.TextBox();
            this.adres_textBox = new System.Windows.Forms.TextBox();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.soyadi_textBox = new System.Windows.Forms.TextBox();
            this.adi_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tc_textBox);
            this.groupBox1.Controls.Add(this.sinif_comboBox);
            this.groupBox1.Controls.Add(this.kaydet_button);
            this.groupBox1.Controls.Add(this.anaSayfa_button);
            this.groupBox1.Controls.Add(this.veliTelefonu_maskedTextBox);
            this.groupBox1.Controls.Add(this.telefon_maskedTextBox);
            this.groupBox1.Controls.Add(this.veliAdi_textBox);
            this.groupBox1.Controls.Add(this.adres_textBox);
            this.groupBox1.Controls.Add(this.mail_textBox);
            this.groupBox1.Controls.Add(this.soyadi_textBox);
            this.groupBox1.Controls.Add(this.adi_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt";
            // 
            // tc_textBox
            // 
            this.tc_textBox.Location = new System.Drawing.Point(115, 43);
            this.tc_textBox.MaxLength = 11;
            this.tc_textBox.Name = "tc_textBox";
            this.tc_textBox.Size = new System.Drawing.Size(141, 22);
            this.tc_textBox.TabIndex = 1;
            this.tc_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_textBox_KeyPress);
            // 
            // sinif_comboBox
            // 
            this.sinif_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinif_comboBox.FormattingEnabled = true;
            this.sinif_comboBox.Location = new System.Drawing.Point(115, 135);
            this.sinif_comboBox.Name = "sinif_comboBox";
            this.sinif_comboBox.Size = new System.Drawing.Size(141, 21);
            this.sinif_comboBox.TabIndex = 4;
            // 
            // kaydet_button
            // 
            this.kaydet_button.BackColor = System.Drawing.Color.Teal;
            this.kaydet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydet_button.Location = new System.Drawing.Point(148, 387);
            this.kaydet_button.Name = "kaydet_button";
            this.kaydet_button.Size = new System.Drawing.Size(108, 23);
            this.kaydet_button.TabIndex = 9;
            this.kaydet_button.Text = "Kaydet";
            this.kaydet_button.UseVisualStyleBackColor = false;
            this.kaydet_button.Click += new System.EventHandler(this.kaydet_button_Click);
            // 
            // anaSayfa_button
            // 
            this.anaSayfa_button.BackColor = System.Drawing.Color.Teal;
            this.anaSayfa_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfa_button.Location = new System.Drawing.Point(21, 387);
            this.anaSayfa_button.Name = "anaSayfa_button";
            this.anaSayfa_button.Size = new System.Drawing.Size(108, 23);
            this.anaSayfa_button.TabIndex = 10;
            this.anaSayfa_button.Text = "Ana Sayfa";
            this.anaSayfa_button.UseVisualStyleBackColor = false;
            this.anaSayfa_button.Click += new System.EventHandler(this.anaSayfa_button_Click);
            // 
            // veliTelefonu_maskedTextBox
            // 
            this.veliTelefonu_maskedTextBox.Location = new System.Drawing.Point(115, 331);
            this.veliTelefonu_maskedTextBox.Mask = "(999) 000-0000";
            this.veliTelefonu_maskedTextBox.Name = "veliTelefonu_maskedTextBox";
            this.veliTelefonu_maskedTextBox.Size = new System.Drawing.Size(141, 22);
            this.veliTelefonu_maskedTextBox.TabIndex = 8;
            // 
            // telefon_maskedTextBox
            // 
            this.telefon_maskedTextBox.Location = new System.Drawing.Point(115, 165);
            this.telefon_maskedTextBox.Mask = "(999) 000-0000";
            this.telefon_maskedTextBox.Name = "telefon_maskedTextBox";
            this.telefon_maskedTextBox.Size = new System.Drawing.Size(141, 22);
            this.telefon_maskedTextBox.TabIndex = 5;
            // 
            // veliAdi_textBox
            // 
            this.veliAdi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.veliAdi_textBox.Location = new System.Drawing.Point(115, 303);
            this.veliAdi_textBox.Name = "veliAdi_textBox";
            this.veliAdi_textBox.Size = new System.Drawing.Size(141, 22);
            this.veliAdi_textBox.TabIndex = 7;
            // 
            // adres_textBox
            // 
            this.adres_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adres_textBox.Location = new System.Drawing.Point(115, 232);
            this.adres_textBox.Multiline = true;
            this.adres_textBox.Name = "adres_textBox";
            this.adres_textBox.Size = new System.Drawing.Size(141, 60);
            this.adres_textBox.TabIndex = 6;
            // 
            // mail_textBox
            // 
            this.mail_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mail_textBox.Location = new System.Drawing.Point(115, 194);
            this.mail_textBox.MaxLength = 23456;
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(141, 22);
            this.mail_textBox.TabIndex = 5;
            this.mail_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mail_textBox_KeyPress);
            // 
            // soyadi_textBox
            // 
            this.soyadi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyadi_textBox.Location = new System.Drawing.Point(115, 107);
            this.soyadi_textBox.Name = "soyadi_textBox";
            this.soyadi_textBox.Size = new System.Drawing.Size(141, 22);
            this.soyadi_textBox.TabIndex = 3;
            // 
            // adi_textBox
            // 
            this.adi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adi_textBox.Location = new System.Drawing.Point(115, 75);
            this.adi_textBox.Name = "adi_textBox";
            this.adi_textBox.Size = new System.Drawing.Size(141, 22);
            this.adi_textBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Veli Telefonu : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Veli Adı Soyadı: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sınıfı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC : ";
            // 
            // OgrenciKayit
            // 
            this.AcceptButton = this.kaydet_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(362, 488);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgrenciKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgrenciKayit_FormClosing);
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kaydet_button;
        private System.Windows.Forms.Button anaSayfa_button;
        private System.Windows.Forms.MaskedTextBox veliTelefonu_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefon_maskedTextBox;
        private System.Windows.Forms.TextBox veliAdi_textBox;
        private System.Windows.Forms.TextBox adres_textBox;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox soyadi_textBox;
        private System.Windows.Forms.TextBox adi_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sinif_comboBox;
        private System.Windows.Forms.TextBox tc_textBox;
    }
}