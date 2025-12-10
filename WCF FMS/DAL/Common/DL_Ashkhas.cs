using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Ashkhas
    {
        #region Detail
        public OBJ_Ashkhas Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhasSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_Ashkhas()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldHaghighiId = q.fldHaghighiId,
                        fldHoghoghiId = q.fldHoghoghiId,
                        Name = q.Name,
                        NoeShakhs = q.NoeShakhs,
                        fldShenase_CodeMeli = q.fldShenase_CodeMeli,
                        shomareshabt_father = q.shomareshabt_father,
                        fldName = q.fldName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldFamily = q.fldFamily,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareTelephone = q.fldShomareTelephone,
                        fldAddress = q.fldAddress
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Ashkhas> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblAshkhasSelect(FieldName, FilterValue,FilterValue1, h)
                    .Select(q => new OBJ_Ashkhas()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldHaghighiId = q.fldHaghighiId,
                        fldHoghoghiId = q.fldHoghoghiId,
                        Name = q.Name,
                        NoeShakhs = q.NoeShakhs,
                        fldShenase_CodeMeli = q.fldShenase_CodeMeli,
                        shomareshabt_father = q.shomareshabt_father,
                        fldName = q.fldName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldFamily = q.fldFamily,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareTelephone = q.fldShomareTelephone,
                        fldAddress = q.fldAddress
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> HaghighiId, Nullable<int> HoghoghiId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhasInsert(HaghighiId, HoghoghiId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> HaghighiId, Nullable<int> HoghoghiId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhasUpdate(Id, HaghighiId, HoghoghiId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblAshkhasDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(Nullable<int> HaghighiId, Nullable<int> HoghoghiId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    if (HaghighiId != null)
                    {
                        q = p.spr_tblAshkhasSelect("fldHaghighiId", HaghighiId.ToString(),"", 0).Where(l => l.fldHoghoghiId == HoghoghiId).Any();
                    }
                    else
                    {
                        q = p.spr_tblAshkhasSelect("fldHaghighiId", HaghighiId.ToString(),"", 0).Where(l => l.fldHoghoghiId == HoghoghiId).Any();
                    }
                }
                else
                {
                    if (HoghoghiId != null)
                    {
                        var query = p.spr_tblAshkhasSelect("fldHoghoghiId", HoghoghiId.ToString(),"", 0).Where(l => l.fldHaghighiId == HaghighiId).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                    else
                    {
                        var query = p.spr_tblAshkhasSelect("fldHoghoghiId", HoghoghiId.ToString(),"", 0).Where(l => l.fldHaghighiId == HaghighiId).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var sh = m.spr_tblShomareHesabeOmoomiSelect("fldAshkhasId", id.ToString(), "", "", 0).FirstOrDefault();
                if (sh != null)
                    q = true;
            }
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var elam = m.spr_tblElamAvarezSelect("CheckAshakhasID", id.ToString(), "", 0).FirstOrDefault();
                var barat = m.spr_tblBaratSelect("fldBaratDarId", id.ToString(), 0).FirstOrDefault();
                var Mahdodiyat = m.spr_tblMahdoodiyatMohasebat_AshkhasSelect("fldAshkhasId", id.ToString(), 0).FirstOrDefault();
                if (elam != null || barat != null || Mahdodiyat != null)
                    q = true;
            }
            using (ChekEntities m = new ChekEntities())
            {
                var sodorchek = m.spr_tblSodorCheckSelect("fldAshkhasId_CheckDelete", id.ToString(), 0, 0).FirstOrDefault();
                if (sodorchek != null)
                    q = true;
            }
            using (AutomationEntities m = new AutomationEntities())
            {
                var co = m.spr_tblCommisionSelect("fldAshkhasID", id.ToString(), 0, 0).FirstOrDefault();
                if (co != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}