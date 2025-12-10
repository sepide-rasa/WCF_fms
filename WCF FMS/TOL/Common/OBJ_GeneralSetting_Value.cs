using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Common
{
    public class OBJ_GeneralSetting_Value
    {
        public byte fldId { get; set; }
        public byte fldGeneralSettingId { get; set; }
        public string fldValue { get; set; }
        public int fldUserId { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public int fldOrganId { get; set; }
        public string fldNameGeneralSetting { get; set; }
    }
}