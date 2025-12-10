using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Deceased
{
    public class OBJ_VadiSalam
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldStateId { get; set; }
        public int fldCityId { get; set; }
        public string fldAddress { get; set; }
        public string fldLatitude { get; set; }
        public string fldLongitude { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldUserID { get; set; }
        public string fldDesc { get; set; }
        public string fldIP { get; set; }
        public string fldNameState { get; set; }
        public string fldNameCity { get; set; }
        public int fldOrganId { get; set; }
    }
}