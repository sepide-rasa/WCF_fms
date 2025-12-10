using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_InternalAssignmentSender
    {
        #region Detail
        public OBJ_InternalAssignmentSender Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalAssignmentSenderSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_InternalAssignmentSender()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldSenderComisionID = q.fldSenderComisionID,
                        fldBoxID = q.fldBoxID,
                        fldName_Family = q.fldName_Family,
                        fldNameBox = q.fldNameBox
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_InternalAssignmentSender> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblInternalAssignmentSenderSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_InternalAssignmentSender()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldAssignmentID = q.fldAssignmentID,
                        fldSenderComisionID = q.fldSenderComisionID,
                        fldBoxID = q.fldBoxID,
                        fldName_Family = q.fldName_Family,
                        fldNameBox = q.fldNameBox
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldAssignmentID, int fldSenderComisionID, int fldBoxID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentSenderInsert(fldAssignmentID, fldSenderComisionID,fldBoxID, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldSenderComisionID, int fldBoxID, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentSenderUpdate(Id, fldAssignmentID, fldSenderComisionID, fldBoxID, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentSenderDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateInternalAssignmentSenderBox
        public string UpdateInternalAssignmentSenderBox(int Id, int fldBoxID, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblInternalAssignmentSenderBoxUpdate(Id, fldBoxID, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}