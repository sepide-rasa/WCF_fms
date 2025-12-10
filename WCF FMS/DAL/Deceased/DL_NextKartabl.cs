using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_NextKartabl
    {
        #region Detail
        public OBJ_NextKartabl Detail(int id, int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblNextKartablSelect("fldId", id.ToString(), organId, 1)
                    .Select(q => new OBJ_NextKartabl
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldTitleAction = q.fldTitleAction,
                        fldKartablNextId = q.fldKartablNextId,
                        fldActionId = q.fldActionId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_NextKartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblNextKartablSelect(FieldName, FilterValue, organId, h)
                    .Select(q => new OBJ_NextKartabl()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldTitleAction = q.fldTitleAction,
                        fldKartablNextId = q.fldKartablNextId,
                        fldActionId = q.fldActionId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldKartablNextId, int ActionId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblNextKartablInsert(fldKartablNextId, ActionId, userId, organId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldKartablNextId, int ActionId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblNextKartablUpdate(fldId, fldKartablNextId, ActionId, userId, organId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblNextKartablDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}