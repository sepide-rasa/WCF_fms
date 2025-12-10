using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ZirListHa
    {
        #region Detail
        public OBJ_ZirListHa Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblZirListHaSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_ZirListHa
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldMasuolin_DetailId = q.fldMasuolin_DetailId,
                        fldReportId=q.fldReportId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ZirListHa> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblZirListHaSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ZirListHa()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldMasuolin_DetailId = q.fldMasuolin_DetailId,
                        fldReportId = q.fldReportId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldReportId,int fldMasuolin_DetailId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblZirListHaInsert(fldReportId,fldMasuolin_DetailId, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldReportId,int fldMasuolin_DetailId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblZirListHaUpdate(fldId, fldReportId, fldMasuolin_DetailId, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblZirListHaDelete(FieldName, id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}