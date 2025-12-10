using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterArchive
    {
        #region Detail
        public OBJ_LetterArchive Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterArchiveSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterArchive()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldArchiveId = q.fldArchiveId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterArchive> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterArchiveSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterArchive()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldArchiveId = q.fldArchiveId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int fldMessageId, int fldArchiveId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterArchiveInsert(fldLetterId, fldMessageId, fldArchiveId, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int fldMessageId, int fldArchiveId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterArchiveUpdate(Id, fldLetterId, fldMessageId, fldArchiveId, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterArchiveDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DeleteLetterArchiveLetterID
        public string DeleteLetterArchiveLetterID(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterArchiveLetterIDDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}