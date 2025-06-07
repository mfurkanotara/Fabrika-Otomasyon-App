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
    public partial class Evraklar : Form
    {
        public Evraklar()
        {
            InitializeComponent();
        }

        private void Evraklar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFabrikaDataSet2.evraklar' table. You can move, or remove it, as needed.
            this.evraklarTableAdapter.Fill(this.dbFabrikaDataSet2.evraklar);

        }
    }
}
