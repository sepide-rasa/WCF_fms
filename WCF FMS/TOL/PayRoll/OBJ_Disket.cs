using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_Disket
    {
        public int fldId { get; set; }
        public string fldMarhale { get; set; }
        public string fldTarikh { get; set; }
        public int fldTedad { get; set; }
        public bool fldType { get; set; }
        public Nullable<long> fldJam { get; set; }
        public byte fldTypePardakht { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public byte[] fldTimeEdit { get; set; }
        public Nullable<long> fldEdit { get; set; }
        public string fldShobeCode { get; set; }
        public string fldOrganCode { get; set; }
        public int fldFileId { get; set; }
        public string fldNameFile { get; set; }
        public int fldBankFixId { get; set; }
        public string fldNameShobe { get; set; }
        public string fldNameTypePardakht { get; set; }
    }
}