using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_AfradTahtePooshesh
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldBirthDate { get; set; }
        public byte fldStatus { get; set; }
        public bool fldMashmul { get; set; }
        public byte fldNesbat { get; set; }
        public string fldCodeMeli { get; set; }
        public string fldSh_Shenasname { get; set; }
        public string fldFatherName { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldStatusName { get; set; }
        public string fldMashmulName { get; set; }
        public string fldNameNesbat { get; set; }
        public string fldTarikhEzdevaj { get; set; }
        public Nullable<byte> fldNesbatShakhs { get; set; }
        public string fldNameNesbatShakhs { get; set; }
        public Nullable<bool> fldMashmoolPadash { get; set; }
        public string fldMashmoolPadashName { get; set; }
        public string fldTarikhTalagh { get; set; }
    
    }
}