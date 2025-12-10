using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptSanad3
    {
        DL_RptSanad3 RptSanad3 = new DL_RptSanad3();

        #region Select
        public List<OBJ_RptSanad3> Select(short Year, byte Mah, byte Nobat, int OrganId, byte CalcType)
        {
            return RptSanad3.Select(Year, Mah, Nobat, OrganId, CalcType);
        }
        #endregion
    }
}