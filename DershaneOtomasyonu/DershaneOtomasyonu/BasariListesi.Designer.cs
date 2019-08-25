namespace DershaneOtomasyonu
{
    partial class BasariListesi
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
            this.sinif_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_button = new System.Windows.Forms.Button();
            this.basariList_dataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.ogr_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.basariList_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sinif_comboBox
            // 
            this.sinif_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinif_comboBox.FormattingEnabled = true;
            this.sinif_comboBox.Location = new System.Drawing.Point(203, 46);
            this.sinif_comboBox.Name = "sinif_comboBox";
            this.sinif_comboBox.Size = new System.Drawing.Size(137, 21);
            this.sinif_comboBox.TabIndex = 1;
            this.sinif_comboBox.SelectedIndexChanged += new System.EventHandler(this.sinif_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sınıf Seç";
            // 
            // list_button
            // 
            this.list_button.BackColor = System.Drawing.Color.Teal;
            this.list_button.Enabled = false;
            this.list_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_button.ForeColor = System.Drawing.Color.White;
            this.list_button.Location = new System.Drawing.Point(372, 44);
            this.list_button.Name = "list_button";
            this.list_button.Size = new System.Drawing.Size(92, 23);
            this.list_button.TabIndex = 20;
            this.list_button.Text = "Listele";
            this.list_button.UseVisualStyleBackColor = false;
            this.list_button.Click += new System.EventHandler(this.list_button_Click);
            // 
            // basariList_dataGridView
            // 
            this.basariList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basariList_dataGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.basariList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basariList_dataGridView.Location = new System.Drawing.Point(170, 254);
            this.basariList_dataGridView.Name = "basariList_dataGridView";
            this.basariList_dataGridView.ReadOnly = true;
            this.basariList_dataGridView.Size = new System.Drawing.Size(354, 147);
            this.basariList_dataGridView.TabIndex = 21;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi.Location = new System.Drawing.Point(167, 91);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(23, 15);
            this.lbl_bilgi.TabIndex = 22;
            this.lbl_bilgi.Text = ">>";
            this.lbl_bilgi.Visible = false;
            // 
            // ogr_listBox
            // 
            this.ogr_listBox.BackColor = System.Drawing.Color.Teal;
            this.ogr_listBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogr_listBox.ForeColor = System.Drawing.Color.White;
            this.ogr_listBox.FormattingEnabled = true;
            this.ogr_listBox.ItemHeight = 17;
            this.ogr_listBox.Location = new System.Drawing.Point(170, 124);
            this.ogr_listBox.Name = "ogr_listBox";
            this.ogr_listBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ogr_listBox.Size = new System.Drawing.Size(354, 106);
            this.ogr_listBox.TabIndex = 24;
            this.ogr_listBox.SelectedIndexChanged += new System.EventHandler(this.ogr_listBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.basariList_dataGridView);
            this.groupBox1.Controls.Add(this.ogr_listBox);
            this.groupBox1.Controls.Add(this.sinif_comboBox);
            this.groupBox1.Controls.Add(this.lbl_bilgi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.list_button);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(30, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 428);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başarı Bilgileri";
            // 
            // BasariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(729, 488);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BasariListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasariListesi_FormClosing);
            this.Load += new System.EventHandler(this.BasariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basariList_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox sinif_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button list_button;
        private System.Windows.Forms.DataGridView basariList_dataGridView;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.ListBox ogr_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}