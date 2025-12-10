using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.DAL.Archive
{
    public class DL_FileMojaz
    {
        #region Detail
        public OBJ_FileMojaz Detail(int Id)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblFileMojazSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_FileMojaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldFormatFileId = q.fldFormatFileId,
                        fldFormatName = q.fldFormatName,
                        fldPassvand = q.fldPassvand,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_FileMojaz> Select(string FieldName, string FilterValue, int h)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                var k = p.spr_tblFileMojazSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_FileMojaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldArchiveTreeId = q.fldArchiveTreeId,
                        fldFormatFileId = q.fldFormatFileId,
                        fldFormatName = q.fldFormatName,
                        fldPassvand = q.fldPassvand,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ArchiveTreeId, int FormatFileId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblFileMojazInsert(ArchiveTreeId, FormatFileId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ArchiveTreeId, int FormatFileId, int UserId, string Desc)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblFileMojazUpdate(Id, ArchiveTreeId, FormatFileId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ArchiveEntities p = new ArchiveEntities())
            {
                p.spr_tblFileMojazDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ArchiveTreeId, int FormatFileId, int Id)
        {
            bool q = false;
            using (ArchiveEntities p = new ArchiveEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblFileMojazSelect("fldArchiveTreeId", ArchiveTreeId.ToString(), 0).Where(l => l.fldFormatFileId == FormatFileId).Any();

                }
                else
                {
                    var query = p.spr_tblFileMojazSelect("fldArchiveTreeId", ArchiveTreeId.ToString(), 0).Where(l => l.fldFormatFileId == FormatFileId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}