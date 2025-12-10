using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_TasviehHesab
    {
       public int fldId { get; set; }
        public int fldPrsPersonalInfoId { get; set; }
        public string fldTarikh { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
    }
}