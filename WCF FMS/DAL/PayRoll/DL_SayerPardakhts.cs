using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SayerPardakhts
    {
        #region Detail
        public OBJ_SayerPardakhts Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSayerPardakhtsSelect("fldId", Id.ToString(), 0, 0, 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_SayerPardakhts()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAmount = q.fldAmount,
                        fldCodemeli = q.fldCodemeli,
                        fldEmployeeId = q.fldEmployeeId,
                        fldHasMaliyat = q.fldHasMaliyat,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMarhalePardakht = q.fldMarhalePardakht,
                        fldMarhalePardakhtName = q.fldMarhalePardakhtName,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakt = q.fldNobatePardakt,
                        fldNobatePardaktName = q.fldNobatePardaktName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitle = q.fldTitle,
                        fldYear = q.fldYear,
                        fldJobeCode = q.fldJobeCode,
                        fldFlag = q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SayerPardakhts> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSayerPardakhtsSelect(FieldName, FilterValue, Id, Year, Month, NobatPardakht, MarhalePardakht, OrganId, h)
                    .Select(q => new OBJ_SayerPardakhts()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAmount = q.fldAmount,
                        fldCodemeli = q.fldCodemeli,
                        fldEmployeeId = q.fldEmployeeId,
                        fldHasMaliyat = q.fldHasMaliyat,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMarhalePardakht = q.fldMarhalePardakht,
                        fldMarhalePardakhtName = q.fldMarhalePardakhtName,
                        fldMonth = q.fldMonth,
                        fldMonthName = q.fldMonthName,
                        fldName_Father = q.fldName_Father,
                        fldNobatePardakt = q.fldNobatePardakt,
                        fldNobatePardaktName = q.fldNobatePardaktName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitle = q.fldTitle,
                        fldYear = q.fldYear,
                        fldJobeCode = q.fldJobeCode,
                        fldFlag = q.fldFlag,
                        fldMostamar=q.fldMostamar,
                        fldNameNoeMostamar=q.fldNameNoeMostamar
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSayerPardakhtsInsert(PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti, ShomareHesabId, CostCenterId, UserId, Desc,Mostamar);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSayerPardakhtsUpdate(Id, PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti,ShomareHesabId,CostCenterId, UserId, Desc,  Mostamar);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSayerPardakhtsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, short Year, byte Month, byte NobatePardakt, byte MarhalePardakht, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblSayerPardakhtsSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakt, MarhalePardakht,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblSayerPardakhtsSelect("CheckSave", PersonalId.ToString(), 0, Year, Month, NobatePardakt, MarhalePardakht,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
       /* #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q=p.spr_Pay_tblMohasebat_PersonalInfoSelect("fldSayerPardakhthaId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion*/
    }
}