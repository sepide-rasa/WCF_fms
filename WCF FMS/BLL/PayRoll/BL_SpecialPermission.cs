using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SpecialPermission
    {
        DL_SpecialPermission SpecialPermission = new DL_SpecialPermission();

        #region Detail
        public OBJ_SpecialPermission Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SpecialPermission.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_SpecialPermission> Select(string FieldName, string FilterValue, int h)
        {
            return SpecialPermission.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int UserSelectId, int ChartOrganId, int OpertionId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (UserSelectId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ChartOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            else if (OpertionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد عملیات ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SpecialPermission.Insert(UserSelectId, ChartOrganId, OpertionId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int UserSelectId, int ChartOrganId, int OpertionId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (UserSelectId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ChartOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            else if (OpertionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد عملیات ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SpecialPermission.Update(Id, UserSelectId, ChartOrganId, OpertionId, userId, Desc);

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

            return SpecialPermission.Delete(id, userId);
        }
        #endregion
    }
}