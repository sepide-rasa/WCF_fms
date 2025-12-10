using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_RequestTaghsit_Takhfif
    {
        public int fldId { get; set; }
        public int fldElamAvarezId { get; set; }
        public byte fldRequestType { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldAddress { get; set; }
        public string fldEmail { get; set; }
        public string fldCodePosti { get; set; }
        public string fldMobile { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldRequestTypeName { get; set; }
        public string fldStatusName { get; set; }
        public string fldStatusId { get; set; }
        public string fldName_Family { get; set; }
        public string fldCodemeli { get; set; }
        public string fldFatherName { get; set; }
        public string fldReplyRequest { get; set; }
        public string fldReplyRequestName { get; set; }
        public long fldMablaghMashmoolKarmozd { get; set; }
        public long fldMablaghKoli { get; set; }
        public string fldCheckTakhfif_Taghsit { get; set; }
        public long fldMablagh { get; set; }
        public long fldMablaghWithTakhfifKoli { get; set; }
        public long MablaghAsli { get; set; }
        public int SumTedad { get; set; }
        public Nullable<long> fldMablaghAmuzesh { get; set; }
    }
}