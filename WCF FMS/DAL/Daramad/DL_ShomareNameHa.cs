using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ShomareNameHa
    {
        #region Detail
        public OBJ_ShomareNameHa Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblShomareNameHaSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ShomareNameHa()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMokatebatId = q.fldMokatebatId,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShomare = q.fldShomare,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ShomareNameHa> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblShomareNameHaSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ShomareNameHa()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldMokatebatId = q.fldMokatebatId,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShomare = q.fldShomare,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, int StartNumber, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Shomare=new System.Data.Entity.Core.Objects.ObjectParameter("fldShomare",typeof(int));
                p.spr_tblShomareNameHaInsert(MokatebatId, ReplyTaghsitId, Shomare, StartNumber, UserId, Desc);
                return Convert.ToInt32(Shomare.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, short Year, int Shomare, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareNameHaUpdate(Id, MokatebatId, ReplyTaghsitId, Year, Shomare, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareNameHaDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}