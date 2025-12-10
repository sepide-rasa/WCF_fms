using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.PayRoll
{
    public class OBJ_PersonalInfo_Mohasebe
    {
        public int PayId { get; set; }
        public int PrsId { get; set; }
        public string fldName_Family { get; set; }
        public string fldCodemeli { get; set; }
        public string fldSh_Personali { get; set; }
        public Nullable<int> fldOrganId { get; set; }
        public int fldCostCenterId { get; set; }
        public int fldAnvaeEstekhdamId { get; set; }
    }
}