using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_Anbar_Tree
    {
        #region Detail
        public OBJ_Anbar_Tree Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblAnbar_TreeSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Anbar_Tree
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldAnbarId = q.fldAnbarId,
                        fldAnbarTreeId = q.fldAnbarTreeId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Anbar_Tree> Select(string FieldName, string FilterValue, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblAnbar_TreeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Anbar_Tree()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldAnbarId = q.fldAnbarId,
                        fldAnbarTreeId = q.fldAnbarTreeId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int AnbarId, int AnbarTreeId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbar_TreeInsert(AnbarId, AnbarTreeId, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int AnbarId, int AnbarTreeId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbar_TreeUpdate(Id, AnbarId, AnbarTreeId, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbar_TreeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}