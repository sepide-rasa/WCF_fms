using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_MessageAttachment
    {
        #region Detail
        public OBJ_MessageAttachment Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMessageAttachmentSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_MessageAttachment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldMessageId = q.fldMessageId,
                        fldFileId = q.fldFileId,
                        fldTitle = q.fldTitle,
                        fldSize = q.fldSize,
                        fldPasvand = q.fldPasvand
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MessageAttachment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMessageAttachmentSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_MessageAttachment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldMessageId = q.fldMessageId,
                        fldFileId = q.fldFileId,
                        fldTitle = q.fldTitle,
                        fldSize = q.fldSize,
                        fldPasvand = q.fldPasvand
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int fldMessageId, byte[] fldImage, string Pasvand, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMessageAttachmentInsert(fldTitle,fldMessageId, fldImage, Pasvand, UserId, Desc, OrganID, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldTitle, int fldMessageId, int fldFileId, byte[] fldImage, string Pasvand, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMessageAttachmentUpdate(Id,fldTitle, fldMessageId,fldFileId, fldImage, Pasvand, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMessageAttachmentDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}