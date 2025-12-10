using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Masoulin_Detail
    {
        public int fldId { get; set; }
        public Nullable<int> fldEmployId { get; set; }
        public int fldMasuolinId { get; set; }
        public int fldOrderId { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldTarikhEjra { get; set; }
        public string fldNameEmployee { get; set; }
        public string fldNameOrgan { get; set; }
        public int fldModule_OrganId { get; set; }
        public string NamePostOrgan { get; set; }
        public Nullable<int> fldOrganPostId { get; set; }
        public string TitlePost { get; set; }
    }
}