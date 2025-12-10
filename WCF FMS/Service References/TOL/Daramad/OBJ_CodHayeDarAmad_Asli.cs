using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Daramad
{
    public class OBJ_CodHayeDarAmad_Asli
    {
        public string P_DaramdCode { get; set; }
        public string P_DaramadTitle { get; set; }
        public Nullable<long> Mablagh { get; set; }
        public Nullable<int> Count { get; set; }
        public string fldTarikh { get; set; }
        public string fldShomareHesab { get; set; }
        public Nullable<int> fldShomareHesabId { get; set; }
    }
}