using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Action_Kartabl
    {
        #region Detail
        public OBJ_Action_Kartabl Detail(int id, int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblAction_KartablSelect("fldId", id.ToString(), organId, 1)
                    .Select(q => new OBJ_Action_Kartabl
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldActionId = q.fldActionId,
                        fldKartablId = q.fldKartablId,
                        fldTitleAction = q.fldTitleAction,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Action_Kartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblAction_KartablSelect(FieldName, FilterValue, organId, h)
                    .Select(q => new OBJ_Action_Kartabl()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldActionId = q.fldActionId,
                        fldKartablId = q.fldKartablId,
                        fldTitleAction = q.fldTitleAction,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ActionId, int KartablId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblAction_KartablInsert(ActionId, KartablId, userId, organId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int ActionId, int KartablId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblAction_KartablUpdate(fldId, ActionId, KartablId, userId, organId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblAction_KartablDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}