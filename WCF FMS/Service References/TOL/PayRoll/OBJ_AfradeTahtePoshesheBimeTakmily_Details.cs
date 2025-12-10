using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_AfradeTahtePoshesheBimeTakmily_Details
    {
        public int fldId { get; set; }
        public int fldAfradTahtePoshehsId { get; set; }
        public int fldBimeTakmiliId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldPersonalId { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldBirthDate { get; set; }
        public string fldCodeMeli { get; set; }
        public string fldCodeMeli1 { get; set; }
        public Nullable<int> fldAge { get; set; }
        public string fldNameNesbatShakhs { get; set; }
    }
}