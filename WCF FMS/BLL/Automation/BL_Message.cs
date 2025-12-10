using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Message
    {
        DL_Message Message = new DL_Message();

        #region Detail
        public OBJ_Message Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Message.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Message> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Message.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(int fldCommisionId, string fldTitle, string fldMatn, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldCommisionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (fldTitle == "" || fldTitle == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldMatn == "" || fldMatn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن ضروری است";
            }
            else if (fldMatn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن وارد شده کمتر از حد مجاز میباشد.";
            }
            if (error.ErrorType == true)
                return 0;

            return Message.Insert(fldCommisionId,fldTitle,fldMatn, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldCommisionId, string fldTitle, string fldMatn, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldCommisionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (fldTitle == "" || fldTitle == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldMatn == "" || fldMatn == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن ضروری است";
            }
            else if (fldMatn.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن وارد شده کمتر از حد مجاز میباشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Message.Update(Id, fldCommisionId, fldTitle, fldMatn, OrganID, UserId, Desc, IP);

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

            return Message.Delete(id, userId);
        }
        #endregion
        #region SelectSavedMessage
        public List<OBJ_SavedMessage> SelectSavedMessage(string FieldName, string Start, string End, string BoxId,int TabaghebandiId, string Value, int OrganId,int h)
        {
            return Message.SelectSavedMessage(FieldName, Start, End, BoxId,TabaghebandiId, Value, OrganId,h);
        }
        #endregion
    }
}