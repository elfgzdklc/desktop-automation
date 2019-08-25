namespace DershaneOtomasyonu
{
    partial class SinifKaydet
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
            this.txt_sinif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sinifKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sinifSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.txt_sube = new System.Windows.Forms.TextBox();
            this.sinif_dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinif_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sinif
            // 
            this.txt_sinif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sinif.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_sinif.Location = new System.Drawing.Point(230, 227);
            this.txt_sinif.MaxLength = 5;
            this.txt_sinif.Name = "txt_sinif";
            this.txt_sinif.Size = new System.Drawing.Size(60, 22);
            this.txt_sinif.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SINIF";
            // 
            // btn_sinifKaydet
            // 
            this.btn_sinifKaydet.BackColor = System.Drawing.Color.Teal;
            this.btn_sinifKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinifKaydet.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_sinifKaydet.ForeColor = System.Drawing.Color.White;
            this.btn_sinifKaydet.Location = new System.Drawing.Point(301, 281);
            this.btn_sinifKaydet.Name = "btn_sinifKaydet";
            this.btn_sinifKaydet.Size = new System.Drawing.Size(90, 23);
            this.btn_sinifKaydet.TabIndex = 9;
            this.btn_sinifKaydet.Text = "Sınıf Kaydet";
            this.btn_sinifKaydet.UseVisualStyleBackColor = false;
            this.btn_sinifKaydet.Click += new System.EventHandler(this.btn_sinifKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ŞUBE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "BÖLÜM";
            // 
            // btn_sinifSil
            // 
            this.btn_sinifSil.BackColor = System.Drawing.Color.Teal;
            this.btn_sinifSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinifSil.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_sinifSil.ForeColor = System.Drawing.Color.White;
            this.btn_sinifSil.Location = new System.Drawing.Point(301, 310);
            this.btn_sinifSil.Name = "btn_sinifSil";
            this.btn_sinifSil.Size = new System.Drawing.Size(90, 23);
            this.btn_sinifSil.TabIndex = 10;
            this.btn_sinifSil.Text = "Sınıf Sil";
            this.btn_sinifSil.UseVisualStyleBackColor = false;
            this.btn_sinifSil.Click += new System.EventHandler(this.btn_sinifSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bolum);
            this.groupBox1.Controls.Add(this.txt_sube);
            this.groupBox1.Controls.Add(this.sinif_dataGridView);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_sinifSil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_sinifKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_sinif);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(31, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 364);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "örn.; TM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "örn.; A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "örn.; LİSE1";
            // 
            // txt_bolum
            // 
            this.txt_bolum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bolum.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_bolum.Location = new System.Drawing.Point(399, 227);
            this.txt_bolum.MaxLength = 3;
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(60, 22);
            this.txt_bolum.TabIndex = 8;
            // 
            // txt_sube
            // 
            this.txt_sube.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sube.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt_sube.Location = new System.Drawing.Point(314, 227);
            this.txt_sube.MaxLength = 1;
            this.txt_sube.Name = "txt_sube";
            this.txt_sube.Size = new System.Drawing.Size(60, 22);
            this.txt_sube.TabIndex = 7;
            // 
            // sinif_dataGridView
            // 
            this.sinif_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sinif_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sinif_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinif_dataGridView.Location = new System.Drawing.Point(176, 50);
            this.sinif_dataGridView.Name = "sinif_dataGridView";
            this.sinif_dataGridView.ReadOnly = true;
            this.sinif_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sinif_dataGridView.Size = new System.Drawing.Size(333, 127);
            this.sinif_dataGridView.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(173, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Var Olan Sınıflar";
            // 
            // SinifKaydet
            // 
            this.AcceptButton = this.btn_sinifKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(729, 488);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SinifKaydet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinifKaydet_FormClosing);
            this.Load += new System.EventHandler(this.SinifKaydet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinif_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_sinif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sinifKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sinifSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView sinif_dataGridView;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.TextBox txt_sube;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}