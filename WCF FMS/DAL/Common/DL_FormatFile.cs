using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_FormatFile
    {
        #region Detail
        public OBJ_FormatFile Detail(int Id,int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblFormatFileSelect("fldId", Id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_FormatFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFormatName = q.fldFormatName,
                        fldIcon = q.fldIcon,
                        fldPassvand = q.fldPassvand,
                        fldSize = q.fldSize
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_FormatFile> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblFormatFileSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_FormatFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFormatName = q.fldFormatName,
                        fldIcon = q.fldIcon,
                        fldPassvand = q.fldPassvand,
                        fldSize = q.fldSize
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string FormatName, byte[] Icon, string Passvand, int fldSize, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblFormatFileInsert(FormatName, Passvand, Icon, fldSize,OrganId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, string FormatName, byte[] Icon, string Passvand, int fldSize, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblFormatFileUpdate(Id, FormatName, Passvand, Icon, fldSize,OrganId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblFormatFileDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (ArchiveEntities m = new ArchiveEntities())
            {
                var FileM = m.spr_tblFileMojazSelect("fldFormatFileId", Id.ToString(), 0).FirstOrDefault();
                if (FileM != null)
                    q = true;
            }
            return q;
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string FormatName, string Passvand, int OrganId, int Id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    var format = p.spr_tblFormatFileSelect("fldFormatName", FormatName,OrganId, 0).FirstOrDefault();
                    if (format != null)
                        q = true;

                    var format1 = p.spr_tblFormatFileSelect("fldPassvand", Passvand,OrganId, 0).FirstOrDefault();
                    if (format1 != null)
                        q = true;

                }
                else
                {
                    var query = p.spr_tblFormatFileSelect("fldFormatName", FormatName,OrganId, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }

                    var query1 = p.spr_tblFormatFileSelect("fldPassvand", Passvand,OrganId, 0).FirstOrDefault();
                    if (query1 != null && query1.fldId != Id)
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