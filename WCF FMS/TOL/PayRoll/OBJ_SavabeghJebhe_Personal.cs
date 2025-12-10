using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_SavabeghJebhe_Personal
    {
        public int fldId { get; set; }
        public int fldItemId { get; set; }
        public int fldPrsPersonalId { get; set; }
        public string fldAzTarikh { get; set; }
        public string fldTaTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTitle { get; set; }
        public decimal fldDarsad_Sal { get; set; }
    }
}