namespace DershaneOtomasyonu
{
    partial class NotGirisi
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
            this.ogrGetir_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sinavBilgi_groupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sinav_comboBox = new System.Windows.Forms.ComboBox();
            this.kayit_button = new System.Windows.Forms.Button();
            this.sinavPuan_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sinavTarih_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soyadi_textBox = new System.Windows.Forms.TextBox();
            this.adi_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_textBox = new System.Windows.Forms.TextBox();
            this.sinavBilgi_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrGetir_button
            // 
            this.ogrGetir_button.BackColor = System.Drawing.Color.Teal;
            this.ogrGetir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrGetir_button.Location = new System.Drawing.Point(330, 91);
            this.ogrGetir_button.Name = "ogrGetir_button";
            this.ogrGetir_button.Size = new System.Drawing.Size(137, 23);
            this.ogrGetir_button.TabIndex = 6;
            this.ogrGetir_button.Text = "Öğrenciyi Getir";
            this.ogrGetir_button.UseVisualStyleBackColor = false;
            this.ogrGetir_button.Click += new System.EventHandler(this.ogrGetir_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TC : ";
            // 
            // sinavBilgi_groupBox
            // 
            this.sinavBilgi_groupBox.Controls.Add(this.label6);
            this.sinavBilgi_groupBox.Controls.Add(this.sinav_comboBox);
            this.sinavBilgi_groupBox.Controls.Add(this.kayit_button);
            this.sinavBilgi_groupBox.Controls.Add(this.sinavPuan_maskedTextBox);
            this.sinavBilgi_groupBox.Controls.Add(this.sinavTarih_dateTimePicker);
            this.sinavBilgi_groupBox.Controls.Add(this.soyadi_textBox);
            this.sinavBilgi_groupBox.Controls.Add(this.adi_textBox);
            this.sinavBilgi_groupBox.Controls.Add(this.label5);
            this.sinavBilgi_groupBox.Controls.Add(this.label3);
            this.sinavBilgi_groupBox.Controls.Add(this.label2);
            this.sinavBilgi_groupBox.Controls.Add(this.label1);
            this.sinavBilgi_groupBox.ForeColor = System.Drawing.Color.White;
            this.sinavBilgi_groupBox.Location = new System.Drawing.Point(30, 150);
            this.sinavBilgi_groupBox.Name = "sinavBilgi_groupBox";
            this.sinavBilgi_groupBox.Size = new System.Drawing.Size(666, 281);
            this.sinavBilgi_groupBox.TabIndex = 15;
            this.sinavBilgi_groupBox.TabStop = false;
            this.sinavBilgi_groupBox.Text = "Sınav Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mevcut Sınavın Adı :";
            // 
            // sinav_comboBox
            // 
            this.sinav_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinav_comboBox.FormattingEnabled = true;
            this.sinav_comboBox.Items.AddRange(new object[] {
            "YGS",
            "LYS1(Matematik)",
            "LYS2(Fen Bilimleri)",
            "LYS3(Edebiyat-Coğrafya)",
            "LYS4(Sosyal Bilimler)",
            "LYS5(Yabancı Dil)"});
            this.sinav_comboBox.Location = new System.Drawing.Point(286, 195);
            this.sinav_comboBox.Name = "sinav_comboBox";
            this.sinav_comboBox.Size = new System.Drawing.Size(151, 21);
            this.sinav_comboBox.TabIndex = 17;
            // 
            // kayit_button
            // 
            this.kayit_button.BackColor = System.Drawing.Color.Teal;
            this.kayit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_button.Location = new System.Drawing.Point(402, 223);
            this.kayit_button.Name = "kayit_button";
            this.kayit_button.Size = new System.Drawing.Size(92, 23);
            this.kayit_button.TabIndex = 16;
            this.kayit_button.Text = "Kaydet";
            this.kayit_button.UseVisualStyleBackColor = false;
            this.kayit_button.Click += new System.EventHandler(this.kayit_button_Click);
            // 
            // sinavPuan_maskedTextBox
            // 
            this.sinavPuan_maskedTextBox.Location = new System.Drawing.Point(286, 167);
            this.sinavPuan_maskedTextBox.Mask = "000.000";
            this.sinavPuan_maskedTextBox.Name = "sinavPuan_maskedTextBox";
            this.sinavPuan_maskedTextBox.Size = new System.Drawing.Size(76, 22);
            this.sinavPuan_maskedTextBox.TabIndex = 23;
            // 
            // sinavTarih_dateTimePicker
            // 
            this.sinavTarih_dateTimePicker.Location = new System.Drawing.Point(286, 127);
            this.sinavTarih_dateTimePicker.Name = "sinavTarih_dateTimePicker";
            this.sinavTarih_dateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.sinavTarih_dateTimePicker.TabIndex = 22;
            // 
            // soyadi_textBox
            // 
            this.soyadi_textBox.Location = new System.Drawing.Point(286, 84);
            this.soyadi_textBox.Name = "soyadi_textBox";
            this.soyadi_textBox.ReadOnly = true;
            this.soyadi_textBox.Size = new System.Drawing.Size(151, 22);
            this.soyadi_textBox.TabIndex = 21;
            // 
            // adi_textBox
            // 
            this.adi_textBox.Location = new System.Drawing.Point(286, 42);
            this.adi_textBox.Name = "adi_textBox";
            this.adi_textBox.ReadOnly = true;
            this.adi_textBox.Size = new System.Drawing.Size(151, 22);
            this.adi_textBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Girmiş Olduğu Sınav Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mevcut Sınava Ait Puanı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adı : ";
            // 
            // tc_textBox
            // 
            this.tc_textBox.Location = new System.Drawing.Point(330, 53);
            this.tc_textBox.MaxLength = 11;
            this.tc_textBox.Name = "tc_textBox";
            this.tc_textBox.Size = new System.Drawing.Size(137, 22);
            this.tc_textBox.TabIndex = 16;
            this.tc_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // NotGirisi
            // 
            this.AcceptButton = this.ogrGetir_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(729, 488);
            this.Controls.Add(this.tc_textBox);
            this.Controls.Add(this.sinavBilgi_groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrGetir_button);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NotGirisi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotGirisi_FormClosing);
            this.Load += new System.EventHandler(this.NotGirisi_Load);
            this.sinavBilgi_groupBox.ResumeLayout(false);
            this.sinavBilgi_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ogrGetir_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox sinavBilgi_groupBox;
        private System.Windows.Forms.Button kayit_button;
        private System.Windows.Forms.MaskedTextBox sinavPuan_maskedTextBox;
        private System.Windows.Forms.DateTimePicker sinavTarih_dateTimePicker;
        private System.Windows.Forms.TextBox soyadi_textBox;
        private System.Windows.Forms.TextBox adi_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sinav_comboBox;
    }
}