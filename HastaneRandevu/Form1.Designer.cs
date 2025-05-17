namespace HastaneRandevu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBranslar = new System.Windows.Forms.ComboBox();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasta Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hasta Soyadı";
            // 
            // cmbBranslar
            // 
            this.cmbBranslar.FormattingEnabled = true;
            this.cmbBranslar.Location = new System.Drawing.Point(169, 44);
            this.cmbBranslar.Name = "cmbBranslar";
            this.cmbBranslar.Size = new System.Drawing.Size(121, 24);
            this.cmbBranslar.TabIndex = 6;
            this.cmbBranslar.SelectedIndexChanged += new System.EventHandler(this.cmbBranslar_SelectedIndexChanged);
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(153, 87);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(121, 24);
            this.cmbDoktorlar.TabIndex = 7;
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(153, 144);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 24);
            this.cmbSaat.TabIndex = 8;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(153, 203);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 9;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(618, 41);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdi.TabIndex = 10;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(618, 87);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtHastaSoyadi.TabIndex = 11;
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.Location = new System.Drawing.Point(469, 202);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(249, 47);
            this.btnRandevuOlustur.TabIndex = 12;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = true;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.cmbDoktorlar);
            this.Controls.Add(this.cmbBranslar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBranslar;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.Button btnRandevuOlustur;
    }
}

