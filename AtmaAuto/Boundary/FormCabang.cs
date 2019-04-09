using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.CabangControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtmaAuto.Boundary
{
    public partial class FormCabang : Form
    {
        private dynamic cabangs { get; set; }
        public FormCabang()
        {
            InitializeComponent();
            CabangControl cabangControl = new CabangControl();
            string responseContent = cabangControl.getData();
            this.cabangs = JObject.Parse(responseContent);
        }

        CabangControl CC = new CabangControl();

        private void btnTambah_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnCabang_Click(object sender, EventArgs e)
        {
            FormCabang fc = new FormCabang();
            fc.Show();
            this.Hide();

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
        



        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
         

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnCabang_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
            if (MessageBox.Show("Ingin Keluar Dari Aplikasi Ini ???", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCabang_Load(object sender, EventArgs e)
        {

        }
    }
}
