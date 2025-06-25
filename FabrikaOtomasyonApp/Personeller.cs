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
    public partial class Personeller : Form
    {
        private SqlConnection baglanti;
        public Personeller()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=MFURKANOTARA\\SQLEXPRESS;Initial Catalog=dbFabrika;Integrated Security=True");
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet3.kullanicilar' table. You can move, or remove it, as needed.
            // this.kullanicilarTableAdapter.Fill(this.dbFabrikaDataSet3.kullanicilar);
            ListelePersoneller();
        }

        private void ListelePersoneller()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM kullanicilar", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvKullanicilar.DataSource = dataTable;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string rol = cbRol.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.");
                return;
            }

            SqlCommand command = new SqlCommand("INSERT INTO kullanicilar (kullaniciAdi, sifre, rol) VALUES (@kullaniciadi, @sifre, @rol)", baglanti);
            command.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
            command.Parameters.AddWithValue("@sifre", sifre);
            command.Parameters.AddWithValue("@rol", rol);

            try
            {
                baglanti.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı kaydedildi.");
                ListelePersoneller();
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
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedCells.Count > 0)
            {
                string secilenkullaniciId = dgvKullanicilar.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand komut = new SqlCommand("DELETE FROM kullanicilar WHERE id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", secilenkullaniciId);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel silindi.");
                    ListelePersoneller();
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
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }
    }
}
