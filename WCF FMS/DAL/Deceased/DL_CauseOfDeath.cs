using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_CauseOfDeath
    {
        #region Detail
        public OBJ_CauseOfDeath Detail(int id)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblCauseOfDeathSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_CauseOfDeath
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserID = q.fldUserID,
                        fldReason = q.fldReason,
                        fldIP = q.fldIP,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CauseOfDeath> Select(string FieldName, string FilterValue, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblCauseOfDeathSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_CauseOfDeath()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserID = q.fldUserID,
                        fldReason = q.fldReason,
                        fldIP = q.fldIP,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldReason, int userId, string Desc,string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCauseOfDeathInsert(fldReason, userId, Desc,IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldReason, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCauseOfDeathUpdate(fldId, fldReason, userId, Desc,IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblCauseOfDeathDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldReason, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblCauseOfDeathSelect("fldReason", fldReason, 0).Any();

                }
                else
                {
                    var query = p.spr_tblCauseOfDeathSelect("fldReason", fldReason, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblMotevaffaSelect("CheckCauseOfDeathId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion
    }
}