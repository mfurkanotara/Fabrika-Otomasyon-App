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
    public partial class Randevular : Form
    {
        private SqlConnection baglanti;
        public Randevular()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Server=MFURKANOTARA\\SQLEXPRESS;Database=dbFabrika;Integrated Security=True");
        }

        private void Randevular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet6.randevular' table. You can move, or remove it, as needed.
            // this.randevularTableAdapter1.Fill(this.dbFabrikaDataSet6.randevular);
            ListeleRandevular();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void ListeleRandevular()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM randevular", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvRandevular.DataSource = dataTable;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string randevuKonu = txtRandevuKonusu.Text;
            string gorusulecekKisi = txtGorusulecekKisi.Text;
            DateTime randevuTarihi = dtpRandevuTarihi.Value;

            if (string.IsNullOrEmpty(randevuKonu) || string.IsNullOrEmpty(gorusulecekKisi) || !dtpRandevuTarihi.Checked)
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.");
                return;
            }

            SqlCommand command = new SqlCommand("INSERT INTO randevular(randevuKonu, gorusulecekKisi, randevuTarihi) VALUES (@randevukonu, @gorusulecekkisi, @randevutarihi)", baglanti);
            command.Parameters.AddWithValue("@randevukonu", randevuKonu);
            command.Parameters.AddWithValue("@gorusulecekkisi", gorusulecekKisi);
            command.Parameters.AddWithValue("@randevutarihi", randevuTarihi);

            try
            {
                baglanti.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Randevu kaydedildi.");
                ListeleRandevular();
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
            txtRandevuKonusu.Text = "";
            txtGorusulecekKisi.Text = "";
        }

        private void dgvRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvRandevular.Rows[e.RowIndex];
                dtpRandevuTarihi.Text = satir.Cells["randevuTarihiDataGridViewTextBoxColumn"].Value.ToString();
                txtRandevuKonusu.Text = satir.Cells["randevuKonuDataGridViewTextBoxColumn"].Value.ToString();
                txtGorusulecekKisi.Text = satir.Cells["gorusulecekKisiDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.Rows.Count > 0)
            {
                string randevuKonu = txtRandevuKonusu.Text;
                string gorusulecekKisi = txtGorusulecekKisi.Text;
                DateTime randevuTarihi = dtpRandevuTarihi.Value;

                string secilenRandevuKodu = dgvRandevular.SelectedRows[0].Cells["randevuKoduDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand command = new SqlCommand(@"UPDATE randevular SET randevuKonu = @randevukonu, gorusulecekKisi = @gorusulecekkisi WHERE randevuKodu = @randevukodu", baglanti);
                command.Parameters.AddWithValue("@randevukonu", randevuKonu);
                command.Parameters.AddWithValue("@gorusulecekkisi", gorusulecekKisi);
                command.Parameters.AddWithValue("@randevutarihi", randevuTarihi);
                command.Parameters.AddWithValue("@randevukodu", secilenRandevuKodu);

                try
                {
                    baglanti.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Randevu güncellendi.");
                    ListeleRandevular();
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
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.");
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.SelectedCells.Count > 0)
            {
                string secilenRandevuKodu = dgvRandevular.SelectedRows[0].Cells["randevuKoduDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand komut = new SqlCommand("DELETE FROM randevular WHERE randevuKodu = @randevukodu", baglanti);
                komut.Parameters.AddWithValue("@randevukodu", secilenRandevuKodu);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Randevu silindi.");
                    ListeleRandevular();
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
            if (dgvRandevular.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "Randevular.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Randevular");

                    // Başlıkları yaz
                    for (int i = 0; i < dgvRandevular.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvRandevular.Columns[i].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dgvRandevular.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvRandevular.Columns.Count; j++)
                        {
                            var val = dgvRandevular.Rows[i].Cells[j].Value;
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
            YoneticiPanel yoneticipanel = new YoneticiPanel();
            this.Hide();
            yoneticipanel.Show();
        }
    }
}
