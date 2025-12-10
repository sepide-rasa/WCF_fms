using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterBox
    {
        #region Detail
        public OBJ_LetterBox Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterBoxSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterBox()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldBoxId = q.fldBoxId,
                        fldLetterId = q.fldLetterId,
                        fldBoxName = q.fldBoxName,
                        fldMessageId = q.fldMessageId,
                        fldTitleMessage = q.fldTitleMessage
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterBox> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterBoxSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterBox()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldBoxId = q.fldBoxId,
                        fldLetterId = q.fldLetterId,
                        fldBoxName = q.fldBoxName,
                        fldMessageId = q.fldMessageId,
                        fldTitleMessage = q.fldTitleMessage
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldBoxId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterBoxInsert(fldBoxId, fldLetterId, fldMessageId, UserId, OrganID, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldBoxId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterBoxUpdate(Id, fldBoxId, fldLetterId,fldMessageId, UserId, OrganID, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterBoxDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region DeleteLetterBoxLetterID
        public string DeleteLetterBoxLetterID(string FieldName, long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterBoxLetterIDDelete(FieldName, Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}