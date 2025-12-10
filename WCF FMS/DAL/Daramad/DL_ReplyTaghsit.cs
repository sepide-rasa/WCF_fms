using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ReplyTaghsit
    {
        #region Detail
        public OBJ_ReplyTaghsit Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblReplyTaghsitSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ReplyTaghsit()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablaghNaghdi = q.fldMablaghNaghdi,
                        fldShomareMojavez = q.fldShomareMojavez,
                        fldTarikh = q.fldTarikh,
                        fldTedadAghsat = q.fldTedadAghsat,
                        fldTedadMahAghsat = q.fldTedadMahAghsat,
                        fldJarimeTakhir = q.fldJarimeTakhir,
                        fldDarsad = q.fldDarsad,
                        fldDescKarmozd = q.fldDescKarmozd,
                        fldStatusId=q.fldStatusId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ReplyTaghsit> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblReplyTaghsitSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ReplyTaghsit()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMablaghNaghdi = q.fldMablaghNaghdi,
                        fldShomareMojavez = q.fldShomareMojavez,
                        fldTarikh = q.fldTarikh,
                        fldTedadAghsat = q.fldTedadAghsat,
                        fldTedadMahAghsat = q.fldTedadMahAghsat,
                        fldJarimeTakhir = q.fldJarimeTakhir,
                        fldDarsad = q.fldDarsad,
                        fldDescKarmozd = q.fldDescKarmozd,
                        fldStatusId = q.fldStatusId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int StatusId, byte TedadMahAghsat, long JarimeTakhir, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTaghsitInsert(MablaghNaghdi, TedadAghsat, ShomareMojavez, Tarikh, UserId, Desc, StatusId, TedadMahAghsat,JarimeTakhir);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int UserId, int StatusId, byte TedadMahAghsat, long JarimeTakhir, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTaghsitUpdate(Id, MablaghNaghdi, TedadAghsat, ShomareMojavez, Tarikh, UserId, Desc, StatusId, TedadMahAghsat, JarimeTakhir);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTaghsitDelete(Id, UserId);
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
                var barat = m.spr_tblBaratSelect("fldReplyTaghsitId", id.ToString(), 0).FirstOrDefault();
                var check = m.spr_tblCheckSelect("fldReplyTaghsitId", id.ToString(), 0).FirstOrDefault();
                var n = m.spr_tblNaghdi_TalabSelect("fldReplyTaghsitId", id.ToString(), 0).FirstOrDefault();
                var sh = m.spr_tblShomareNameHaSelect("fldReplyTaghsitId", id.ToString(), 0).FirstOrDefault();
                if (barat != null || check != null || n != null || sh != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}