namespace DershaneOtomasyonu
{
    partial class KullaniciGiris
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
            this.button1 = new System.Windows.Forms.Button();
            this.giris_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kAdi_textBox = new System.Windows.Forms.TextBox();
            this.kSifre_textBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(816, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "DERSHANE OTOMASYONU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // giris_button
            // 
            this.giris_button.BackColor = System.Drawing.Color.Teal;
            this.giris_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button.ForeColor = System.Drawing.Color.White;
            this.giris_button.Location = new System.Drawing.Point(497, 155);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(75, 36);
            this.giris_button.TabIndex = 4;
            this.giris_button.Text = "Giriş Yap";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(287, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre : ";
            // 
            // kAdi_textBox
            // 
            this.kAdi_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kAdi_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdi_textBox.Location = new System.Drawing.Point(364, 63);
            this.kAdi_textBox.Name = "kAdi_textBox";
            this.kAdi_textBox.Size = new System.Drawing.Size(156, 22);
            this.kAdi_textBox.TabIndex = 1;
            this.kAdi_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_textBox_KeyPress);
            // 
            // kSifre_textBox
            // 
            this.kSifre_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.kSifre_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kSifre_textBox.Location = new System.Drawing.Point(364, 105);
            this.kSifre_textBox.Name = "kSifre_textBox";
            this.kSifre_textBox.PasswordChar = '*';
            this.kSifre_textBox.Size = new System.Drawing.Size(156, 22);
            this.kSifre_textBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.kSifre_textBox, "Sadece rakam girilebilir!");
            this.kSifre_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kSifre_textBox_KeyPress);
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
            // Form1
            // 
            this.AcceptButton = this.giris_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 216);
            this.Controls.Add(this.kSifre_textBox);
            this.Controls.Add(this.kAdi_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kAdi_textBox;
        private System.Windows.Forms.TextBox kSifre_textBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

