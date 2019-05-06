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
            dt.Columns.Add("ID Cabang");
            dt.Columns.Add("ID Transaction");
            dt.Columns.Add("Transaction Number");
            dt.Columns.Add("Total Services");
            dt.Columns.Add("Total Spareparts");
            dt.Columns.Add("Total Cost");
            dt.Columns.Add("Payment");
            dt.Columns.Add("Diskon");
            dt.Columns.Add("CS ID");
            dt.Columns.Add("Customer ID");
            dt.Columns.Add("Cashier ID");


            foreach (dynamic pembayaran in this.pembayarans)
            {
                DataRow row = dt.NewRow();
                
                row["ID Cabang"] = pembayaran.id;
                
                row["Transaction Number"] = pembayaran.transaction.transactionNumber;
                row["Total Services"] = pembayaran.totalServices;
                row["Total Spareparts"] = pembayaran.totalSpareparts;
                row["Total Cost"] = pembayaran.totalCost;
                row["Payment"] = pembayaran.payment;
                row["Diskon"] = pembayaran.diskon;
                row["CS ID"] = pembayaran.cs_id;
                row["Customer ID"] = pembayaran.customer_id;
                row["Cashier ID"] = pembayaran.cashier_id;

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

        }
    }
}
