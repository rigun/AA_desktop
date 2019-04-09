using AtmaAuto.Boundary;
using AtmaAuto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmaAuto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileHandling fh = new FileHandling();
            string str = null;
            try
            {
                str = fh.ReadData();
            }catch(Exception ex)
            {
                str = null;
            }
            if (str != null && str != "")
            {
                Application.Run(new Dashboard());
            }
            else
            {
                Application.Run(new Form1());

            }
        }
    }
}
