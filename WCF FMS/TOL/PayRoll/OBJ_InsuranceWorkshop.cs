using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_InsuranceWorkshop
    {
        public int fldId { get; set; }
        public string fldWorkShopName { get; set; }
        public string fldEmployerName { get; set; }
        public string fldWorkShopNum { get; set; }
        public decimal fldPersent { get; set; }
        public string fldAddress { get; set; }
        public string fldPeyman { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldOrganId { get; set; }
        public string fldName { get; set; }
    }
}