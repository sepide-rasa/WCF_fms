using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterTemplate
    {
        #region Detail
        public OBJ_LetterTemplate Detail(int Id, int OrganId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblletterTemplateSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_LetterTemplate()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldIsBackGround = q.fldIsBackGround,
                        fldFileId = q.fldFileId,
                        fldBackGroundName = q.fldBackGroundName,
                        fldNameMergeField = q.fldNameMergeField,
                        fldIdMergeField = q.fldIdMergeField,
                        fldFormat = q.fldFormat,
                        fldEnNameMergeField = q.fldEnNameMergeField,
                        fldLetterFileId=q.fldLetterFileId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterTemplate> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                var k = p.spr_tblletterTemplateSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_LetterTemplate()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldName = q.fldName,
                        fldIsBackGround = q.fldIsBackGround,
                        fldFileId = q.fldFileId,
                        fldBackGroundName = q.fldBackGroundName,
                        fldNameMergeField = q.fldNameMergeField,
                        fldIdMergeField = q.fldIdMergeField,
                        fldFormat = q.fldFormat,
                        fldEnNameMergeField = q.fldEnNameMergeField,
                        fldLetterFileId=q.fldLetterFileId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, bool fldIsBackGround, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile, string LetterPasvand, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblletterTemplateInsert(fldName, fldIsBackGround, fldImage, fldPasvand, fldMergeFieldId, UserId, OrganID, Desc, LetterFile,LetterPasvand, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, bool fldIsBackGround, int? fldFileId, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile,string LetterPasvand,int? LetterFileId, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblletterTemplateUpdate(Id, fldName, fldIsBackGround, fldFileId, fldImage, fldPasvand,fldMergeFieldId,LetterFile,LetterPasvand,LetterFileId, UserId, OrganID, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblletterTemplateDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AutomationEntities p = new AutomationEntities())
            {
                var L = p.spr_tblMergeField_LetterTemplateSelect("CheckLetterTamplateId", Id.ToString(), 0, 0).FirstOrDefault();
                if (L != null)
                    q = true;
            }
            return q;
        }
        #endregion

        #region UpdateFormat
        public string UpdateFormat(int Id, string fldFormat, int UserId, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                p.spr_tblLetterTemplateUpdateFormat(Id, fldFormat, UserId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}