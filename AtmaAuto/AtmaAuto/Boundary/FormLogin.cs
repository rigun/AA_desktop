using System;
using System.Windows.Forms;
using AtmaAuto.Control;
using Newtonsoft.Json;

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
            UserData userData = new UserData();
            userData.email = txtUsername.Text;
            userData.password = txtPassword.Text;
            

            String Json = JsonConvert.SerializeObject(userData);
            LC.postJson = Json;
            if (LC.cekLogin() != "error")
            {
            
                
                MessageBox.Show(LC.cekLogin(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Username atau Password salah !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

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
    }
}