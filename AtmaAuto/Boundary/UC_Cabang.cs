using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtmaAuto.Control;

namespace AtmaAuto.Boundary
{
    public partial class UC_Cabang : UserControl
    {
        public UC_Cabang()
        {
            InitializeComponent();
        }

        SIAAControl SIAA = new SIAAControl();

        int flagperintah = 0;
        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
        }    

        public void cleartxt()
        {
        }

    }
}
