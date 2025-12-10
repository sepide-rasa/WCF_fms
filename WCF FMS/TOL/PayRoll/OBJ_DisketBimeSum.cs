using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_DisketBimeSum
    {
        public decimal fldItem { get; set; }
        public decimal fldMashmolBime { get; set; }
        public decimal fldBimePersonal { get; set; }
        public decimal fldBimeKarFarma { get; set; }
        public decimal fldBimeBikari { get; set; }
        public decimal fldJBime { get; set; }
        public string fldWorkShopName { get; set; }
        public string fldWorkShopNum { get; set; }
        public int fldMan { get; set; }
        public int fldWomen { get; set; }
    }
}