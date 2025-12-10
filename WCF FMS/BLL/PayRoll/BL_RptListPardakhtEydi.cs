using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptListPardakhtEydi
    {
        DL_RptListPardakhtEydi RptListPardakhtEydi = new DL_RptListPardakhtEydi();

        #region RptListPardakhtEydi
        public List<OBJ_RptListPardakhtEydi> Select(int CostCenter, short Year, byte Month, byte NobatPardakht, int OrganId)
        {
            return RptListPardakhtEydi.RptListPardakhtEydi( CostCenter, Year,  Month, NobatPardakht, OrganId);
        }
        #endregion
    }
}