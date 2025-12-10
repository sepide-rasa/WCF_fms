using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_HistoryLetter
    {
        DL_HistoryLetter HistoryLetter = new DL_HistoryLetter();

        #region Detail
        public OBJ_HistoryLetter Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return HistoryLetter.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_HistoryLetter> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return HistoryLetter.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldCurrentLetter_Id, int fldHistoryType_Id, long fldHistoryLetter_Id, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldCurrentLetter_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه اصلی ضروری است";
            }
            else if (fldHistoryType_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع سابقه ضروری است";
            }
            else if (fldHistoryLetter_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه سوابق ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return HistoryLetter.Insert(fldCurrentLetter_Id, fldHistoryType_Id, fldHistoryLetter_Id, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long fldCurrentLetter_Id, int fldHistoryType_Id, long fldHistoryLetter_Id, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldCurrentLetter_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه اصلی ضروری است";
            }
            else if (fldHistoryType_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع سابقه ضروری است";
            }
            else if (fldHistoryLetter_Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه سوابق ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return HistoryLetter.Update(Id, fldCurrentLetter_Id, fldHistoryType_Id, fldHistoryLetter_Id, OrganID, UserId, Desc, IP);

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

            return HistoryLetter.Delete(id, userId);
        }
        #endregion
    }
}