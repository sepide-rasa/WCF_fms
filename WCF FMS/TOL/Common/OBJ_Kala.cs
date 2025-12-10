using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Kala
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public byte fldKalaType { get; set; }
        public string fldKalaCode { get; set; }
        public byte fldStatus { get; set; }
        public Nullable<bool> fldSell { get; set; }
        public bool fldArzeshAfzodeh { get; set; }
        public string fldIranCode { get; set; }
        public byte fldMoshakhaseType { get; set; }
        public string fldMoshakhase { get; set; }
        public int fldVahedAsli { get; set; }
        public int fldVahedFaree { get; set; }
        public byte fldNesbatType { get; set; }
        public int? fldVahedMoadel { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public string fldStatusName { get; set; }
        public string fldVahedAsli_Name { get; set; }
        public string fldVahedFaree_Name { get; set; }
    }
}