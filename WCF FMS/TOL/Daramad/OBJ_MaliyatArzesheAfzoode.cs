using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_MaliyatArzesheAfzoode
    {
        public int fldId { get; set; }
        public string fldFromDate { get; set; }
        public string fldEndDate { get; set; }
        public decimal fldDarsadeAvarez { get; set; }
        public decimal fldDarsadeMaliyat { get; set; }
        public decimal fldDarsadAmuzeshParvaresh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}