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

        private void dgvFaturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvFaturalar.Rows[e.RowIndex];
                txtFaturaNo.Text = satir.Cells["faturanoDataGridViewTextBoxColumn"].Value.ToString();
                dtpFaturaTarihi.Text = satir.Cells["faturatarihiDataGridViewTextBoxColumn"].Value.ToString();
                txtFaturaTipi.Text = satir.Cells["faturatipiDataGridViewTextBoxColumn"].Value.ToString();
                txtFirmaAdi.Text = satir.Cells["firmaadiDataGridViewTextBoxColumn"].Value.ToString();
                txtTutar.Text = satir.Cells["tutarDataGridViewTextBoxColumn"].Value.ToString();
                txtOdenmeDurumu.Text = satir.Cells["odemedurumuDataGridViewTextBoxColumn"].Value.ToString();
                txtDosyaYolu.Text = satir.Cells["dosyayoluDataGridViewTextBoxColumn"].Value.ToString();
                txtAciklama.Text = satir.Cells["aciklamaDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvFaturalar.Rows.Count > 0)
            {
                string faturaNo = txtFaturaNo.Text;
                DateTime faturaTarihi = dtpFaturaTarihi.Value;
                string faturaTipi = txtFaturaTipi.Text;
                string firmaAdi = txtFirmaAdi.Text;
                decimal tutar;
                if (!decimal.TryParse(txtTutar.Text, out tutar))
                {
                    MessageBox.Show("Tutar sayısal olmalı");
                    return;
                }

                string odemeDurumu = txtOdenmeDurumu.Text;
                string dosyaYolu = txtDosyaYolu.Text;
                string aciklama = txtAciklama.Text;

                string secilenFaturaNo = dgvFaturalar.SelectedRows[0].Cells["faturanoDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand command = new SqlCommand(@"UPDATE faturalar SET fatura_tarihi = @faturaTarihi,fatura_tipi = @faturaTipi,firma_adi = @firmaAdi, tutar = @tutar, odeme_durumu = @odemeDurumu, dosya_yolu = @dosyaYolu, aciklama = @aciklama, eklenme_tarihi = @eklenmeTarihi WHERE fatura_no = @eskiFaturaNo", baglanti);

                command.Parameters.AddWithValue("@faturaTarihi", faturaTarihi);
                command.Parameters.AddWithValue("@faturaTipi", faturaTipi);
                command.Parameters.AddWithValue("@firmaAdi", firmaAdi);
                command.Parameters.AddWithValue("@tutar", tutar);
                command.Parameters.AddWithValue("@odemeDurumu", odemeDurumu);
                command.Parameters.AddWithValue("@dosyaYolu", dosyaYolu);
                command.Parameters.AddWithValue("@aciklama", aciklama);
                command.Parameters.AddWithValue("@eklenmeTarihi", DateTime.Now);
                command.Parameters.AddWithValue("@eskiFaturaNo", secilenFaturaNo);

                try
                {
                    baglanti.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Fatura güncellendi.");
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
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir fatura seçin.");
            }

        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            if (dgvFaturalar.SelectedCells.Count > 0)
            {
                string secilenFaturaNo = dgvFaturalar.SelectedRows[0].Cells["faturanoDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand komut = new SqlCommand("DELETE FROM faturalar WHERE fatura_no = @faturaNo", baglanti);
                komut.Parameters.AddWithValue("@faturaNo", secilenFaturaNo);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Fatura silindi.");
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
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void btnExcelAktarma_Click(object sender, EventArgs e)
        {
            if (dgvFaturalar.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "Faturalar.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Faturalar");

                    // Başlıkları yaz
                    for (int i = 0; i < dgvFaturalar.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvFaturalar.Columns[i].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dgvFaturalar.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvFaturalar.Columns.Count; j++)
                        {
                            var val = dgvFaturalar.Rows[i].Cells[j].Value;
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
    }
}
