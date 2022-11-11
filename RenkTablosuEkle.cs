using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Collections;

namespace DuzgunUygulama
{
    public partial class RenkTablosuEkle : Form
    {
        public RenkTablosuEkle()
        {
            InitializeComponent();
        }        
        private void RenkTablosuEkle_Load(object sender, EventArgs e)
        {
            RenkSql rnk = new RenkSql();
            grdRenkler.DataSource = rnk.RenkGoster();     
        }
        private void button2_Click(object sender, EventArgs e)
        {           
            RenkSql rnk = new RenkSql();         
            rnk.Renk = renkkodu.Text;
            rnk.Renkkodu = renk.Text;          
            grdRenkler.DataSource = rnk.RenkEKle();
            grdRenkler.DataSource = rnk.RenkGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RenkSql rnk = new RenkSql();
            //// silgi yeri   
            if (grdRenkler.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğin idyi  satır olarak tıkla!");
                return;
            }
            DialogResult secenek = MessageBox.Show("Seçilenleri Silmek İstiyormusunuz?","", MessageBoxButtons.YesNo);
            
            if (secenek == DialogResult.Yes)
            {                      
                    foreach (DataGridViewRow drow in grdRenkler.SelectedRows)  //Seçili Satırları Silme
                    {
                        int numara = Convert.ToInt32(drow.Cells[0].Value);
                        rnk.Renkid = numara;
                        rnk.Renksil();
                        MessageBox.Show("" + numara + "lı id  silindi");
                    }                        
                grdRenkler.DataSource = rnk.RenkGoster();                
            }

            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Silmedik la korkma");
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (renkidtex.Text == "")
            {
                MessageBox.Show("Güncellemek istediğiniz verinin id sini girin!");
                return;
            }
            RenkSql rnk = new RenkSql();
            rnk.Renk = renkkodu.Text;
            rnk.Renkkodu = renk.Text;       
                var a = int.Parse(renkidtex.Text);
                rnk.Renkid = a;
                rnk.Update();                        
            grdRenkler.DataSource = rnk.RenkGoster();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
