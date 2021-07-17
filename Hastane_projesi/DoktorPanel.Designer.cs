namespace Hastane_projesi
{
    partial class DoktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPanel));
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Lime;
            this.buttonEkle.Location = new System.Drawing.Point(118, 327);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(92, 62);
            this.buttonEkle.TabIndex = 35;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Branş =";
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(216, 173);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(147, 31);
            this.comboBoxBrans.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(216, 264);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(147, 29);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şifre =";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(216, 122);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(147, 29);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(216, 70);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(147, 29);
            this.textBoxAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Soyad =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad =";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(216, 218);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(147, 29);
            this.textBoxTc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tc Kimlik No =";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Red;
            this.buttonSil.Location = new System.Drawing.Point(232, 327);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(92, 62);
            this.buttonSil.TabIndex = 36;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(408, 70);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.Size = new System.Drawing.Size(547, 319);
            this.dataGridViewDoktor.TabIndex = 37;
            this.dataGridViewDoktor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoktor_CellContentClick);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.Blue;
            this.buttonGüncelle.Location = new System.Drawing.Point(118, 395);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(206, 48);
            this.buttonGüncelle.TabIndex = 38;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // DoktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(987, 455);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.dataGridViewDoktor);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBrans);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DoktorPanel";
            this.Text = "DoktorPanel";
            this.Load += new System.EventHandler(this.DoktorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.Button buttonGüncelle;
    }
}