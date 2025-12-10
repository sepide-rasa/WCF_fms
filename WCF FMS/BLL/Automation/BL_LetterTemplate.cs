using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterTemplate
    {
        DL_LetterTemplate LetterTemplate = new DL_LetterTemplate();

        #region Detail
        public OBJ_LetterTemplate Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterTemplate.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterTemplate> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterTemplate.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, bool fldIsBackGround, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile, string LetterPasvand, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldMergeFieldId == "" || fldMergeFieldId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد MergeField ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterTemplate.Insert(fldName, fldIsBackGround,fldImage,fldPasvand,fldMergeFieldId,LetterFile,LetterPasvand, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, bool fldIsBackGround, int? fldFileId, byte[] fldImage, string fldPasvand, string fldMergeFieldId, byte[] LetterFile, string LetterPasvand, int? LetterFileId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldMergeFieldId == "" || fldMergeFieldId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد MergeField ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterTemplate.Update(Id, fldName, fldIsBackGround, fldFileId, fldImage, fldPasvand, fldMergeFieldId, LetterFile, LetterPasvand, LetterFileId, OrganID, UserId, Desc, IP);

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
            //else if (LetterTemplate.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم در جای دیگر استفاده شده لذا مجاز به حذف نمی باشید.";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return LetterTemplate.Delete(id, userId);
        }
        #endregion
        #region UpdateFormat
        public string UpdateFormat(int Id, string fldFormat, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return LetterTemplate.UpdateFormat(Id, fldFormat, UserId, IP);

        }
        #endregion
    }
}