namespace DuzgunUygulama
{
    partial class UlkeSehircs
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
            this.Ulkesehir = new System.Windows.Forms.DataGridView();
            this.Sehir = new System.Windows.Forms.TextBox();
            this.Ulke = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ulkeid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ulkesehir)).BeginInit();
            this.SuspendLayout();
            // 
            // Ulkesehir
            // 
            this.Ulkesehir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ulkesehir.Location = new System.Drawing.Point(17, 12);
            this.Ulkesehir.Name = "Ulkesehir";
            this.Ulkesehir.Size = new System.Drawing.Size(345, 270);
            this.Ulkesehir.TabIndex = 0;
            // 
            // Sehir
            // 
            this.Sehir.Location = new System.Drawing.Point(368, 102);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(92, 20);
            this.Sehir.TabIndex = 1;
            this.Sehir.Text = "Şehir giriniz";
            this.Sehir.Click += new System.EventHandler(this.Sehir_Click);
            // 
            // Ulke
            // 
            this.Ulke.Location = new System.Drawing.Point(368, 76);
            this.Ulke.Name = "Ulke";
            this.Ulke.Size = new System.Drawing.Size(92, 20);
            this.Ulke.TabIndex = 2;
            this.Ulke.Text = "Ülke giriniz";
            this.Ulke.Click += new System.EventHandler(this.Ulke_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(17, 288);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(97, 45);
            this.Ekle.TabIndex = 3;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(265, 288);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(97, 45);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ulkeid
            // 
            this.ulkeid.Location = new System.Drawing.Point(368, 50);
            this.ulkeid.Name = "ulkeid";
            this.ulkeid.Size = new System.Drawing.Size(92, 20);
            this.ulkeid.TabIndex = 6;
            this.ulkeid.Text = "ID giriniz";
            this.ulkeid.Click += new System.EventHandler(this.ulkeid_Click);
            this.ulkeid.TextChanged += new System.EventHandler(this.ulkeid_TextChanged);
            // 
            // UlkeSehircs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::DuzgunUygulama.Properties.Resources.terstenpenaltı;
            this.ClientSize = new System.Drawing.Size(709, 345);
            this.Controls.Add(this.ulkeid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Ulke);
            this.Controls.Add(this.Sehir);
            this.Controls.Add(this.Ulkesehir);
            this.Name = "UlkeSehircs";
            this.Text = "UlkeSehircs";
            this.Load += new System.EventHandler(this.UlkeSehircs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ulkesehir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ulkesehir;
        private System.Windows.Forms.TextBox Sehir;
        private System.Windows.Forms.TextBox Ulke;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ulkeid;
    }
}