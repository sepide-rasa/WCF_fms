using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_MahalFot
    {
        #region Detail
        public OBJ_MahalFot Detail(int id)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblMahalFotSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_MahalFot
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldNameMahal = q.fldNameMahal,
                        fldIP = q.fldIP,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MahalFot> Select(string FieldName, string FilterValue, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblMahalFotSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MahalFot()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldNameMahal = q.fldNameMahal,
                        fldIP = q.fldIP,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldNameMahal, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblMahalFotInsert(fldNameMahal, userId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldNameMahal, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblMahalFotUpdate(fldId, fldNameMahal, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblMahalFotDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldNameMahal, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMahalFotSelect("fldNameMahal", fldNameMahal, 0).Any();

                }
                else
                {
                    var query = p.spr_tblMahalFotSelect("fldNameMahal", fldNameMahal, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblMotevaffaSelect("CheckMahalFotId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion
    }
}