using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Moavaghat_Items
    {
        #region Detail
        public OBJ_Moavaghat_Items Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoavaghat_ItemsSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Moavaghat_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldItemEstekhdamId=q.fldItemEstekhdamId,
                        fldMablagh=q.fldMablagh,
                        fldMoavaghatId = q.fldMoavaghatId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Moavaghat_Items> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoavaghat_ItemsSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Moavaghat_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMablagh = q.fldMablagh,
                        fldMoavaghatId = q.fldMoavaghatId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MoavaghatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoavaghat_ItemsInsert(MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId, SourceId, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MoavaghatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoavaghat_ItemsUpdate(Id, MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoavaghat_ItemsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}