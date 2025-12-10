using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MaliyatArzesheAfzoode
    {
        #region Detail
        public OBJ_MaliyatArzesheAfzoode Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMaliyatArzesheAfzoodeSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MaliyatArzesheAfzoode()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadeAvarez=q.fldDarsadeAvarez,
                        fldDarsadeMaliyat=q.fldDarsadeMaliyat,
                        fldEndDate=q.fldEndDate,
                        fldFromDate = q.fldFromDate,
                        fldDarsadAmuzeshParvaresh = q.fldDarsadAmuzeshParvaresh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MaliyatArzesheAfzoode> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMaliyatArzesheAfzoodeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MaliyatArzesheAfzoode()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadeAvarez = q.fldDarsadeAvarez,
                        fldDarsadeMaliyat = q.fldDarsadeMaliyat,
                        fldDarsadAmuzeshParvaresh = q.fldDarsadAmuzeshParvaresh,
                        fldEndDate = q.fldEndDate,
                        fldFromDate = q.fldFromDate,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMaliyatArzesheAfzoodeInsert(FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMaliyatArzesheAfzoodeUpdate(Id, FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMaliyatArzesheAfzoodeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDate
        public bool CheckDate(string FromDate, string EndDate,int Id)
        {
            var q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    var p = m.spr_chechRangeDateMaliyat(FromDate, EndDate).FirstOrDefault();
                    if (p.fldid!=0)
                        q = true;

                }
                else
                {
                    var p = m.spr_chechRangeDateMaliyat(FromDate, EndDate).FirstOrDefault();
                    if (p.fldid != 0 && p.fldid != Id)
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