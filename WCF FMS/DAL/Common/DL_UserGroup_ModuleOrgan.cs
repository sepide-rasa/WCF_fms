using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Common
{
    public class DL_UserGroup_ModuleOrgan
    {
        #region Detail
        public OBJ_UserGroup_ModuleOrgan Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblUserGroup_ModuleOrganSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_UserGroup_ModuleOrgan()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldModuleOrganId = q.fldModuleOrganId,
                        fldUserGroupId = q.fldUserGroupId,
                        fldModuleOrganName = q.fldModuleOrganName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_UserGroup_ModuleOrgan> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblUserGroup_ModuleOrganSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_UserGroup_ModuleOrgan()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldModuleOrganId = q.fldModuleOrganId,
                        fldUserGroupId = q.fldUserGroupId,
                        fldModuleOrganName = q.fldModuleOrganName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int UserGroupId, int ModuleOrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserGroup_ModuleOrganInsert(UserGroupId, ModuleOrganId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int UserGroupId, int ModuleOrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserGroup_ModuleOrganUpdate(Id, UserGroupId, ModuleOrganId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserGroup_ModuleOrganDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}