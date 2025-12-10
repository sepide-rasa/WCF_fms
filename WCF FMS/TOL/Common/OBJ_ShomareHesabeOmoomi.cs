using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_ShomareHesabeOmoomi
    {
        public int fldId { get; set; }
        public int fldShobeId { get; set; }
        public int fldAshkhasId { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldShomareSheba { get; set; }
        public Nullable<int> fldBankId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldBankName { get; set; }
        public string nameShobe { get; set; }
        public string NameAshkhas { get; set; }
        public int fldCodeSHobe { get; set; }
    }
}