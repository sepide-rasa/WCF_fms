using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_GHarardadBime
    {
        DL_GHarardadBime GHarardadBime = new DL_GHarardadBime();
        #region Detail
        public OBJ_GHarardadBime Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return GHarardadBime.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_GHarardadBime> Select(string FieldName, string FilterValue, int h)
        {
            return GHarardadBime.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, int fldUserId, string fldDesc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (fldNameBime == null || fldNameBime == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام بیمه ضروری است";
            }
            else if (fldTarikhSHoro == null || fldTarikhSHoro == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldTarikhPayan == null || fldTarikhPayan == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (fldNameBime.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام بیمه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameBime.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(fldTarikhSHoro))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(fldTarikhPayan))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (fldDesc == null)
                fldDesc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GHarardadBime.Insert(fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal, fldMablaghe70Sal
                    , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh, fldUserId, fldDesc);
        }
        #endregion
        #region Update
        public string Update(int Id, string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, int fldUserId, string fldDesc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (fldNameBime == null || fldNameBime == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام بیمه ضروری است";
            }
            else if (fldTarikhSHoro == null || fldTarikhSHoro == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldTarikhPayan == null || fldTarikhPayan == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (fldNameBime.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام بیمه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameBime.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(fldTarikhSHoro))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!r.IsMatch(fldTarikhPayan))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            if (fldDesc == null)
                fldDesc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return GHarardadBime.Update(Id, fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal, fldMablaghe70Sal
                    , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh, fldUserId, fldDesc);
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
            else if(GHarardadBime.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return GHarardadBime.Delete(Id, UserId);
        }
        #endregion
    }
}