using DAO;
using System;
using System.Windows.Forms;

namespace DuzgunUygulama
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncorrnet_Click_1(object sender, EventArgs e)
        {
            Parameters.DbName = textveritabani.Text;
            Parameters.Server = textServer.Text;
            Parameters.User = textuser.Text;
            Parameters.Password = textpasword.Text;
            if (string.IsNullOrEmpty(textServer.Text) || string.IsNullOrEmpty(textveritabani.Text) || string.IsNullOrEmpty(textuser.Text) || string.IsNullOrEmpty(textpasword.Text))
            {
                MessageBox.Show("Boşlukları doldurunuz eksik alan bırakmayınız ", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KontrolEtBaglantiDogruMu())
                MessageBox.Show("Veri tabanına bağlanılamadı! Lütfen girilen değerleri kontrol ediniz.");
            else
                Close();

        }
        
        private bool KontrolEtBaglantiDogruMu()
        {
            Test tst = new Test();
            return tst.ConnectDatabase();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_Load(object sender, EventArgs e)
        {
         
        }
    }
}
