using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using static AtmaAuto.Control.LapSpLarisControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using AtmaAuto.Entity;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace AtmaAuto.Boundary
{
    public partial class FormLaporan : Form
    {
   

        public FormLaporan()
        {
            InitializeComponent();
        }


    

        private void btnLapSpLaris_Click(object sender, EventArgs e)
        {

            var url = "https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf";
            using (var client = new HttpClient())
            {
                
                var req = client.GetAsync(url).ContinueWith(res =>{
                    var result = res.Result;
                    
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readData = result.Content.ReadAsAsync();
                        readData.wait();
                        var ReadStream = readData.Result;
                       
                      
                        
                    }
                });
                req.Wait();
            }
                        
            
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

        private void LapPenBul_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf", @"D:\P3L\Laporan.pdf");
        }

        private void LapSisaStok_Click(object sender, EventArgs e)
        {
            var t = new Task(DownloadPageAsync);
            t.Start();

            Console.WriteLine("Downloading Page");
            Console.ReadLine();

        }

        public static async void DownloadPageAsync()
        {
            var page = "https://api1.thekingcorp.org/files/report/sparepartTerlaris/09-2019.pdf";
           
        }
    }
}
