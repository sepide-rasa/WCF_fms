using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptListAghsatVam
    {
        DL_RptListAghsatVam RptListAghsatVam = new DL_RptListAghsatVam();

        #region RptListAghsatVam_Excel
        public List<OBJ_RptListAghsatVam> RptListAghsatVam_Excel(short Year, byte Month, int OrganId, byte CalcType)
        {
            return RptListAghsatVam.RptListAghsatVam_Excel(Year, Month, OrganId, CalcType);
        }
        #endregion
    }
}