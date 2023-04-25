namespace BİL203_Odev2
{
    partial class formDersGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskdtxtDersBilgi = new System.Windows.Forms.MaskedTextBox();
            this.btnDersBilgi = new System.Windows.Forms.Button();
            this.dataGridViewDersBilgiEski = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskdtxtHarfNotu = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtAkts = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtKredi = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtDersKodu = new System.Windows.Forms.MaskedTextBox();
            this.txtOgrUye = new System.Windows.Forms.TextBox();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewDersBilgiYeni = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersBilgiEski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersBilgiYeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellemek istediğiniz dersin kodunu giriniz : ";
            // 
            // mskdtxtDersBilgi
            // 
            this.mskdtxtDersBilgi.Location = new System.Drawing.Point(337, 29);
            this.mskdtxtDersBilgi.Mask = "LLL 000";
            this.mskdtxtDersBilgi.Name = "mskdtxtDersBilgi";
            this.mskdtxtDersBilgi.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtDersBilgi.TabIndex = 1;
            // 
            // btnDersBilgi
            // 
            this.btnDersBilgi.BackColor = System.Drawing.Color.White;
            this.btnDersBilgi.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDersBilgi.Location = new System.Drawing.Point(491, 29);
            this.btnDersBilgi.Name = "btnDersBilgi";
            this.btnDersBilgi.Size = new System.Drawing.Size(185, 27);
            this.btnDersBilgi.TabIndex = 2;
            this.btnDersBilgi.Text = "Ders Bilgisini Gör";
            this.btnDersBilgi.UseVisualStyleBackColor = false;
            this.btnDersBilgi.Click += new System.EventHandler(this.btnDersBilgi_Click);
            // 
            // dataGridViewDersBilgiEski
            // 
            this.dataGridViewDersBilgiEski.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDersBilgiEski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersBilgiEski.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewDersBilgiEski.Name = "dataGridViewDersBilgiEski";
            this.dataGridViewDersBilgiEski.RowHeadersWidth = 51;
            this.dataGridViewDersBilgiEski.RowTemplate.Height = 29;
            this.dataGridViewDersBilgiEski.Size = new System.Drawing.Size(664, 74);
            this.dataGridViewDersBilgiEski.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ogr Uye Ad Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "AKTS :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ders Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ders Kodu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kredi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dönem : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Harf Notu : ";
            // 
            // mskdtxtHarfNotu
            // 
            this.mskdtxtHarfNotu.Location = new System.Drawing.Point(155, 332);
            this.mskdtxtHarfNotu.Mask = "LL";
            this.mskdtxtHarfNotu.Name = "mskdtxtHarfNotu";
            this.mskdtxtHarfNotu.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtHarfNotu.TabIndex = 11;
            this.mskdtxtHarfNotu.ValidatingType = typeof(int);
            // 
            // mskdtxtAkts
            // 
            this.mskdtxtAkts.Location = new System.Drawing.Point(454, 236);
            this.mskdtxtAkts.Mask = "0";
            this.mskdtxtAkts.Name = "mskdtxtAkts";
            this.mskdtxtAkts.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtAkts.TabIndex = 12;
            // 
            // mskdtxtKredi
            // 
            this.mskdtxtKredi.Location = new System.Drawing.Point(155, 236);
            this.mskdtxtKredi.Mask = "0";
            this.mskdtxtKredi.Name = "mskdtxtKredi";
            this.mskdtxtKredi.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtKredi.TabIndex = 13;
            // 
            // mskdtxtDersKodu
            // 
            this.mskdtxtDersKodu.Location = new System.Drawing.Point(155, 185);
            this.mskdtxtDersKodu.Mask = "LLL 000";
            this.mskdtxtDersKodu.Name = "mskdtxtDersKodu";
            this.mskdtxtDersKodu.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtDersKodu.TabIndex = 14;
            // 
            // txtOgrUye
            // 
            this.txtOgrUye.Location = new System.Drawing.Point(454, 283);
            this.txtOgrUye.Name = "txtOgrUye";
            this.txtOgrUye.Size = new System.Drawing.Size(125, 27);
            this.txtOgrUye.TabIndex = 15;
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(155, 283);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(125, 27);
            this.txtDonem.TabIndex = 16;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(454, 185);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(125, 27);
            this.txtDersAdi.TabIndex = 17;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(454, 327);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 39);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Dersi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridViewDersBilgiYeni
            // 
            this.dataGridViewDersBilgiYeni.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDersBilgiYeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersBilgiYeni.Location = new System.Drawing.Point(12, 385);
            this.dataGridViewDersBilgiYeni.Name = "dataGridViewDersBilgiYeni";
            this.dataGridViewDersBilgiYeni.RowHeadersWidth = 51;
            this.dataGridViewDersBilgiYeni.RowTemplate.Height = 29;
            this.dataGridViewDersBilgiYeni.Size = new System.Drawing.Size(664, 80);
            this.dataGridViewDersBilgiYeni.TabIndex = 19;
            // 
            // formDersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(688, 495);
            this.Controls.Add(this.dataGridViewDersBilgiYeni);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.txtOgrUye);
            this.Controls.Add(this.mskdtxtDersKodu);
            this.Controls.Add(this.mskdtxtKredi);
            this.Controls.Add(this.mskdtxtAkts);
            this.Controls.Add(this.mskdtxtHarfNotu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDersBilgiEski);
            this.Controls.Add(this.btnDersBilgi);
            this.Controls.Add(this.mskdtxtDersBilgi);
            this.Controls.Add(this.label1);
            this.Name = "formDersGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Güncelleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersBilgiEski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersBilgiYeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox mskdtxtDersBilgi;
        private Button btnDersBilgi;
        private DataGridView dataGridViewDersBilgiEski;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private MaskedTextBox mskdtxtHarfNotu;
        private MaskedTextBox mskdtxtAkts;
        private MaskedTextBox mskdtxtKredi;
        private MaskedTextBox mskdtxtDersKodu;
        private TextBox txtOgrUye;
        private TextBox txtDonem;
        private TextBox txtDersAdi;
        private Button btnGuncelle;
        private DataGridView dataGridViewDersBilgiYeni;
    }
}