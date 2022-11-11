using DAO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuzgunUygulama
{
   
    public partial class OgrenciListesi : Form
    {
        public int s;
        public static bool EkranYenileyici = false;
        
        public OgrenciListesi()
        {
            InitializeComponent();

        }
        private void Ogrencitablosu_Load(object sender, EventArgs e)
        {    
            OgrenciSql Ogrencikod = new OgrenciSql();
            Ogrenci.DataSource = Ogrencikod.OgrenciGoster();
        }
        private void Ekle_Click(object sender, EventArgs e)
        {  
            OgrenciSql Ogrencikod = new OgrenciSql();
           
            Ogrencie acilsusam = new Ogrencie();         
            acilsusam.MdiParent = this.MdiParent;            
            acilsusam.Show();         
            Ogrenci.DataSource = Ogrencikod.OgrenciGoster();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OgreciPaneliniAc();
        }
        private void OgreciPaneliniAc()
        {
            if (Ogrenci.CurrentRow is null)
            {
                MessageBox.Show("Lütfen satır olarak tıkla!");
                return;
            }

            Ogrencie acilsusam = new Ogrencie();          
            int numara = Convert.ToInt32(Ogrenci.CurrentRow.Cells[0].Value);
            acilsusam.selectedId = numara;           
            acilsusam.MdiParent = this.MdiParent;
            acilsusam.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            OgrenciSql Ogrencikod = new OgrenciSql();
            foreach (DataGridViewRow drow in Ogrenci.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                Ogrencikod.OgrenciID = numara;
            }
            if (Ogrenci.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen seçmek istediğin idyi  satır olarak tıkla!");
                return;
            }
            DialogResult secenek = MessageBox.Show(Ogrencikod.OgrenciID + "Seçilen Id yi silinsin mi  ", " ", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                Ogrencikod.DeleteOgrenci();
                Ogrenci.DataSource = Ogrencikod.OgrenciGoster();
            }
            else
            {
                MessageBox.Show("seçiminiz iptal edildi");
            }
        }



        private void Ogrenci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OgreciPaneliniAc();
        }
    }
}
