using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_FiscalTitle
    {
        public int fldId { get; set; }
        public int fldFiscalHeaderId { get; set; }
        public int fldItemEstekhdamId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldTitle { get; set; }
        public string fldAnvaeEstekhdamTitle { get; set; }
        public int fldAnvaEstekhdamId { get; set; }
    }
}