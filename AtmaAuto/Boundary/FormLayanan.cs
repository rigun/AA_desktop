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
using AtmaAuto.Boundary;
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
           

        }

        private void btnCabang_Click(object sender, EventArgs e)
        {
            FormCabang foc = new FormCabang();
            foc.Show();
            this.Hide();
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            FormLayanan fola = new FormLayanan();
            fola.Show();
            this.Hide();
        }

        private void btnKendaraan_Click(object sender, EventArgs e)
        {
            FormKendaraan foke = new FormKendaraan();
            foke.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPegawai fopeg = new FormPegawai();
            fopeg.Show();
            this.Hide();
        }

        private void btnSparepart_Click(object sender, EventArgs e)
        {
            FormSparepart fosp = new FormSparepart();
            fosp.Show();
            this.Hide();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            FormPembayaran fobay = new FormPembayaran();
            fobay.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan folap = new FormLaporan();
            folap.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {

        }
    }
}
