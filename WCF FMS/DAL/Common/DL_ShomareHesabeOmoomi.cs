using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ShomareHesabeOmoomi
    {
        #region Detail
        public OBJ_ShomareHesabeOmoomi Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblShomareHesabeOmoomiSelect("fldId", Id.ToString(),"","", 1)
                    .Select(q => new OBJ_ShomareHesabeOmoomi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldBankId = q.fldBankId,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareSheba = q.fldShomareSheba,
                        fldBankName = q.fldBankName,
                        NameAshkhas = q.NameAshkhas,
                        nameShobe = q.nameShobe,
                        fldCodeSHobe = q.fldCodeSHobe
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabeOmoomi> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblShomareHesabeOmoomiSelect(FieldName, FilterValue, FilterValue2, FilterValue3, h)
                    .Select(q => new OBJ_ShomareHesabeOmoomi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshkhasId = q.fldAshkhasId,
                        fldBankId = q.fldBankId,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareSheba = q.fldShomareSheba,
                        fldBankName = q.fldBankName,
                        NameAshkhas = q.NameAshkhas,
                        nameShobe = q.nameShobe,
                        fldCodeSHobe = q.fldCodeSHobe
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblShomareHesabeOmoomiInsert(ShobeId, AshkhasId, ShomareHesab, ShomareSheba, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblShomareHesabeOmoomiUpdate(Id, ShobeId, AshkhasId, ShomareHesab, ShomareSheba, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblShomareHesabeOmoomiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var sh = m.spr_tblShomareHesabCodeDaramadSelect("fldShomareHesadId", id.ToString(),"",0, 0).FirstOrDefault();
                var fish = m.spr_tblSodoorFishSelect("fldShomareHesabId", id.ToString(), 0).FirstOrDefault();
                var d = m.spr_tblCodhayeDaramadiElamAvarezSelect("fldShomareHesabId", id.ToString(), 0).FirstOrDefault();
                var check = m.spr_tblCheckSelect("fldShomareHesabId", id.ToString(), 0).FirstOrDefault();
                var PspM = m.spr_tblPSPModel_ShomareHesabSelect("fldShHesabId", id.ToString(), 0).FirstOrDefault();
                if (sh != null || fish != null || d != null || check != null || PspM != null)
                    q = true;
            }
            using (RasaFMSPayRollDBEntities m = new RasaFMSPayRollDBEntities())
            {
                var k = m.spr_tblKomakGheyerNaghdiSelect("fldShomareHesabId", id.ToString(), 0, 0, 0, 0, 0, 0).FirstOrDefault();
                var mohasebat = m.spr_tblMohasebat_PersonalInfoSelect("checkShomareHesabId", id.ToString(), 0, 0).FirstOrDefault();
                var setting = m.spr_tblSettingSelect("fldB_ShomareHesabId", id.ToString(), 0, 0).FirstOrDefault();
                var setting1 = m.spr_tblSettingSelect("fldSh_HesabCheckId", id.ToString(), 0, 0).FirstOrDefault();
                if (k != null || mohasebat != null || setting != null || setting1 != null)
                    q = true;
            }
            using (ChekEntities p = new ChekEntities())
            {
                var daste_Ch = p.spr_tblDasteCheckSelect("fldShomareHesabId_Check", id.ToString(),0, 0).FirstOrDefault();
                if (daste_Ch != null)
                    q = true;
            }
            return q;
        }
        #endregion
        #region CheckShomareSheba
        public bool CheckShomareSheba(string ShomareSheba)
        {
            var q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var m = p.spr_CheckShomareSheba(ShomareSheba).FirstOrDefault();
                if (m.CheckShomareSheba != 1)
                    q = true;
            }
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ShobeId, string ShomareHesab, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var shobe = p.spr_tblSHobeSelect("fldId", ShobeId.ToString(), 0).FirstOrDefault();

                if (Id == 0)
                {
                    q = p.spr_tblShomareHesabeOmoomiSelect("fldShomareHesab", ShomareHesab,"","", 0).Where(l => l.fldBankId == shobe.fldBankId).Any();

                }
                else
                {
                    var query = p.spr_tblShomareHesabeOmoomiSelect("fldShomareHesab", ShomareHesab,"","", 0).Where(l => l.fldBankId == shobe.fldBankId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}