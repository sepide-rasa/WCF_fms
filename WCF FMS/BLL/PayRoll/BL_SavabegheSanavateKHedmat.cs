using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using System.Text.RegularExpressions;
using WCF_FMS.DAL.Common;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SavabegheSanavateKHedmat
    {
        DL_SavabegheSanavateKHedmat SavabegheSanavateKHedmat = new DL_SavabegheSanavateKHedmat();
        DL_PersonalInfo PersonahInfo = new DL_PersonalInfo();
        DL_Employee_Detail Employee_Detail = new DL_Employee_Detail();
        DL_Employee Employee = new DL_Employee();
        #region Detail
        public OBJ_SavabegheSanavateKHedmat Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه سابقه صنوات خدمت ضروری است";
            }
            return SavabegheSanavateKHedmat.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_SavabegheSanavateKHedmat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return SavabegheSanavateKHedmat.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, bool NoeSabeghe, string AzTarikh,string TaTarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            var p = PersonahInfo.Select("CheckId", PersonalId.ToString(), 0, 1).FirstOrDefault();
            var q = Employee.Select("fldId", p.fldEmployeeId.ToString(),"", 1).FirstOrDefault();
            bool? jensiyat = Employee_Detail.Select("fldEmployeeId", q.fldId.ToString(), 1).FirstOrDefault().fldJensiyat;
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه پرسنل ضروری است";
            }
            else if (AzTarikh == null || AzTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فیلد از تاریخ ضروری است";
            }
            else if (TaTarikh == null || TaTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فیلد تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (jensiyat == false && NoeSabeghe==false)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "پرسنل انتخاب شده مجاز به انتخاب خدمت سربازی نمی باشد.";
            }
            else if (SavabegheSanavateKHedmat.CheckRepeatedRow(PersonalId,AzTarikh,TaTarikh,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده در این بازه زمانی تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return SavabegheSanavateKHedmat.Insert(PersonalId, NoeSabeghe, AzTarikh, TaTarikh, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه سوابق سنوات خدمت ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه پرسنل ضروری است";
            }
            else if (AzTarikh == null || AzTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فیلد از تاریخ ضروری است";
            }
            else if (TaTarikh == null || TaTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فیلد تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (SavabegheSanavateKHedmat.CheckRepeatedRow(PersonalId, AzTarikh, TaTarikh, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده در این بازه زمانی تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return SavabegheSanavateKHedmat.Update(Id,PersonalId,NoeSabeghe,AzTarikh,TaTarikh, UserId,Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه سوابق سنوات خدمت ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return  SavabegheSanavateKHedmat.Delete(Id, UserId);
        }
        #endregion
    }
}