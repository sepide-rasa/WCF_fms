using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_Items
    {
        #region Detail
        public OBJ_Mohasebat_Items Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_ItemsSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Mohasebat_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldItemEstekhdamId=q.fldItemEstekhdamId,
                        fldMablagh=q.fldMablagh,
                        fldMohasebatId = q.fldMohasebatId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Items> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_ItemsSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Mohasebat_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMablagh = q.fldMablagh,
                        fldMohasebatId = q.fldMohasebatId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MohasebatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId,byte fldCalcType, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_ItemsInsert(MohasebatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId, SourceId, OrganId, fldCalcType);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_ItemsUpdate(Id, MohasebatId, ItemEstekhdamId, Mablagh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_ItemsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}