using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Actions
    {
        #region Detail
        public OBJ_Actions Detail(int id,int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblActionsSelect("fldId", id.ToString(),organId, 1)
                    .Select(q => new OBJ_Actions
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleAction = q.fldTitleAction,
                        fldOrganId=q.fldOrganId,
                        fldIP = q.fldIP,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Actions> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblActionsSelect(FieldName, FilterValue,organId, h)
                    .Select(q => new OBJ_Actions()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleAction = q.fldTitleAction,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitleAction, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblActionsInsert(fldTitleAction, userId, organId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitleAction, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblActionsUpdate(fldId, fldTitleAction, userId, organId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblActionsDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldTitleAction, int organId, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblActionsSelect("fldTitleAction", fldTitleAction, organId, 0).Any();

                }
                else
                {
                    var query = p.spr_tblActionsSelect("fldTitleAction", fldTitleAction, organId, 0).FirstOrDefault();
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
                var m = p.spr_tblAction_KartablSelect("CheckActionId", id.ToString(), 0, 1).FirstOrDefault();
                var k = p.spr_tblKartabl_RequestSelect("CheckActionId", id.ToString(), 0, 1).FirstOrDefault();
                var n = p.spr_tblNextKartablSelect("CheckActionId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null || k != null || n != null)
                    q = true;
            }


            return q;
        }
        #endregion
    }
}