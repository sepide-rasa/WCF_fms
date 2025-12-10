using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_ExternalLetterSender
    {
        #region Detail
        public OBJ_ExternalLetterSender Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblExternalLetterSenderSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_ExternalLetterSender()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldShakhsHoghoghiTitlesId = q.fldShakhsHoghoghiTitlesId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ExternalLetterSender> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblExternalLetterSenderSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_ExternalLetterSender()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldMessageId = q.fldMessageId,
                        fldShakhsHoghoghiTitlesId = q.fldShakhsHoghoghiTitlesId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblExternalLetterSenderInsert(fldLetterId, fldMessageId, fldAshkhasHoghoghiId, OrganID, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblExternalLetterSenderUpdate(Id, fldLetterId, fldMessageId, fldAshkhasHoghoghiId, OrganID, UserId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblExternalLetterSenderDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}