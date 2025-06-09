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
    }
}
