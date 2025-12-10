using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Morakhasi
    {
        public int fldId { get; set; }
        public int fldPersonalId { get; set; }
        public short fldYear { get; set; }
        public byte fldMonth { get; set; }
        public byte fldNobatePardakht { get; set; }
        public short fldSalAkharinHokm { get; set; }
        public int fldTedad { get; set; }
        public int fldUserId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public string fldSh_Personali { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldName_Father { get; set; }
        public string fldNobatePardakhtName { get; set; }
        public string fldMonthName { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public Nullable<bool> fldFlag { get; set; }


        public int fldPersonalInfoId { get; set; }
        public string fldName { get; set; }
        public string fldCodemeli { get; set; }
        public int fldMorakhasiId { get; set; }
        public Nullable<bool> fldChecked { get; set; }
    }
}