using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MaliyatArzesheAfzoode
    {
        DL_MaliyatArzesheAfzoode MaliyatArzesheAfzoode = new DL_MaliyatArzesheAfzoode();

        #region Detail
        public OBJ_MaliyatArzesheAfzoode Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MaliyatArzesheAfzoode.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MaliyatArzesheAfzoode> Select(string FieldName, string FilterValue, int h)
        {
            return MaliyatArzesheAfzoode.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, int userId, string Desc, out ClsError error)
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
            else if (FromDate == "" || FromDate==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (EndDate == "" || EndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(FromDate) || !r.IsMatch(EndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(FromDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (DarsadeAvarez > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد عوارض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DarsadeMaliyat > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد مالیات وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MaliyatArzesheAfzoode.CheckDate(FromDate, EndDate,0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "بازه انتخاب شده با اطلاعات از پیش ثبت شده تداخل زمانی دارد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MaliyatArzesheAfzoode.Insert(FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, int userId, string Desc, out ClsError error)
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
            else if (FromDate == "" || FromDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (EndDate == "" || EndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (!r.IsMatch(FromDate) || !r.IsMatch(EndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndDate) - MyLib.Shamsi.Shamsi2miladiDateTime(FromDate)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (DarsadeAvarez > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد عوارض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DarsadeMaliyat > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد مالیات وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MaliyatArzesheAfzoode.CheckDate(FromDate, EndDate,Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "بازه انتخاب شده با اطلاعات از پیش ثبت شده تداخل زمانی دارد. ";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MaliyatArzesheAfzoode.Update(Id, FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, userId, Desc);

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

            return MaliyatArzesheAfzoode.Delete(id, userId);
        }
        #endregion
    }
}