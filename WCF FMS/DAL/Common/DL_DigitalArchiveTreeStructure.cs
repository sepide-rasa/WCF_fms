using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Common
{
    public class DL_DigitalArchiveTreeStructure
    {
        #region Detail
        public OBJ_DigitalArchiveTreeStructure Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblDigitalArchiveTreeStructureSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_DigitalArchiveTreeStructure
                    {
                        fldId=q.fldId,
                        fldPID=q.fldPID,
                        fldModuleId=q.fldModuleId,
                        fldTitle=q.fldTitle,
                        fldAttachFile=q.fldAttachFile,
                        fldModuleName=q.fldModuleName,
                        fldUserId=q.fldUserId,
                        fldDesc=q.fldDesc,
                        fldDate=q.fldDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DigitalArchiveTreeStructure> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblDigitalArchiveTreeStructureSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DigitalArchiveTreeStructure()
                    {
                        fldId = q.fldId,
                        fldPID = q.fldPID,
                        fldModuleId = q.fldModuleId,
                        fldTitle = q.fldTitle,
                        fldAttachFile = q.fldAttachFile,
                        fldModuleName=q.fldModuleName,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, int? PID, int? ModuleId, bool AttachFile, string Desc,int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblDigitalArchiveTreeStructureInsert(Title, PID, ModuleId, AttachFile, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int? PID, int? ModuleId, bool AttachFile, string Desc, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblDigitalArchiveTreeStructureUpdate(Id, Title, PID, ModuleId, AttachFile, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblDigitalArchiveTreeStructureDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int? ModuleId, int? PID, string Title, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    if (ModuleId != null)
                    {
                        q = p.spr_tblDigitalArchiveTreeStructureSelect("fldTitle", Title, 0).Where(l => l.fldModuleId == ModuleId).Any();
                    }
                    else
                    {
                        q= p.spr_tblDigitalArchiveTreeStructureSelect("fldTitle", Title, 0).Where(l => l.fldPID == PID).Any();
                    }       
                }
                else
                {
                    if (ModuleId != null)
                    {
                        var query = p.spr_tblDigitalArchiveTreeStructureSelect("fldTitle", Title, 0).Where(l => l.fldModuleId == ModuleId).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                    else
                    {
                        var query = p.spr_tblDigitalArchiveTreeStructureSelect("fldTitle", Title, 0).Where(l => l.fldPID == PID).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                }
            }
            return q;
        }
        #endregion
    }
}