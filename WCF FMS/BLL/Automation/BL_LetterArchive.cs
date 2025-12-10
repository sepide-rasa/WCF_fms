using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterArchive
    {
        DL_LetterArchive LetterArchive = new DL_LetterArchive();

        #region Detail
        public OBJ_LetterArchive Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterArchive.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterArchive> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterArchive.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int fldMessageId, int fldArchiveId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldArchiveId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بایگانی ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return LetterArchive.Insert(fldLetterId, fldMessageId, fldArchiveId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int fldMessageId, int fldArchiveId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldArchiveId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بایگانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterArchive.Update(Id, fldLetterId, fldMessageId, fldArchiveId, OrganID, UserId, Desc, IP);

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

            return LetterArchive.Delete(id, userId);
        }
        #endregion
        #region DeleteLetterArchiveLetterID
        public string DeleteLetterArchiveLetterID(long id, int userId, out ClsError error)
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

            return LetterArchive.DeleteLetterArchiveLetterID(id, userId);
        }
        #endregion
    }
}