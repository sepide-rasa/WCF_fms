using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptListPardakhtEydi
    {
        #region RptListPardakhtEydi
        public List<OBJ_RptListPardakhtEydi> RptListPardakhtEydi(int CostCenter,short Year, byte Month,byte NobatPardakht,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptListPardakhtEydi(CostCenter,Year,Month,NobatPardakht,OrganId)
                    .Select(q => new OBJ_RptListPardakhtEydi()
                    {
                        fldDayCount = q.fldDayCount,
                        fldFatherName=q.fldFatherName,
                        fldKhalesPardakhti=q.fldKhalesPardakhti,
                        fldKosurat=q.fldKosurat,
                        fldMablagh=q.fldMablagh,
                        fldMaliyat=q.fldMaliyat,
                        fldName_Family=q.fldName_Family,
                        fldPersonalId=q.fldPersonalId,
                        fldShomareHesab=q.fldShomareHesab,
                        NameNobat=q.NameNobat,
                        Sal=q.Sal
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}