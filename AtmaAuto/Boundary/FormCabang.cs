﻿using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.CabangControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormCabang : Form
    {
        private dynamic cabangs { get; set; }
        private int setTableStatus = 0;
        CabangControl cabangControl = new CabangControl();

        public FormCabang()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.cabangControl.token = fh.ReadData();
            string responseContent = cabangControl.getData();
            this.cabangs = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        CabangControl CC = new CabangControl();

        
        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
         

            foreach (dynamic cabang in this.cabangs)
            {
                DataRow row = dt.NewRow();
                row["ID"] = cabang.id;
                row["Name"] = cabang.name;
                
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string responseContent = CC.getData();
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
            txtNamaCabang.Text = dataGridView1[2, baris].Value.ToString();

            
        }

        private void FormCabang_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            if (txtNamaCabang.Text != null && txtNamaCabang.Text != "")
            {
                Cabang cabang = new Cabang();
                cabang.name = txtNamaCabang.Text;
                string success = cabangControl.sendData(cabang);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = cabangControl.getData();
                    this.cabangs = JArray.Parse(responseContent.ToString());
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
            if (txtNamaCabang.Text != null && txtNamaCabang.Text != "")
            {
                Cabang cabang = new Cabang();
                cabang.name = txtNamaCabang.Text;
                int inputId = Int32.Parse(txtID.Text);
                string success = cabangControl.updateData(cabang,inputId);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                    string responseContent = cabangControl.getData();
                    this.cabangs = JArray.Parse(responseContent.ToString());
                    this.setTable();
                    MessageBox.Show("Data Anda Berhasil Diupdate", "SELAMAT", MessageBoxButtons.OK);
                }
                MessageBox.Show("Data Anda Tidak Berhasil Diupdate", "PERINGATAN", MessageBoxButtons.OK);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNamaCabang_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPencarian_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string sql = "select * from example where nama like '%"+txtPencarian.Text+"%'"+"order by no asc";
            

        }

        static void ShowDGV()
        {
            System.Data.DataTable dt = new DataTable();

        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (txtNamaCabang.Text != null && txtNamaCabang.Text != "")
            {
                Cabang cabang = new Cabang();
                cabang.name = txtNamaCabang.Text;
                int inputId = Int32.Parse(txtID.Text);
                string success = cabangControl.deleteData(inputId);
                dynamic json = JObject.Parse(success);
                if (success != null)
                {
                     cabangControl.deleteData(cabang.id);
         
                    this.setTable();
                    MessageBox.Show("Data Anda Berhasil Dihapuskan", "SELAMAT", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Data Tidak Berhasil", "PERHATIAN!", MessageBoxButtons.OK);
                }
                

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
