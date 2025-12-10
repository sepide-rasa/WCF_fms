using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_ReferralRules
    {
        DL_ReferralRules ReferralRules = new DL_ReferralRules();

        #region Detail
        public OBJ_ReferralRules Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ReferralRules.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ReferralRules> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return ReferralRules.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldPostErjaDahandeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع دهنده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReferralRules.Insert(fldPostErjaDahandeId, fldPostErjaGirandeId, fldChartEjraeeGirandeId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldPostErjaDahandeId, int? fldPostErjaGirandeId, int? fldChartEjraeeGirandeId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldPostErjaDahandeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع دهنده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReferralRules.Update(Id, fldPostErjaDahandeId, fldPostErjaGirandeId, fldChartEjraeeGirandeId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(int fldPostErjaDahandeId, int OrganErjaGirande, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldPostErjaDahandeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع دهنده ضروری است";
            }
            else if (OrganErjaGirande == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارگان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReferralRules.Delete(fldPostErjaDahandeId, OrganErjaGirande, userId);
        }
        #endregion
    }
}