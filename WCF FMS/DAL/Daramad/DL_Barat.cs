using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Barat
    {
        #region Detail
        public OBJ_Barat Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblBaratSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Barat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBaratDarId = q.fldBaratDarId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Barat> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblBaratSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Barat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBaratDarId = q.fldBaratDarId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, int BaratDarId, string MakanPardakht, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblBaratInsert(TarikhSarResid, ReplyTaghsitId, ShomareSanad, MablaghSanad, Status, BaratDarId, MakanPardakht, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, int BaratDarId, string MakanPardakht, string DateStatus, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblBaratUpdate(Id, TarikhSarResid, ReplyTaghsitId, ShomareSanad, MablaghSanad, Status, BaratDarId, MakanPardakht, UserId, Desc,DateStatus);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblBaratDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string ShomareSanad, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblBaratSelect("fldShomareSanad", ShomareSanad, 0).Any();

                }
                else
                {
                    var query = p.spr_tblBaratSelect("fldShomareSanad", ShomareSanad, 0).FirstOrDefault();
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