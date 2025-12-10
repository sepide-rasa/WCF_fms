using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Archive;
using WCF_FMS.TOL.Accounting;


namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentBookMark
    {
        DL_DocumentBookMark DocumentBookMark = new DL_DocumentBookMark();

        #region Detail
        public OBJ_DocumentBookMark Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DocumentBookMark.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_DocumentBookMark> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return DocumentBookMark.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (fldDocumentRecordeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
            else if (fldArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بایگانی دیجیتال ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentBookMark.Insert(fldDocumentRecordeId, fldArchiveTreeId, fldOrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرح سند جهت ویرایش ضروری است";
            }
            else if (fldDocumentRecordeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
            else if (fldArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بایگانی دیجیتال ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentBookMark.Update(Id, fldDocumentRecordeId, fldArchiveTreeId, fldOrganId, UserId, IP, Desc);

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
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentBookMark.Delete(id, userId);
        }
        #endregion

        #region DocumentRecorde_File_BookMarkInsert
        public string DocumentRecorde_File_BookMarkInsert(int fldDocumentRecordeId, int fldOrganId, int UserId, string IP, string Desc, System.Data.DataTable tblRecorde_File, string fldDocumentRecordeId_Del, out ClsError error)
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
            else if (fldDocumentRecordeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentBookMark.DocumentRecorde_File_BookMarkInsert(fldDocumentRecordeId, fldOrganId, UserId, IP, Desc, tblRecorde_File, fldDocumentRecordeId_Del);

        }
        #endregion
        #region SelectDocumentRecorde_File_BookMark
        public List<OBJ_DocumentRecorde_File_BookMark> SelectDocumentRecorde_File_BookMark(string FieldName, int DocumentHeaderId, int ArchiveTreeId)
        {
            return DocumentBookMark.SelectDocumentRecorde_File_BookMark(FieldName, DocumentHeaderId, ArchiveTreeId);
        }
        #endregion
        #region SelectBookmarkPath

        public OBJ_ArchiveTree SelectBookmarkPath(int DocumentHeaderId)
        {
            return DocumentBookMark.SelectBookmarkPath(DocumentHeaderId);
        }
        #endregion
    }
}