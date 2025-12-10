using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptSumMotalebat_Kosurat
    {
        #region Select
        public List<OBJ_RptSumMotalebat_Kosurat> Select(string FieldName, short sal, byte Month, int CostCenter, int TypeBime, byte nobat,int OrganId,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptSumMotalebat_Kosurat(FieldName, sal, Month, CostCenter, TypeBime, nobat,OrganId,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_RptSumMotalebat_Kosurat()
                    {
                        fldMablagh = q.fldMablagh,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}