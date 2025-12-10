using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_Arze_Detail
    {
        #region Select
        public List<OBJ_Arze_Detail> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblArze_DetailSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Arze_Detail()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldHeaderId = q.fldHeaderId,
                        fldIP = q.fldIP,
                        fldParametrSabetCodeDaramd = q.fldParametrSabetCodeDaramd,
                        fldValue = q.fldValue,
                        fldOrganId = q.fldOrganId,
                        fldFlag =q.fldFlag,
                        fldNameParametreEn = q.fldNameParametreEn,
                        fldNameParametreFa = q.fldNameParametreFa,
                        fldValue_Arze=q.fldValue_Arze
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldHeaderId, int? fldParametrSabetCodeDaramd, string fldValue, bool fldFlag, int userId, int OrganId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblArze_DetailInsert(fldHeaderId, fldParametrSabetCodeDaramd, fldValue, fldFlag, userId, OrganId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion

        #region Delete
        public string Delete(int id, int userId)
        {
            using (WeighEntities p = new WeighEntities())
            {
                p.spr_tblArze_DetailDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}