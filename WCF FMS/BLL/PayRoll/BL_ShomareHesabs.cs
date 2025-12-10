using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ShomareHesabs
    {
        DL_ShomareHesabs ShomareHesabs = new DL_ShomareHesabs();
        #region Detail
        public OBJ_ShomareHesabs Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return ShomareHesabs.Detail(Id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabs> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            return ShomareHesabs.Select(FieldName, FilterValue, FilterValue2,FilterValue3,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
            else if (ShobeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (ShomareHesab == null || ShomareHesab=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره حساب ضروری است";
            }
            else if (ShomareHesab.Length < 8)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حساب وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesab.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حساب وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
           /* else if (ShomareKart == null || ShomareKart == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره کارت ضروری است";
            }*/
            if (ShomareKart != "")
            {
                if (ShomareKart.Length < 16)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر شماره کارت وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (ShomareKart.Length > 50)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر شماره کارت وارده شده بیشتر از حد مجاز می باشد.";
                }
            }

            else if (ShomareHesabs.CheckRepeatedRow(TypeHesab, ShomareHesab, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (ShomareKart == null)
                ShomareKart = "";
            if (Error.ErrorType == true)
                return "خطا";
            return ShomareHesabs.Insert(PersonalId, ShobeId, ShomareHesab, ShomareKart, TypeHesab,  HesabTypeId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, int UserId, string Desc, out ClsError Error)
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
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (ShobeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (ShomareHesab == null || ShomareHesab == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره حساب ضروری است";
            }
            else if (ShomareHesab.Length < 8)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حساب وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesab.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حساب وارده شده بیشتر از حد مجاز می باشد.";
            }
           /* else if (ShomareKart == null || ShomareKart == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره کارت ضروری است";
            }*/
            if (ShomareKart != "")
            {
                if (ShomareKart.Length < 16)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر شماره کارت وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (ShomareKart.Length > 50)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر شماره کارت وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            else if (ShomareHesabs.CheckRepeatedRow(TypeHesab, ShomareHesab, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (ShomareKart == null)
                ShomareKart = "";
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return ShomareHesabs.Update(Id, PersonalId, ShobeId, ShomareHesab, ShomareKart, TypeHesab,  HesabTypeId, UserId, Desc);
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
            else if (ShomareHesabs.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return ShomareHesabs.Delete(Id, UserId);
        }
        #endregion

        #region ShomareHesabGroup
        public List<OBJ_ShomareHesabs> ShomareHesabGroup(bool NoeHesab, int BankId, int OrganId)
        {
            return ShomareHesabs.ShomareHesabGroup(NoeHesab, BankId, OrganId);
        }
        #endregion
    }
}