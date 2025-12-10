using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Arze
    {
        public int fldId { get; set; }
        public int fldBaskoolId { get; set; }
        public int fldKalaId { get; set; }
        public int fldShomareHesabCodeDaramadId { get; set; }
        public int fldUserId { get; set; }
        public int fldOrganId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public string fldNameKala { get; set; }
        public string fldDaramadCode { get; set; }
        public string fldDaramadTitle { get; set; }
        public byte fldTedad { get; set; }
        public long fldMablagh { get; set; }
        public string fldOrganName { get; set; }
        public Nullable<byte> fldStatusForoosh { get; set; }
        public string fldStatusForooshName { get; set; }
        public Nullable<int> fldVaznVahed { get; set; }
    }
}