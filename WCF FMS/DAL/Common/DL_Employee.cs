using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Common
{
    public class DL_Employee
    {
        #region Detail
        public OBJ_Employee Detail(int id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblEmployeeSelect("fldId", id.ToString(), "", 1)
                    .Select(q => new OBJ_Employee
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldFatherName = q.fldFatherName,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldOrganPostEjraeeId=q.fldOrganPostEjraeeId,
                        fldPostEjraee=q.fldPostEjraee
                        
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Employee> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblEmployeeSelect(FieldName, FilterValue, FilterValue1, h)
                    .Select(q => new OBJ_Employee()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldFatherName = q.fldFatherName,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldTypeShakhsName = q.fldTypeShakhsName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldOrganPostEjraeeId = q.fldOrganPostEjraeeId,
                        fldPostEjraee = q.fldPostEjraee
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(string fldName, string fldFamily, string fldCodemeli, bool fldStatus,byte TypeShakhs, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("AshkhasId", typeof(int));
                p.spr_tblEmployeeInsert(fldName, fldFamily, fldCodemeli, fldStatus, userId, Desc, id, TypeShakhs);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, string fldFamily, string fldCodemeli, bool fldStatus,byte TypeShakhs, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblEmployeeUpdate(fldId, fldName, fldFamily, fldCodemeli, fldStatus, userId, Desc, TypeShakhs);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblEmployeeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var Personal = p.spr_Prs_tblPersonalInfoSelect("CheckEmployeeId", id.ToString(), 0, 0).FirstOrDefault();
                if (Personal != null)
                    q = true;
            }
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var r = m.spr_tblRequestTaghsit_TakhfifSelect("fldEmployeeId", id.ToString(), 0).FirstOrDefault();
                if (r != null)
                    q = true;
            }
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var Masuolin = m.spr_tblMasuolin_DetailSelect("fldEmployId", id.ToString(), 0).FirstOrDefault();
              //  var Ashkhas = m.spr_tblAshkhasSelect("fldHaghighiId", id.ToString(), "", 0).FirstOrDefault(); تو حذف از اشخاص پاک شده
                if (Masuolin != null )
                    q = true;
            }
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblGhabreAmanatSelect("CheckEmployeeId", id.ToString(), 0, 1).FirstOrDefault();
                var r = p.spr_tblRequestAmanatSelect("CheckEmployeeId", id.ToString(), 0, 0).FirstOrDefault();
                if (m != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}