using ClosedXML.Excel;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMalzemeler.SelectedCells.Count > 0)
            {
                string secilenmalzemeId = dgvMalzemeler.SelectedRows[0].Cells["malzemeKoduDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand komut = new SqlCommand("DELETE FROM malzemeler WHERE malzemeKodu = @malzemekodu", baglanti);
                komut.Parameters.AddWithValue("@malzemekodu", secilenmalzemeId);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Malzeme silindi.");
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
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMalzemeler.Rows.Count > 0)
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

                string secilenmalzemeKodu = dgvMalzemeler.SelectedRows[0].Cells["malzemeKoduDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand command = new SqlCommand(@"UPDATE malzemeler SET malzemeKodu = @malzemekodu, malzemeAdi = @malzemeadi, malzemeTipi = @malzemetipi, birim = @birim, adet = @adet, tedarikciAdi = @tedarikciadi, tedarikTarihi = @tedariktarihi, bulunduguRaf = @bulunduguraf, aciklama = @aciklama WHERE malzemeKodu = @eskimalzemeKodu", baglanti);

                command.Parameters.AddWithValue("@eskimalzemeKodu", secilenmalzemeKodu);
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
                    MessageBox.Show("Malzeme güncellendi.");
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
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir malzeme seçin.");
            }
        }

        private void dgvMalzemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvMalzemeler.Rows[e.RowIndex];

                txtMalzemeKodu.Text = satir.Cells["malzemeKoduDataGridViewTextBoxColumn"].Value?.ToString();
                txtMalzemeAdi.Text = satir.Cells["malzemeAdiDataGridViewTextBoxColumn"].Value?.ToString();
                txtMalzemeTipi.Text = satir.Cells["malzemeTipiDataGridViewTextBoxColumn"].Value?.ToString();
                txtBirim.Text = satir.Cells["birimDataGridViewTextBoxColumn"].Value?.ToString();
                txtAdet.Text = satir.Cells["adetDataGridViewTextBoxColumn"].Value?.ToString();
                txtTedarikciAdi.Text = satir.Cells["tedarikciAdiDataGridViewTextBoxColumn"].Value?.ToString();
                dtpTedarikTarihi.Text = satir.Cells["tedarikTarihiDataGridViewTextBoxColumn"].Value?.ToString();
                txtBulunduguRaf.Text = satir.Cells["bulunduguRafDataGridViewTextBoxColumn"].Value?.ToString();
                txtAciklama.Text = satir.Cells["aciklamaDataGridViewTextBoxColumn"].Value?.ToString();
            }
        }

        private void btnExcelAktarma_Click(object sender, EventArgs e)
        {
            if (dgvMalzemeler.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "Malzemeler.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Malzemeler");

                    // Başlıkları yaz
                    for (int i = 0; i < dgvMalzemeler.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvMalzemeler.Columns[i].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dgvMalzemeler.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvMalzemeler.Columns.Count; j++)
                        {
                            var val = dgvMalzemeler.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = val != null ? val.ToString() : "";
                        }
                    }

                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel dosyası başarıyla kaydedildi.");
                }
            }
            else
            {
                MessageBox.Show("Veri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelPanel personelpanel = new PersonelPanel();
            this.Hide();
            personelpanel.Show();
        }
    }
}
