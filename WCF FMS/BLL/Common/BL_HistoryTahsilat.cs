using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;
namespace WCF_FMS.BLL.Common
{
    public class BL_HistoryTahsilat
    {
        DL_HistoryTahsilat HistoryTahsilat = new DL_HistoryTahsilat();
        #region Detail
        public OBJ_HistoryTahsilat Detail(int Id,  out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه تاریخچه تحصیلات ضروری است";
            }
            return HistoryTahsilat.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_HistoryTahsilat> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return HistoryTahsilat.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldEmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شخص ضروری است";
            }
            else if (fldMadrakId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مدرک ضروری است";
            }
            else if (fldReshteId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد رشته ضروری است";
            }
            else if (fldTarikh == null || fldTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(fldTarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!HistoryTahsilat.ValidDateMadrak(fldEmployeeId,fldMadrakId.ToString(),fldReshteId,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات تحصیلی تکراری است";
            }
            else if (!HistoryTahsilat.ValidDateTarikh(fldEmployeeId, fldTarikh,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده تکراری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return HistoryTahsilat.Insert(fldEmployeeId, fldMadrakId,fldReshteId, fldTarikh, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "کد تاریخچه تحصیلات ضروری است";
            }
            else if (fldEmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شخص ضروری است";
            }
            else if (fldMadrakId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مدرک ضروری است";
            }
            else if (fldReshteId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد رشته ضروری است";
            }
            else if (fldTarikh == null || fldTarikh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(fldTarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            else if (!HistoryTahsilat.ValidDateMadrak(fldEmployeeId, fldMadrakId.ToString(), fldReshteId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات تحصیلی تکراری است";
            }
            else if (!HistoryTahsilat.ValidDateTarikh(fldEmployeeId, fldTarikh, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return HistoryTahsilat.Update(Id, fldEmployeeId, fldMadrakId, fldReshteId, fldTarikh, Desc, UserId);
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
                Error.ErrorMsg = "شناسه تاریخچه نوع استخدام ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return HistoryTahsilat.Delete(Id, UserId);
        }
        #endregion
    }
}