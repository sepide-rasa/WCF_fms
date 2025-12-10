using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_NahvePardakht
    {
        #region Detail
        public OBJ_NahvePardakht Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblNahvePardakhtSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_NahvePardakht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldCodePardakht = q.fldCodePardakht
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_NahvePardakht> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblNahvePardakhtSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_NahvePardakht()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldCodePardakht = q.fldCodePardakht
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, string CodePardakht, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNahvePardakhtInsert(Title, UserId, Desc, CodePardakht);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string CodePardakht, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNahvePardakhtUpdate(Id, Title, UserId, Desc, CodePardakht);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblNahvePardakhtDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, string CodePardakht, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    var NahveP = p.spr_tblNahvePardakhtSelect("fldTitle", Title, 0).FirstOrDefault();
                    var NahveP1 = p.spr_tblNahvePardakhtSelect("fldCodePardakht", CodePardakht, 0).FirstOrDefault();
                    if (NahveP != null || NahveP1 != null)
                        q = true;
                }
                else
                {
                    var query = p.spr_tblNahvePardakhtSelect("fldTitle", Title, 0).FirstOrDefault();
                    var query1 = p.spr_tblNahvePardakhtSelect("fldCodePardakht", CodePardakht, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id || query1 != null && query1.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var C = p.spr_tblPardakhtFishSelect("fldNahvePardakhtId", Id.ToString(), 0).FirstOrDefault();
                var Pardakht = p.spr_tblPardakhtFiles_DetailSelect("fldNahvePardakhtId", Id.ToString(), "", "", "", 0).FirstOrDefault();
                if (C != null || Pardakht!=null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}