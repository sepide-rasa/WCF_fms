using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Kartabl_Request
    {
        #region Detail
        public OBJ_Kartabl_Request Detail(int id, int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblKartabl_RequestSelect("fldId", id.ToString(), organId, 1)
                    .Select(q => new OBJ_Kartabl_Request
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldKartablId = q.fldKartablId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldActionId = q.fldActionId,
                        fldRequestId = q.fldRequestId,
                        fldKartablNextId = q.fldKartablNextId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Kartabl_Request> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblKartabl_RequestSelect(FieldName, FilterValue, organId, h)
                    .Select(q => new OBJ_Kartabl_Request()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldKartablId = q.fldKartablId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldActionId = q.fldActionId,
                        fldRequestId = q.fldRequestId,
                        fldKartablNextId = q.fldKartablNextId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartabl_RequestInsert(fldKartablId, fldActionId, fldRequestId, fldKartablNextId, userId, organId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartabl_RequestUpdate(fldId, fldKartablId, fldActionId, fldRequestId, fldKartablNextId, userId, organId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartabl_RequestDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}