using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.Common
{
    public class DL_User
    {
        #region Detail
        public OBJ_User Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblUserSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_User()
                    {
                        fldId = q.fldId,
                        fldEmployeeId = q.fldEmployId,
                        fldUserId = q.fldUserId,
                        fldUserName = q.fldUserName,
                        fldPassword = q.fldPassword,
                        fldActive_Deactive = q.fldActive_Deactive,
                        fldActive_DeactiveName = q.fldActive_DeactiveName,
                        fldNameEmployee=q.fldNameEmployee,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldCodemeli=q.fldCodemeli
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_User> Select(string FieldName, string FilterValue,string FilterValue2, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblUserSelect(FieldName, FilterValue, FilterValue2,h)
                    .Select(q => new OBJ_User()
                    {
                        fldId = q.fldId,
                        fldEmployeeId = q.fldEmployId,
                        fldUserId = q.fldUserId,
                        fldUserName = q.fldUserName,
                        fldPassword = q.fldPassword,
                        fldActive_Deactive = q.fldActive_Deactive,
                        fldActive_DeactiveName = q.fldActive_DeactiveName,
                        fldNameEmployee = q.fldNameEmployee,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldCodemeli = q.fldCodemeli
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int EmployeeId, string UserName, string PassWord, bool Active_Deactive, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblUserInsert(Id, EmployeeId, UserName, PassWord, Active_Deactive, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int EmployeeId, string UserName, bool Active_Deactive, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserUpdate(Id, EmployeeId, UserName, Active_Deactive, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblUserDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region ResetPass
        public string ResetPass(int Id, string Password)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_UserPassUpdate(Id, Password);
                return "تغییر رمز عبور با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string UserName, int EmployeeId,int Id)
        {
            bool q=false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    var q1 = p.spr_tblUserSelect("CheckUserName", UserName, "", 0).Where(l => l.fldEmployId == EmployeeId).Any();
                    var q2 = p.spr_tblUserSelect("CheckEmployId", EmployeeId.ToString(), "", 0).Any();
                    var q3 = p.spr_tblUserSelect("CheckUserName", UserName, "",  0).Any();
                    if (q1 == true || q2 == true||q3==true)
                    {
                        q = true;
                    }
                }
                else
                {
                    var q1 = p.spr_tblUserSelect("CheckUserName", UserName, "",  0).Where(l => l.fldEmployId == EmployeeId).FirstOrDefault();
                    var q2 = p.spr_tblUserSelect("CheckEmployId", EmployeeId.ToString(), "",  0).FirstOrDefault();
                    var q3 = p.spr_tblUserSelect("CheckUserName", UserName, "",  0).FirstOrDefault();
                    if (q1 != null && q1.fldId != Id || q2 != null && q2.fldId != Id || q3 != null && q3.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region SelectUserByUserId
        public List<OBJ_User> SelectUserByUserId(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_SelectUserByUserId(FieldName, FilterValue, UserId, h)
                    .Select(q => new OBJ_User()
                    {
                        fldActive_Deactive = q.fldActive_Deactive,
                        fldActive_DeactiveName = q.fldActive_DeactiveName,
                        fldCodemeli = q.fldCodemeli,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEmployeeId = q.fldEmployId,
                        fldId = q.fldId,
                        fldNameEmployee = q.fldNameEmployee,
                        fldPassword = q.fldPassword,
                        fldUserId = q.fldUserId,
                        fldUserName = q.fldUserName,
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region UpdateActiveUser
        public string UpdateActiveUser(int Id, bool Active_Deactive)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_UpdateActiveUser( Id, Active_Deactive);
                return "حساب کاربری مورد نظر غیرفعال شد.";
            }
        }
        #endregion
    }
}