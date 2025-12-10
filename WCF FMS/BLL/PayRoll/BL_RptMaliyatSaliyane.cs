using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptMaliyatSaliyane
    {
        DL_RptMaliyatSaliyane RptMaliyatSaliyane = new DL_RptMaliyatSaliyane();
        #region RptMaliyatSaliyane
        public List<OBJ_RptMaliyatSaliyane> GetRptMaliyatSaliyane(int PersonId, short Year, byte Month, int OrganId, byte type, int UserId)
        {
            return RptMaliyatSaliyane.RptMaliyatSaliyane( PersonId,Year, Month, OrganId, type, UserId);
        }
        #endregion

        #region RptEkhtelafMaliyatBaDaraei
        public List<OBJ_RptEkhtelafMaliyatBaDaraei> GetRptEkhtelafMaliyatBaDaraei(short Year, byte Month, byte nobatPardakht, int OrganId)
        {
            return RptMaliyatSaliyane.RptEkhtelafMaliyatBaDaraei(Year, Month, nobatPardakht, OrganId);
        }
        #endregion
    }
}