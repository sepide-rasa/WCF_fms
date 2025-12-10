using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_Morakhasi
    {
        #region Detail
        public OBJ_Mohasebat_Morakhasi Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_MorakhasiSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_Mohasebat_Morakhasi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldHokmId = q.fldHokmId,
                        fldMablagh = q.fldMablagh,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldSalHokm = q.fldSalHokm,
                        fldTedad = q.fldTedad,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Morakhasi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_MorakhasiSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Mohasebat_Morakhasi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldHokmId = q.fldHokmId,
                        fldMablagh = q.fldMablagh,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldSalHokm = q.fldSalHokm,
                        fldTedad = q.fldTedad,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, byte HesabTypeId, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MorakhasiInsert(PersonalId, Tedad, Mablagh, Month, Year, NobatPardakht, SalHokm, HokmId, UserId, OrganId, Desc, HesabTypeId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, int CostCenterId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MorakhasiUpdate(Id, PersonalId, Tedad, Mablagh, Month, Year, NobatPardakht, SalHokm, HokmId, CostCenterId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MorakhasiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}