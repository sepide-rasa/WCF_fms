using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;
namespace WCF_FMS.DAL.Automation
{
    public class DL_Substitute
    {
        #region Detail
        public OBJ_Substitute Detail(int id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblSubstituteSelect("fldId", id.ToString(),OrganId, 1)
                .Select(q => new OBJ_Substitute
                {
                    fldID = q.fldID,
                    fldSenderComisionID = q.fldSenderComisionID,
                    fldReceiverComisionID = q.fldReceiverComisionID,
                    fldStartDate = q.fldStartDate,
                    fldEndDate = q.fldEndDate,
                    fldStartTime = q.fldStartTime,
                    fldEndTime = q.fldEndTime,
                    fldIsSigner = q.fldIsSigner,
                    fldShowReceiverName = q.fldShowReceiverName,
                    fldDate = q.fldDate,
                    fldUserID = q.fldUserID,
                    fldDesc = q.fldDesc,
                    fldIP = q.fldIP,
                    fldOrganId = q.fldOrganId,
                    fldReciverComisionName = q.fldReciverComisionName,
                    fldSenderComisionName = q.fldSenderComisionName,
                    fldStartTime_S = q.fldStartTime_S,
                    fldEndTime_S = q.fldEndTime_S
                }).FirstOrDefault();
                return k;
            }
        }
        #endregion;
        #region Select
        public List<OBJ_Substitute> Select(string fieldname, string Value, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var test = p.spr_tblSubstituteSelect(fieldname, Value, OrganId, h)
                .Select(q => new OBJ_Substitute()
               {
                   fldID = q.fldID,
                   fldSenderComisionID = q.fldSenderComisionID,
                   fldReceiverComisionID = q.fldReceiverComisionID,
                   fldStartDate = q.fldStartDate,
                   fldEndDate = q.fldEndDate,
                   fldStartTime = q.fldStartTime,
                   fldEndTime = q.fldEndTime,
                   fldIsSigner = q.fldIsSigner,
                   fldShowReceiverName = q.fldShowReceiverName,
                   fldDate = q.fldDate,
                   fldUserID = q.fldUserID,
                   fldDesc = q.fldDesc,
                   fldIP = q.fldIP,
                   fldOrganId = q.fldOrganId,
                   fldReciverComisionName = q.fldReciverComisionName,
                   fldSenderComisionName = q.fldSenderComisionName,
                   fldStartTime_S = q.fldStartTime_S,
                   fldEndTime_S = q.fldEndTime_S
               }).ToList();
                return test;
            }
        }
        #endregion;
        #region Insert
        public string Insert(int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, int fldUserID, string fldDesc, string fldIP, int fldOrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                
                p.spr_tblSubstituteInsert(fldSenderComisionID, fldReceiverComisionID, fldStartDate, fldEndDate, TimeSpan.Parse(fldStartTime), TimeSpan.Parse(fldEndTime), fldIsSigner, fldShowReceiverName, fldUserID, fldDesc, fldIP, fldOrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion;
        #region Update
        public string Update(int fldID, int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, int fldUserID, string fldDesc, string fldIP, int fldOrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblSubstituteUpdate(fldID, fldSenderComisionID, fldReceiverComisionID, fldStartDate, fldEndDate, TimeSpan.Parse(fldStartTime), TimeSpan.Parse(fldEndTime), fldIsSigner, fldShowReceiverName, fldUserID, fldDesc, fldIP, fldOrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion;
        #region Delete
        public string Delete(int fldID, int fldUserID)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblSubstituteDelete(fldID, fldUserID);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion;
    }
}