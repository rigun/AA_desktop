using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.PegawaiControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormPegawai : Form
    {
        private dynamic pegawais { get; set; }
        private int setTableStatus = 0;
        PegawaiControl pegawaiControl = new PegawaiControl();

        public FormPegawai()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.pegawaiControl.token = fh.ReadData();
            string responseContent = pegawaiControl.getData();
            this.pegawais = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        PegawaiControl PC = new PegawaiControl();
        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Cabang");
            dt.Columns.Add("Pekerjaan");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Nomor Telepon");
            dt.Columns.Add("Alamat");
            dt.Columns.Add("Kota");
            dt.Columns.Add("Gaji");
            dt.Columns.Add("Dibuat Pada");

            foreach (dynamic pegawai in this.pegawais)
            {
                DataRow row = dt.NewRow();
                row["Cabang"] = pegawai.branch.name;
                row["Pekerjaan"] = pegawai.detail.role.name;
                row["Nama"] = pegawai.detail.name;
                row["Nomor Telepon"] = pegawai.detail.phoneNumber;
                row["Alamat"] = pegawai.detail.address;
                row["Kota"] = pegawai.detail.city;
                row["Gaji"] = pegawai.salary;
                row["Dibuat pada"] = pegawai.created_at;
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtCabang.Text != null && txtCabang.Text != "" || txtRole.Text != null && txtRole.Text != "" || txtName.Text != null && txtName.Text != "" || txtTelp.Text != null && txtTelp.Text != "" || txtAlamat.Text != null && txtAlamat.Text != "" || txtKota.Text != null && txtKota.Text != "" || txtSalary.Text != null && txtSalary.Text != "")
            {
                Pegawai pegawai = new Pegawai();
                pegawai.branch = txtCabang.Text;
                pegawai.role = txtRole.Text;
                pegawai.name = txtName.Text;
                pegawai.phoneNumber = txtTelp.Text;
                pegawai.address = txtAlamat.Text;
                pegawai.city = txtKota.Text;
                pegawai.salary = txtSalary.Text;

                string success = pegawaiControl.sendData(pegawai);

                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = pegawaiControl.getData();
                    this.pegawais = JArray.Parse(responseContent.ToString());
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
            String responseContent = PC.getData();
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

            int baris = int.Parse(e.RowIndex.ToString());
            txtRole.Text = dataGridView1[1, baris].Value.ToString();
            txtName.Text = dataGridView1[2, baris].Value.ToString();
            txtTelp.Text = dataGridView1[3, baris].Value.ToString();
            txtAlamat.Text = dataGridView1[4, baris].Value.ToString();
            txtKota.Text = dataGridView1[5, baris].Value.ToString();
            txtSalary.Text = dataGridView1[6, baris].Value.ToString();
        }

        private void txtName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPencarian_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string sql = "select * from example where nama like '%" + txtPencarian.Text + "%'" + "order by no asc";
        }
    }
}
