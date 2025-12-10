using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SelectPayPersonalInfo_Ezafekar
    {
        DL_SelectPayPersonalInfo_Ezafekar SelectPayPersonalInfo_Ezafekar = new DL_SelectPayPersonalInfo_Ezafekar();
        #region Select
        public List<OBJ_SelectPayPersonalInfo_Ezafekar> Select(string FieldName, int costcenter_ChartOrganId, int organId, short year, byte mah, int h)
        {
            return SelectPayPersonalInfo_Ezafekar.Select(FieldName, costcenter_ChartOrganId, organId, year, mah, h);
        }
        #endregion
    }
}