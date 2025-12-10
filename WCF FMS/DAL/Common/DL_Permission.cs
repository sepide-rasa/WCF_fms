using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Permission
    {
        #region Select
        public List<OBJ_Permission> Select(string FieldName, string FilterValue, int UserId, int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities r = new RasaFMSCommonDBEntities())
            {
                var p = r.spr_tblPermissionSelect(FieldName, FilterValue, UserId, OrganId, h)
                    .Select(x => new OBJ_Permission
                    {
                        fldApplicationPartId = x.fldApplicationPartID,
                        fldDate = x.fldDate,
                        fldDesc = x.fldDesc,
                        fldId = x.fldId,
                        fldUserGroup_ModuleOrganID = x.fldUserGroup_ModuleOrganID,
                        UserId = x.fldUserID
                    }).ToList();
                return p;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldUserGroup_ModuleOrganID, int ApplicationPartId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities r = new RasaFMSCommonDBEntities())
            {
                r.spr_tblPermissionInsert(fldUserGroup_ModuleOrganID, ApplicationPartId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد";
            }
        }
        #endregion
        #region Delete
        public string Delete(int UserGroupId,int ModuleId, int UserId)
        {
            using (RasaFMSCommonDBEntities r = new RasaFMSCommonDBEntities())
            {
                r.spr_tblPermissionDelete(UserGroupId, ModuleId, UserId);
                return "حذف با موفقیت انجام شد";
            }
        }
        #endregion
        #region CopyPermission
        public string CopyPermission(int por, int khali, int UserId)
        {
            using (RasaFMSCommonDBEntities r = new RasaFMSCommonDBEntities())
            {
                r.spr_CopyPermission(por,khali, UserId);
                return "ذخیره با موفقیت انجام شد";
            }
        }
        #endregion
        #region DeleteChildUserGroupPermission
        public string DeleteChildUserGroupPermission(int UserGroup_ModuleOrganId, string appId)
        {
            using (RasaFMSCommonDBEntities r = new RasaFMSCommonDBEntities())
            {
                r.spr_DeleteChildUserGroupPermission(UserGroup_ModuleOrganId, appId);
                return "حذف با موفقیت انجام شد";
            }
        }
        #endregion
    }
}