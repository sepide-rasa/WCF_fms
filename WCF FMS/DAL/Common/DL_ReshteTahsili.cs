using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ReshteTahsili
    {
        #region Detail
        public OBJ_ReshteTahsili Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblReshteTahsiliSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_ReshteTahsili()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ReshteTahsili> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblReshteTahsiliSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ReshteTahsili()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblReshteTahsiliInsert(Title, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblReshteTahsiliUpdate(Id, Title, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblReshteTahsiliDelete(Id, UserId);
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
                q = p.spr_Prs_tblPersonalInfoSelect("CheckReshteTahsiliId", Id.ToString(),0, 0).Any();
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblReshteTahsiliSelect("fldTitle", Title, 0).Any();

                }
                else
                {
                    var query = p.spr_tblReshteTahsiliSelect("fldTitle", Title, 0).FirstOrDefault();
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