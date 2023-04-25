namespace BİL203_Odev2
{
    partial class formDersSil
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
            this.lblSil = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.mskdtxtSil = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Location = new System.Drawing.Point(12, 113);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(278, 20);
            this.lblSil.TabIndex = 0;
            this.lblSil.Text = "Silmek istediğiniz dersin kodunu giriniz : ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(172, 194);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Dersi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // mskdtxtSil
            // 
            this.mskdtxtSil.Location = new System.Drawing.Point(296, 110);
            this.mskdtxtSil.Mask = "LLL 000";
            this.mskdtxtSil.Name = "mskdtxtSil";
            this.mskdtxtSil.Size = new System.Drawing.Size(125, 27);
            this.mskdtxtSil.TabIndex = 3;
            this.mskdtxtSil.ValidatingType = typeof(int);
            // 
            // formDersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(478, 325);
            this.Controls.Add(this.mskdtxtSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSil);
            this.Name = "formDersSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblSil;
        public Button btnSil;
        private MaskedTextBox mskdtxtSil;
    }
}