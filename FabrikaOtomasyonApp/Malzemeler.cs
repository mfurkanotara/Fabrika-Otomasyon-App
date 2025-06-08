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
    public partial class Malzemeler : Form
    {
        private SqlConnection baglanti;
        public Malzemeler()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=MFURKANOTARA\\SQLEXPRESS;Initial Catalog=dbFabrika;Integrated Security=True");
        }

        private void Malzemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet.malzemeler' table. You can move, or remove it, as needed.
            // this.malzemelerTableAdapter.Fill(this.dbFabrikaDataSet.malzemeler);
            ListeleMalzemeler();
        }

        private void ListeleMalzemeler()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM malzemeler", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvMalzemeler.DataSource = dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string malzemekodu = txtMalzemeKodu.Text;
            string malzemeadi = txtMalzemeAdi.Text;
            string malzemetipi = txtMalzemeTipi.Text;
            string birim = txtBirim.Text;
            string adet = txtAdet.Text;
            string tedarikciadi = txtTedarikciAdi.Text;
            DateTime tedariktarihi = dtpTedarikTarihi.Value;
            string bulunduguraf = txtBulunduguRaf.Text;
            string aciklama = txtAciklama.Text;

            if (string.IsNullOrEmpty(malzemekodu) || string.IsNullOrEmpty(malzemeadi) || string.IsNullOrEmpty(malzemetipi) || string.IsNullOrEmpty(birim) || string.IsNullOrEmpty(adet) || string.IsNullOrEmpty(tedarikciadi) || !dtpTedarikTarihi.Checked || string.IsNullOrEmpty(bulunduguraf) || string.IsNullOrEmpty(aciklama))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }

            SqlCommand command = new SqlCommand("INSERT INTO malzemeler (malzemeKodu, malzemeAdi, malzemeTipi, birim, adet, tedarikciAdi, tedarikTarihi, bulunduguRaf, aciklama) VALUES (@malzemekodu, @malzemeadi, @malzemetipi, @birim, @adet, @tedarikciadi, @tedariktarihi, @bulunduguraf, @aciklama)", baglanti);
            command.Parameters.AddWithValue("@malzemekodu", malzemekodu);
            command.Parameters.AddWithValue("@malzemeadi", malzemeadi);
            command.Parameters.AddWithValue("@malzemetipi", malzemetipi);
            command.Parameters.AddWithValue("@birim", birim);
            command.Parameters.AddWithValue("@adet", adet);
            command.Parameters.AddWithValue("@tedarikciadi", tedarikciadi);
            command.Parameters.AddWithValue("@tedariktarihi", tedariktarihi);
            command.Parameters.AddWithValue("@bulunduguraf", bulunduguraf);
            command.Parameters.AddWithValue("@aciklama", aciklama);

            try
            {
                baglanti.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Malzeme kaydedildi.");
                ListeleMalzemeler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMalzemeKodu.Text = "";
            txtMalzemeAdi.Text = "";
            txtMalzemeTipi.Text = "";
            txtBirim.Text = "";
            txtAdet.Text = "";
            txtTedarikciAdi.Text = "";
            txtBulunduguRaf.Text = "";
            txtAciklama.Text = "";
        }
    }
}
