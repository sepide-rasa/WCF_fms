using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_Assignment
    {
        #region Detail
        public OBJ_Assignment Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblAssignmentSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Assignment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterID = q.fldLetterID,
                        fldMessageId = q.fldMessageId,
                        fldAssignmentDate = q.fldAssignmentDate,
                        fldAnswerDate = q.fldAnswerDate,
                        fldSourceAssId = q.fldSourceAssId,
                        fldTitleMessage = q.fldTitleMessage,
                        fldSubject = q.fldSubject
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Assignment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblAssignmentSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Assignment()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterID = q.fldLetterID,
                        fldMessageId = q.fldMessageId,
                        fldAssignmentDate = q.fldAssignmentDate,
                        fldAnswerDate = q.fldAnswerDate,
                        fldSourceAssId = q.fldSourceAssId,
                        fldTitleMessage = q.fldTitleMessage,
                        fldSubject = q.fldSubject
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblAssignmentInsert(Id,fldLetterID, fldMessageId, fldAnswerDate, fldSourceAssId, UserId, Desc, OrganID, IP);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentUpdate(Id, fldLetterID, fldMessageId, fldAnswerDate, fldSourceAssId, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DeleteAssignmentLetterID
        public string DeleteAssignmentLetterID(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblAssignmentLetterIDDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}