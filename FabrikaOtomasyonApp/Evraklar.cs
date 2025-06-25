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
    public partial class Evraklar : Form
    {
        private SqlConnection baglanti;
        public Evraklar()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=MFURKANOTARA\\SQLEXPRESS;Initial Catalog=dbFabrika;Integrated Security=True");
        }

        private void Evraklar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet2.evraklar' table. You can move, or remove it, as needed.
            // this.evraklarTableAdapter.Fill(this.dbFabrikaDataSet2.evraklar);
            ListeleEvraklar();
        }

        private void ListeleEvraklar()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM evraklar", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvEvraklar.DataSource = dataTable;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string evrakadi = txtEvrakAdi.Text;
            string evrakturu = txtEvrakTuru.Text;
            string birim = txtBirim.Text;
            DateTime tarih = dtpTarih.Value;
            string dosyayolu = txtDosyaYolu.Text;
            string aciklama = txtAciklama.Text;

            if (string.IsNullOrEmpty(evrakadi) || string.IsNullOrEmpty(evrakturu) || string.IsNullOrEmpty(birim) || !dtpTarih.Checked || string.IsNullOrEmpty(dosyayolu) || string.IsNullOrEmpty(aciklama))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }

            SqlCommand command = new SqlCommand("INSERT INTO malzemeler (evrakAdi, evrakTuru, birim, tarih, dosyaYolu, aciklama) VALUES (@evrakadi, @evrakturu, @birim, @tarih, @dosyayolu, @aciklama)", baglanti);
            command.Parameters.AddWithValue("@evrakadi", evrakadi);
            command.Parameters.AddWithValue("@malzemeadi", evrakturu);
            command.Parameters.AddWithValue("@birim", birim);
            command.Parameters.AddWithValue("@tarih", tarih);
            command.Parameters.AddWithValue("@dosyayolu", dosyayolu);
            command.Parameters.AddWithValue("@aciklama", aciklama);

            try
            {
                baglanti.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Evrak kaydedildi.");
                ListeleEvraklar();
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
            txtEvrakAdi.Text = "";
            txtEvrakTuru.Text = "";
            txtBirim.Text = "";
            txtDosyaYolu.Text = "";
            txtAciklama.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvEvraklar.SelectedCells.Count > 0)
            {
                string secilenevrakId = dgvEvraklar.SelectedRows[0].Cells["evrakIdDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand komut = new SqlCommand("DELETE FROM evraklar WHERE evrakId = @evrakId", baglanti);
                komut.Parameters.AddWithValue("@evrakId", secilenevrakId);

                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Evrak silindi.");
                    ListeleEvraklar();
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
            if (dgvEvraklar.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "Evraklar.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Evraklar");

                    // Başlıkları yaz
                    for (int i = 0; i < dgvEvraklar.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvEvraklar.Columns[i].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dgvEvraklar.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvEvraklar.Columns.Count; j++)
                        {
                            var val = dgvEvraklar.Rows[i].Cells[j].Value;
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
