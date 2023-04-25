namespace BİL203_Odev2
{
    partial class formAnaSayfa
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
            this.dataGridViewTablo = new System.Windows.Forms.DataGridView();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablo
            // 
            this.dataGridViewTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTablo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablo.GridColor = System.Drawing.Color.Black;
            this.dataGridViewTablo.Location = new System.Drawing.Point(26, 12);
            this.dataGridViewTablo.Name = "dataGridViewTablo";
            this.dataGridViewTablo.RowHeadersWidth = 51;
            this.dataGridViewTablo.RowTemplate.Height = 29;
            this.dataGridViewTablo.Size = new System.Drawing.Size(746, 216);
            this.dataGridViewTablo.TabIndex = 0;
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.White;
            this.btnDersSil.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDersSil.Location = new System.Drawing.Point(457, 344);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(130, 44);
            this.btnDersSil.TabIndex = 1;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackColor = System.Drawing.Color.White;
            this.btnDersGuncelle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDersGuncelle.Location = new System.Drawing.Point(207, 344);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(126, 44);
            this.btnDersGuncelle.TabIndex = 2;
            this.btnDersGuncelle.Text = "Ders Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = false;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.White;
            this.btnTranskript.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTranskript.Location = new System.Drawing.Point(639, 344);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(133, 44);
            this.btnTranskript.TabIndex = 3;
            this.btnTranskript.Text = "Transkript";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.White;
            this.btnDersEkle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDersEkle.Location = new System.Drawing.Point(26, 344);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(128, 44);
            this.btnDersEkle.TabIndex = 4;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.White;
            this.btnGoster.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoster.Location = new System.Drawing.Point(345, 234);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(94, 29);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.dataGridViewTablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridViewTablo;
        public Button btnDersSil;
        public Button btnDersGuncelle;
        public Button btnTranskript;
        public Button btnDersEkle;
        public Button btnGoster;
    }
}