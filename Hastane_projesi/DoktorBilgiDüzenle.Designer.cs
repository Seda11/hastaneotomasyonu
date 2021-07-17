namespace Hastane_projesi
{
    partial class DoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgiDüzenle));
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textboxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonDoktorGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(173, 69);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(147, 29);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textboxAd
            // 
            this.textboxAd.Location = new System.Drawing.Point(173, 12);
            this.textboxAd.Name = "textboxAd";
            this.textboxAd.Size = new System.Drawing.Size(147, 29);
            this.textboxAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Soyad =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad =";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(173, 133);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(147, 29);
            this.textBoxTc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tc Kimlik No =";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(173, 236);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(147, 29);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şifre =";
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(173, 182);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(147, 31);
            this.comboBoxBrans.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Branş =";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(366, 192);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(133, 48);
            this.buttonGüncelle.TabIndex = 24;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonDoktorGiris
            // 
            this.buttonDoktorGiris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDoktorGiris.BackgroundImage = global::Hastane_projesi.Properties.Resources.doctor;
            this.buttonDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoktorGiris.Location = new System.Drawing.Point(381, 12);
            this.buttonDoktorGiris.Name = "buttonDoktorGiris";
            this.buttonDoktorGiris.Size = new System.Drawing.Size(128, 98);
            this.buttonDoktorGiris.TabIndex = 25;
            this.buttonDoktorGiris.UseVisualStyleBackColor = false;
            // 
            // DoktorBilgiDüzenle
            // 
            this.AcceptButton = this.buttonGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Hastane_projesi.Properties.Resources.lotusnilüfer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 277);
            this.Controls.Add(this.buttonDoktorGiris);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBrans);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textboxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.DoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textboxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonDoktorGiris;
    }
}