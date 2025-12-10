using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_DasteCheck
    {
        #region Detail
        public OBJ_DasteCheck Detail(int Id,int OrganId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblDasteCheckSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_DasteCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldIdOlgoCheck = q.fldIdOlgoCheck,
                        fldMoshakhaseDasteCheck = q.fldMoshakhaseDasteCheck,
                        fldShomareHesab = q.fldShomareHesab,
                        fldBankName = q.fldBankName,
                        fldIdShomareHesab = q.fldIdShomareHesab,
                        fldShobeName = q.fldShobeName,
                        fldOlgu = q.fldOlgu,
                        fldShoroeSeriyal = q.fldShoroeSeriyal,
                        fldTedadBarg = q.fldTedadBarg,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DasteCheck> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblDasteCheckSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_DasteCheck()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldIdOlgoCheck = q.fldIdOlgoCheck,
                        fldMoshakhaseDasteCheck = q.fldMoshakhaseDasteCheck,
                        fldShomareHesab = q.fldShomareHesab,
                        fldBankName = q.fldBankName,
                        fldIdShomareHesab = q.fldIdShomareHesab,
                        fldShobeName = q.fldShobeName,
                        fldOlgu = q.fldOlgu,
                        fldShoroeSeriyal = q.fldShoroeSeriyal,
                        fldTedadBarg = q.fldTedadBarg,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblDasteCheckInsert(OlgoCheckId, ShomareHesabId, MoshakhaseDasteCheck, TedadBarg, ShoroeSeriyal, UserId, Desc,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblDasteCheckUpdate(Id, OlgoCheckId, ShomareHesabId, MoshakhaseDasteCheck, TedadBarg, ShoroeSeriyal, UserId, Desc,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblDasteCheckDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (ChekEntities m = new ChekEntities())
            {
                var sodor = m.spr_tblSodorCheckSelect("fldIdDasteChek_CheckDelete", id.ToString(), 0, 0).FirstOrDefault();
                if (sodor != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}