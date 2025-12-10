using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterAttachment
    {
        #region Detail
        public OBJ_LetterAttachment Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterAttachmentSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterAttachment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldName = q.fldName,
                        fldContentFileId = q.fldContentFileId,
                        fldNameFile = q.fldNameFile
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterAttachment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterAttachmentSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterAttachment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldName = q.fldName,
                        fldContentFileId = q.fldContentFileId,
                        fldNameFile = q.fldNameFile
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, string fldName, string fldNameFile,byte[] file,string fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterAttachmentInsert(fldLetterId, fldName, fldNameFile, file, fldType, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, string fldName, int fldContentFileId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterAttachmentUpdate(Id, fldLetterId, fldName, fldContentFileId, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterAttachmentDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DeleteLetterAttachmentLetterID
        public string DeleteLetterAttachmentLetterID(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterAttachmentLetterIDDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}