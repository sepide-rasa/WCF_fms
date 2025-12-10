using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_HistoryLetter
    {
        #region Detail
        public OBJ_HistoryLetter Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblHistoryLetterSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_HistoryLetter()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldCurrentLetter_Id = q.fldCurrentLetter_Id,
                        fldHistoryType_Id = q.fldHistoryType_Id,
                        fldHistoryLetter_Id = q.fldHistoryLetter_Id,
                        fldSubject = q.fldSubject,
                        fldLetterNumber = q.fldLetterNumber,
                        fldCreatedLetterId = q.fldCreatedLetterId,
                        fldLetterDate = q.fldLetterDate,
                        fldComisionID = q.fldComisionID,
                        fldHistoryTypeName = q.fldHistoryTypeName,

                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_HistoryLetter> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblHistoryLetterSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_HistoryLetter()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldCurrentLetter_Id = q.fldCurrentLetter_Id,
                        fldHistoryType_Id = q.fldHistoryType_Id,
                        fldHistoryLetter_Id = q.fldHistoryLetter_Id,
                        fldSubject = q.fldSubject,
                        fldLetterNumber = q.fldLetterNumber,
                        fldCreatedLetterId = q.fldCreatedLetterId,
                        fldLetterDate = q.fldLetterDate,
                        fldComisionID = q.fldComisionID,
                        fldHistoryTypeName = q.fldHistoryTypeName,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long fldCurrentLetter_Id,int fldHistoryType_Id,long fldHistoryLetter_Id, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblHistoryLetterInsert(fldCurrentLetter_Id, fldHistoryType_Id, fldHistoryLetter_Id, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long fldCurrentLetter_Id, int fldHistoryType_Id, long fldHistoryLetter_Id, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblHistoryLetterUpdate(Id, fldCurrentLetter_Id, fldHistoryType_Id, fldHistoryLetter_Id, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblHistoryLetterDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}