using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MahdoodiyatMohasebat_ShomareHesabDaramad
    {
        #region Detail
        public OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomarehesabDarmadId = q.fldShomarehesabDarmadId,
                        fldMahdodiyatMohasebatId = q.fldMahdodiyatMohasebatId,
                        fldDaramadCode = q.fldDaramadCode
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomarehesabDarmadId = q.fldShomarehesabDarmadId,
                        fldMahdodiyatMohasebatId = q.fldMahdodiyatMohasebatId,
                        fldDaramadCode = q.fldDaramadCode
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MahdodiyatMohasebatId, int ShomarehesabDarmadId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadInsert(MahdodiyatMohasebatId, ShomarehesabDarmadId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MahdodiyatMohasebatId, int ShomarehesabDarmadId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadUpdate(Id, MahdodiyatMohasebatId, ShomarehesabDarmadId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}