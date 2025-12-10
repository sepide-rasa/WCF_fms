using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_LetterSigners
    {
        DL_LetterSigners lettersigners = new DL_LetterSigners();
        #region Detail
        public OBJ_LetterSigners Detail(int Id, out ClsError error)
        {
            error = new ClsError();
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return lettersigners.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_LetterSigners> Select(string fieldname, string value, int h)
        {
            return lettersigners.Select(fieldname, value, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldLetMiId, int fldOrgPosId, int fldUserId, string flddesc,out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (flddesc == null)
                flddesc = "";
            if (fldLetMiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو نامه ضروری است.";
            }
            else if (fldOrgPosId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return lettersigners.Insert(fldLetMiId, fldOrgPosId, fldUserId, flddesc);
        }
        #endregion
        #region Update
        public string Update(int fldId,int fldLetMiId, int fldOrgPosId, int fldUserId, string flddesc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (flddesc == null)
                flddesc = "";
            if (fldId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (fldLetMiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو نامه ضروری است.";
            }
            else if (fldOrgPosId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return lettersigners.Update(fldId,fldLetMiId, fldOrgPosId, fldUserId, flddesc);
        }
        #endregion
        #region Delete
        public string Delete(int fldLetterMinutId, int fldUserID, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldUserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldLetterMinutId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگوی نامه ضروری است";
            }
            // else if (lettersigners.CheckDelete(fldID))
            // {
            //  error.ErrorType = true;
            // error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            // }
            if (error.ErrorType == true)
                return "خطا";

            return lettersigners.Delete(fldLetterMinutId, fldUserID);
        }
        #endregion
    }
}