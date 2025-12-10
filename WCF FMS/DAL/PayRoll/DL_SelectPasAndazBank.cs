using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SelectPasAndazBank
    {
        #region Select
        public int? Select(short Year, byte Mah,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_SelectPasAndazBank(Year, Mah, OrganId).FirstOrDefault();
                return Convert.ToInt32(k.fldBankId);
            }
        }
        #endregion
    }
}