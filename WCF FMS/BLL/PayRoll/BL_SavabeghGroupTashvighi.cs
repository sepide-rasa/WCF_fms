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
    public class BL_SavabeghGroupTashvighi
    {
        DL_SavabeghGroupTashvighi SavabeghGroupTashvighi = new DL_SavabeghGroupTashvighi();

        #region Detail
        public OBJ_SavabeghGroupTashvighi Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سوابق گروه تشویقی ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SavabeghGroupTashvighi.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghGroupTashvighi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return SavabeghGroupTashvighi.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldAnvaGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع گروه تشویقی ضروری است";
            }
            else if (fldPersonalId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (fldTarikh == null || fldTarikh == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(fldTarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            if (Desc == null)
                Desc = "";
            if (error.ErrorType == true)
                return "خطا";

            return SavabeghGroupTashvighi.Insert(fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldAnvaGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع گروه تشویقی ضروری است";
            }
            else if (fldPersonalId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (fldTarikh == null || fldTarikh == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(fldTarikh))
            {
                //DateTime Result;
                //bool valid = DateTime.TryParseExact(Tarikh, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Result);
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید.";
            }
            if (Desc == null)
                Desc = "";
            if (error.ErrorType == true)
                return "خطا";

            return SavabeghGroupTashvighi.Update(fldId, fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, userId, Desc);

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
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سوابق گروه تشویقی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SavabeghGroupTashvighi.Delete(id, userId);
        }
        #endregion
    }
}