using DAO;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DuzgunUygulama
{
    public partial class Ogrencie : Form
    {

        private int _selectedId { get; set; }
        public int selectedId
        {
            get
            {
                return _selectedId;
            }

            set
            {
                tbx_OgrenciId.Text = value.ToString();
                _selectedId = value;
            }
        }

        public Ogrencie()
        {
            InitializeComponent();
        }

        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {                  
            ComboxEkleme comboxSql = new ComboxEkleme();
            MySqlDataReader dr;
            #region açılır açılmaz verileri yazdıran yer 
           
            comboxSql.Ogrencinumara = selectedId.ToString();
            dr = comboxSql.Ogrenciad().ExecuteReader();
            while (dr.Read())
            {                             
                Oad.Text = dr["ogrenciad"].ToString();
                Osoyad.Text = dr["ogrencisoyad"].ToString();
                nick.Text = dr["nickname"].ToString();
                yas.Text = dr["Age"].ToString();
                dogum.Text = dr["birday"].ToString();

                Ulke.Text = dr["ulke"].ToString();
                Sehir.Text = dr["city"].ToString();
                renkler.Text = dr["favorirenk"].ToString();
            }
            dr.Close();
            #endregion
            #region texboxların dolduğu yer
            dr = comboxSql.Ulke().ExecuteReader();
            while (dr.Read())
            {
                Ulke.Items.Add(dr["ulke"]);
            }
            dr.Close();
            dr = comboxSql.Sehir().ExecuteReader();
            while (dr.Read())
            {
                Sehir.Items.Add(dr["city"]);
            }
            dr = comboxSql.RenkleriCom().ExecuteReader();
            while (dr.Read())
            { renkler.Items.Add(dr["renk"]); }
            #endregion
        }
        //ulkeSehirSql.UlkeGoster()
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciSql Ogrencikod = new OgrenciSql();
            if (Oad.Text == "" || Osoyad.Text == "" || Osoyad.Text == "" || yas.Text == "" || dogum.Text == "" || Ulke.Text == "" || Sehir.Text == "")
            {
                MessageBox.Show("kırmızı alanları boş bırakmayınız  ");
                ad.ForeColor = Color.Red;
                soyad.ForeColor = Color.Red;
                hayattakalmasuresi.ForeColor = Color.Red;
                gun.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                return;
            }
            else
            {
                Ogrencikod.Ogrenciad = Oad.Text;
                Ogrencikod.Ogrencisoyad = Osoyad.Text;
                Ogrencikod.Nickname = nick.Text;
                Ogrencikod.Age = yas.Text;
                Ogrencikod.Birday = dogum.Text;
                Ogrencikod.Ulke = Ulke.Text;
                Ogrencikod.City = Sehir.Text;
                Ogrencikod.Favorirenk = renkler.Text;
                Ogrencikod.Ogrenciekle();
                OgrenciListesi.EkranYenileyici = true;
                Close();
            }
        }
        private void Guncelle_Click_1(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show(selectedId + "Seçilen Id yi güncellemek istediğnize emin misiniz " ," " , MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                MySqlDataReader dr;
                OgrenciSql Ogrencikod = new OgrenciSql();
                ComboxEkleme comboxEkleme = new ComboxEkleme();
                //comboxEkleme.Ogrencinumara = ;
                Ogrencikod.OgrenciID = int.Parse(selectedId.ToString());
                dr = comboxEkleme.Ogrenciad().ExecuteReader();
                dr.Read();
                comboxEkleme.Ogrencinumara = selectedId.ToString();
                Ogrencikod.Ogrenciad = Oad.Text;
                Ogrencikod.Ogrencisoyad = Osoyad.Text;
                Ogrencikod.Nickname = nick.Text;
                Ogrencikod.Age = yas.Text;
                Ogrencikod.Birday = dogum.Text;
                Ogrencikod.Ulke = Ulke.Text;
                Ogrencikod.City = Sehir.Text;
                Ogrencikod.Favorirenk = renkler.Text;
                Ogrencikod.OgrenciGuncel();
                OgrenciListesi.EkranYenileyici = true;
                Close();
            }
            else
            {
                MessageBox.Show("Doğru id yi seçip tekrar deneyin");
                Close();
            }
        }
    }
}