using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_OnAccount
    {
        public int fldId { get; set; }
        public string fldCodeMeli { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public string fldTitle { get; set; }
        public byte fldNobatePardakt { get; set; }
        public int fldKhalesPardakhti { get; set; }
        public int fldUserId { get; set; }
        public string fldIP { get; set; }
        public System.DateTime fldDate { get; set; }
        public bool fldFlag { get; set; }
        public string fldName { get; set; }
        public int fldOrganId { get; set; }
        public bool fldGhatei { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldGhateiName { get; set; }
    }
}