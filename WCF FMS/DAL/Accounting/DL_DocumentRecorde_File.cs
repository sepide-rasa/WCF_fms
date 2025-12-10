using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_DocumentRecorde_File
    {
        #region Detail
        public OBJ_DocumentRecorde_File Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblDocumentRecorde_FileSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_DocumentRecorde_File
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocumentHeaderId = q.fldDocumentHeaderId,
                        fldFileId = q.fldFileId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecorde_File> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblDocumentRecorde_FileSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DocumentRecorde_File()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDocumentHeaderId = q.fldDocumentHeaderId,
                        fldFileId = q.fldFileId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int DocumentHeaderId,byte[] Image,string Pasvand, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecorde_FileInsert(DocumentHeaderId, Image, Pasvand, UserId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        //#region Update
        //public string Update(int Id, int DocumentHeaderId, byte[] Image, string Pasvand, int UserId, string IP, string Desc)
        //{
        //    using (AccountingEntities p = new AccountingEntities())
        //    {
        //        p.spr_tblDocumentRecordeUpdate(Id, DocumentHeaderId, Image, Pasvand, UserId, Desc, IP);
        //        return "ویرایش با موفقیت انجام شد.";
        //    }
        //}
        //#endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblDocumentRecorde_FileDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}