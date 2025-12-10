using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_CostCenter
    {
        DL_CostCenter CostCenter = new DL_CostCenter();
        #region Detail
        public OBJ_CostCenter Detail(int Id,int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return CostCenter.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CostCenter> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return CostCenter.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId,int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (TypeOfCostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع مرکز هزینه ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ReportTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع گزارش هزینه ضروری است";
            }
            else if (EmploymentCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز اشتغال ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return CostCenter.Insert(Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId,OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (TypeOfCostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع مرکز هزینه ضروری است";
            }
            else if (ReportTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع گزارش هزینه ضروری است";
            }
            else if (EmploymentCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز اشتغال ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return CostCenter.Update(Id, Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId, OrganId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (CostCenter.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return CostCenter.Delete(Id, UserId);
        }
        #endregion
    }
}