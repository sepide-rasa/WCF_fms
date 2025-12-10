using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_ShomareHesabPasAndaz
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public int fldBankFixId { get; set; }
        public int fldShomareHesabPersonalId { get; set; }
        public int? fldShomareHesabKarfarmaId { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldBankName { get; set; }
        public string fldName { get; set; }
        public string fldShomareHesabPersonal { get; set; }
        public string fldShomareHesabKarfarma { get; set; }
    }
}