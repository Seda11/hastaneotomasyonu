namespace Hastane_projesi
{
    partial class Duyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyurular));
            this.dataGridViewDuyuru = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyuru)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDuyuru
            // 
            this.dataGridViewDuyuru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDuyuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuyuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDuyuru.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDuyuru.Name = "dataGridViewDuyuru";
            this.dataGridViewDuyuru.Size = new System.Drawing.Size(563, 339);
            this.dataGridViewDuyuru.TabIndex = 0;
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 339);
            this.Controls.Add(this.dataGridViewDuyuru);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Duyurular";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.Duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDuyuru;
    }
}