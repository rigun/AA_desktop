using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.SparepartControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormSparepart : Form
    {
        private dynamic spareparts { get; set; }
        private int setTableStatus = 0;
        SparepartControl SparepartControl = new SparepartControl();

        public FormSparepart()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.SparepartControl.token = fh.ReadData();
            string responseContent = SparepartControl.getData();
            this.spareparts = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        SparepartControl SPC = new SparepartControl();

        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Kode");
            dt.Columns.Add("Name");
            dt.Columns.Add("Merk");
            dt.Columns.Add("Type");
            dt.Columns.Add("supplier_id");
            ;

            foreach (dynamic sparepart in this.spareparts)
            {
                DataRow row = dt.NewRow();
                row["Kode"] = sparepart.code;
                row["Name"] = sparepart.name;
                row["Merk"] = sparepart.merk;
                row["Type"] = sparepart.type;
                row["Supplier_id"] = sparepart.supplier_id;
                
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

        private void btnCabang_Click(object sender, EventArgs e)
        {

        }

        private void FormSparepart_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String responseContent = SPC.getData();
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
            txtKode.Text = dataGridView1[1, baris].Value.ToString();
            txtNamaSparepart.Text = dataGridView1[2, baris].Value.ToString();
            txtMerk.Text = dataGridView1[3, baris].Value.ToString();
            txtType.Text = dataGridView1[4, baris].Value.ToString();
            txtIDSupplier.Text = dataGridView1[5, baris].Value.ToString();
            
        }

        private void txtCabang_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != null && txtKode.Text != "" || txtType.Text != null && txtType.Text != "" || txtIDSupplier.Text != null && txtIDSupplier.Text != "" || txtNamaSparepart.Text != null && txtNamaSparepart.Text != "")
            {
                Sparepart sparepart = new Sparepart();
                sparepart.branch = txtCabang.Text;
                sparepart.code = txtKode.Text;
                sparepart.name = txtNamaSparepart.Text;
                sparepart.merk = txtMerk.Text;
                sparepart.type = txtType.Text;
                sparepart.supplier_id = txtIDSupplier.Text;
                

                string success = SparepartControl.sendData(sparepart);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = SparepartControl.getData();
                    this.spareparts = JArray.Parse(responseContent.ToString());
                    this.setTable();
                }
                MessageBox.Show("Data Anda Berhasil Ditambahkan", "SELAMAT", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Silahkan Input Data", "PERINGATAN", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != null && txtKode.Text != "" || txtType.Text != null && txtType.Text != "" || txtIDSupplier.Text != null && txtIDSupplier.Text != "" || txtNamaSparepart.Text != null && txtNamaSparepart.Text != "")
            {
                Sparepart sparepart = new Sparepart();

                sparepart.code = txtKode.Text;
                sparepart.name = txtNamaSparepart.Text;
                sparepart.merk = txtMerk.Text;
                sparepart.type = txtType.Text;
                sparepart.supplier_id = txtIDSupplier.Text;

                int inputId = Int32.Parse(txtNamaSparepart.Text);
                string success = SparepartControl.updateData(sparepart, inputId);

                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = SparepartControl.getData();
                    this.spareparts = JArray.Parse(responseContent.ToString());
                    this.setTable();
                    MessageBox.Show("Data Anda Berhasil Diupdate", "SELAMAT", MessageBoxButtons.OK);
                }
                MessageBox.Show("Data Anda Tidak Berhasil Diupdate", "PERINGATAN", MessageBoxButtons.OK);

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != null && txtKode.Text != "" || txtType.Text != null && txtType.Text != "" || txtIDSupplier.Text != null && txtIDSupplier.Text != "" || txtNamaSparepart.Text != null && txtNamaSparepart.Text != "")
            {
                Cabang cabang = new Cabang();
                spareparts.code = txtKode.Text;
                spareparts.name = txtNamaSparepart.Text;
                spareparts.merk = txtMerk.Text;
                spareparts.type = txtType.Text;
                spareparts.supplier_id = txtIDSupplier.Text;



                int inputId = Int32.Parse(txtNamaSparepart.Text);
                string success = SparepartControl.deleteData(inputId);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {

                    SparepartControl.deleteData(spareparts.id);
                    this.setTable();
                    MessageBox.Show("Data Anda Berhasil Dihapuskan", "SELAMAT", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Data Tidak Berhasil", "PERHATIAN!", MessageBoxButtons.OK);
                }

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }
    }
}