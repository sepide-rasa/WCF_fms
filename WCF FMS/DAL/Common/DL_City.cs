using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_City
    {
        #region Detail
        public OBJ_City Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblCitySelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_City
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldStateId = q.fldStateId,
                        fldStateName=q.fldStateName,
                        fldLatitude = q.fldLatitude,
                        fldLongitude = q.fldLongitude
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_City> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblCitySelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_City()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldStateId = q.fldStateId,
                        fldStateName = q.fldStateName,
                        fldLatitude = q.fldLatitude,
                        fldLongitude = q.fldLongitude
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldStateId, string fldLatitude, string fldLongitude, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCityInsert(fldName,fldStateId,fldLatitude,fldLongitude, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int fldStateId, string fldLatitude, string fldLongitude, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCityUpdate(fldId, fldName,fldStateId,fldLatitude,fldLongitude, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblCityDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var m = p.spr_tblOrganizationSelect("CheckCityId", id.ToString(),0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var personal = p.spr_Prs_tblPersonalInfoSelect("CheckMahalTavalodId", id.ToString(), 0, 1).FirstOrDefault();
                if (personal != null)
                    q = true;
            }
            
            return q;
        }
        #endregion
    }
}