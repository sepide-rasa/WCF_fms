using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_KosoratBank
    {
        #region Detail
        public OBJ_Mohasebat_KosoratBank Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_KosoratBankSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Mohasebat_KosoratBank()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKosoratBankId = q.fldKosoratBankId,
                        fldMablagh = q.fldMablagh,
                        fldMohasebatId = q.fldMohasebatId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_KosoratBank> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_KosoratBankSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Mohasebat_KosoratBank()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKosoratBankId = q.fldKosoratBankId,
                        fldMablagh = q.fldMablagh,
                        fldMohasebatId = q.fldMohasebatId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MohasebatId, int KosoratBankId, int Mablagh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_KosoratBankInsert(MohasebatId, KosoratBankId, Mablagh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, int KosoratBankId, int Mablagh, int UserID, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_KosoratBankUpdate(Id, MohasebatId, KosoratBankId, Mablagh, UserID, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_KosoratBankDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}