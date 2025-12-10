using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_InsuranceWorkshop
    {
        DL_InsuranceWorkshop InsuranceWorkshop = new DL_InsuranceWorkshop();
        #region Detail
        public OBJ_InsuranceWorkshop Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return InsuranceWorkshop.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_InsuranceWorkshop> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return InsuranceWorkshop.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (WorkShopName == null || WorkShopName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کارگاه بیمه ضروری است";
            }
            else if (EmployerName == null || EmployerName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کارفرما ضروری است";
            }
            else if (WorkShopNum == null || WorkShopNum == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره کارگاه بیمه ضروری است";
            }
            else if (Peyman == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "بیمه پیمانکار ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (WorkShopName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارگاه بیمه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (WorkShopName.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارگاه بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (EmployerName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارفرما وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (EmployerName.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارفرما وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Peyman.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر بیمه پیمانکار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Peyman.Length > 3)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر بیمه پیمانکار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (WorkShopNum.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره کارگاه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Persent > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر درصد حق بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (InsuranceWorkshop.CheckRepeatedRow(WorkShopNum,Peyman, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Address == null)
                Address = "";
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return InsuranceWorkshop.Insert(WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman, OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int OrganId, int UserId, string Desc, out ClsError Error)
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

            else if (WorkShopName == null || WorkShopName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کارگاه بیمه ضروری است";
            }
            else if (EmployerName == null || EmployerName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کارفرما ضروری است";
            }
            else if (WorkShopNum == null || WorkShopNum == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره کارگاه بیمه ضروری است";
            }
            else if (Peyman == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "بیمه پیمانکار ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (WorkShopName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارگاه بیمه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (WorkShopName.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارگاه بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (EmployerName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارفرما وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (EmployerName.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام کارفرما وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Peyman.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر بیمه پیمانکار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Peyman.Length > 3)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر بیمه پیمانکار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (WorkShopNum.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره کارگاه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Persent > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر درصد حق بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (InsuranceWorkshop.CheckRepeatedRow(WorkShopNum,Peyman, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return InsuranceWorkshop.Update(Id, WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman, OrganId, UserId, Desc);
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
            else if (InsuranceWorkshop.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return InsuranceWorkshop.Delete(Id, UserId);
        }
        #endregion
    }
}