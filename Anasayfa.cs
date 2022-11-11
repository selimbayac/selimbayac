using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DuzgunUygulama
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        } 
        private void öğrenciTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Renk tablosu 
            RenkTablosuEkle renk = new RenkTablosuEkle();
            renk.MdiParent = this;
            renk.Show();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {// öğrenci tablosu açma yeri
            OgrenciListesi ogrenci = new OgrenciListesi();
            ogrenci.MdiParent = this;
            ogrenci.Show(); 
        }
        private void ülkeTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UlkeSehircs ulkeSehircs = new UlkeSehircs();
            ulkeSehircs.MdiParent = this;
            ulkeSehircs.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
