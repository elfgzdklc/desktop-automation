namespace DershaneOtomasyonu
{
    partial class PersonelKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kAdi_textBox = new System.Windows.Forms.TextBox();
            this.tc_textBox = new System.Windows.Forms.TextBox();
            this.kSifre_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gorev_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ana = new System.Windows.Forms.Button();
            this.telefon_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adres_textBox = new System.Windows.Forms.TextBox();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.soyadi_textBox = new System.Windows.Forms.TextBox();
            this.Adi_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kAdi_textBox);
            this.groupBox1.Controls.Add(this.tc_textBox);
            this.groupBox1.Controls.Add(this.kSifre_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gorev_comboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_ana);
            this.groupBox1.Controls.Add(this.telefon_maskedTextBox);
            this.groupBox1.Controls.Add(this.adres_textBox);
            this.groupBox1.Controls.Add(this.mail_textBox);
            this.groupBox1.Controls.Add(this.soyadi_textBox);
            this.groupBox1.Controls.Add(this.Adi_textBox);
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
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // kAdi_textBox
            // 
            this.kAdi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kAdi_textBox.Location = new System.Drawing.Point(119, 300);
            this.kAdi_textBox.Name = "kAdi_textBox";
            this.kAdi_textBox.Size = new System.Drawing.Size(141, 22);
            this.kAdi_textBox.TabIndex = 8;
            this.kAdi_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_textBox_KeyPress);
            // 
            // tc_textBox
            // 
            this.tc_textBox.Location = new System.Drawing.Point(119, 74);
            this.tc_textBox.MaxLength = 11;
            this.tc_textBox.Name = "tc_textBox";
            this.tc_textBox.Size = new System.Drawing.Size(141, 22);
            this.tc_textBox.TabIndex = 2;
            this.tc_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_textBox_KeyPress);
            // 
            // kSifre_textBox
            // 
            this.kSifre_textBox.Location = new System.Drawing.Point(119, 325);
            this.kSifre_textBox.Name = "kSifre_textBox";
            this.kSifre_textBox.Size = new System.Drawing.Size(141, 22);
            this.kSifre_textBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.kSifre_textBox, "Sadece rakam girilebilir!");
            this.kSifre_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Şifresi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Kullanıcı Adı : ";
            // 
            // gorev_comboBox
            // 
            this.gorev_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gorev_comboBox.FormattingEnabled = true;
            this.gorev_comboBox.Items.AddRange(new object[] {
            "Öğretmen",
            "Yönetici",
            "Sekreter"});
            this.gorev_comboBox.Location = new System.Drawing.Point(119, 40);
            this.gorev_comboBox.Name = "gorev_comboBox";
            this.gorev_comboBox.Size = new System.Drawing.Size(141, 21);
            this.gorev_comboBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Görevi : ";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Teal;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Location = new System.Drawing.Point(152, 387);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(108, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ana
            // 
            this.btn_ana.BackColor = System.Drawing.Color.Teal;
            this.btn_ana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ana.Location = new System.Drawing.Point(25, 387);
            this.btn_ana.Name = "btn_ana";
            this.btn_ana.Size = new System.Drawing.Size(108, 23);
            this.btn_ana.TabIndex = 11;
            this.btn_ana.Text = "Ana Sayfa";
            this.btn_ana.UseVisualStyleBackColor = false;
            this.btn_ana.Click += new System.EventHandler(this.btn_ana_Click);
            // 
            // telefon_maskedTextBox
            // 
            this.telefon_maskedTextBox.Location = new System.Drawing.Point(119, 168);
            this.telefon_maskedTextBox.Mask = "(999) 000-0000";
            this.telefon_maskedTextBox.Name = "telefon_maskedTextBox";
            this.telefon_maskedTextBox.Size = new System.Drawing.Size(141, 22);
            this.telefon_maskedTextBox.TabIndex = 5;
            // 
            // adres_textBox
            // 
            this.adres_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adres_textBox.Location = new System.Drawing.Point(119, 231);
            this.adres_textBox.Multiline = true;
            this.adres_textBox.Name = "adres_textBox";
            this.adres_textBox.Size = new System.Drawing.Size(141, 60);
            this.adres_textBox.TabIndex = 7;
            // 
            // mail_textBox
            // 
            this.mail_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mail_textBox.Location = new System.Drawing.Point(119, 197);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(141, 22);
            this.mail_textBox.TabIndex = 6;
            // 
            // soyadi_textBox
            // 
            this.soyadi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyadi_textBox.Location = new System.Drawing.Point(119, 135);
            this.soyadi_textBox.Name = "soyadi_textBox";
            this.soyadi_textBox.Size = new System.Drawing.Size(141, 22);
            this.soyadi_textBox.TabIndex = 4;
            // 
            // Adi_textBox
            // 
            this.Adi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Adi_textBox.Location = new System.Drawing.Point(119, 103);
            this.Adi_textBox.Name = "Adi_textBox";
            this.Adi_textBox.Size = new System.Drawing.Size(141, 22);
            this.Adi_textBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC : ";
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
            // PersonelKayit
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(362, 488);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonelKayit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelKayit_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox gorev_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ana;
        private System.Windows.Forms.MaskedTextBox telefon_maskedTextBox;
        private System.Windows.Forms.TextBox adres_textBox;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox soyadi_textBox;
        private System.Windows.Forms.TextBox Adi_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kSifre_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tc_textBox;
        private System.Windows.Forms.TextBox kAdi_textBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}