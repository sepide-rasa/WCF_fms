using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_ContentFile
    {
        #region Detail
        public OBJ_ContentFile Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblContentFileSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_ContentFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldLetterText = q.fldLetterText,
                        fldLetterId = q.fldLetterId,
                        fldType = q.fldType
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ContentFile> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblContentFileSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_ContentFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldLetterText = q.fldLetterText,
                        fldLetterId = q.fldLetterId,
                        fldType = q.fldType
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, byte[] fldLetterText, long fldLetterId, string fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblContentFileInsert(fldName, fldLetterText, fldLetterId, UserId, OrganID, Desc, fldType, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, byte[] fldLetterText,long fldLetterId, string fldType, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblContentFileUpdate(Id, fldName, fldLetterText, fldLetterId, UserId, OrganID, Desc,fldType, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(long Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblContentFileDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}