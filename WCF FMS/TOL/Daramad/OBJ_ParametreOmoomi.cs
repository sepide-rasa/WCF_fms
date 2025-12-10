using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_ParametreOmoomi
    {
        public int fldId { get; set; }
        public string fldNameParametreFa { get; set; }
        public string fldNameParametreEn { get; set; }
        public byte fldNoeField { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string NoeFieldName { get; set; }
        public Nullable<int> fldFormulId { get; set; }
    }
}