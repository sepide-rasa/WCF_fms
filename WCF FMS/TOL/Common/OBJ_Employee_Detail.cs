using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_Employee_Detail
    {
        public int fldId { get; set; }
        public int fldEmployeeId { get; set; }
        public string fldFatherName { get; set; }
        public Nullable<bool> fldJensiyat { get; set; }
        public Nullable<int> fldMadrakId { get; set; }
        public Nullable<byte> fldNezamVazifeId { get; set; }
        public Nullable<int> fldTaaholId { get; set; }
        public Nullable<int> fldReshteId { get; set; }
        public Nullable<int> fldFileId { get; set; }
        public string fldSh_Shenasname { get; set; }
        public Nullable<int> fldMahalTavalodId { get; set; }
        public Nullable<int> fldMahalSodoorId { get; set; }
        public string fldTarikhSodoor { get; set; }
        public string fldAddress { get; set; }
        public string fldCodePosti { get; set; }
        public Nullable<bool> fldMeliyat { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldName { get; set; }
        public string fldFamily { get; set; }
        public string fldCodemeli { get; set; }
        public string fldTarikhTavalod { get; set; }
        public byte fldTypeShakhs { get; set; }
        public string fldTypeShakhsName { get; set; }
        public string fldTel { get; set; }
        public string fldMobile { get; set; }
    }
}