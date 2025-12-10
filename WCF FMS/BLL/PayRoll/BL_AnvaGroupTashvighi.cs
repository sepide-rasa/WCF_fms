using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AnvaGroupTashvighi
    {
        DL_AnvaGroupTashvighi AnvaGroupTashvighi = new DL_AnvaGroupTashvighi();
        #region Detail
        public OBJ_AnvaGroupTashvighi Detail(byte Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع گروه تشویقی ضروری است";
            }
            return AnvaGroupTashvighi.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_AnvaGroupTashvighi> Select(string FieldName, string FilterValue, int h)
        {
            return AnvaGroupTashvighi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "عنوان گروه تشویقی ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AnvaGroupTashvighi.CheckRepeatedRow(Title, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return AnvaGroupTashvighi.Insert(Title, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(byte Id, string Title, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه انواع گروه تشویقی ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان گروه تشویقی ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AnvaGroupTashvighi.CheckRepeatedRow(Title, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AnvaGroupTashvighi.Update(Id, Title, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(byte Id, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد انواع گروه های تشویقی ضروری است";
            }
            else if (AnvaGroupTashvighi.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return AnvaGroupTashvighi.Delete(Id, UserId);
        }
        #endregion
    }
}