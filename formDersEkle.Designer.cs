namespace BİL203_Odev2
{
    partial class formDersEkle
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
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblOgrUye = new System.Windows.Forms.Label();
            this.lblAkts = new System.Windows.Forms.Label();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.txtOgrUye = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mskdtxtDersKodu = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtHarfNotu = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtAkts = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtKredi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.ForeColor = System.Drawing.Color.Black;
            this.lblDersKodu.Location = new System.Drawing.Point(12, 25);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(89, 20);
            this.lblDersKodu.TabIndex = 0;
            this.lblDersKodu.Text = "Ders Kodu : ";
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.ForeColor = System.Drawing.Color.Black;
            this.lblDersAdi.Location = new System.Drawing.Point(340, 25);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(73, 20);
            this.lblDersAdi.TabIndex = 1;
            this.lblDersAdi.Text = "Ders Adı :";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.ForeColor = System.Drawing.Color.Black;
            this.lblKredi.Location = new System.Drawing.Point(40, 116);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(51, 20);
            this.lblKredi.TabIndex = 2;
            this.lblKredi.Text = "Kredi :";
            // 
            // lblOgrUye
            // 
            this.lblOgrUye.AutoSize = true;
            this.lblOgrUye.ForeColor = System.Drawing.Color.Black;
            this.lblOgrUye.Location = new System.Drawing.Point(275, 203);
            this.lblOgrUye.Name = "lblOgrUye";
            this.lblOgrUye.Size = new System.Drawing.Size(138, 20);
            this.lblOgrUye.TabIndex = 3;
            this.lblOgrUye.Text = "Ogr Üye Ad Soyad :";
            // 
            // lblAkts
            // 
            this.lblAkts.AutoSize = true;
            this.lblAkts.ForeColor = System.Drawing.Color.Black;
            this.lblAkts.Location = new System.Drawing.Point(362, 116);
            this.lblAkts.Name = "lblAkts";
            this.lblAkts.Size = new System.Drawing.Size(51, 20);
            this.lblAkts.TabIndex = 4;
            this.lblAkts.Text = "AKTS :";
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.ForeColor = System.Drawing.Color.Black;
            this.lblHarfNotu.Location = new System.Drawing.Point(19, 297);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(82, 20);
            this.lblHarfNotu.TabIndex = 5;
            this.lblHarfNotu.Text = "Harf Notu :";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.ForeColor = System.Drawing.Color.Black;
            this.lblDonem.Location = new System.Drawing.Point(36, 203);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(65, 20);
            this.lblDonem.TabIndex = 6;
            this.lblDonem.Text = "Dönem :";
            // 
            // txtOgrUye
            // 
            this.txtOgrUye.Location = new System.Drawing.Point(419, 200);
            this.txtOgrUye.Name = "txtOgrUye";
            this.txtOgrUye.Size = new System.Drawing.Size(125, 27);
            this.txtOgrUye.TabIndex = 8;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(419, 22);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(125, 27);
            this.txtDersAdi.TabIndex = 10;
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(107, 200);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(125, 27);
            this.txtDonem.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(419, 284);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 49);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Dersi Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mskdtxtDersKodu
            // 
            this.mskdtxtDersKodu.Location = new System.Drawing.Point(107, 22);
            this.mskdtxtDersKodu.Mask = "LLL 000";
            this.mskdtxtDersKodu.Name = "mskdtxtDersKodu";
            this.mskdtxtDersKodu.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtDersKodu.TabIndex = 15;
            this.mskdtxtDersKodu.ValidatingType = typeof(int);
            // 
            // mskdtxtHarfNotu
            // 
            this.mskdtxtHarfNotu.Location = new System.Drawing.Point(107, 294);
            this.mskdtxtHarfNotu.Mask = "LL";
            this.mskdtxtHarfNotu.Name = "mskdtxtHarfNotu";
            this.mskdtxtHarfNotu.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtHarfNotu.TabIndex = 16;
            // 
            // mskdtxtAkts
            // 
            this.mskdtxtAkts.Location = new System.Drawing.Point(419, 113);
            this.mskdtxtAkts.Mask = "0";
            this.mskdtxtAkts.Name = "mskdtxtAkts";
            this.mskdtxtAkts.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtAkts.TabIndex = 17;
            this.mskdtxtAkts.ValidatingType = typeof(int);
            // 
            // mskdtxtKredi
            // 
            this.mskdtxtKredi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mskdtxtKredi.Location = new System.Drawing.Point(107, 113);
            this.mskdtxtKredi.Mask = "0";
            this.mskdtxtKredi.Name = "mskdtxtKredi";
            this.mskdtxtKredi.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtKredi.TabIndex = 18;
            this.mskdtxtKredi.ValidatingType = typeof(int);
            // 
            // formDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(568, 364);
            this.Controls.Add(this.mskdtxtKredi);
            this.Controls.Add(this.mskdtxtAkts);
            this.Controls.Add(this.mskdtxtHarfNotu);
            this.Controls.Add(this.mskdtxtDersKodu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtOgrUye);
            this.Controls.Add(this.lblDonem);
            this.Controls.Add(this.lblHarfNotu);
            this.Controls.Add(this.lblAkts);
            this.Controls.Add(this.lblOgrUye);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.lblDersKodu);
            this.Name = "formDersEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblDersKodu;
        public Label lblDersAdi;
        public Label lblKredi;
        public Label lblOgrUye;
        public Label lblAkts;
        public Label lblHarfNotu;
        public Label lblDonem;
        public TextBox txtOgrUye;
        public TextBox txtDersAdi;
        public TextBox txtDonem;
        public Button btnEkle;
        public MaskedTextBox mskdtxtDersKodu;
        public MaskedTextBox mskdtxtHarfNotu;
        public MaskedTextBox mskdtxtAkts;
        public MaskedTextBox mskdtxtKredi;
    }
}