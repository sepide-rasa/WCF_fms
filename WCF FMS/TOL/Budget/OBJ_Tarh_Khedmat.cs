using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_Tarh_Khedmat
    {
        public int fldId { get; set; }
        public int fldProgramId { get; set; }
        public string fldCod { get; set; }
        public string fldTitle { get; set; }
        public byte fldType { get; set; }
        public string fldTarh_KhedmatType { get; set; }
        public int fldOrganId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldUserId { get; set; }
        public string fldTitle_Program { get; set; }
        public string fldTitle_Mamoriyat { get; set; }
        public string fldCod_Mamoriyat { get; set; }
        public string fldCod_Program { get; set; }
        public short fldYear { get; set; }
    }
}