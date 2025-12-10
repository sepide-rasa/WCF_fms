using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SavabegheSanavateKHedmat
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public bool fldNoeSabeghe { get; set; }
        public string fldNoeSabegheName { get; set; }
        public string fldAzTarikh { get; set; }
        public string fldTaTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public DateTime fldDate { get; set; }
    }
}