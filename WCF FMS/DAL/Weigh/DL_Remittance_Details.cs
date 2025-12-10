using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Remittance_Details
    {
        #region Select
        public List<OBJ_Remittance_Details> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblRemittance_DetailsSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Remittance_Details()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldRemittanceId = q.fldRemittanceId,
                        fldIP = q.fldIP,
                        fldKalaId = q.fldKalaId,
                        fldMaxTon = q.fldMaxTon,
                        fldControlLimit = q.fldControlLimit,
                        fldKalaName = q.fldKalaName,
                        fldTitleHeader = q.fldTitleHeader,
                        fldExistsVazn=q.fldExistsVazn
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}