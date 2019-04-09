using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtmaAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LoginControl LC = new LoginControl();

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string responseContent = LC.cekLogin(txtUsername.Text, txtPassword.Text);
            dynamic json = JObject.Parse(responseContent);
            string token= json.access_token;
            MessageBox.Show(token, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string responseContent = LC.cekLogin(txtUsername.Text, txtPassword.Text);
            dynamic json = JObject.Parse(responseContent);
            string token = json.access_token;
            MessageBox.Show(token, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}