using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DigitalArchive
    {
        /*DL_DigitalArchive DigitalArchive = new DL_DigitalArchive();
        #region Detail
        public OBJ_DigitalArchive Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه بایگانی دیجیتال ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return DigitalArchive.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_DigitalArchive> Select(string FieldName, string FilterValue, int h)
        {
            return DigitalArchive.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int TreeId, byte[] ImageFile, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه پرسنل ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.Insert(PersonalId, TreeId, ImageFile, UserId);
        }
        #endregion
        #region InsertMain
        public string InsertMain(int PersonalId, int TreeId, byte[] ImageFile, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه پرسنل ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.InsertMain(PersonalId, TreeId, ImageFile, UserId);
        }
        #endregion
        #region UpdateForBookMark
        public string UpdateForBookMark(string ImageFile, int TreeId, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.UpdateForBookMark(ImageFile, TreeId, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int ParvandeId, string ImageName, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ImageName == "" || ImageName == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام فایل ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.Delete(ParvandeId, ImageName, UserId);
        }
        #endregion
        #region Rotate
        public string Rotate(int Id, int PersonalId, byte[] ImageFile, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.Rotate(Id, PersonalId, ImageFile, UserId);
        }
        #endregion
        #region Move
        public string Move(int TreeId, string ImageFile, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchive.Move(TreeId, ImageFile, UserId);
        }
        #endregion*/
    }
}