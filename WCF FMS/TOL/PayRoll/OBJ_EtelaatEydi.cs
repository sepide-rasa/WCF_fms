using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_EtelaatEydi
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public int fldDayCount { get; set; }
        public int fldKosurat { get; set; }
        public byte fldNobatePardakht { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldName_Father { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public string fldNobatePardakhtName { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public Nullable<bool> fldFlag { get; set; }

        public int fldPersonalInfoId { get; set; }
        public string fldName { get; set; }
        public int fldEtelaatEydiId { get; set; }
        public Nullable<bool> fldChecked { get; set; }
    }
}