using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MahdoodiyatMohasebat_Ashkhas
    {
        #region Detail
        public OBJ_MahdoodiyatMohasebat_Ashkhas Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebat_AshkhasSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MahdoodiyatMohasebat_Ashkhas()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldMahdoodiyatMohasebatId = q.fldMahdoodiyatMohasebatId,
                        fldName = q.fldName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat_Ashkhas> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblMahdoodiyatMohasebat_AshkhasSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MahdoodiyatMohasebat_Ashkhas()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldMahdoodiyatMohasebatId = q.fldMahdoodiyatMohasebatId,
                        fldName = q.fldName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MahdoodiyatMohasebatId, int AshkhasId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_AshkhasInsert(MahdoodiyatMohasebatId, AshkhasId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MahdoodiyatMohasebatId, int AshkhasId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_AshkhasUpdate(Id, MahdoodiyatMohasebatId, AshkhasId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblMahdoodiyatMohasebat_AshkhasDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}