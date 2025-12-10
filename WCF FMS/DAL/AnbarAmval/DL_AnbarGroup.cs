using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_AnbarGroup
    {
        #region Detail
        public OBJ_AnbarGroup Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblAnbarGroupSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_AnbarGroup
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AnbarGroup> Select(string FieldName, string FilterValue, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblAnbarGroupSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_AnbarGroup()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarGroupInsert(Name, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarGroupUpdate(Id, Name, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarGroupDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            using (AnbarAmvalEntities m = new AnbarAmvalEntities())
            {
                var q = false;
                q = m.spr_tblAnbarTreeSelect("fldGroupId", id.ToString(),"", 0).Any();
                return q;
            }
        }
        #endregion
    }
}