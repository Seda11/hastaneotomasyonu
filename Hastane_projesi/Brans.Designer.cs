namespace Hastane_projesi
{
    partial class Brans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brans));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewBrans = new System.Windows.Forms.DataGridView();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textboxBransAd = new System.Windows.Forms.TextBox();
            this.textboxBransId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrans)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Blue;
            this.buttonGuncelle.Location = new System.Drawing.Point(78, 211);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(206, 48);
            this.buttonGuncelle.TabIndex = 52;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dataGridViewBrans
            // 
            this.dataGridViewBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrans.Location = new System.Drawing.Point(362, 44);
            this.dataGridViewBrans.Name = "dataGridViewBrans";
            this.dataGridViewBrans.Size = new System.Drawing.Size(299, 215);
            this.dataGridViewBrans.TabIndex = 51;
            this.dataGridViewBrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrans_CellClick);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Red;
            this.buttonSil.Location = new System.Drawing.Point(192, 143);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(92, 62);
            this.buttonSil.TabIndex = 50;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Lime;
            this.buttonEkle.Location = new System.Drawing.Point(78, 143);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(92, 62);
            this.buttonEkle.TabIndex = 49;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textboxBransAd
            // 
            this.textboxBransAd.Location = new System.Drawing.Point(192, 96);
            this.textboxBransAd.Name = "textboxBransAd";
            this.textboxBransAd.Size = new System.Drawing.Size(147, 29);
            this.textboxBransAd.TabIndex = 44;
            // 
            // textboxBransId
            // 
            this.textboxBransId.Location = new System.Drawing.Point(192, 44);
            this.textboxBransId.Name = "textboxBransId";
            this.textboxBransId.Size = new System.Drawing.Size(147, 29);
            this.textboxBransId.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Branş Ad =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Branş İd=";
            // 
            // Brans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(692, 296);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.dataGridViewBrans);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textboxBransAd);
            this.Controls.Add(this.textboxBransId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Brans";
            this.Text = "Brans";
            this.Load += new System.EventHandler(this.Brans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewBrans;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textboxBransAd;
        private System.Windows.Forms.TextBox textboxBransId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}