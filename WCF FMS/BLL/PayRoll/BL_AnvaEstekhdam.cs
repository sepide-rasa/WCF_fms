using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AnvaEstekhdam
    {
        DL_AnvaEstekhdam AnvaEstekhdam = new DL_AnvaEstekhdam();
        #region Detail
        public OBJ_AnvaEstekhdam Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            return AnvaEstekhdam.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_AnvaEstekhdam> Select(string FieldName, string FilterValue, int h)
        {
            return AnvaEstekhdam.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (NoeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه نوع استخدام ضروری است";
            }
            else if (fldTypeEstekhdamFormul == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه نوع استخدام در فرمول ضروری است";
            }
            else if (Title == null || Title=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان استخدام ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AnvaEstekhdam.CheckRepeatedRow(NoeEstekhdamId, Title, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return AnvaEstekhdam.Insert(Title, NoeEstekhdamId, fldPatternNoeEstekhdamId,fldTypeEstekhdamFormul, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, int UserId, string IP, out ClsError Error)
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
            else if (NoeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه نوع استخدام ضروری است";
            }
            else if (fldTypeEstekhdamFormul == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه نوع استخدام در فرمول ضروری است";
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
            else if (Title.Length > 300)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AnvaEstekhdam.CheckRepeatedRow(NoeEstekhdamId, Title, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            else if (AnvaEstekhdam.CheckPattern(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رکورد موردنظر به عنوان الگوی استخدام تعریف شده است؛ لذا ویرایش مجاز نیست.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AnvaEstekhdam.Update(Id, Title, NoeEstekhdamId, fldPatternNoeEstekhdamId,fldTypeEstekhdamFormul, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId,string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (AnvaEstekhdam.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return AnvaEstekhdam.Delete(Id, UserId);
        }
        #endregion
    }
}