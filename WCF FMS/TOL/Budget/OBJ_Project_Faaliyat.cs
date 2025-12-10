using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Budget
{
    public class OBJ_Project_Faaliyat
    {
        public int fldId { get; set; }
        public int fldTrah_KhedmatId { get; set; }
        public string fldCod { get; set; }
        public string fldTitle { get; set; }
        public byte fldType { get; set; }
        public string fldProject_faaliyatType { get; set; }
        public int fldEtebarId { get; set; }
        public int fldMasrafId { get; set; }
        public int fldChartOrganId { get; set; }
        public int fldOrganId { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldDesc { get; set; }
        public int fldUserId { get; set; }
        public string fldTitle_ChartOrgan { get; set; }
        public string fldTitle_EtebarType { get; set; }
        public string fldTitle_MasrafType { get; set; }
        public string fldTitle_Tarh_Khedmat { get; set; }
        public string fldCod_Mamoriyat { get; set; }
        public string fldTitle_Mamoriyat { get; set; }
        public string fldCod_Program { get; set; }
        public string fldTitle_Program { get; set; }
        public string fldCod_Tarh_Khedmat { get; set; }
        public short fldYear { get; set; }
    }
}