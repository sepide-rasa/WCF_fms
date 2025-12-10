using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Chek;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.BLL.Chek
{
    public class BL_AghsatCheckAmani
    {
        DL_AghsatCheckAmani AghsatCheckAmani = new DL_AghsatCheckAmani();

        #region Detail
        public OBJ_AghsatCheckAmani Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AghsatCheckAmani.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_AghsatCheckAmani> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return AghsatCheckAmani.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId, int OrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است";
            }
            else if (Tarikh == "" || Tarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Nobat == "" || Nobat == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوبت ضروری است";
            }
            else if (CheckHayeVaredeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چکهای وارده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AghsatCheckAmani.Insert(Mablagh, Tarikh, Nobat, CheckHayeVaredeId,OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId, int OrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است";
            }
            else if (Tarikh == "" || Tarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(Tarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Nobat == "" || Nobat == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوبت ضروری است";
            }
            else if (CheckHayeVaredeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چکهای وارده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AghsatCheckAmani.Update(Id, Mablagh, Tarikh, Nobat, CheckHayeVaredeId,OrganId, userId, Desc);

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
            else if (AghsatCheckAmani.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AghsatCheckAmani.Delete(id, userId);
        }
        #endregion
        #region UpdateStatusAghsat
        public string UpdateStatusAghsat(int Id, string TarikhPardakht, byte Vaziat, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (TarikhPardakht == "" || TarikhPardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (!r.IsMatch(TarikhPardakht))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AghsatCheckAmani.UpdateStatusAghsat(Id, TarikhPardakht, Vaziat, userId);

        }
        #endregion
        #region Delete_CheckHayeVaredeId
        public string Delete_CheckHayeVaredeId(int ChekVardeId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ChekVardeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AghsatCheckAmani.Delete_CheckHayeVaredeId(ChekVardeId, userId);
        }
        #endregion
    }
}