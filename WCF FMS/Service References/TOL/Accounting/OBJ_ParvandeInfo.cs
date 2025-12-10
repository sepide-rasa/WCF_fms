using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_ParvandeInfo
    {
        public int fldId { get; set; }
        public string fldName { get; set; }
        public string fldCodemeli { get; set; }
        public string fldStartContract { get; set; }
        public string fldEndContract { get; set; }
        public Nullable<long> fldMablagh { get; set; }
        public string fldShenasePardakht { get; set; }
        public string fldShenaseGhabz { get; set; }
        public string fldShomareHesab { get; set; }
        public string fldIsEbtal { get; set; }
        public string fldSharh { get; set; }
        public string fldType { get; set; }
        public Nullable<int> fldTypeId { get; set; }
    }
}