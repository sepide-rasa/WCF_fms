using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_FormatShomareName
    {
        DL_FormatShomareName ShomareName = new DL_FormatShomareName();

        #region Detail
        public OBJ_FormatShomareName Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ShomareName.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_FormatShomareName> Select(string FieldName, string FilterValue, int h)
        {
            return ShomareName.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(short Year, string FormatShomareName, int ShomareShoro, bool Type, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (FormatShomareName == "" || FormatShomareName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت شماره نامه ضروری است";
            }
            else if (FormatShomareName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareName.CheckRepeatedRow(Year, Type, 0))
            {
                if (Type == true)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "برای سال انتخاب شده رسید مودی قبلا در سیستم ثبت شده است.";
                }
                else
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "برای سال انتخاب شده مکاتبات قبلا در سیستم ثبت شده است.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareName.Insert(Year, FormatShomareName, ShomareShoro,Type, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, short Year, string FormatShomareName, int ShomareShoro,bool Type, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (FormatShomareName == "" || FormatShomareName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت شماره نامه ضروری است";
            }
            else if (FormatShomareName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareName.CheckRepeatedRow(Year, Type, Id))
            {
                if (Type == true)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "برای سال انتخاب شده رسید مودی قبلا در سیستم ثبت شده است.";
                }
                else
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "برای سال انتخاب شده مکاتبات قبلا در سیستم ثبت شده است.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareName.Update(Id, Year, FormatShomareName, ShomareShoro,Type, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
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
            if (error.ErrorType == true)
                return "خطا";

            return ShomareName.Delete(id, userId);
        }
        #endregion
    }
}