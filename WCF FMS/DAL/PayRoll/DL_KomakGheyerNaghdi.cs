using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KomakGheyerNaghdi
    {
        #region Detail
        public OBJ_KomakGheyerNaghdi Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKomakGheyerNaghdiSelect("fldId", Id.ToString(), 0, 0, 0, 0, OrganId, 1)
                    .Select(q => new OBJ_KomakGheyerNaghdi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKhalesPardakhti=q.fldKhalesPardakhti,
                        fldMablagh=q.fldMablagh,
                        fldMaliyat=q.fldMaliyat,
                        fldMonth=q.fldMonth,
                        fldNoeMostamer=q.fldNoeMostamer,
                        fldPersonalId=q.fldPersonalId,
                        fldYear = q.fldYear,
                        fldNameNoeMostamer = q.fldNameNoeMostamer,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldNameFamilyPersonal = q.fldNameFamilyPersonal,
                        fldMonthName = q.fldMonthName,
                        fldFlag = q.fldFlag
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KomakGheyerNaghdi> Select(string FieldName, string FilterValue, int id, int PersonalId, short Year, byte Month, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKomakGheyerNaghdiSelect(FieldName, FilterValue, id, PersonalId, Year, Month, OrganId, h)
                    .Select(q => new OBJ_KomakGheyerNaghdi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMonth = q.fldMonth,
                        fldNoeMostamer = q.fldNoeMostamer,
                        fldPersonalId = q.fldPersonalId,
                        fldYear = q.fldYear,
                        fldNameNoeMostamer = q.fldNameNoeMostamer,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldNameFamilyPersonal = q.fldNameFamilyPersonal,
                        fldMonthName = q.fldMonthName,
                        fldFlag = q.fldFlag
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKomakGheyerNaghdiInsert(PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKomakGheyerNaghdiUpdate(Id, PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKomakGheyerNaghdiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region KomakGheyerNaghdiGroup
        public List<OBJ_KomakGheyerNaghdi> KomakGheyerNaghdiGroup(string FieldName,byte Month, short Year, bool NoeMostamer, int PersonalId,int OrganId,int CostCenter_Chart)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKomakGheyerNaghdiGroupSelect(FieldName,Month, Year, NoeMostamer, PersonalId, OrganId,CostCenter_Chart)
                    .Select(q => new OBJ_KomakGheyerNaghdi()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldId = q.fldId,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMonth = q.fldMonth,
                        fldName = q.fldName,
                        fldNoeMostamer = q.fldNoeMostamer,
                        fldNoeMostamerName = q.fldNoeMostamerName,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareHesab = q.fldShomareHesab,
                        fldYear = q.fldYear,
                        fldShomareHesabId = q.fldShomareHesabId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}