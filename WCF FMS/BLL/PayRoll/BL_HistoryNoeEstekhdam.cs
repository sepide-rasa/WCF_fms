using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_HistoryNoeEstekhdam
    {
        DL_HistoryNoeEstekhdam HistoryNoeEstekhdam = new DL_HistoryNoeEstekhdam();
        #region Detail
        public OBJ_HistoryNoeEstekhdam Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه تاریخچه نوع استخدام ضروری است";
            }
            return HistoryNoeEstekhdam.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_HistoryNoeEstekhdam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return HistoryNoeEstekhdam.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PrsPersonalInfoId, int NoeEstekhdamId,string Tarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (NoeEstekhdamId==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (Tarikh == null || Tarikh=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!HistoryNoeEstekhdam.ValidDate(PrsPersonalInfoId, Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
            }
            else if (!HistoryNoeEstekhdam.ValidDateTasvie(PrsPersonalInfoId, Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تسویه حساب کوچکتر است";
            }
            else if (HistoryNoeEstekhdam.CheckRepeatedRow(Tarikh,PrsPersonalInfoId, NoeEstekhdamId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            
            return HistoryNoeEstekhdam.Insert(NoeEstekhdamId, PrsPersonalInfoId, Tarikh, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int PrsPersonalInfoId, int NoeEstekhdamId, string Tarikh, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد تاریخچه نوع استخدام ضروری است";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (NoeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!HistoryNoeEstekhdam.ValidDateEdit(PrsPersonalInfoId, Tarikh,Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
            }
            else if (!HistoryNoeEstekhdam.ValidDateTasvie(PrsPersonalInfoId, Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تسویه حساب کوچکتر است";
            }
            else if (HistoryNoeEstekhdam.CheckRepeatedRow(Tarikh,PrsPersonalInfoId, NoeEstekhdamId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return HistoryNoeEstekhdam.Update(Id,NoeEstekhdamId, PrsPersonalInfoId, Tarikh, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه تاریخچه نوع استخدام ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return HistoryNoeEstekhdam.Delete(Id, UserId);
        }
        #endregion
    }
}