using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_SecurityType
    {
        DL_SecurityType SecurityTypee = new DL_SecurityType();

        #region Detail
        public OBJ_SecurityType Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SecurityTypee.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_SecurityType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return SecurityTypee.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string SecurityType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (SecurityType == "" || SecurityType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع محرمانگی ضروری است";
            }
            else if (SecurityType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع محرمانگی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (SecurityType.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع محرمانگی وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SecurityTypee.Insert(SecurityType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string SecurityType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (SecurityType == "" || SecurityType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع محرمانگی ضروری است";
            }
            else if (SecurityType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع محرمانگی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (SecurityType.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع محرمانگی وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SecurityTypee.Update(Id, SecurityType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SecurityTypee.Delete(id, userId);
        }
        #endregion
    }
}