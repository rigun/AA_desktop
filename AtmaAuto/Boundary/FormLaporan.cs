using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.LapSpLarisControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;
using System.Diagnostics;

namespace AtmaAuto.Boundary
{
    public partial class FormLaporan : Form
    {
        private dynamic laporans { get; set; }
        private int setTableStatus = 0;
        LapSpLarisControl LapSpLarisControl = new LapSpLarisControl();

        public FormLaporan()
        {
            InitializeComponent();
        }

        

        private void btnLapSpLaris_Click(object sender, EventArgs e)
        {
            Process.Start("https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
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
    }
}
