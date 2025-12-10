using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_WebServiceLog
    {
        #region Detail
        public OBJ_WebServiceLog Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblWebServiceLogSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_WebServiceLog
                    {
                        fldId = q.fldId,
                        flddate = q.flddate,
                        fldMatn = q.fldMatn,
                        fldUser = q.fldUser,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_WebServiceLog> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblWebServiceLogSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_WebServiceLog()
                    {
                        fldId = q.fldId,
                        flddate = q.flddate,
                        fldMatn = q.fldMatn,
                        fldUser = q.fldUser,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Matn, string user)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblWebServiceLogInsert(Matn, user);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Matn, string user)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblWebServiceLogUpdate(Id, Matn, user);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblWebServiceLogDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}