using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaOtomasyonApp
{
    public partial class PersonelPanel : Form
    {
        public PersonelPanel()
        {
            InitializeComponent();
        }
        public string KullaniciAdi { get; set; }

        private void PersonelPanel_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = $"Sn. {KullaniciAdi}, hoş geldiniz.";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btnMalzemeler_Click(object sender, EventArgs e)
        {
            Malzemeler malzemeler = new Malzemeler();
            malzemeler.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnEvraklar_Click(object sender, EventArgs e)
        {
            Evraklar evraklar = new Evraklar();
            evraklar.Show();
            this.Hide();
        }
    }
}
