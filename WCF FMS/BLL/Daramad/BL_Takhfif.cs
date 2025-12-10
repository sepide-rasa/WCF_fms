using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Takhfif
    {
        DL_Takhfif Takhfif = new DL_Takhfif();

        #region Detail
        public OBJ_Takhfif Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Takhfif.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            return Takhfif.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, int userId, string Desc, out ClsError error)
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
            else if (ShomareMojavez == "" || ShomareMojavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره مجوز ضروری است";
            }
            else if (ShomareMojavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TarikhMojavez == "" || TarikhMojavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ مجوز ضروری است";
            }
            else if (AzTarikh == "" || AzTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (TaTarikh == "" || TaTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ مجوز ضروری است";
            }
            else if (!r.IsMatch(TarikhMojavez) || !r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return 0;

            return Takhfif.Insert(ShomareMojavez, TarikhMojavez, AzTarikh, TaTarikh, TakhfifKoli, TakhfifNaghdi, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, int userId, string Desc, out ClsError error)
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
            else if (ShomareMojavez == "" || ShomareMojavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره مجوز ضروری است";
            }
            else if (ShomareMojavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TarikhMojavez == "" || TarikhMojavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ مجوز ضروری است";
            }
            else if (AzTarikh == "" || AzTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "از تاریخ ضروری است";
            }
            else if (TaTarikh == "" || TaTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تا تاریخ مجوز ضروری است";
            }
            else if (!r.IsMatch(TarikhMojavez) || !r.IsMatch(AzTarikh) || !r.IsMatch(TaTarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(TaTarikh) - MyLib.Shamsi.Shamsi2miladiDateTime(AzTarikh)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Takhfif.Update(Id, ShomareMojavez, TarikhMojavez, AzTarikh, TaTarikh, TakhfifKoli, TakhfifNaghdi, userId, Desc);

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

            return Takhfif.Delete(id, userId);
        }
        #endregion
        public bool CheckTakhfif(int idElamAvarez, int ShomareHesabId, byte ShooroShenaseGhabz)
        {
            return Takhfif.CheckTakhfif(idElamAvarez,ShomareHesabId,ShooroShenaseGhabz);
        }
    }
}