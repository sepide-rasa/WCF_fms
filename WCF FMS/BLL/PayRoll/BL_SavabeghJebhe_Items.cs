using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SavabeghJebhe_Items
    {
        DL_SavabeghJebhe_Items SavabeghJebhe_Items = new DL_SavabeghJebhe_Items();
        #region Detail
        public OBJ_SavabeghJebhe_Items Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            return SavabeghJebhe_Items.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghJebhe_Items> Select(string FieldName, string FilterValue, int h)
        {
            return SavabeghJebhe_Items.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, decimal Darsad_Sal, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان استخدام ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 250)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Darsad_Sal > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار درصد سال وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return SavabeghJebhe_Items.Insert(Title,Darsad_Sal, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, decimal Darsad_Sal, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان استخدام ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 250)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Darsad_Sal > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار درصد سال وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return SavabeghJebhe_Items.Update(Id, Title, Darsad_Sal, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
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
            else if (SavabeghJebhe_Items.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return SavabeghJebhe_Items.Delete(Id, UserId);
        }
        #endregion
    }
}