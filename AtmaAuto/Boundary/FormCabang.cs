using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.CabangControl;
using Newtonsoft.Json;

namespace AtmaAuto.Boundary
{
    public partial class FormCabang : Form
    {
        public FormCabang()
        {
            InitializeComponent();
        }

        CabangControl CC = new CabangControl();

        private void btnTambah_Click(object sender, EventArgs e)
        {
            UserData1 userData1 = new UserData1();
            userData1.cabang = txtCabang.Text;
            
            String Json = JsonConvert.SerializeObject(userData1);
            CC.postJson = Json;

            if (CC.tambahCabang() != "error")
            {
            }
           
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
            UserData1 userData1 = new UserData1();
            userData1.cabang = txtCabang.Text;

            String Json = JsonConvert.SerializeObject(userData1);
            CC.postJson = Json;

            if (CC.hapusCabang() != "error")
            {
            }



        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            UserData1 userData1 = new UserData1();
            userData1.cabang = txtCabang.Text;

            String Json = JsonConvert.SerializeObject(userData1);
            CC.postJson = Json;

            if (CC.hapusCabang() != "error")
            {
            }

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserData1 userData1 = new UserData1();
            userData1.cabang = txtCabang.Text;

            String Json = JsonConvert.SerializeObject(userData1);
            CC.postJson = Json;

            if (CC.tampilCabang() != "error")
            {
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
