using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmaAuto.Entity
{
    class Pembayaran
    {
        public int branch { get; set; }
        public int id { get; set; }
        public int branch_id { get; set; }
        public int cs_id  { get; set; }
        public int cashier_id { get; set; }
        public string transaction { get; set; }
        public int id_transaction { get; set; }
        public string transactionNumber { get; set; }
        public string totalservices { get; set; }
        public string  totalspareparts{ get; set; }
        public string  totalcost{ get; set; }
        public string  payment{ get; set; }
        public string  diskon{ get; set; }
        public string  status{ get; set; }
       
}
}
