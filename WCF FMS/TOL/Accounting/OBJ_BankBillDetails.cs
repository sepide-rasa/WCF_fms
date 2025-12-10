using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_BankBillDetails
    {
        public int fldId { get; set; }
        public int fldHedearId { get; set; }
        public long fldBedehkar { get; set; }
        public long fldBestankar { get; set; }
        public long fldMandeh { get; set; }
        public string fldTarikh { get; set; }
        public string fldTime { get; set; }
        public string fldCodePeygiri { get; set; }
    }
}