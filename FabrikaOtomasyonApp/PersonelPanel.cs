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
        }

        private void btnMalzemeler_Click(object sender, EventArgs e)
        {
            Malzemeler malzemeler = new Malzemeler();
            malzemeler.Show();
            this.Hide();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            Stoklar stoklar = new Stoklar();
            stoklar.Show();
            this.Hide();
        }
    }
}
