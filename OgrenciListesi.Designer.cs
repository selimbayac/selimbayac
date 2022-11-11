namespace DuzgunUygulama
{
    partial class OgrenciListesi
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
            this.Ogrenci = new System.Windows.Forms.DataGridView();
            this.Ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogrenci
            // 
            this.Ogrenci.AllowUserToAddRows = false;
            this.Ogrenci.AllowUserToDeleteRows = false;
            this.Ogrenci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ogrenci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Ogrenci.Location = new System.Drawing.Point(14, 12);
            this.Ogrenci.MultiSelect = false;
            this.Ogrenci.Name = "Ogrenci";
            this.Ogrenci.Size = new System.Drawing.Size(948, 348);
            this.Ogrenci.TabIndex = 1;
            this.Ogrenci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ogrenci_CellDoubleClick);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(12, 400);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(312, 60);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 60);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(976, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Ogrenci);
            this.Name = "OgrenciListesi";
            this.Text = "Ogrencitablosu";
            this.Load += new System.EventHandler(this.Ogrencitablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ogrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Ogrenci;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}