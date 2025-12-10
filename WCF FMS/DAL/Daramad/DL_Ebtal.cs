using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Ebtal
    {
        #region Detail
        public OBJ_Ebtal Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblEbtalSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Ebtal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFishId=q.fldFishId,
                        fldRequestTaghsit_TakhfifId = q.fldRequestTaghsit_TakhfifId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Ebtal> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblEbtalSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Ebtal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFishId = q.fldFishId,
                        fldRequestTaghsit_TakhfifId = q.fldRequestTaghsit_TakhfifId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> FishId, Nullable<int> RequestTaghsit_TakhfifId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblEbtalInsert(FishId, RequestTaghsit_TakhfifId, UserId, Desc);
                return "ابطال در خواست مورد نظر با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> FishId, Nullable<int> RequestTaghsit_TakhfifId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblEbtalUpdate(Id, FishId, RequestTaghsit_TakhfifId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblEbtalDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}