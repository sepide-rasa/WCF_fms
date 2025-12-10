using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ReplyTakhfif
    {
        #region Detail
        public OBJ_ReplyTakhfif Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblReplyTakhfifSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ReplyTakhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsad=q.fldDarsad,
                        fldMablagh=q.fldMablagh,
                        fldShomareMajavez=q.fldShomareMajavez,
                        fldTarikh=q.fldTarikh,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ReplyTakhfif> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblReplyTakhfifSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ReplyTakhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsad = q.fldDarsad,
                        fldMablagh = q.fldMablagh,
                        fldShomareMajavez = q.fldShomareMajavez,
                        fldTarikh = q.fldTarikh,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTakhfifInsert(Darsad, Mablagh, ShomareMajavez, Tarikh, UserId, Desc, StatusId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTakhfifUpdate(Id, Darsad, Mablagh, ShomareMajavez, Tarikh, UserId, Desc,StatusId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblReplyTakhfifDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}