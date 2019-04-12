using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.LayananControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormLayanan : Form
    {
        private dynamic layanans { get; set; }
        private int setTableStatus = 0;
        LayananControl layanancontrol = new LayananControl();

        public FormLayanan()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.layanancontrol.token = fh.ReadData();
            string responseContent = layanancontrol.getData();
            this.layanans = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        LayananControl LC = new LayananControl();

        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("name");
            dt.Columns.Add("price");
            dt.Columns.Add("Dibuat Pada");

            foreach (dynamic layanan in this.layanans)
            {
                DataRow row = dt.NewRow();
                row["Name"] = layanan.name;
                row["Price"] = layanan.price;
                row["Dibuat pada"] = layanan.created_at;
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



        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtLayanan.Text != null && txtLayanan.Text != "" || txtBiaya.Text != null && txtBiaya.Text != "")
            {
            
                Layanan layanan = new Layanan();
                layanan.name = txtLayanan.Text;
                layanan.price = txtBiaya.Text;
                string success = layanancontrol.sendData(layanan);
           
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = layanancontrol.getData();
                    this.layanans = JArray.Parse(responseContent.ToString());
                    this.setTable();
                }
                MessageBox.Show("Data Anda Berhasil Ditambahkan", "SELAMAT", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string responseContent = LC.getData();
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
