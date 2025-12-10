using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_HokmReport
    {
        #region Detail
        public OBJ_HokmReport Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHokmReportSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_HokmReport()
                    {
                        fldAnvaEstekhdamId=q.fldAnvaEstekhdamId,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldFileId=q.fldFileId,
                        fldId=q.fldId,
                        fldName=q.fldName,
                        fldUserId = q.fldUserId,
                        fldAnvaEstekhdamName = q.fldAnvaEstekhdamName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_HokmReport> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHokmReportSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_HokmReport()
                    {
                        fldAnvaEstekhdamId = q.fldAnvaEstekhdamId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFileId = q.fldFileId,
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldUserId = q.fldUserId,
                        fldAnvaEstekhdamName = q.fldAnvaEstekhdamName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, byte[] File, string Pasvand, int AnvaEstekhdamId, int fldUserId, string fldDesc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokmReportInsert(fldName, File, Pasvand, AnvaEstekhdamId, fldUserId, fldDesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName,int FileId, byte[] File, string Pasvand, int AnvaEstekhdamId, string fldDesc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokmReportUpdate(Id, fldName, FileId, File, Pasvand, AnvaEstekhdamId,fldDesc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHokmReportDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}