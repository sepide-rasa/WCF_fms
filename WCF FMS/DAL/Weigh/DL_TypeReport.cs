using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_TypeReport
    {
        #region Select
        public List<OBJ_TypeReport> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblTypeReportSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_TypeReport()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldBaskoolId = q.fldBaskoolId,
                        fldTypeName = q.fldTypeName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(byte fldType, int fldOrganId, int fldBaskoolId, int userId, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_tblTypeReportInsert(fldType, fldOrganId, fldBaskoolId, userId, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}