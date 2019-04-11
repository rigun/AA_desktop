using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.KendaraanControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormKendaraan : Form
    {
        private dynamic kendaraans { get; set; }
        private int setTableStatus = 0;
        KendaraanControl kendaraanControl = new KendaraanControl();

        public FormKendaraan()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.kendaraanControl.token = fh.ReadData();
            string responseContent = kendaraanControl.getData();
            this.kendaraans = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        KendaraanControl KC = new KendaraanControl();
        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("Dibuat Pada");

            foreach (dynamic kendaraan in this.kendaraans)
            {
                DataRow row = dt.NewRow();
                row["Merk"] = kendaraans.merk;
                row["Type"] = kendaraans.type;
                row["Dibuat Pada"] = kendaraans.created_at;
                dt.Rows.Add(row);

            }


            dataGridView1.DataSource = dt;
            if (this.setTableStatus == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Pengaturan";
                btn.Text = "Hapus";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                this.setTableStatus = 1;
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNamaKendaraan.Text != null && txtNamaKendaraan.Text != "" || txtMerkKendaraan.Text != null && txtMerkKendaraan.Text != "")
            {
                Kendaraan kendaraan = new Kendaraan();
                kendaraan.merk = txtMerkKendaraan.Text;
                kendaraan.type = txtNamaKendaraan.Text;
                string success = kendaraanControl.sendData(kendaraans);
              
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = kendaraanControl.getData();
                    this.kendaraans = JArray.Parse(responseContent.ToString());
                   this.setTable();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string responseContent = KC.getData();
            dynamic json = JObject.Parse(responseContent);
            string token = json.access_token;
            if (token != null)
            {
                FileHandling wr = new FileHandling();
                wr.WriteData(token);
                Dashboard dsh = new Dashboard();
                dsh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silahkan Masukkan Data Tepat!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show((e.RowIndex + 1) + "Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
        }
    }
}
