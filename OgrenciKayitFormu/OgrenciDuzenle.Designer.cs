namespace OgrenciKayitFormu
{
    partial class OgrencGirisFormu
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
            txtLotFiyati = new TextBox();
            label1 = new Label();
            txtHisseIsmi = new TextBox();
            label2 = new Label();
            txtLotSayisi = new MaskedTextBox();
            label3 = new Label();
            rbAlıs = new RadioButton();
            rbSatis = new RadioButton();
            dtpTarih = new DateTimePicker();
            label6 = new Label();
            btnKaydet = new Button();
            btnKapat = new Button();
            label7 = new Label();
            txtPiyasaDegeri = new TextBox();
            SuspendLayout();
            // 
            // txtLotFiyati
            // 
            txtLotFiyati.AccessibleName = "";
            txtLotFiyati.Location = new Point(149, 185);
            txtLotFiyati.Name = "txtLotFiyati";
            txtLotFiyati.Size = new Size(193, 27);
            txtLotFiyati.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Location = new Point(67, 126);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Hisse İsmi:";
            // 
            // txtHisseIsmi
            // 
            txtHisseIsmi.AccessibleName = "";
            txtHisseIsmi.Location = new Point(149, 119);
            txtHisseIsmi.Name = "txtHisseIsmi";
            txtHisseIsmi.Size = new Size(193, 27);
            txtHisseIsmi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.Location = new Point(72, 188);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Lot Fiyatı:";
            // 
            // txtLotSayisi
            // 
            txtLotSayisi.AccessibleName = "";
            txtLotSayisi.Location = new Point(149, 218);
            txtLotSayisi.Name = "txtLotSayisi";
            txtLotSayisi.Size = new Size(193, 27);
            txtLotSayisi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.Location = new Point(69, 225);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Lot Sayısı:";
            // 
            // rbAlıs
            // 
            rbAlıs.AccessibleName = "";
            rbAlıs.AutoSize = true;
            rbAlıs.Location = new Point(110, 89);
            rbAlıs.Name = "rbAlıs";
            rbAlıs.Size = new Size(54, 24);
            rbAlıs.TabIndex = 6;
            rbAlıs.TabStop = true;
            rbAlıs.Text = "Alış";
            rbAlıs.UseVisualStyleBackColor = true;
            // 
            // rbSatis
            // 
            rbSatis.AccessibleName = "";
            rbSatis.AutoSize = true;
            rbSatis.Location = new Point(226, 89);
            rbSatis.Name = "rbSatis";
            rbSatis.Size = new Size(61, 24);
            rbSatis.TabIndex = 7;
            rbSatis.TabStop = true;
            rbSatis.Text = "Satış";
            rbSatis.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(149, 152);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(193, 27);
            dtpTarih.TabIndex = 11;
            dtpTarih.Value = new DateTime(2023, 7, 26, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AccessibleName = "";
            label6.AutoSize = true;
            label6.Location = new Point(59, 157);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 12;
            label6.Text = "İşlem Tarihi:";
            // 
            // btnKaydet
            // 
            btnKaydet.AccessibleName = "";
            btnKaydet.BackColor = Color.FromArgb(128, 255, 128);
            btnKaydet.Location = new Point(21, 311);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(117, 87);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.AccessibleName = "";
            btnKapat.BackColor = Color.FromArgb(255, 128, 128);
            btnKapat.Location = new Point(243, 311);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(117, 87);
            btnKapat.TabIndex = 15;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(92, 9);
            label7.Name = "label7";
            label7.Size = new Size(206, 35);
            label7.TabIndex = 16;
            label7.Text = "Hisse Detayları";
            // 
            // txtPiyasaDegeri
            // 
            txtPiyasaDegeri.AccessibleName = "";
            txtPiyasaDegeri.Location = new Point(149, 218);
            txtPiyasaDegeri.Name = "txtPiyasaDegeri";
            txtPiyasaDegeri.Size = new Size(193, 27);
            txtPiyasaDegeri.TabIndex = 17;
            // 
            // OgrencGirisFormu
            // 
            AccessibleName = "OgrenciGirisFormu";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 464);
            Controls.Add(label7);
            Controls.Add(btnKapat);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(dtpTarih);
            Controls.Add(rbSatis);
            Controls.Add(rbAlıs);
            Controls.Add(label3);
            Controls.Add(txtLotSayisi);
            Controls.Add(label2);
            Controls.Add(txtHisseIsmi);
            Controls.Add(label1);
            Controls.Add(txtLotFiyati);
            Controls.Add(txtPiyasaDegeri);
            Name = "OgrencGirisFormu";
            Text = "OgrenciGirisFormu";
            Load += OgrencGirisFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLotFiyati;
        private Label label1;
        private TextBox txtHisseIsmi;
        private Label label2;
        private MaskedTextBox txtLotSayisi;
        private Label label3;
        private RadioButton rbAlıs;
        private RadioButton rbSatis;
        private DateTimePicker dtpTarih;
        private Label label6;
        private Button btnKaydet;
        private Button btnKapat;
        private Label label7;
        private TextBox txtPiyasaDegeri;
    }
}