using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Secretariat_OrganizationUnit
    {
        DL_Secretariat_OrganizationUnit Secretariat_OrganizationUnit = new DL_Secretariat_OrganizationUnit();

        #region Detail
        public OBJ_Secretariat_OrganizationUnit Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Secretariat_OrganizationUnit.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Secretariat_OrganizationUnit> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Secretariat_OrganizationUnit.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldSecretariatID, int fldOrganizationUnitID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSecretariatID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (fldOrganizationUnitID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Secretariat_OrganizationUnit.Insert(fldSecretariatID,fldOrganizationUnitID, UserId, Desc, IP, OrganID);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldSecretariatID, int fldOrganizationUnitID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSecretariatID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (fldOrganizationUnitID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Secretariat_OrganizationUnit.Update(Id, fldSecretariatID,fldOrganizationUnitID, UserId, Desc, IP, OrganID);

        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int id, int userId, out ClsError error)
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
            else if (Secretariat_OrganizationUnit.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده لذا مجاز به حذف نمیباشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Secretariat_OrganizationUnit.Delete(FieldName, id, userId);
        }
        #endregion
    }
}