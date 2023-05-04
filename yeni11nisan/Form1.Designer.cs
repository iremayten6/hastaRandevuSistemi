namespace yeni11nisan
{
    partial class FormRandevu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRandevuKaydet = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            dtpTarih = new DateTimePicker();
            btnRandevuListele = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBolum = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtSaat = new TextBox();
            txtHekimAdi = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnRandevuKaydet
            // 
            btnRandevuKaydet.BackColor = SystemColors.ButtonShadow;
            btnRandevuKaydet.Location = new Point(180, 585);
            btnRandevuKaydet.Name = "btnRandevuKaydet";
            btnRandevuKaydet.Size = new Size(150, 90);
            btnRandevuKaydet.TabIndex = 0;
            btnRandevuKaydet.Text = "Randevu Kaydet";
            btnRandevuKaydet.UseVisualStyleBackColor = false;
            btnRandevuKaydet.Click += btnRandevuKaydet_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(385, 109);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(249, 39);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(385, 181);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(249, 39);
            txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(385, 256);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(249, 39);
            txtTelefon.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(297, 517);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(400, 39);
            dtpTarih.TabIndex = 2;
            // 
            // btnRandevuListele
            // 
            btnRandevuListele.BackColor = SystemColors.ButtonShadow;
            btnRandevuListele.Location = new Point(352, 585);
            btnRandevuListele.Name = "btnRandevuListele";
            btnRandevuListele.Size = new Size(150, 90);
            btnRandevuListele.TabIndex = 3;
            btnRandevuListele.Text = "Randevu Listele";
            btnRandevuListele.UseVisualStyleBackColor = false;
            btnRandevuListele.Click += btnRandevuListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 109);
            label1.Name = "label1";
            label1.Size = new Size(289, 32);
            label1.TabIndex = 4;
            label1.Text = "Randevu Sahibinin İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 188);
            label2.Name = "label2";
            label2.Size = new Size(317, 32);
            label2.TabIndex = 4;
            label2.Text = "Randevu Sahibinin Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 259);
            label3.Name = "label3";
            label3.Size = new Size(351, 32);
            label3.TabIndex = 4;
            label3.Text = "Randevu Sahibinin Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 517);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 4;
            label4.Text = "İstenilen Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 329);
            label5.Name = "label5";
            label5.Size = new Size(306, 32);
            label5.TabIndex = 5;
            label5.Text = "Randevu Alınacak Bölüm:";
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(385, 326);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(249, 39);
            txtBolum.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 392);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 7;
            label6.Text = "İstenilen Saat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 453);
            label7.Name = "label7";
            label7.Size = new Size(245, 32);
            label7.TabIndex = 8;
            label7.Text = "İstenilen Hekim Adı:";
            // 
            // txtSaat
            // 
            txtSaat.Location = new Point(385, 389);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new Size(249, 39);
            txtSaat.TabIndex = 9;
            // 
            // txtHekimAdi
            // 
            txtHekimAdi.Location = new Point(385, 446);
            txtHekimAdi.Name = "txtHekimAdi";
            txtHekimAdi.Size = new Size(249, 39);
            txtHekimAdi.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonShadow;
            label8.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(143, 23);
            label8.Name = "label8";
            label8.Size = new Size(522, 59);
            label8.TabIndex = 10;
            label8.Text = "RANDEVU GİRİŞ EKRANI";
            // 
            // FormRandevu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 687);
            Controls.Add(label8);
            Controls.Add(txtHekimAdi);
            Controls.Add(txtSaat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtBolum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRandevuListele);
            Controls.Add(dtpTarih);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnRandevuKaydet);
            Name = "FormRandevu";
            Text = "Randevu Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandevuKaydet;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private DateTimePicker dtpTarih;
        private Button btnRandevuListele;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBolum;
        private Label label6;
        private Label label7;
        private TextBox txtSaat;
        private TextBox txtHekimAdi;
        private Label label8;
    }
}