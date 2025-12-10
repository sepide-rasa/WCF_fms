using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SelectFlagKarKard_Mohasebe
    {
        #region Select
        public List<OBJ_SelectFlagKarKard_Mohasebe> Select(short sal,byte mah,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectFlagKarKard_Mohasebe(sal, mah, OrganId)
                    .Select(q => new OBJ_SelectFlagKarKard_Mohasebe()
                    {
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}