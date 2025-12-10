using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_RptMaliyatSaliyane
    {
        public byte fldMonth { get; set; }
        public string fldName { get; set; }
        public string fldCodemeli { get; set; }
        public int fldPersonalId { get; set; }
        public Nullable<long> fldMablaghMostamarNaghdi { get; set; }
        public Nullable<long> fldMablaghMostamarGHeirNaghdi { get; set; }
        public Nullable<long> fldMablaghGheirMostamarNaghdi { get; set; }
        public Nullable<long> fldMablaghGheirMostamarGHeirNaghdi { get; set; }
        public Nullable<int> fldBimePersonal { get; set; }
        public int fldMaliyat { get; set; }
    }
}