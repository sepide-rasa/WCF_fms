using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Commision
    {
        DL_Commision Commision = new DL_Commision();

        #region Detail
        public OBJ_Commision Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Commision.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Commision> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Commision.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AshkhasID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (OrganizPostEjraeeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی اجرایی ضروری است";
            }
            else if (StartDate == "" || StartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (EndDate == "" || EndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(StartDate) || !r.IsMatch(EndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(StartDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (OraganicNumber.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Commision.CheckRepeatedRow(StartDate,EndDate,AshkhasID, OrganizPostEjraeeID, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Commision.Insert(AshkhasID, OrganizPostEjraeeID, StartDate, EndDate, OraganicNumber, fldSign, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int AshkhasID, int OrganizPostEjraeeID, string StartDate, string EndDate, string OraganicNumber, bool fldSign, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AshkhasID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (OrganizPostEjraeeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی اجرایی ضروری است";
            }
            else if (StartDate == "" || StartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (EndDate == "" || EndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(StartDate) || !r.IsMatch(EndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(StartDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (OraganicNumber.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Commision.CheckRepeatedRow(StartDate, EndDate, AshkhasID, OrganizPostEjraeeID, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Commision.Update(Id, AshkhasID, OrganizPostEjraeeID, StartDate, EndDate, OraganicNumber, fldSign, OrganID, UserId, Desc, IP);

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

            return Commision.Delete(id, userId);
        }
        #endregion
        #region CommisionSelect_Post
        public List<OBJ_Commision> CommisionSelect_Post(int fldId, int OrganId)
        {
            return Commision.CommisionSelect_Post(fldId, OrganId);
        }
        #endregion
    }
}