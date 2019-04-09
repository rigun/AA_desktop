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
using AtmaAuto.Entity;
using AtmaAuto.Control;
using Newtonsoft.Json.Linq;

namespace AtmaAuto.Boundary
{
    public partial class FormKendaraan : Form
    {
        public FormKendaraan()
        {
            InitializeComponent();
            KendaraanControl KC = new KendaraanControl();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ingin Keluar Dari Aplikasi Ini ???", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FileHandling wr = new FileHandling();
                wr.WriteData("");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
        }
    }
}
