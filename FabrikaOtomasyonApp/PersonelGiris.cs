using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaOtomasyonApp
{
    public partial class PersonelGiris : Form
    {
        private SqlConnection baglanti;
        public PersonelGiris()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=MFURKANOTARA\\SQLEXPRESS;Initial Catalog=dbFabrika;Integrated Security=True");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string kullaniciSifre = txtSifre.Text;
            string girisRol = "Personel";

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM kullanicilar", baglanti);
            SqlDataReader dataReader = cmd.ExecuteReader();

            bool girisBasarili = false;

            while (dataReader.Read())
            {
                if (dataReader["kullaniciAdi"].ToString() == kullaniciAdi && dataReader["sifre"].ToString() == kullaniciSifre && dataReader["rol"].ToString() == girisRol)
                {
                    girisBasarili = true;
                    break;
                }
            }
            dataReader.Close();
            baglanti.Close();

            if (girisBasarili)
            {
                PersonelPanel personelPanel = new PersonelPanel();
                personelPanel.KullaniciAdi = kullaniciAdi;
                personelPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı, şifre veya rolünüz giriş için uygun değil.");
            }
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
