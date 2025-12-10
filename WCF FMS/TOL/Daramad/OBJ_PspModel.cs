using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_PspModel
    {
        public int fldId { get; set; }
        public int fldPspId { get; set; }
        public string fldModel { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTitle { get; set; }
        public string fldTitleModel { get; set; }
        public bool fldMultiHesab { get; set; }
        public string fldMultiHesabName { get; set; }
    }
}