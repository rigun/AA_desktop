using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmaAuto.Boundary
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCabang_Click(object sender, EventArgs e)
        {
            FormCabang fc = new FormCabang();
            fc.Show();
            this.Hide();
           
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
            this.Hide();
        }

        private void btnSparepart_Click(object sender, EventArgs e)
        {
            FormSparepart fsp = new FormSparepart();
            fsp.Show();
            this.Hide();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnTambahLayanan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTambahKendaraan_Click(object sender, EventArgs e)
        {
            UC_Kendaraan uck = new UC_Kendaraan();
            uck.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            FormLayanan fl = new FormLayanan();
            fl.Show();
            this.Hide();
        }

        private void btnKendaraan_Click(object sender, EventArgs e)
        {
            FormKendaraan fk = new FormKendaraan();
            fk.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan fla = new FormLaporan();
            fla.Show();
            this.Hide();
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            FormPegawai fp = new FormPegawai();
            fp.Show();
            this.Hide();
        }

        private void btnSparepartCabang_Click(object sender, EventArgs e)
        {
            FormSparepart fs = new FormSparepart();
            fs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrder fo = new FormOrder();
            fo.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
