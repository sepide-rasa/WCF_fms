using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_OnAccount
    {
        #region Select
        public List<OBJ_OnAccount> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, string FilterValue4, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblOnAccountSelect(FieldName, FilterValue ,  FilterValue2,  FilterValue3,  FilterValue4,OrganId, h)
                    .Select(q => new OBJ_OnAccount()
                    {
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldCodeMeli = q.fldCodeMeli,
                        fldFlag = q.fldFlag,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMonth = q.fldMonth,
                        fldPersonalId = q.fldPersonalId,
                        fldYear=q.fldYear,
                        fldNobatePardakt=q.fldNobatePardakt,
                        fldGhatei=q.fldGhatei,
                        fldGhateiName=q.fldGhateiName,
                        fldShomareHesab = q.fldShomareHesab
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}