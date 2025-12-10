using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Assignment
    {
        DL_Assignment Assignment = new DL_Assignment();

        #region Detail
        public OBJ_Assignment Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Assignment.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Assignment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Assignment.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            
            else if (fldAnswerDate == "" || fldAnswerDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پاسخ ضروری است";
            }
            else if (!r.IsMatch(fldAnswerDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ پاسخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return 0;

            return Assignment.Insert(fldLetterID, fldMessageId, fldAnswerDate, fldSourceAssId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterID, int? fldMessageId, string fldAnswerDate, int? fldSourceAssId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldAnswerDate == "" || fldAnswerDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پاسخ ضروری است";
            }
            else if (!r.IsMatch(fldAnswerDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ پاسخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Assignment.Update(Id, fldLetterID, fldMessageId, fldAnswerDate, fldSourceAssId, OrganID, UserId, Desc, IP);

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

            return Assignment.Delete(id, userId);
        }
        #endregion
        #region DeleteAssignmentLetterID
        public string DeleteAssignmentLetterID(long id, int userId, out ClsError error)
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

            return Assignment.DeleteAssignmentLetterID(id, userId);
        }
        #endregion
    }
}