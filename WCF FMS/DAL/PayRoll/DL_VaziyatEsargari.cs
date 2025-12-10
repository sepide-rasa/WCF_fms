using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_VaziyatEsargari
    {
        #region Detail
        public OBJ_VaziyatEsargari Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblVaziyatEsargariSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_VaziyatEsargari
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldMoafAsBime=q.fldMoafAsBime,
                        fldMoafAsBimeName=q.fldMoafAsBimeName,
                        fldMoafAsMaliyat=q.fldMoafAsMaliyat,
                        fldMoafAsMaliyatName = q.fldMoafAsMaliyatName,
                        fldMoafAsBimeOmr=q.fldMoafAsBimeOmr,
                        fldMoafAsBimeOmrName=q.fldMoafAsBimeOmrName,
                        fldMoafAsBimeTakmili=q.fldMoafAsBimeTakmili,
                        fldMoafAsBimeTakmiliName=q.fldMoafAsBimeTakmiliName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_VaziyatEsargari> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblVaziyatEsargariSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_VaziyatEsargari()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldMoafAsBime = q.fldMoafAsBime,
                        fldMoafAsBimeName = q.fldMoafAsBimeName,
                        fldMoafAsMaliyat = q.fldMoafAsMaliyat,
                        fldMoafAsMaliyatName = q.fldMoafAsMaliyatName,
                        fldMoafAsBimeOmr=q.fldMoafAsBimeOmr,
                        fldMoafAsBimeOmrName=q.fldMoafAsBimeOmrName,
                        fldMoafAsBimeTakmili=q.fldMoafAsBimeTakmili,
                        fldMoafAsBimeTakmiliName=q.fldMoafAsBimeTakmiliName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVaziyatEsargariInsert(fldTitle, fldMoafAsBime, fldMoafAsMaliyat,fldMoafAsBimeOmr, fldMoafAsBimeTakmili, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVaziyatEsargariUpdate(fldId, fldTitle, fldMoafAsBime, fldMoafAsMaliyat,fldMoafAsBimeOmr, fldMoafAsBimeTakmili, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblVaziyatEsargariDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var m = p.spr_tblMohasebat_PersonalInfoSelect("CheckStatusIsargariId", id.ToString(), 0, 0).FirstOrDefault();
                var personal = p.spr_Prs_tblPersonalInfoSelect("CheckEsargariId", id.ToString(), 0, 0).FirstOrDefault();
                if (m != null || personal != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}