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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.Rows.Count > 0)
            {
                string kullaniciAdi = txtKullaniciAdi.Text;
                string sifre = txtSifre.Text;
                string rol = cbRol.Text;

                string secilenkullaniciid = dgvKullanicilar.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value?.ToString();

                SqlCommand command = new SqlCommand(@"UPDATE kullanicilar SET kullaniciAdi = @kullaniciadi, sifre = @sifre, rol = @rol WHERE id = @eskikullaniciid", baglanti);

                command.Parameters.AddWithValue("@eskikullaniciid", secilenkullaniciid);
                command.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", sifre);
                command.Parameters.AddWithValue("@rol", rol);

                try
                {
                    baglanti.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Personel güncellendi.");
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
                MessageBox.Show("Lütfen güncellenecek bir Personel seçin.");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvKullanicilar.Rows[e.RowIndex];
                txtKullaniciAdi.Text = satir.Cells["kullaniciAdiDataGridViewTextBoxColumn"].Value.ToString();
                txtSifre.Text = satir.Cells["sifreDataGridViewTextBoxColumn"].Value.ToString();
                cbRol.Text = satir.Cells["rolDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnExcelAktarma_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "Kullanicilar.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Kullanicilar");

                    // Başlıkları yaz
                    for (int i = 0; i < dgvKullanicilar.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvKullanicilar.Columns[i].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dgvKullanicilar.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvKullanicilar.Columns.Count; j++)
                        {
                            var val = dgvKullanicilar.Rows[i].Cells[j].Value;
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
