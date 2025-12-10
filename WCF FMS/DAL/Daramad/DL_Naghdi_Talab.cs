using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Naghdi_Talab
    {
        #region Detail
        public OBJ_Naghdi_Talab Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblNaghdi_TalabSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Naghdi_Talab()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablagh = q.fldMablagh,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldFishId = q.fldFishId,
                        fldShomareHesabId = q.fldShomareHesabId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Naghdi_Talab> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblNaghdi_TalabSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Naghdi_Talab()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablagh = q.fldMablagh,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldFishId = q.fldFishId,
                        fldShomareHesabId = q.fldShomareHesabId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long Mablagh, int ReplyTaghsitId, byte Type,int? ShomareHesabId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNaghdi_TalabInsert(Mablagh, ReplyTaghsitId, Type, UserId, Desc, ShomareHesabId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long Mablagh, int ReplyTaghsitId, byte Type, int? ShomareHesabId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNaghdi_TalabUpdate(Id, Mablagh, ReplyTaghsitId, Type, UserId, Desc, ShomareHesabId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNaghdi_TalabDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}