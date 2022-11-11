using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuzgunUygulama
{
    public partial class UlkeSehircs : Form
    {
        public UlkeSehircs()
        {
            InitializeComponent();
        }

        private void UlkeSehircs_Load(object sender, EventArgs e)
        {     
           UlkeSehirSql ulkeSehirSql = new UlkeSehirSql();
           Ulkesehir.DataSource = ulkeSehirSql.UlkeGoster();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            UlkeSehirSql ulkeSehirSql = new UlkeSehirSql();
            ulkeSehirSql.Ulkee=Ulke.Text;
            ulkeSehirSql.Sehirr = Sehir.Text;         
            ulkeSehirSql.Ekle();
            Ulkesehir.DataSource = ulkeSehirSql.UlkeGoster();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            UlkeSehirSql Ulkee = new UlkeSehirSql();
           if (Ulkesehir.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen satır olarak tıkla!");
                return;
            }
            DialogResult secenek = MessageBox.Show("Seçilenleri Silmek İstiyormusunuz?", "", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in Ulkesehir.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    Ulkee.Ulkeid = numara;
                    Ulkee.Delete();
                    MessageBox.Show("" + Ulkee.Ulkeid + "lı id  silindi");
                    
                }
                Ulkesehir.DataSource = Ulkee.UlkeGoster();
            }
            else
            {
                MessageBox.Show("İşlem iptal edilidi ");
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {

                UlkeSehirSql ulkeSehirSql = new UlkeSehirSql();
                ulkeSehirSql.Ulkee = Ulke.Text;
                ulkeSehirSql.Sehirr = Sehir.Text;

           
            if (ulkeid.Text == "" || ulkeid.Text == "ID giriniz")
            {
                MessageBox.Show("Güncellemek istediğiniz veriyin id değierini giriniz ");
                return;
            }
                  ulkeSehirSql.Ulkeid = int.Parse(ulkeid.Text);
                 Ulkesehir.DataSource = ulkeSehirSql.Update();
                MessageBox.Show("" + ulkeSehirSql.Ulkeid + "li Renk Güncellendi");
                Ulkesehir.DataSource = ulkeSehirSql.UlkeGoster();
        }

        private void ulkeid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ulkeid_Click(object sender, EventArgs e)
        {
            if (ulkeid.Text == "ID giriniz")
            {
                ulkeid.Clear();
            }
        }

        private void Ulke_Click(object sender, EventArgs e)
        {
            if (Ulke.Text == "Ülke giriniz")
            {
                Ulke.Clear();
            }
        }

        private void Sehir_Click(object sender, EventArgs e)
        {
            if (Sehir.Text == "Şehir giriniz")
            {
                Sehir.Clear();
            }
        }
    }

    }

