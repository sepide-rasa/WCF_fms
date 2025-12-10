using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.DAL.Archive
{
    public class DL_ArchiveTree
    {
        #region Detail
        public OBJ_ArchiveTree Detail(int Id,int OrganId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblArchiveTreeSelect("fldId", Id.ToString(), OrganId,"", 1)
                    .Select(q => new OBJ_ArchiveTree()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldFileUpload = q.fldFileUpload,
                        fldPID = q.fldPID,
                        fldOrganId = q.fldOrganId,
                        fldModuleId = q.fldModuleId,
                        fldMaduleName = q.fldMaduleName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ArchiveTree> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblArchiveTreeSelect(FieldName, FilterValue, OrganId, FilterValue2, h)
                    .Select(q => new OBJ_ArchiveTree()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldFileUpload = q.fldFileUpload,
                        fldPID = q.fldPID,
                        fldOrganId = q.fldOrganId,
                        fldModuleId = q.fldModuleId,
                        fldMaduleName = q.fldMaduleName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int? PID, string Title, bool FileUpload, int fldModuleId, int fldOrganId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblArchiveTreeInsert(Id,PID, Title, FileUpload,fldOrganId,fldModuleId, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int? PID, string Title, bool FileUpload, int fldModuleId, int fldOrganId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblArchiveTreeUpdate(Id, PID, Title, FileUpload, fldOrganId, fldModuleId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblArchiveTreeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDeleteNodeTree
        public bool CheckDeleteNodeTree(int Id,int OrganId)
        {
            var q = false;
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var C = p.spr_tblArchiveTreeSelect("fldPID", Id.ToString(),OrganId,"", 0).FirstOrDefault();
                if (C != null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (ArchiveEntities m = new ArchiveEntities())
            {
                var FileM = m.spr_tblFileMojazSelect("fldArchiveTreeId", Id.ToString(), 0).FirstOrDefault();
                var p = m.spr_tblParticularPropertiesSelect("fldArchiveTreeId", Id.ToString(), 0).FirstOrDefault();
                if (FileM != null || p != null)
                    q = true;
            }
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title,int? PID, int fldModuleId, int fldOrganId, int Id)
        {
            bool q = false;
            using (ArchiveEntities p = new ArchiveEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblArchiveTreeSelect("CheckTitle", Title, fldOrganId,"", 0).Where(l => l.fldPID == PID && l.fldModuleId == fldModuleId).Any();

                }
                else
                {
                    var query = p.spr_tblArchiveTreeSelect("CheckTitle", Title, fldOrganId,"", 0).Where(l => l.fldPID == PID && l.fldModuleId == fldModuleId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region SelectArchiveTree_Module
        public List<OBJ_ArchiveTree> SelectArchiveTree_Module(string FilterValue, int OrganId, int ModuleId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_SelectArchiveTree_Module(OrganId, ModuleId, FilterValue)
                    .Select(q => new OBJ_ArchiveTree()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldFileUpload = q.fldFileUpload,
                        fldPID = q.fldPID,
                        fldOrganId = q.fldOrganId,
                        fldModuleId = q.fldModuleId,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}