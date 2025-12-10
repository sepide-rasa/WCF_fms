using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MahdoodiyatMohasebat
    {
        DL_MahdoodiyatMohasebat MahdoodiyatMohasebat = new DL_MahdoodiyatMohasebat();

        #region Detail
        public OBJ_MahdoodiyatMohasebat Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MahdoodiyatMohasebat.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat> Select(string FieldName, string FilterValue, int h)
        {
            return MahdoodiyatMohasebat.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(string Title, string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, int userId, string Desc, out ClsError error)
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
            else if (AzTarikh == "" || AzTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (Tatarikh == "" || Tatarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(Tatarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(Tatarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return 0;

            return MahdoodiyatMohasebat.Insert(Title, AzTarikh, Tatarikh, NoeKarbar, NoeCodeDaramad, NoeAshkhas, Status, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, int userId, string Desc, out ClsError error)
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
            else if (AzTarikh == "" || AzTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (Tatarikh == "" || Tatarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(AzTarikh) || !r.IsMatch(Tatarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(Tatarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat.Update(Id, Title, AzTarikh, Tatarikh, NoeKarbar, NoeCodeDaramad, NoeAshkhas, Status, userId, Desc);

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
            /*else if (MahdoodiyatMohasebat.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }*/
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat.Delete(id, userId);
        }
        #endregion
        #region CheckMahdoodiyatMohasebat
        public bool CheckMahdoodiyatMohasebat(string Tarikh, int AshkhasId, int ShomareHesabDaramad, int UserId)
        {
            return MahdoodiyatMohasebat.CheckMahdoodiyatMohasebat(Tarikh, AshkhasId, ShomareHesabDaramad, UserId);
        }
        #endregion
    }
}