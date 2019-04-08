using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmaAuto.Boundary
{
    public partial class UC_Kendaraan : UserControl
    {
        public UC_Kendaraan()
        {
            InitializeComponent();
        }

        private void txtTipeKendaraan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
