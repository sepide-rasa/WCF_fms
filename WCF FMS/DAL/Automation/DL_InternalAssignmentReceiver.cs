using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_InternalAssignmentReceiver
    {
        #region Detail
        public OBJ_InternalAssignmentReceiver Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalAssignmentReceiverSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_InternalAssignmentReceiver()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldAssignmentTypeID = q.fldAssignmentTypeID,
                        fldBoxID = q.fldBoxID,
                        fldLetterReadDate = q.fldLetterReadDate,
                        fldShowTypeT_F = q.fldShowTypeT_F,
                        fldBoxName = q.fldBoxName,
                        fldStatusName = q.fldStatusName,
                        fldTypeAssignment = q.fldTypeAssignment,
                        fldName_Family = q.fldName_Family
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_InternalAssignmentReceiver> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalAssignmentReceiverSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_InternalAssignmentReceiver()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserID = q.fldUserID,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldAssignmentTypeID = q.fldAssignmentTypeID,
                        fldBoxID = q.fldBoxID,
                        fldLetterReadDate = q.fldLetterReadDate,
                        fldShowTypeT_F = q.fldShowTypeT_F,
                        fldBoxName = q.fldBoxName,
                        fldStatusName = q.fldStatusName,
                        fldTypeAssignment = q.fldTypeAssignment,
                        fldName_Family = q.fldName_Family
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate,bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentReceiverInsert(fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, UserId, Desc, OrganID, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentReceiverUpdate(Id, fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, UserId, Desc, OrganID, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentReceiverDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateInternalAssignmentReceiverBox
        public string UpdateInternalAssignmentReceiverBox(int Id, int fldBoxID, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentReceiverBoxUpdate(Id, fldBoxID, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateInternalAssignmentReceiverStatus
        public string UpdateInternalAssignmentReceiverStatus(int Id, int fldStatusID, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentReceiverStatusUpdate(Id, fldStatusID, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}