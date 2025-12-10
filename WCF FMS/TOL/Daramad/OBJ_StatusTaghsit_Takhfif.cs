using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_StatusTaghsit_Takhfif
    {
        public int fldId { get; set; }
        public int fldRequestId { get; set; }
        public byte fldTypeMojavez { get; set; }
        public byte fldTypeRequest { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string Vaziyat { get; set; }
        public string NoeDarkhast { get; set; }
    }
}