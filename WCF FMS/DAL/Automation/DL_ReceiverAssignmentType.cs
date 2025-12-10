using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_ReceiverAssignmentType
    {
        #region Detail
        public OBJ_ReceiverAssignmentType Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblReceiverAssignmentTypeSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_ReceiverAssignmentType()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldAssignmentTypeID = q.fldAssignmentTypeID,
                        fldBoxID = q.fldBoxID,
                        fldLetterReadDate = q.fldLetterReadDate,
                        fldShowTypeT_F = q.fldShowTypeT_F,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ReceiverAssignmentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblReceiverAssignmentTypeSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_ReceiverAssignmentType()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldReceiverComisionID = q.fldReceiverComisionID,
                        fldAssignmentStatusID = q.fldAssignmentStatusID,
                        fldAssignmentTypeID = q.fldAssignmentTypeID,
                        fldBoxID = q.fldBoxID,
                        fldLetterReadDate = q.fldLetterReadDate,
                        fldShowTypeT_F = q.fldShowTypeT_F,
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
                p.spr_tblReceiverAssignmentTypeInsert(fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblReceiverAssignmentTypeUpdate(Id, fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblReceiverAssignmentTypeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}