using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_VaziyatEsargari
    {
        DL_VaziyatEsargari VaziyatEsargari = new DL_VaziyatEsargari();

        #region Detail
        public OBJ_VaziyatEsargari Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ایثارگری ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return VaziyatEsargari.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_VaziyatEsargari> Select(string FieldName, string FilterValue, int h)
        {
            return VaziyatEsargari.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = VaziyatEsargari.Select("fldTitle", fldTitle, 0).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                if (fldTitle == "")
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "عنوان وضعیت ایثارگری ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return VaziyatEsargari.Insert(fldTitle, fldMoafAsBime, fldMoafAsMaliyat,fldMoafAsBimeOmr, fldMoafAsBimeTakmili, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = VaziyatEsargari.Select("fldTitle", fldTitle, 0).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                if (fldTitle == "")
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "عنوان وضعیت ایثارگری ضروری است";
                }
                else if (fldTitle.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldTitle.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return VaziyatEsargari.Update(fldId, fldTitle, fldMoafAsBime, fldMoafAsMaliyat,fldMoafAsBimeOmr, fldMoafAsBimeTakmili, userId, Desc);

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
                error.ErrorMsg = "کد وضعیت ایثارگری ضروری است";
            }
            else if (VaziyatEsargari.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return VaziyatEsargari.Delete(id, userId);
        }
        #endregion
    }
}