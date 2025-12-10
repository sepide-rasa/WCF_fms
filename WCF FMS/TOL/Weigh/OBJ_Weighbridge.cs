using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Weighbridge
    {
        public int fldId { get; set; }
        public int fldAshkhasHoghoghiId { get; set; }
        public string fldName { get; set; }
        public string fldAddress { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldNameAshkhasHoghoghi { get; set; }
        public string fldShenaseMelli { get; set; }
        public string fldPassword { get; set; }
    }
}