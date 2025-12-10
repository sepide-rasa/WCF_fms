using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_UpdateFlag
    {
        #region Update
        public string Update(string fieldName, short sal, byte mah, byte nobat, byte marhalePardaht, int OrganId, byte Type, int UserId, string Ip, byte fldCalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_UpdateFlag(fieldName, Type, sal, mah, nobat, marhalePardaht, OrganId, UserId, Ip, fldCalcType);
                return "بستن حقوق با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}