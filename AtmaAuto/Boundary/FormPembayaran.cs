using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.PembayaranControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;

namespace AtmaAuto.Boundary
{
    public partial class FormPembayaran : Form
    {
        private dynamic pembayarans { get; set; }
        private int setTableStatus = 0;
        PembayaranControl pembayaranControl = new PembayaranControl();
        

        public FormPembayaran()
        {
            InitializeComponent();
            FileHandling fh = new FileHandling();
            this.pembayaranControl.token = fh.ReadData();
            string responseContent = pembayaranControl.getData();
            this.pembayarans = JArray.Parse(responseContent.ToString());
            this.setTable();
        }

        PembayaranControl pbc = new PembayaranControl();

        public void setTable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Status");
            dt.Columns.Add("Nama Cabang");
            dt.Columns.Add("ID Transaksi");
            dt.Columns.Add("Nomor Transaksi");
            dt.Columns.Add("Nama Customer");
            dt.Columns.Add("Total Services");
            dt.Columns.Add("Total Spareparts");
            dt.Columns.Add("Total Transaksi");
            dt.Columns.Add("Pembayaran");
            dt.Columns.Add("Diskon");
            dt.Columns.Add("Nama CS");
            dt.Columns.Add("Nama Cashier");
            

            foreach (dynamic pembayaran in this.pembayarans)
            {
                DataRow row = dt.NewRow();

                row["Status"] = "Belum diBayarkan" ;
                row["Nama Cabang"] = pembayaran.branch.name;
                row["ID Transaksi"] = pembayaran.id;
                row["Nomor Transaksi"] = pembayaran.transactionNumber;
                row["Nama Customer"] = pembayaran.customer.name;
                row["Total Services"] = pembayaran.totalServices;
                row["Total Spareparts"] = pembayaran.totalSpareparts;
                row["Total Transaksi"] = pembayaran.totalCost;
                row["Pembayaran"] = pembayaran.payment;
                row["Diskon"] = pembayaran.diskon;
                row["Nama CS"] = pembayaran.cs.name;
                row["Nama Cashier"] = pembayaran.cashier.name;
            
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


        public void setStatus()
        {
                Console.WriteLine("Hello World");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string responseContent = pbc.getData();
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
            txtPilih.Text = dataGridView1[3, baris].Value.ToString();
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

     
        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (txtPilih.Text != null && txtPilih.Text != "" )
            {

                string success = pbc.getData();
                dynamic json = JObject.Parse(success);
                MessageBox.Show("Data Anda Berhasil Ditambahkan", "SELAMAT", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Silahkan Input Data", "PERINGATAN", MessageBoxButtons.OK);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPilih.Text != null && txtPilih.Text != "" )
            {
               
             

                MessageBox.Show("Data Anda Berhasil Ditambahkan", "SELAMAT", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Silahkan Input Data", "PERINGATAN", MessageBoxButtons.OK);
            }
        }
    }
}
