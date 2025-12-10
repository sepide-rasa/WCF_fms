using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ReplyTakhfif
    {
        DL_ReplyTakhfif ReplyTakhfif = new DL_ReplyTakhfif();

        #region Detail
        public OBJ_ReplyTakhfif Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ReplyTakhfif.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ReplyTakhfif> Select(string FieldName, string FilterValue, int h)
        {
            return ReplyTakhfif.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, int userId, string Desc, out ClsError error)
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
            else if (Darsad > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد تخفیف وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Darsad < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد تخفیف وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (ShomareMajavez == "" || ShomareMajavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره مجوز ضروری است";
            }
            else if (ShomareMajavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره مجوز وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(Tarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Tarikh == "" || Tarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (StatusId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت تقسیط-تخفیف ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReplyTakhfif.Insert(Darsad, Mablagh, ShomareMajavez, Tarikh,StatusId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, int userId, string Desc, out ClsError error)
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
            else if (Darsad > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد تخفیف وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Darsad < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد تخفیف وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (ShomareMajavez == "" || ShomareMajavez == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره مجوز ضروری است";
            }
            else if (ShomareMajavez.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره مجوز وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(Tarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Tarikh == "" || Tarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }
            else if (StatusId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت تقسیط-تخفیف ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReplyTakhfif.Update(Id, Darsad, Mablagh, ShomareMajavez, Tarikh,StatusId, userId, Desc);

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

            return ReplyTakhfif.Delete(id, userId);
        }
        #endregion
    }
}