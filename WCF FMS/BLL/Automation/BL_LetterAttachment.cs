using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterAttachment
    {
        DL_LetterAttachment AssignmentType = new DL_LetterAttachment();

        #region Detail
        public OBJ_LetterAttachment Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AssignmentType.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterAttachment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return AssignmentType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, string fldName, string fldNameFile, byte[] file, string fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AssignmentType.Insert(fldLetterId, fldName, fldNameFile,file,fldType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, string fldName, int fldContentFileId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            else if (fldContentFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد متن نامه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AssignmentType.Update(Id, fldLetterId, fldName, fldContentFileId, OrganID, UserId, Desc, IP);

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

            return AssignmentType.Delete(id, userId);
        }
        #endregion
        #region DeleteLetterAttachmentLetterID
        public string DeleteLetterAttachmentLetterID(long id, int userId, out ClsError error)
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

            return AssignmentType.DeleteLetterAttachmentLetterID(id, userId);
        }
        #endregion
    }
}