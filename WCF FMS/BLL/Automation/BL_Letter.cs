using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Letter
    {
        DL_Letter Letter = new DL_Letter();

        #region Detail
        public OBJ_Letter Detail(long id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Letter.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Letter> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Letter.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public ClsError Insert(int fldYear, string fldSubject, string fldLetterNumber, string fldLetterDate, string fldKeywords, int fldLetterStatusID
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, int OrganID, int UserId, string Desc, string IP)
        {
            ClsError Message = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            Message.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "کد کاربر ضروری است";
            }
            else if (fldYear == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "سال ضروری است";
            }
            else if (fldSubject == "" || fldSubject == null)
            {
                Message.ErrorType = true;
                Message.Msg = "موضوع نامه ضروری است";
            }
            else if (fldSubject.Length < 2)
            {
                Message.ErrorType = true;
                Message.Msg = "تعداد کاراکتر موضوع نامه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldSubject.Length > 300)
            {
                Message.ErrorType = true;
                Message.Msg = "تعداد کاراکتر موضوع وارده شده بیشتر از حد مجاز می باشد.";
            }
            //else if (fldLetterNumber == "" || fldLetterNumber == null)
            //{
            //    Message.ErrorType = true;
            //    Message.Msg = "شماره نامه ضروری است";
            //}
            //else if (fldLetterNumber.Length > 50)
            //{
            //    Message.ErrorType = true;
            //    Message.Msg = "تعداد کاراکتر شماره وارده شده بیشتر از حد مجاز می باشد.";
            //}
            
            else if (fldImmediacyID == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "کد فوریت ضروری است";
            }
            else if (fldComisionID == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "کد حکم ضروری است";
            }
            else if (fldSecurityTypeID == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "کد نوع محرمانه ضروری است";
            }
            else if (fldLetterTypeID == 0)
            {
                Message.ErrorType = true;
                Message.Msg = "کد نوع نامه ضروری است";
            }
            if (Message.ErrorType == true)
            {
                Message.ErrorMsg = "خطا";
                return Message;
            }

            return Letter.Insert(fldYear, fldSubject, fldLetterNumber, fldLetterDate, fldKeywords, fldLetterStatusID, fldComisionID,
                   fldImmediacyID, fldSecurityTypeID, fldLetterTypeID, fldSignType, MatnLetter, LetterTempId,fldFont, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(long Id, string fldSubject, string fldLetterNumber, string fldLetterDate, string fldKeywords
            , int fldComisionID, int fldImmediacyID, int fldSecurityTypeID, int fldLetterTypeID, byte fldSignType, string MatnLetter, int? LetterTempId,string fldFont, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
          
            else if (fldSubject == "" || fldSubject == null)
            {
                error.ErrorType = true;
                error.Msg = "موضوع نامه ضروری است";
            }
            else if (fldSubject.Length < 2)
            {
                error.ErrorType = true;
                error.Msg = "تعداد کاراکتر موضوع نامه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldSubject.Length > 300)
            {
                error.ErrorType = true;
                error.Msg = "تعداد کاراکتر موضوع وارده شده بیشتر از حد مجاز می باشد.";
            }
            //else if (fldLetterNumber == "" || fldLetterNumber == null)
            //{
            //    error.ErrorType = true;
            //    error.Msg = "شماره نامه ضروری است";
            //}
            //else if (fldLetterNumber.Length > 50)
            //{
            //    error.ErrorType = true;
            //    error.Msg = "تعداد کاراکتر شماره وارده شده بیشتر از حد مجاز می باشد.";
            //}
            else if (fldImmediacyID == 0)
            {
                error.ErrorType = true;
                error.Msg = "کد فوریت ضروری است";
            }
            else if (fldComisionID == 0)
            {
                error.ErrorType = true;
                error.Msg = "کد دبیرخانه ضروری است";
            }
            else if (fldSecurityTypeID == 0)
            {
                error.ErrorType = true;
                error.Msg = "کد نوع محرمانه ضروری است";
            }
            else if (fldLetterTypeID == 0)
            {
                error.ErrorType = true;
                error.Msg = "کد نوع نامه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Letter.Update(Id,  fldSubject, fldLetterNumber, fldLetterDate, fldKeywords, fldComisionID,
                   fldImmediacyID, fldSecurityTypeID, fldLetterTypeID, fldSignType, MatnLetter, LetterTempId, fldFont,OrganID, UserId, Desc, IP);

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

            return Letter.Delete(id, userId);
        }
        #endregion

        #region UpdateLetterNumDate
        public string UpdateLetterNumDate(long Id, string fldLetterNumber, int OrganID, int UserId , out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldLetterNumber == "" || fldLetterNumber == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره نامه ضروری است";
            }
            else if (fldLetterNumber.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره نامه وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Letter.UpdateLetterNumDate(Id, fldLetterNumber, OrganID, UserId);

        }
        #endregion
        #region UpdateLetterStatusId
        public string UpdateLetterStatusId(long LetterId, int fldLetterStatusID,int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (fldLetterStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت نامه ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return Letter.UpdateLetterStatusId(LetterId, fldLetterStatusID, UserId);

        }
        #endregion

        #region SelectInbox
        public List<OBJ_Inbox> SelectInbox(string FieldName, string Start, string End, int BoxId,int TabaghebandiId, int OrganId, string Value,int h)
         {
             return Letter.SelectInbox(FieldName, Start, End, BoxId,TabaghebandiId, OrganId,Value,h);
        }
        #endregion
        #region SelectSavedLetter
        public List<OBJ_SavedLetter> SelectSavedLetter(string FieldName, string Start, string End, string BoxId,int TabaghebandiId, string value, int OrganId, int h)
         {
             return Letter.SelectSavedLetter(FieldName, Start, End, BoxId, TabaghebandiId,value, OrganId, h);
        }
        #endregion

        #region SelectSent
        public List<OBJ_Sent> SelectSent(string FieldName, string Start, string End, int BoxId,int TabaghebandiId, string Value, int OrganId, int h)
        {
            return Letter.SelectSent(FieldName, Start, End, BoxId, TabaghebandiId,Value, OrganId, h);
        }
        #endregion

        #region SelectTrash
        public List<OBJ_Trash> SelectTrash(string FieldName, string Start, string End, int BoxId,int TabaghebandiId, string Value, int OrganId, int h)
        {
            return Letter.SelectTrash(FieldName, Start, End, BoxId, TabaghebandiId,Value, OrganId, h);
        }
        #endregion
    }
}