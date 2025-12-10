using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_UserGroup
    {
        #region Detail
        public OBJ_UserGroup Detail(int id)
        {
            using (RasaFMSCommonDBEntities s = new RasaFMSCommonDBEntities())
            {
                var p = s.spr_tblUserGroupSelect("fldId", id.ToString(),0, 1)
                    .Select(x => new OBJ_UserGroup
                    {
                        fldId = x.fldId,
                        fldTitle = x.fldTitle,
                        fldUserId = x.fldUserID,
                        fldDate = x.fldDate,
                        fldDesc = x.fldDesc,
                    }).FirstOrDefault();
                return p;
            }
        }
        #endregion
        #region Select
        public List<OBJ_UserGroup> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var t = p.spr_tblUserGroupSelect(FieldName, FilterValue,UserId, h)
                    .Select(x => new OBJ_UserGroup()
                    {
                        fldId = x.fldId,
                        fldTitle = x.fldTitle,
                        fldUserId = x.fldUserID,
                        fldDate = x.fldDate,
                        fldDesc = x.fldDesc,
                    }).ToList();
                return t;
            }
        }
        #endregion
        #region Insert
        public int Insert(string Title, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities t = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                t.spr_tblUserGroupInsert(id, Title, UserId, Desc);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities t = new RasaFMSCommonDBEntities())
            {
                t.spr_tblUserGroupUpdate(Id, Title, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserGroupDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
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
                    q = p.spr_tblUserGroupSelect("fldTitle", Title,0, 0).Any();
                }
                else
                {
                    var query = p.spr_tblUserGroupSelect("fldTitle", Title,0, 0).FirstOrDefault(); ;
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
            var q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var UserGroup_M = m.spr_CheckUserGroupForPermission(id).FirstOrDefault();
                if (UserGroup_M.fldType == "1")
                    q = true;
            }
            return q;
        }
        #endregion
    }
}