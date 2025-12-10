using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Parametrs
    {
        DL_Parametrs Parametrs = new DL_Parametrs();
        #region Detail
        public OBJ_Parametrs Detail(int Id,int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Parametrs.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Parametrs> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return Parametrs.Select(FieldName, FilterValue,  FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (TypeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (IsMostamar == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع پارامتر ضروری است";
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
            return Parametrs.Insert(Title, TypeParametr, TypeMablagh, TypeEstekhdamId, UserId, Desc, Active, Private, HesabTypeParam, IsMostamar, OrganId);
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, int OrganId, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (TypeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (IsMostamar == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع پارامتر ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
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
            return Parametrs.Update(Id, Title, TypeParametr, TypeMablagh, TypeEstekhdamId, UserId, Desc,  Active,  Private,  HesabTypeParam,  IsMostamar,  OrganId);
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
            else if (Parametrs.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Parametrs.Delete(Id, UserId);
        }
        #endregion
    }
}