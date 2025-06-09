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
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }
        public string KullaniciAdi { get; set; }

        private void YoneticiPanel_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = $"Sn. {KullaniciAdi}, hoş geldiniz.";
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Hide();
        }
    }
}
