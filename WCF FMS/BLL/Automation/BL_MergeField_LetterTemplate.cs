using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_MergeField_LetterTemplate
    {
        DL_MergeField_LetterTemplate MergeField_LetterTemplate = new DL_MergeField_LetterTemplate();

        #region Detail
        public OBJ_MergeField_LetterTemplate Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MergeField_LetterTemplate.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_MergeField_LetterTemplate> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MergeField_LetterTemplate.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldLetterTamplateId, int fldMergeFieldId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldLetterTamplateId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو نامه ضروری است";
            }
            else if (fldMergeFieldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد MergeField ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MergeField_LetterTemplate.Insert(fldLetterTamplateId, fldMergeFieldId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldLetterTamplateId, int fldMergeFieldId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldLetterTamplateId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو نامه ضروری است";
            }
            else if (fldMergeFieldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد MergeField ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MergeField_LetterTemplate.Update(Id, fldLetterTamplateId, fldMergeFieldId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return MergeField_LetterTemplate.Delete(id, userId);
        }
        #endregion
    }
}