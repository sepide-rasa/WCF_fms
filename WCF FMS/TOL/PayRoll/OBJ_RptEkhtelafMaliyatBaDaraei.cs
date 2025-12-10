using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_RptEkhtelafMaliyatBaDaraei
    {
        public int fldPersonalId { get; set; }
        public string fldName { get; set; }
        public string fldFatherName { get; set; }
        public string fldCodemeli { get; set; }
        public Nullable<int> fldMaliyat { get; set; }
        public Nullable<int> fldMaliyatMoavagh { get; set; }
        public Nullable<int> fldMaliyatCalc { get; set; }
        public Nullable<int> fldEkhtelafMaliyat { get; set; }
    }
}