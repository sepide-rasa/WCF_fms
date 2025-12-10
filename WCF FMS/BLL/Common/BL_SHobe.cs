using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;


namespace WCF_FMS.BLL.Common
{
    public class BL_SHobe
    {
        DL_SHobe SHobe = new DL_SHobe();

        #region Detail
        public OBJ_SHobe Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SHobe.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_SHobe> Select(string FieldName, string FilterValue, int h)
        {
            return SHobe.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int BankId, string Name, int CodeSHobe, string Address, int UserId, string Desc, out ClsError error)
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
            else if (BankId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بانک ضروری است";
            }
            else if (Name == null || Name == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام شعبه ضروری است";
            }
            else if (CodeSHobe==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شعبه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (SHobe.CheckRepeatedRow(Name,BankId,0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شعبه بانک انتخاب شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SHobe.Insert(BankId, Name, CodeSHobe, Address, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int BankId, string Name, int CodeSHobe, string Address, int UserId, string Desc, out ClsError error)
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
            else if (BankId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بانک ضروری است";
            }
            else if (Name == null || Name == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام شعبه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شعبه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodeSHobe == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (SHobe.CheckRepeatedRow(Name, BankId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شعبه بانک انتخاب شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SHobe.Update(Id, BankId,Name,CodeSHobe,Address, UserId, Desc);

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
            else if(SHobe.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SHobe.Delete(id, userId);
        }
        #endregion
    }
}