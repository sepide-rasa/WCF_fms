using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SelectFlagKarKard_Mohasebe
    {
        DL_SelectFlagKarKard_Mohasebe SelectFlagKarKard_Mohasebe = new DL_SelectFlagKarKard_Mohasebe();
        #region Select
        public List<OBJ_SelectFlagKarKard_Mohasebe> Select(short sal, byte mah, int OrganId)
        {
            return SelectFlagKarKard_Mohasebe.Select(sal, mah, OrganId);
        }
        #endregion
    }
}