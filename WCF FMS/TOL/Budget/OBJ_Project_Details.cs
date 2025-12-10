using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_Project_Details
    {
        public int fldId { get; set; }
        public int fldProject_faaliyatId { get; set; }
        public string fldAddress { get; set; }
        public string fldMojri { get; set; }
        public short fldStratYear { get; set; }
        public short fldEndYear { get; set; }
        public int fldMeghdar { get; set; }
        public long fldGheymatVahed { get; set; }
        public long fldEtebar { get; set; }
        public int fldOrganId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldUserId { get; set; }
        public short fldYear { get; set; }
    }
}