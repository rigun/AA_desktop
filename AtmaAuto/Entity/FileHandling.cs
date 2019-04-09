using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmaAuto.Entity
{
    class FileHandling
    {
        public void WriteData(string token)
        {
            FileStream fs = new FileStream("e:\\token.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(token);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public string ReadData()
        {
            FileStream fs = new FileStream("e:\\token.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            sr.Close();
            fs.Close();
            return str;
        }
    }
}
