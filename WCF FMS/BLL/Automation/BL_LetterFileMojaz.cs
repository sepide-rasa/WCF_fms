using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterFileMojaz
    {
        DL_LetterFileMojaz LetterFileMojaz = new DL_LetterFileMojaz();

        #region Detail
        public OBJ_LetterFileMojaz Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterFileMojaz.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterFileMojaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterFileMojaz.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldFormatFileId, byte fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldFormatFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فرمت فایل ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return LetterFileMojaz.Insert(fldFormatFileId,fldType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, byte fldFormatFileId, byte fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldFormatFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فرمت فایل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterFileMojaz.Update(Id, fldFormatFileId,fldType, OrganID, UserId, Desc, IP);

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

            return LetterFileMojaz.Delete(id, userId);
        }
        #endregion
    }
}