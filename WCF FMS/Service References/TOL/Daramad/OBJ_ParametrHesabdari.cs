using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_ParametrHesabdari
    {
        public int fldId { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
        public string fldCodeHesab { get; set; }
        public Nullable<int> fldHesabId { get; set; }
        public int fldCompanyId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}