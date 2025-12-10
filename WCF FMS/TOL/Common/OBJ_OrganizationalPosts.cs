using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_OrganizationalPosts
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldOrgPostCode { get; set; }
        public int fldChartOrganId { get; set; }
        public Nullable<int> fldPID { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldNameChart { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public string fldTitlePID { get; set; }
    }
}