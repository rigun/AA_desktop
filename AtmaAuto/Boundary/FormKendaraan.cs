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
            dt.Columns.Add("ID Kendaraan");
            dt.Columns.Add("Merk Kendaraan");
            dt.Columns.Add("Type Kendaraan");
           

            foreach (dynamic kendaraan in this.kendaraans)
            {
                DataRow row = dt.NewRow();
                row["ID Kendaraan"] = kendaraan.id;
                row["Merk Kendaraan"] = kendaraan.merk;
                row["Type Kendaraan"] = kendaraan.type;
               
                dt.Rows.Add(row);

            }


            dataGridView1.DataSource = dt;
            if (this.setTableStatus == 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Pengaturan";
                btn.Text = "Pilih";
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
                string success = kendaraanControl.sendData(kendaraan);
              
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = kendaraanControl.getData();
                    this.kendaraans = JArray.Parse(responseContent.ToString());
                   this.setTable();
                }
                MessageBox.Show("Data Anda Berhasil Ditambahkan", "SELAMAT", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Silahkan Input Data", "PERINGATAN", MessageBoxButtons.OK);
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
            
            int baris = int.Parse(e.RowIndex.ToString());
            txtID.Text = dataGridView1[1, baris].Value.ToString();
            txtNamaKendaraan.Text = dataGridView1[2, baris].Value.ToString();
            txtMerkKendaraan.Text = dataGridView1[3, baris].Value.ToString();
        }

        private void txtPencarian_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string sql = "select * from example where nama like '%" + txtPencarian.Text + "%'" + "order by no asc";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtNamaKendaraan.Text != null && txtNamaKendaraan.Text != "" || txtMerkKendaraan.Text != null && txtMerkKendaraan.Text != "")
            {
                Kendaraan kendaraan = new Kendaraan();
                kendaraan.merk = txtMerkKendaraan.Text;
                kendaraan.type = txtNamaKendaraan.Text;
                int inputId = Int32.Parse(txtID.Text);
                string success = kendaraanControl.deleteData(inputId);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    kendaraanControl.deleteData(kendaraan.id);
                    this.setTable();
                    MessageBox.Show("Data Anda Berhasil Dihapuskan", "SELAMAT", MessageBoxButtons.OK);
                }
                MessageBox.Show("Data Anda Tidak Berhasil Dihapuskan", "SELAMAT", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNamaKendaraan.Text != null && txtNamaKendaraan.Text != "" || txtMerkKendaraan.Text != null && txtMerkKendaraan.Text != "")
            {
                Kendaraan kendaraan = new Kendaraan();
                kendaraan.merk = txtMerkKendaraan.Text;
                kendaraan.type = txtNamaKendaraan.Text;
                int inputId = Int32.Parse(txtID.Text);
                string success = kendaraanControl.updateData(kendaraan,inputId);

                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = kendaraanControl.getData();
                    this.kendaraans = JArray.Parse(responseContent.ToString());
                    this.setTable();
                }
                MessageBox.Show("Data Anda Berhasil Diupdate", "SELAMAT", MessageBoxButtons.OK);
            }
        }
    }
}
