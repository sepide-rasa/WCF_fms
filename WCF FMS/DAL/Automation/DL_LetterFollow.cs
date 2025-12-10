using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterFollow
    {
        #region Detail
        public OBJ_LetterFollow Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterFollowSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterFollow()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldLetterText = q.fldLetterText
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterFollow> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblLetterFollowSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterFollow()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterId = q.fldLetterId,
                        fldLetterText = q.fldLetterText
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId,string fldLetterText, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFollowInsert(fldLetterId, fldLetterText, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, string fldLetterText, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFollowUpdate(Id, fldLetterId, fldLetterText, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFollowDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region DeleteLetterFollowLetterID
        public string DeleteLetterFollowLetterID(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterFollowLetterIDDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}