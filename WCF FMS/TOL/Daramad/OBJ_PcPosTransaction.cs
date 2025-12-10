using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_PcPosTransaction
    {
        public int fldId { get; set; }
        public int fldFishId { get; set; }
        public long fldPrice { get; set; }
        public bool fldStatus { get; set; }
        public string fldTrackingCode { get; set; }
        public string fldShGhabz { get; set; }
        public string fldShPardakht { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldSerialNumber { get; set; }
        public string fldTerminalCode { get; set; }
        public string fldTarikh { get; set; }
        public string fldCardNumber { get; set; }
        public string fldNahvePardakht { get; set; }
    }
}