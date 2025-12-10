using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Archive;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.BLL.Archive
{
    public class BL_FileMojaz
    {
        DL_FileMojaz FileMojaz = new DL_FileMojaz();

        #region Detail
        public OBJ_FileMojaz Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return FileMojaz.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_FileMojaz> Select(string FieldName, string FilterValue, int h)
        {
            return FileMojaz.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ArchiveTreeId, int FormatFileId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            else if (FormatFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فرمت فایل ضروری است";
            }
            else if (FileMojaz.CheckRepeatedRow(ArchiveTreeId, FormatFileId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return FileMojaz.Insert(ArchiveTreeId, FormatFileId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ArchiveTreeId, int FormatFileId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (ArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            else if (FormatFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فرمت فایل ضروری است";
            }
            else if (FileMojaz.CheckRepeatedRow(ArchiveTreeId, FormatFileId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return FileMojaz.Update(Id, ArchiveTreeId, FormatFileId, userId, Desc);

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

            return FileMojaz.Delete(id, userId);
        }
        #endregion
    }
}