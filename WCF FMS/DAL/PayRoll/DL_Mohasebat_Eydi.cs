using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_Eydi
    {
        #region Detail
        public OBJ_Mohasebat_Eydi Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_EydiSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Mohasebat_Eydi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKhalesPardakhti=q.fldKhalesPardakhti,
                        fldKosurat = q.fldKosurat,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldDayCount = q.fldDayCount,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Eydi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_EydiSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Mohasebat_Eydi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldKosurat = q.fldKosurat,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldDayCount = q.fldDayCount,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht,byte HesabTypeId,int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_EydiInsert(PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht, UserId, OrganId, Desc, HesabTypeId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, int CostCenterId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_EydiUpdate(Id, PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht, CostCenterId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_EydiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}