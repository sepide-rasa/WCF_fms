using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Disket
    {
        DL_Disket Disket = new DL_Disket();
        #region Detail
        public OBJ_Disket Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Disket.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Disket> Select(string FieldName, string FilterValue, int h)
        {
            return Disket.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, 
            string ShobeCode, string OrganCode, byte[] File, string Pasvand, string NameFile,
            int BankFixId, string NameShobe, int UserId, string Desc,int organId, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (BankFixId == null || BankFixId == 0 )
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بانک ضروری است";
            }
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (ShobeCode == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (OrganCode == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (NameShobe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام شعبه ضروری است";
            }
            else if (NameShobe.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameShobe.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShobeCode.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (OrganCode.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد پست سازمانی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return Disket.Insert(Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode, File,
                Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc,organId);
        }
        #endregion
        #region Update
        public string Update(int Id, string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, int FielId, byte[] File, string Pasvand, string NameFile, int BankFixId, string NameShobe, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            else if (BankFixId == null || BankFixId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بانک ضروری است";
            }
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (ShobeCode == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (OrganCode == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (NameShobe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام شعبه ضروری است";
            }
            else if (NameShobe.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameShobe.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShobeCode.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شعبه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (OrganCode.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد پست سازمانی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Disket.Update(Id, Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode, FielId, File, Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc);
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
            
            if (Error.ErrorType == true)
                return "خطا";
            return Disket.Delete(Id, UserId);
        }
        #endregion
    }
}