using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_EzafeKari_TatilKari
    {
        #region Detail
        public OBJ_EzafeKari_TatilKari Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEzafeKari_TatilKariSelect("fldId", Id.ToString(), 0, 0, 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_EzafeKari_TatilKari()
                    {
                        fldCount = q.fldCount,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldMonth = q.fldMonth,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldName_Father = q.fldName_Father,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Personali = q.fldSh_Personali,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldMonthName = q.fldMonthName,
                        fldHasBime = q.fldHasBime,
                        fldHasMaliyat = q.fldHasMaliyat,
                        fldHasBimeName = q.fldHasBimeName,
                        fldHasMaliyatName = q.fldHasMaliyatName,
                        fldOrganId = q.fldOrganId,
                        fldFlag=q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_EzafeKari_TatilKari> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatePardakht, byte Type, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEzafeKari_TatilKariSelect(FieldName, FilterValue, Id, Year, Month, NobatePardakht, Type, OrganId, h)
                    .Select(q => new OBJ_EzafeKari_TatilKari()
                    {
                        fldCount = q.fldCount,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldMonth = q.fldMonth,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldName_Father = q.fldName_Father,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Personali = q.fldSh_Personali,
                        fldNobatePardakhtName = q.fldNobatePardakhtName,
                        fldMonthName = q.fldMonthName,
                        fldHasBime = q.fldHasBime,
                        fldHasMaliyat = q.fldHasMaliyat,
                        fldHasBimeName = q.fldHasBimeName,
                        fldHasMaliyatName = q.fldHasMaliyatName,
                        fldOrganId = q.fldOrganId,
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEzafeKari_TatilKariInsert(PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEzafeKari_TatilKariUpdate(Id, PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblEzafeKari_TatilKariDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, short Year,byte Month,byte NobatPardakht,byte Type, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblEzafeKari_TatilKariSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatPardakht, Type, 0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblEzafeKari_TatilKariSelect("CheckSave", PersonalId.ToString(),0 , Year, Month, NobatPardakht, Type,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region EzafeKari_TatilKariGroup
        public List<OBJ_EzafeKari_TatilKari> EzafeKari_TatilKariGroup(string FieldName,  string Sal, string Mah, byte NobatePardakht, byte Type,int OrganId, int CostCenter_Chart)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblEzafeKari_TatilKariGroupSelect(FieldName, Sal, Mah, NobatePardakht, Type, OrganId,CostCenter_Chart)
                    .Select(q => new OBJ_EzafeKari_TatilKari()
                    {
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldCount = q.fldCount,
                        fldEzafeKari_TatilKariId = q.fldEzafeKari_TatilKariId,
                        fldMonth = q.fldMonth,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldYear = q.fldYear,
                        fldHasBime = q.fldHasBime,
                        fldHasMaliyat = q.fldHasMaliyat,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}