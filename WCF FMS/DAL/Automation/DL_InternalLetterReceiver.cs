using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_InternalLetterReceiver
    {
        #region Detail
        public OBJ_InternalLetterReceiver Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalLetterReceiverSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_InternalLetterReceiver()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldNameAssignmentStatus = q.fldNameAssignmentStatus
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_InternalLetterReceiver> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalLetterReceiverSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_InternalLetterReceiver()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldNameAssignmentStatus = q.fldNameAssignmentStatus
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalLetterReceiverInsert(fldLetterId, fldMessageId, fldReceiverComisionID, fldAssignmentStatusID, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalLetterReceiverUpdate(Id, fldLetterId, fldMessageId, fldReceiverComisionID, fldAssignmentStatusID, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalLetterReceiverDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}