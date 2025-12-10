using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_MessageAttachment
    {
        DL_MessageAttachment MessageAttachment = new DL_MessageAttachment();

        #region Detail
        public OBJ_MessageAttachment Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MessageAttachment.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_MessageAttachment> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MessageAttachment.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle,int fldMessageId,  byte[] fldImage, string Pasvand, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldMessageId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پیام ضروری است";
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
            else if (fldTitle.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MessageAttachment.Insert(fldTitle,fldMessageId, fldImage, Pasvand, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldTitle, int fldMessageId, int fldFileId, byte[] fldImage, string Pasvand, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldMessageId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پیام ضروری است";
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
            else if (fldTitle.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MessageAttachment.Update(Id, fldTitle, fldMessageId, fldFileId, fldImage, Pasvand, OrganID, UserId, Desc, IP);

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

            return MessageAttachment.Delete(id, userId);
        }
        #endregion
    }
}