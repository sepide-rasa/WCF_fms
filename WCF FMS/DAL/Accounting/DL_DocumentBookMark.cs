using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.BLL;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;
using WCF_FMS.TOL.Archive;


namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentBookMark
    {
        #region Detail
        public OBJ_DocumentBookMark Detail(int id,int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblDocumentBookMarkSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_DocumentBookMark
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocumentRecordeId = q.fldDocumentRecordeId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DocumentBookMark> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentBookMarkSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_DocumentBookMark()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocumentRecordeId = q.fldDocumentRecordeId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentBookMarkInsert(fldDocumentRecordeId, fldArchiveTreeId, UserId, fldOrganId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentBookMarkUpdate(Id, fldDocumentRecordeId, fldArchiveTreeId, UserId, fldOrganId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentBookMarkDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region DocumentRecorde_File_BookMarkInsert
        public string DocumentRecorde_File_BookMarkInsert(int fldDocumentRecordeId, int fldOrganId, int UserId, string IP, string Desc, System.Data.DataTable tblRecorde_File, string fldDocumentRecordeId_Del)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
               //ClsError error = new ClsError();
               //error.ErrorType = false; 
                string Msg = "";
               //var q= 
                p.spr_tblDocumentRecorde_File_BookMarkInsert(fldDocumentRecordeId, fldOrganId, UserId, Desc, IP, tblRecorde_File, fldDocumentRecordeId_Del);//.FirstOrDefault();
               //if (q.ErrorMessage == "")
               //{
                   Msg= "ذخیره با موفقیت انجام شد.";
               //}
               //else
               //{
               //    var Err = new BL().BLErrorMsg("",q.ErrorMessage, UserId);
               //    error.Msg = q.ErrorMessage;
               //    error.ErrorType = true;
               //}
               return Msg;
            }
        }
        #endregion
        #region SelectDocumentRecorde_File_BookMark
        public List<OBJ_DocumentRecorde_File_BookMark> SelectDocumentRecorde_File_BookMark(string FieldName,int DocumentHeaderId,int ArchiveTreeId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentRecorde_File_BookMarkSelect(FieldName, DocumentHeaderId, ArchiveTreeId)
                    .Select(q => new OBJ_DocumentRecorde_File_BookMark()
                    {
                        fldId = q.fldId,
                        fldImage = q.fldImage,
                        fldPasvand = q.fldPasvand,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldIsBookMark = q.fldIsBookMark,
                        fldTitle = q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region SelectBookmarkPath
        public OBJ_ArchiveTree SelectBookmarkPath(int DocumentHeaderId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectBookmarkPath(DocumentHeaderId)
                    .Select(q => new OBJ_ArchiveTree()
                    {
                        fldTitle=q.fldTitle
                    }).FirstOrDefault();
                return test;
            }
        }
        #endregion
    }
}