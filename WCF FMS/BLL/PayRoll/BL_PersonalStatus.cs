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
    public class BL_PersonalStatus
    {
        DL_PersonalStatus PersonalStatus = new DL_PersonalStatus();
        #region Detail
        public OBJ_PersonalStatus Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه وضعیت ضروری است";
            }
            return PersonalStatus.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_PersonalStatus> Select(string FieldName, string FilterValue, int h)
        {
            return PersonalStatus.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int StatusId,int? PrsPersonalInfoId,int? PayPersonalInfoId,string DateTaghirVaziyat, string Desc,int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PrsPersonalInfoId == null && PayPersonalInfoId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا یکی از فیلدهای پرسنل کارگزینی یا پرسنل حقوقی را مقداردهی کنید";
            }
            else if (PrsPersonalInfoId != null && PayPersonalInfoId != null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تنها یکی از فیلدهای پرسنل حقوقی یا پرسنل کارگزینی را مقداردهی نمایید";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه اطلاعات پرسنلی ضروری است";
            }
            else if (PayPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه اطلاعات حقوقی ضروری است";
            }
            else if (StatusId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه وضعیت پرسنل ضروری است";
            }
            else if (DateTaghirVaziyat == null || DateTaghirVaziyat == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است";
            }
            else if (!r.IsMatch(DateTaghirVaziyat))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (PersonalStatus.CheckRepeatedRow(StatusId, PrsPersonalInfoId, PayPersonalInfoId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (PrsPersonalInfoId != null)
            {
                var q = PersonalStatus.validDate(DateTaghirVaziyat, (int)PrsPersonalInfoId, null);
                if(q==false)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
                }            
            }
            if (PayPersonalInfoId != null)
            {
                var q = PersonalStatus.validDate(DateTaghirVaziyat, null, (int)PayPersonalInfoId);
                if (q == false)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return PersonalStatus.Insert(StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه وضعیت ضروری است";
            }
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PrsPersonalInfoId == null && PayPersonalInfoId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا یکی از فیلدهای پرسنل کارگزینی یا پرسنل حقوقی را مقداردهی کنید";
            }
            else if (PrsPersonalInfoId != null && PayPersonalInfoId != null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تنها یکی از فیلدهای پرسنل حقوقی یا پرسنل کارگزینی را مقداردهی نمایید";
            }
            else if (PrsPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه اطلاعات پرسنلی ضروری است";
            }
            else if (PayPersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه اطلاعات حقوقی ضروری است";
            }
            else if (StatusId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه وضعیت پرسنل ضروری است";
            }
            else if (DateTaghirVaziyat == null || DateTaghirVaziyat == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است";
            }
            else if (!r.IsMatch(DateTaghirVaziyat))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
           else if (PersonalStatus.CheckRepeatedRow(StatusId, PrsPersonalInfoId, PayPersonalInfoId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (PrsPersonalInfoId != null)
            {
                var q = PersonalStatus.validDate(DateTaghirVaziyat, (int)PrsPersonalInfoId, null);
                if (q == false)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
                }
            }
            if (PayPersonalInfoId != null)
            {
                var q = PersonalStatus.validDate(DateTaghirVaziyat, null, (int)PayPersonalInfoId);
                if (q == false)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ وارد شده از آخرین تاریخ تغییر وضعیت کوچکتر است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return PersonalStatus.Update(Id, StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, Desc, UserId);
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
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه وضعیت ضروری است";
            }
            if (Error.ErrorType == true)
                return Error.ErrorMsg;
            return PersonalStatus.Delete(Id, UserId);
        }
        #endregion
    }
}