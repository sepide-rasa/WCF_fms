using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_ContentFile
    {
        DL_ContentFile ContentFile = new DL_ContentFile();

        #region Detail
        public OBJ_ContentFile Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ContentFile.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ContentFile> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return ContentFile.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, byte[] fldLetterText, long fldLetterId, string fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            //else if (fldName == "" || fldName == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "نام ضروری است";
            //}
            //else if (fldName.Length < 2)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            //}
            //else if (fldName.Length > 300)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            //}
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            else if (fldType == "" || fldType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فایل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ContentFile.Insert(fldName, fldLetterText, fldLetterId, fldType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, byte[] fldLetterText, long fldLetterId, string fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            //else if (fldName == "" || fldName == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "نام ضروری است";
            //}
            //else if (fldName.Length < 2)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            //}
            //else if (fldName.Length > 300)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            //}
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            else if (fldType == "" || fldType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فایل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ContentFile.Update(Id, fldName, fldLetterText, fldLetterId,fldType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(long id, int userId, out ClsError error)
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

            return ContentFile.Delete(id, userId);
        }
        #endregion
    }
}