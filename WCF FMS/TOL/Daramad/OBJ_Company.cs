using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_Company
    {
        public int fldId { get; set; }
        public string fldTitle { get; set; }
        public string fldShenaseMeli { get; set; }
        public int fldKarbarId { get; set; }
        public string fldURL { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldUserName { get; set; }
        public string fldUserNameService { get; set; }
        public string fldPassService { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public string fldNameOrgan { get; set; }
    }
}