using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Weigh
{
    public class OBJ_Tozin
    {
        public int fldId { get; set; }
        public int fldWeighbridgeId { get; set; }
        public int fldMaxW { get; set; }
        public int? fldPlaqueId { get; set; }
        public System.DateTime fldHour { get; set; }
        public System.DateTime fldStartDate { get; set; }
        public System.DateTime fldEndDate { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldPlaque { get; set; }
        public string fldNameBaskool { get; set; }
        public string fldTarikhShoroo { get; set; }
        public string fldTarikhPayan { get; set; }
        public string fldSaat { get; set; }
    }
}