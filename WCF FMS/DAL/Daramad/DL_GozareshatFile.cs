using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_GozareshatFile
    {
        #region Detail
        public OBJ_GozareshatFile Detail(int Id,string OrganId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblGozareshatFileSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_GozareshatFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldGozareshatId = q.fldGozareshatId,
                        fldOrganId = q.fldOrganId,
                        fldOrganName = q.fldOrganName,
                        fldReportFileId = q.fldReportFileId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GozareshatFile> Select(string FieldName, string FilterValue, string OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblGozareshatFileSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_GozareshatFile()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldGozareshatId = q.fldGozareshatId,
                        fldOrganId = q.fldOrganId,
                        fldOrganName = q.fldOrganName,
                        fldReportFileId = q.fldReportFileId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int GozareshatId, int OrganId, byte[] file, string passvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblGozareshatFileInsert(GozareshatId, OrganId, file, passvand, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int GozareshatId, int OrganId,int ReportFileId, byte[] file, string passvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblGozareshatFileUpdate(Id, GozareshatId, OrganId, ReportFileId, file, passvand, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblGozareshatFileDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region SelectGozareshat
        public List<OBJ_GozareshatFile> SelectGozareshat(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblGozareshatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_GozareshatFile()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}