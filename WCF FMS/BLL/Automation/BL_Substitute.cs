using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Substitute
    {
        DL_Substitute Substitute = new DL_Substitute();

        #region Detail
        public OBJ_Substitute Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Substitute.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Substitute> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Substitute.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSenderComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تفویض دهنده ضروری است";
            }
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تفویض گیرنده ضروری است";
            }
            else if (fldStartDate == "" || fldStartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldEndDate == "" || fldEndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(fldStartDate) || !r.IsMatch(fldEndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(fldEndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(fldStartDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Substitute.Insert(fldSenderComisionID, fldReceiverComisionID, fldStartDate, fldEndDate,fldStartTime,fldEndTime,fldIsSigner,fldShowReceiverName, UserId, Desc, IP,OrganID);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldSenderComisionID, int fldReceiverComisionID, string fldStartDate, string fldEndDate, string fldStartTime, string fldEndTime, bool fldIsSigner, bool fldShowReceiverName, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSenderComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تفویض دهنده ضروری است";
            }
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تفویض گیرنده ضروری است";
            }
            else if (fldStartDate == "" || fldStartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldEndDate == "" || fldEndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(fldStartDate) || !r.IsMatch(fldEndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(fldEndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(fldStartDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Substitute.Update(Id, fldSenderComisionID, fldReceiverComisionID, fldStartDate, fldEndDate, fldStartTime, fldEndTime, fldIsSigner, fldShowReceiverName, UserId, Desc, IP, OrganID);

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

            return Substitute.Delete(id, userId);
        }
        #endregion
    }
}