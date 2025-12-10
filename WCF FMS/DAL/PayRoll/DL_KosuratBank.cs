using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KosuratBank
    {
        #region Detail
        public OBJ_KosuratBank Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKosuratBankSelect("fldId", Id.ToString(),"","",OrganId, 1)
                    .Select(q => new OBJ_KosuratBank()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldCodemeli = q.fldCodemeli,
                        fldCount = q.fldCount,
                        fldDeactiveDate = q.fldDeactiveDate,
                        fldMablagh = q.fldMablagh,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldUserID = q.fldUserID,
                        ShobeName = q.ShobeName,
                        fldBankName = q.fldBankName,
                        fldMandeAzGhabl = q.fldMandeAzGhabl,
                        fldMandeDarFish = q.fldMandeDarFish,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldShomareSheba=q.fldShomareSheba
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KosuratBank> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKosuratBankSelect(FieldName, FilterValue, FilterValue1, FilterValue2, OrganId, h)
                    .Select(q => new OBJ_KosuratBank()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldCodemeli = q.fldCodemeli,
                        fldCount = q.fldCount,
                        fldDeactiveDate = q.fldDeactiveDate,
                        fldMablagh = q.fldMablagh,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldUserID = q.fldUserID,
                        ShobeName = q.ShobeName,
                        fldBankName = q.fldBankName,
                        fldMandeAzGhabl = q.fldMandeAzGhabl,
                        fldMandeDarFish = q.fldMandeDarFish,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldShomareSheba = q.fldShomareSheba
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region RptKosouratBank
        public List<OBJ_RptKosouratBank> RptKosouratBank(byte NobatPardakhtId,short Year, byte Month, int CostCenterId, byte CalcType, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptKosuratBank(NobatPardakhtId, Year, Month, CostCenterId, OrganId, CalcType)
                    .Select(q => new OBJ_RptKosouratBank()
                    {
                        fldBankId=q.fldBankId,
                        fldDesc=q.fldDesc,
                        fldFamily=q.fldFamily,
                        fldFatherName=q.fldFatherName,
                        fldId=q.fldId,
                        fldMablagh=q.fldMablagh,
                        fldMonth=q.fldMonth,
                        fldName=q.fldName,
                        fldNameBank=q.fldNameBank,
                        fldShobeId=q.fldShobeId,
                        fldShomareHesab=q.fldShomareHesab,
                        fldYear=q.fldYear                        
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish, string ShomareSheba, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosuratBankInsert(PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab, Status, DeactiveDate, UserId, Desc, MandeAzGhabl, MandeDarFish,ShomareSheba);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab,string ShomareSheba, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosuratBankUpdate(Id, PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab, Status, DeactiveDate, UserId, Desc, MandeAzGhabl, MandeDarFish, ShomareSheba);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKosuratBankDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohasebat_KosoratBankSelect("fldKosoratBankId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion

        #region UpdateKosuratBankStatus
        public string UpdateKosuratBankStatus(bool Status, int Id, int tarikhDeactive, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_UpdateKosuratBankStatus(Status, Id, tarikhDeactive, UserId);
                return "تغییر وضعیت با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateDescKosuratBank
        public string UpdateDescKosuratBank(int Id, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_UpdateDescKosuratBank(Id, Desc, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}