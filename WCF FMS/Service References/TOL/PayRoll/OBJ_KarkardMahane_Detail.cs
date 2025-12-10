using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_KarkardMahane_Detail
    {
        public int fldId { get; set; }
        public int fldKarkardMahaneId { get; set; }
        public int fldKarkard { get; set; }
        public int fldKargahBimeId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldWorkShopName { get; set; }
        public string fldWorkShopNum { get; set; }
        public string fldEmployerName { get; set; }
    }
}