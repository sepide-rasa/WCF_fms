using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Vam
    {
        DL_Vam Vam = new DL_Vam();
        #region Detail
        public OBJ_Vam Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Vam.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Vam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Vam.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (TarikhDaryaft == null || TarikhDaryaft=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ دریافتی ضروری است";
            }
            else if (StartDate == null || StartDate == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (!r.IsMatch(StartDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(TarikhDaryaft))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Vam.Insert(PersonalId,TarikhDaryaft,TypeVam,MablaghVam,StartDate,Count,Mablagh,MandeVam,Status, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, int UserId, string Desc, out ClsError Error)
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
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (TarikhDaryaft == null || TarikhDaryaft == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ دریافتی ضروری است";
            }
            else if (StartDate == null || StartDate == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (!r.IsMatch(StartDate))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(TarikhDaryaft))
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
            return Vam.Update(Id, PersonalId, TarikhDaryaft, TypeVam, MablaghVam, StartDate, Count, Mablagh, MandeVam, Status, UserId, Desc);
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
            else if (Vam.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Vam.Delete(Id, UserId);
        }
        #endregion

        #region VamStatusUpdate
        public string VamStatusUpdate(int Id, bool Status, int UserId, out ClsError Error)
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
            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Vam.VamStatusUpdate(Id, Status, UserId);
        }
        #endregion
    }
}