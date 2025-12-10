using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterBox
    {
        DL_LetterBox LetterBox = new DL_LetterBox();

        #region Detail
        public OBJ_LetterBox Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterBox.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterBox> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterBox.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldBoxId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldBoxId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = " کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterBox.Insert(fldBoxId, fldLetterId, fldMessageId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldBoxId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldBoxId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = " کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterBox.Update(Id, fldBoxId, fldLetterId,fldMessageId, OrganID, UserId, Desc, IP);

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

            return LetterBox.Delete(id, userId);
        }
        #endregion
        #region DeleteLetterBoxLetterID
        public string DeleteLetterBoxLetterID(string FieldName,long id, int userId, out ClsError error)
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

            return LetterBox.DeleteLetterBoxLetterID(FieldName, id, userId);
        }
        #endregion
    }
}