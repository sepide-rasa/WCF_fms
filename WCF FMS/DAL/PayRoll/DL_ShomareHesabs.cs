using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_ShomareHesabs
    {
        #region Detail
        public OBJ_ShomareHesabs Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblShomareHesabsSelect("fldId", Id.ToString(), "","",OrganId, 1)
                    .Select(q => new OBJ_ShomareHesabs()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankFixId = q.fldBankFixId,
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareKart = q.fldShomareKart,
                        fldTypeHesab = q.fldTypeHesab,
                        fldTypeHesabName = q.fldTypeHesabName,
                        fldBankName = q.fldBankName,
                        fldShobeId = q.fldShobeId,
                        fldHesabTypeId=q.fldHesabTypeId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabs> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblShomareHesabsSelect(FieldName, FilterValue,FilterValue2,FilterValue3,OrganId, h)
                    .Select(q => new OBJ_ShomareHesabs()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankFixId = q.fldBankFixId,
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareKart = q.fldShomareKart,
                        fldTypeHesab = q.fldTypeHesab,
                        fldTypeHesabName = q.fldTypeHesabName,
                        fldBankName = q.fldBankName,
                        fldShobeId = q.fldShobeId,
                        fldHesabTypeId = q.fldHesabTypeId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab,byte HesabTypeId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabsInsert(PersonalId, ShobeId, ShomareHesab, ShomareKart, TypeHesab, UserId, Desc,HesabTypeId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabsUpdate(Id, ShobeId, PersonalId, ShomareHesab, ShomareKart, TypeHesab, UserId, Desc, HesabTypeId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblShomareHesabsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(bool TypeHesab, string ShomareHesab, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblShomareHesabsSelect("CheckHesab", TypeHesab.ToString(), ShomareHesab, "",0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblShomareHesabsSelect("CheckHesab", TypeHesab.ToString(), ShomareHesab, "",0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region ShomareHesabGroup
        public List<OBJ_ShomareHesabs> ShomareHesabGroup(bool NoeHesab, int BankId, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblShomareHesabGroupSelect(NoeHesab, BankId, OrganId)
                    .Select(q => new OBJ_ShomareHesabs()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareKart = q.fldShomareKart,
                        fldShobeId = q.fldShobeId,
                        fldShobeName=q.fldShobeName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckShomareHesabId", Id.ToString(),0, 0).Any();
                return q;
            }
        }
        #endregion
    }
}