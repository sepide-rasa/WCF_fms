using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterFollow
    {
        DL_LetterFollow LetterFollow = new DL_LetterFollow();

        #region Detail
        public OBJ_LetterFollow Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterFollow.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterFollow> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterFollow.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, string fldLetterText, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            else if (fldLetterText == "" || fldLetterText == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان نامه ضروری است";
            }
            else if (fldLetterText.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان نامه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldLetterText.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان نامه وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterFollow.Insert(fldLetterId, fldLetterText, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, string fldLetterText, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            else if (fldLetterText == "" || fldLetterText == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان نامه ضروری است";
            }
            else if (fldLetterText.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان نامه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldLetterText.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان نامه وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterFollow.Update(Id, fldLetterId, fldLetterText, OrganID, UserId, Desc, IP);

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

            return LetterFollow.Delete(id, userId);
        }
        #endregion
        #region DeleteLetterFollowLetterID
        public string DeleteLetterFollowLetterID(long id, int userId, out ClsError error)
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

            return LetterFollow.DeleteLetterFollowLetterID(id, userId);
        }
        #endregion
    }
}