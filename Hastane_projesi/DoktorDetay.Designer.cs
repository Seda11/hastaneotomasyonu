namespace Hastane_projesi
{
    partial class DoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorDetay));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDuyuru = new System.Windows.Forms.Button();
            this.buttonDüzenle = new System.Windows.Forms.Button();
            this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewRandevu);
            this.groupBox3.Location = new System.Drawing.Point(285, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 415);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridViewRandevu
            // 
            this.dataGridViewRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRandevu.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewRandevu.Name = "dataGridViewRandevu";
            this.dataGridViewRandevu.Size = new System.Drawing.Size(462, 387);
            this.dataGridViewRandevu.TabIndex = 0;
            this.dataGridViewRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRandevu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgisi";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(103, 84);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(87, 23);
            this.labelAdSoyad.TabIndex = 2;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad Soyad= ";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(84, 39);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(142, 23);
            this.labelTc.TabIndex = 1;
            this.labelTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO= ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.buttonDuyuru);
            this.groupBox4.Controls.Add(this.buttonDüzenle);
            this.groupBox4.Location = new System.Drawing.Point(26, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 116);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Hastane_projesi.Properties.Resources.logout32;
            this.button1.Location = new System.Drawing.Point(153, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 48);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDuyuru
            // 
            this.buttonDuyuru.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDuyuru.Location = new System.Drawing.Point(10, 66);
            this.buttonDuyuru.Name = "buttonDuyuru";
            this.buttonDuyuru.Size = new System.Drawing.Size(110, 32);
            this.buttonDuyuru.TabIndex = 2;
            this.buttonDuyuru.Text = "Duyurular";
            this.buttonDuyuru.UseVisualStyleBackColor = true;
            this.buttonDuyuru.Click += new System.EventHandler(this.buttonDuyuru_Click);
            // 
            // buttonDüzenle
            // 
            this.buttonDüzenle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDüzenle.Location = new System.Drawing.Point(10, 28);
            this.buttonDüzenle.Name = "buttonDüzenle";
            this.buttonDüzenle.Size = new System.Drawing.Size(110, 32);
            this.buttonDüzenle.TabIndex = 1;
            this.buttonDüzenle.Text = "Bilgi Düzenle";
            this.buttonDüzenle.UseVisualStyleBackColor = true;
            this.buttonDüzenle.Click += new System.EventHandler(this.buttonDüzenle_Click);
            // 
            // richTextBoxSikayet
            // 
            this.richTextBoxSikayet.Location = new System.Drawing.Point(8, 28);
            this.richTextBoxSikayet.Name = "richTextBoxSikayet";
            this.richTextBoxSikayet.Size = new System.Drawing.Size(218, 96);
            this.richTextBoxSikayet.TabIndex = 4;
            this.richTextBoxSikayet.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxSikayet);
            this.groupBox2.Location = new System.Drawing.Point(26, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Sikayet";
            // 
            // DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DoktorDetay";
            this.Text = "DoktorDetay";
            this.Load += new System.EventHandler(this.DoktorDetay_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewRandevu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDuyuru;
        private System.Windows.Forms.Button buttonDüzenle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxSikayet;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}