using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using AtmaAuto.Control;

namespace AtmaAuto
{
    public partial class FormLayanan : Form
    {
        public FormLayanan()
        {
            InitializeComponent();
        }

        LayananControl LC = new LayananControl();

        private void btnCari_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Boundary.Dashboard dsh = new Boundary.Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            userData2 userData2 = new userData2();
            userData2.namalayanan = txtLayanan.Text;
            userData2.biaya = txtBiaya.Text;

            string Json = JsonConvert.SerializeObject(userData2);
            LC.postJson = Json;

            if (LC.tambahLayanan() != "error")
            {
            }

        }
    }
}
