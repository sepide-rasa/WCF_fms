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
    public class BL_PersonalHokm
    {
        DL_PersonalHokm PersonalHokm = new DL_PersonalHokm();
        #region Detail
        public OBJ_PersonalHokm Detail(int Id, int OrganId, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return PersonalHokm.Detail(Id, OrganId, UserId);
        }
        #endregion
        #region Select
        public List<OBJ_PersonalHokm> Select(string FieldName, string FilterValue, string FilterValue1, int OrganId, int UserId, int h)
        {
            return PersonalHokm.Select(FieldName, FilterValue, FilterValue1, OrganId, UserId, h);
        }
        #endregion
        #region Insert
        public int Insert(int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, int fldUserId, string fldDesc, byte fldHokmType, int IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldPrs_PersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (fldTarikhEjra == null || fldTarikhEjra == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (fldTarikhSodoor == null || fldTarikhSodoor == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (fldAnvaeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (fldShomarePostSazmani == null || fldShomarePostSazmani == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره پست سازمانی ضروری است";
            }
            else if (fldTypehokm == null || fldTypehokm == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (fldDescriptionHokm == null || fldDescriptionHokm == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شرح حکم ضروری است";
            }
            else if (fldCodeShoghl == null || fldCodeShoghl == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شغل ضروری است";
            }
            else if (StatusTaaholId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "وضعیت تاهل ضروری است";
            }
            else if (fldHokmType == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (!r.IsMatch(fldTarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(fldTarikhSodoor))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (fldShomarePostSazmani.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره پست سازمانی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldShomareHokm.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldCodeShoghl.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شغل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PersonalHokm.CheckRepeatedRow(fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (fldDesc == null)
                fldDesc = "";
            if (Error.ErrorType == true)
                return 0;
            return PersonalHokm.Insert(fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, fldTarikhEtmam, fldAnvaeEstekhdamId, fldGroup, fldMoreGroup
                    , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, File, Pasvand, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, fldUserId, fldDesc, fldHokmType);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, int? FileId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, int fldUserId, string fldDesc, byte fldHokmType, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldPrs_PersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل ضروری است";
            }
            else if (fldTarikhEjra == null || fldTarikhEjra == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (fldTarikhSodoor == null || fldTarikhSodoor == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ صدور ضروری است";
            }
            else if (fldAnvaeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (fldShomarePostSazmani == null || fldShomarePostSazmani == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره پست سازمانی ضروری است";
            }
            else if (fldTypehokm == null || fldTypehokm == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (fldDescriptionHokm == null || fldDescriptionHokm == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شرح حکم ضروری است";
            }
            else if (fldCodeShoghl == null || fldCodeShoghl == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شغل ضروری است";
            }
            else if (StatusTaaholId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "وضعیت تاهل ضروری است";
            }
            else if (fldHokmType == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حکم ضروری است";
            }
            else if (!r.IsMatch(fldTarikhEjra))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (!r.IsMatch(fldTarikhSodoor))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (fldShomarePostSazmani.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره پست سازمانی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldShomareHokm.Length > 100)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره حکم وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldCodeShoghl.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شغل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if(PersonalHokm.CheckUpdate(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شما مجاز به ویرایش حکم نمی باشید.";
            }
            else if (PersonalHokm.CheckRepeatedRow(fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (fldDesc == null)
                fldDesc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return PersonalHokm.Update(Id, fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, fldTarikhEtmam, fldAnvaeEstekhdamId, fldGroup, fldMoreGroup
                    , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, FileId, File, Pasvand, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, fldUserId, fldDesc, fldHokmType);
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
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return PersonalHokm.Delete(Id, UserId);
        }
        #endregion
    }
}