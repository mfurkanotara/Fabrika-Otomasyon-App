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
    public partial class Faturalar : Form
    {
        private SqlConnection baglanti;

        public Faturalar()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server=MFURKANOTARA\\SQLEXPRESS;Database=dbFabrika;Integrated Security=True");
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet4.faturalar' table. You can move, or remove it, as needed.
            // this.faturalarTableAdapter.Fill(this.dbFabrikaDataSet4.faturalar);
            ListeleFaturalar();

        }

        private void ListeleFaturalar()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM faturalar", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvFaturalar.DataSource = dataTable;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string faturaNo = txtFaturaNo.Text;
            DateTime faturaTarihi = dtpFaturaTarihi.Value;
            string faturaTipi = txtFaturaTipi.Text;
            string firmaAdi = txtFirmaAdi.Text;
            string tutar = txtTutar.Text;
            string odenmeDurumu = txtOdenmeDurumu.Text;
            string dosyaYolu = txtDosyaYolu.Text;
            string aciklama = txtAciklama.Text;
            DateTime eklenmeTarihi = DateTime.Now;

            if (string.IsNullOrEmpty(faturaNo) || !dtpFaturaTarihi.Checked || string.IsNullOrEmpty(faturaTipi) || string.IsNullOrEmpty(firmaAdi) || string.IsNullOrEmpty(tutar) || string.IsNullOrEmpty(odenmeDurumu) || string.IsNullOrEmpty(dosyaYolu) || string.IsNullOrEmpty(aciklama))
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.");
                return;
            }

            SqlCommand command = new SqlCommand("INSERT INTO faturalar (fatura_no, fatura_tarihi, fatura_tipi, firma_adi, tutar, odeme_durumu, dosya_yolu, aciklama, eklenme_tarihi) VALUES (@faturaNo, @faturaTarihi, @faturaTipi, @firmaAdi, @tutar, @odenmeDurumu, @dosyaYolu, @aciklama, @eklenmeTarihi)", baglanti);
            command.Parameters.AddWithValue("@faturaNo", faturaNo);
            command.Parameters.AddWithValue("@faturaTarihi", faturaTarihi);
            command.Parameters.AddWithValue("@faturaTipi", faturaTipi);
            command.Parameters.AddWithValue("@firmaAdi", firmaAdi);
            command.Parameters.AddWithValue("@tutar", tutar);
            command.Parameters.AddWithValue("@odenmeDurumu", odenmeDurumu);
            command.Parameters.AddWithValue("@dosyaYolu", dosyaYolu);
            command.Parameters.AddWithValue("@aciklama", aciklama);
            command.Parameters.AddWithValue("@eklenmeTarihi", eklenmeTarihi);

            try
            {
                baglanti.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Fatura kaydedildi.");
                ListeleFaturalar();
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
            txtFaturaNo.Text = "";
            txtFaturaTipi.Text = "";
            txtFirmaAdi.Text = "";
            txtTutar.Text = "";
            txtOdenmeDurumu.Text = "";
            txtDosyaYolu.Text = "";
            txtAciklama.Text = "";
        }
    }
}
