using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_TreeOrganPost
    {
        public Nullable<int> id { get; set; }
        public Nullable<int> pid { get; set; }
        public string title { get; set; }
        public string Namechart { get; set; }
        public string fldOrgPostCode { get; set; }
    }
}