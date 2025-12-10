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
    public class DL_Module_Organ
    {
        #region Detail
        public OBJ_Module_Organ Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblModule_OrganSelect("fldId", Id.ToString(), 0, 1)
                    .Select(q => new OBJ_Module_Organ()
                    {
                        fldId=q.fldId,
                        fldUserId=q.fldUserId,
                        fldModuleId=q.fldModuleId,
                        fldOrganId=q.fldOrganId,
                        fldNameModule=q.fldNameModule,
                        fldNameModule_Organ=q.fldNameModule_Organ,
                        fldNameOrgan=q.fldNameOrgan,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldPermissionId = q.fldPermissionId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Module_Organ> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblModule_OrganSelect(FieldName, FilterValue, UserId, h)
                    .Select(q => new OBJ_Module_Organ()
                    {
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldModuleId = q.fldModuleId,
                        fldOrganId = q.fldOrganId,
                        fldNameModule = q.fldNameModule,
                        fldNameModule_Organ = q.fldNameModule_Organ,
                        fldNameOrgan =q.fldNameOrgan,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldPermissionId = q.fldPermissionId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int OrganId, int ModuleId,int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModule_OrganInsert(OrganId, ModuleId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int OrganId, int ModuleId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModule_OrganUpdate(Id, OrganId, ModuleId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModule_OrganDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int  ModuleId,int OrganId, int Id)
        {
            bool q=false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q=p.spr_tblModule_OrganSelect("CheckModuleId", ModuleId.ToString(),0, 0).Where(l => l.fldOrganId == OrganId).Any();
                }
                else
                {
                    var query = p.spr_tblModule_OrganSelect("CheckModuleId", ModuleId.ToString(), 0, 0).Where(l => l.fldOrganId == OrganId).FirstOrDefault();
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
                var UserGroup_M = m.spr_tblUserGroup_ModuleOrganSelect("fldModuleOrganId", id.ToString(), 0).FirstOrDefault();
                var Masolin = m.spr_tblMasuolinSelect("fldModule_OrganId", id.ToString(), 0, 0).FirstOrDefault();
                if (UserGroup_M != null || Masolin!=null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}