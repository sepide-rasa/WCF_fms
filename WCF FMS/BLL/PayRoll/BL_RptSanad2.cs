using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptSanad2
    {
        DL_RptSanad2 RptSanad2 = new DL_RptSanad2();

        #region Select
        public List<OBJ_RptSanad2> Select(short Year, byte Mah, byte Nobat, int OrganId, byte CalcType)
        {
            return RptSanad2.Select(Year, Mah, Nobat, OrganId, CalcType);
        }
        #endregion
    }
}