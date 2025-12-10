using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_TakhfifDetail
    {
        #region Detail
        public OBJ_TakhfifDetail Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTakhfifDetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_TakhfifDetail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShCodeDaramad = q.fldShCodeDaramad,
                        fldTakhfifId = q.fldTakhfifId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TakhfifDetail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTakhfifDetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TakhfifDetail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShCodeDaramad = q.fldShCodeDaramad,
                        fldTakhfifId = q.fldTakhfifId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int TakhfifId, int ShCodeDaramad, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTakhfifDetailInsert(TakhfifId, ShCodeDaramad, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int TakhfifId, int ShCodeDaramad, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTakhfifDetailUpdate(Id, TakhfifId, ShCodeDaramad, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTakhfifDetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}