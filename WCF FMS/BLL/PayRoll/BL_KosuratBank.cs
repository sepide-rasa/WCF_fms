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
    public class BL_KosuratBank
    {
        DL_KosuratBank KosuratBank = new DL_KosuratBank();
        #region Detail
        public OBJ_KosuratBank Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return KosuratBank.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_KosuratBank> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, int OrganId, int h)
        {
            return KosuratBank.Select(FieldName, FilterValue, FilterValue1,FilterValue2, OrganId, h);
        }
        #endregion
        #region RptKosouratBank
        public List<OBJ_RptKosouratBank> RptKosouratBank(byte NobatPardakhtId, short Year, byte Month, int CostCenterId, byte CalcType, int OrganId)
        {
            return KosuratBank.RptKosouratBank(NobatPardakhtId, Year, Month, CostCenterId,CalcType,OrganId);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish,string ShomareSheba, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            else if (ShobeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (TarikhPardakht == null || TarikhPardakht=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
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
            else if (!r.IsMatch(TarikhPardakht))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return KosuratBank.Insert(PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab, Status, DeactiveDate,MandeAzGhabl,MandeDarFish,ShomareSheba, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish,string ShomareSheba, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            else if (TarikhPardakht == null || TarikhPardakht == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ پرداخت ضروری است";
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
            else if (!r.IsMatch(TarikhPardakht))
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
            return KosuratBank.Update(Id, PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab,ShomareSheba, Status, DeactiveDate,MandeAzGhabl,MandeDarFish, UserId, Desc);
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
            else if (KosuratBank.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return KosuratBank.Delete(Id, UserId);
        }
        #endregion

        #region UpdateKosuratBankStatus
        public string UpdateKosuratBankStatus(bool Status, int Id, int tarikhDeactive, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KosuratBank.UpdateKosuratBankStatus(Status, Id, tarikhDeactive, UserId);
        }
        #endregion

        #region UpdateDescKosuratBank
        public string UpdateDescKosuratBank(int Id, string Desc, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KosuratBank.UpdateDescKosuratBank(Id, Desc, UserId);
        }
        #endregion
    }
}