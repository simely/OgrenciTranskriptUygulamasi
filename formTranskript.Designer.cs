namespace BİL203_Odev2
{
    partial class formTranskript
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
            this.dataGridViewAlinanDersler = new System.Windows.Forms.DataGridView();
            this.lblGano = new System.Windows.Forms.Label();
            this.txtGano = new System.Windows.Forms.TextBox();
            this.btnAlinanDers = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlinanDersler
            // 
            this.dataGridViewAlinanDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlinanDersler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAlinanDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlinanDersler.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlinanDersler.Name = "dataGridViewAlinanDersler";
            this.dataGridViewAlinanDersler.RowHeadersWidth = 51;
            this.dataGridViewAlinanDersler.RowTemplate.Height = 29;
            this.dataGridViewAlinanDersler.Size = new System.Drawing.Size(644, 240);
            this.dataGridViewAlinanDersler.TabIndex = 0;
            // 
            // lblGano
            // 
            this.lblGano.AutoSize = true;
            this.lblGano.Location = new System.Drawing.Point(152, 358);
            this.lblGano.Name = "lblGano";
            this.lblGano.Size = new System.Drawing.Size(62, 20);
            this.lblGano.TabIndex = 1;
            this.lblGano.Text = "GANO : ";
            // 
            // txtGano
            // 
            this.txtGano.Location = new System.Drawing.Point(229, 355);
            this.txtGano.Name = "txtGano";
            this.txtGano.Size = new System.Drawing.Size(125, 27);
            this.txtGano.TabIndex = 2;
            // 
            // btnAlinanDers
            // 
            this.btnAlinanDers.BackColor = System.Drawing.Color.White;
            this.btnAlinanDers.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlinanDers.Location = new System.Drawing.Point(185, 258);
            this.btnAlinanDers.Name = "btnAlinanDers";
            this.btnAlinanDers.Size = new System.Drawing.Size(251, 29);
            this.btnAlinanDers.TabIndex = 3;
            this.btnAlinanDers.Text = "Harf notu girilen dersleri göster";
            this.btnAlinanDers.UseVisualStyleBackColor = false;
            this.btnAlinanDers.Click += new System.EventHandler(this.btnAlinanDers_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHesapla.Location = new System.Drawing.Point(373, 353);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 29);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // formTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(668, 411);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnAlinanDers);
            this.Controls.Add(this.txtGano);
            this.Controls.Add(this.lblGano);
            this.Controls.Add(this.dataGridViewAlinanDersler);
            this.Name = "formTranskript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAlinanDersler;
        private Label lblGano;
        private TextBox txtGano;
        private Button btnAlinanDers;
        private Button btnHesapla;
    }
}