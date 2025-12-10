using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_MergeField_LetterTemplate
    {
        #region Detail
        public OBJ_MergeField_LetterTemplate Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMergeField_LetterTemplateSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_MergeField_LetterTemplate()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterTamplateId = q.fldLetterTamplateId,
                        fldMergeFieldId = q.fldMergeFieldId,
                        fldEnName = q.fldEnName,
                        fldFaName = q.fldFaName,
                        fldTitleLetter = q.fldTitleLetter
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MergeField_LetterTemplate> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblMergeField_LetterTemplateSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_MergeField_LetterTemplate()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldLetterTamplateId = q.fldLetterTamplateId,
                        fldMergeFieldId = q.fldMergeFieldId,
                        fldEnName = q.fldEnName,
                        fldFaName = q.fldFaName,
                        fldTitleLetter = q.fldTitleLetter
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldLetterTamplateId, int fldMergeFieldId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMergeField_LetterTemplateInsert(fldLetterTamplateId, fldMergeFieldId, UserId, OrganID, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldLetterTamplateId, int fldMergeFieldId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMergeField_LetterTemplateUpdate(Id, fldLetterTamplateId, fldMergeFieldId, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblMergeField_LetterTemplateDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}