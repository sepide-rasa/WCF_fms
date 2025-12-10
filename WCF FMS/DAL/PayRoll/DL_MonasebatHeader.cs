using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MonasebatHeader
    {
        #region Detail
        public OBJ_MonasebatHeader Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMonasebatHeaderSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_MonasebatHeader
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldActive=q.fldActive,
                        fldActiveDate=q.fldActiveDate,
                        fldActiveName=q.fldActiveName,
                        fldDeactiveDate=q.fldDeactiveDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MonasebatHeader> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatHeaderSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MonasebatHeader()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldActive = q.fldActive,
                        fldActiveDate = q.fldActiveDate,
                        fldActiveName = q.fldActiveName,
                        fldDeactiveDate = q.fldDeactiveDate
                    }).ToList();
                return test;
            }
        }
        #endregion      
        #region Insert
        public string Insert(int ActiveDate, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatHeaderInsert(ActiveDate, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int? DeactiveDate, bool Active, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatHeaderActiveDate_fldDeactiveDate(Id,DeactiveDate,Active, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatHeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Copy
        public string Copy(int HeaderId, int ActiveDate, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatMablaghCopy(HeaderId, ActiveDate, IP, UserId);
                return "عملیات کپی با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ActiveDate)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMonasebatHeaderSelect("fldActiveDate", ActiveDate.ToString(), 0).Any();
            }
            return q;
        }
        #endregion        
    }
}