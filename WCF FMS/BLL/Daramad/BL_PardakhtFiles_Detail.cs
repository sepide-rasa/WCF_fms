using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PardakhtFiles_Detail
    {
        DL_PardakhtFiles_Detail PardakhtFiles_Detail = new DL_PardakhtFiles_Detail();

        #region Detail
        public OBJ_PardakhtFiles_Detail Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PardakhtFiles_Detail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFiles_Detail> Select(string FieldName, string FilterValue, string OrganId, string AzTarikh, string TaTarikh, int h)
        {
            return PardakhtFiles_Detail.Select(FieldName, FilterValue, OrganId, AzTarikh, TaTarikh, h);
        }
        #endregion
        #region Insert
        public string Insert(string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int PardakhtFileId, int OrganId, string CodePardakht, int userId, string Desc, out ClsError error)
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
            else if (ShenaseGhabz == "" || ShenaseGhabz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه قبض ضروری است";
            }
            else if (ShenaseGhabz.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenaseGhabz.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShenasePardakht == "" || ShenaseGhabz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه پرداخت ضروری است";
            }
            else if (ShenasePardakht.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenasePardakht.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(TarikhPardakht))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (TarikhPardakht == "" || TarikhPardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (CodeRahgiry == "" || CodeRahgiry == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد رهگیری ضروری است";
            }
            else if (CodeRahgiry.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کد رهگیری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (CodeRahgiry.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد رهگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PardakhtFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرداخت فایل ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (CodePardakht.Length > 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد پرداخت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodePardakht == "" || CodePardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرداخت ضروری است";
            }
            else if (PardakhtFiles_Detail.CheckRepeatedRow(ShenaseGhabz, ShenasePardakht, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFiles_Detail.Insert(ShenaseGhabz, ShenasePardakht, TarikhPardakht, CodeRahgiry, PardakhtFileId, OrganId, CodePardakht, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int NahvePardakhtId, int PardakhtFileId, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (ShenaseGhabz == "" || ShenaseGhabz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه قبض ضروری است";
            }
            else if (ShenaseGhabz.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenaseGhabz.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShenasePardakht == "" || ShenaseGhabz == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه پرداخت ضروری است";
            }
            else if (ShenasePardakht.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenasePardakht.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (!r.IsMatch(TarikhPardakht))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (TarikhPardakht == "" || TarikhPardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پرداخت ضروری است";
            }
            else if (CodeRahgiry == "" || CodeRahgiry == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد رهگیری ضروری است";
            }
            else if (CodeRahgiry.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کد رهگیری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (CodeRahgiry.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد رهگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NahvePardakhtId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نحوه پرداخت ضروری است";
            }
            else if (PardakhtFileId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پرداخت فایل ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (PardakhtFiles_Detail.CheckRepeatedRow(ShenaseGhabz, ShenasePardakht, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PardakhtFiles_Detail.Update(Id, ShenaseGhabz, ShenasePardakht, TarikhPardakht, CodeRahgiry, NahvePardakhtId, PardakhtFileId, OrganId, userId, Desc);

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

            return PardakhtFiles_Detail.Delete(id, userId);
        }
        #endregion
    }
}