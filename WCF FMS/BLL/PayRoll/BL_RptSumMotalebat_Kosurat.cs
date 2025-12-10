using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptSumMotalebat_Kosurat
    {
        DL_RptSumMotalebat_Kosurat RptSumMotalebat_Kosurat = new DL_RptSumMotalebat_Kosurat();
        #region Select
        public List<OBJ_RptSumMotalebat_Kosurat> Select(string FieldName, short sal, byte Month, int CostCenter, int TypeBime, byte nobat, int OrganId, byte CalcType)
        {
            return RptSumMotalebat_Kosurat.Select(FieldName, sal, Month, CostCenter, TypeBime, nobat, OrganId, CalcType);
        }
        #endregion
    }
}