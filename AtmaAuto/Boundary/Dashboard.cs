using AtmaAuto.Entity;
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
        private string str { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.str = fh.ReadData();
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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnCabang_Click_1(object sender, EventArgs e)
        {
            FormCabang foc = new FormCabang();
            foc.Show();
            this.Hide();
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            FormSupplier fos = new FormSupplier();
            fos.Show();
            this.Hide();
        }

        private void btnSparepart_Click_1(object sender, EventArgs e)
        {
            FormSparepart fosp = new FormSparepart();
            fosp.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FileHandling wr = new FileHandling();
            wr.WriteData("");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnLayanan_Click_1(object sender, EventArgs e)
        {
            FormLayanan fola = new FormLayanan();
            fola.Show();
            this.Hide();
        }

        private void btnKendaraan_Click_1(object sender, EventArgs e)
        {
            FormKendaraan foke = new FormKendaraan();
            foke.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormPegawai fopeg = new FormPegawai();
            fopeg.Show();
            this.Hide();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            FormPembayaran fobay = new FormPembayaran();
            fobay.Show();
            this.Hide();
        }

        private void btnLaporan_Click_1(object sender, EventArgs e)
        {
            FormLaporan folap = new FormLaporan();
            folap.Show();
            this.Hide();
        }
    }
}
