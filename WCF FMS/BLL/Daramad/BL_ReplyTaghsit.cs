using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ReplyTaghsit
    {
        DL_ReplyTaghsit ReplyTaghsit = new DL_ReplyTaghsit();

        #region Detail
        public OBJ_ReplyTaghsit Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ReplyTaghsit.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ReplyTaghsit> Select(string FieldName, string FilterValue, int h)
        {
            return ReplyTaghsit.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int StatusId, byte TedadMahAghsat, int JarimeTakhir, int userId, string Desc, out ClsError error)
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
            else if (TedadAghsat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد اقساط ضروری است";
            }
            else if (TedadAghsat > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد تعداد اقساط وارده شده بیشتر از حد مجاز می باشد.";
            }  
            else if (ShomareMojavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره مجوز وارده شده بیشتر از حد مجاز می باشد.";
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
            else if (StatusId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت تقسیط-تخفیف ضروری است";
            }
            else if (TedadMahAghsat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ماه اقساط ضروری است";
            }
            else if (TedadMahAghsat > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد تعداد ماه اقساط وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReplyTaghsit.Insert(MablaghNaghdi, TedadAghsat, ShomareMojavez, Tarikh, StatusId,TedadMahAghsat,JarimeTakhir, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int StatusId, byte TedadMahAghsat, int JarimeTakhir, int userId, string Desc, out ClsError error)
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
            else if (TedadAghsat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد اقساط ضروری است";
            }
            else if (TedadAghsat > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد تعداد اقساط وارده شده بیشتر از حد مجاز می باشد.";
            } 
            else if (ShomareMojavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره مجوز وارده شده بیشتر از حد مجاز می باشد.";
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
            else if (StatusId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت تقسیط-تخفیف ضروری است";
            }
            else if (TedadMahAghsat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ماه اقساط ضروری است";
            }
            else if (TedadMahAghsat > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد تعداد ماه اقساط وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReplyTaghsit.Update(Id, MablaghNaghdi, TedadAghsat, ShomareMojavez, Tarikh, userId, StatusId, TedadMahAghsat, JarimeTakhir, Desc);

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
            else if (ReplyTaghsit.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReplyTaghsit.Delete(id, userId);
        }
        #endregion
    }
}