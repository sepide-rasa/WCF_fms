using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Setting
    {
        DL_Setting Setting = new DL_Setting();
        #region Update
        public string Update(int Id, int? H_BankFixId, string H_NameShobe, string H_CodeOrgan, string H_CodeShobe, bool ShowBankLogo, int OrganId, string CodeEghtesadi, int? Prs_PersonalId,
            string CodeParvande, string CodeOrganPasAndaz, int? Sh_HesabCheckId, int? B_BankFixId, string B_NameShobe, int? B_ShomareHesabId, string B_CodeShenasaee, string CodeDastgah, int? P_BankFixId, int P_ShobeId, int UserId, string Desc, byte StatusMahalKedmatId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد تنظیمات ضروری است";
            }
            else if (H_BankFixId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بانک-حقوق ضروری است";
            }
            else if (H_NameShobe == null || H_NameShobe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام شعبه-حقوق ضروری است";
            }
            else if (H_CodeOrgan == null || H_CodeOrgan == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی-حقوق ضروری است";
            }
            else if (H_CodeShobe == null || H_CodeShobe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شعبه-حقوق ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (CodeEghtesadi == null || CodeEghtesadi == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد اقتصادی ضروری است";
            }
            else if (Prs_PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل کارگزینی ضروری است";
            }
            else if (CodeParvande == null || CodeParvande == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرونده ضروری است";
            }
            else if (CodeOrganPasAndaz == null || CodeOrganPasAndaz == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی پس انداز ضروری است";
            }
            else if (Sh_HesabCheckId ==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب چک ضروری است";
            }
            else if (B_BankFixId ==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد بانک-بازنشستگی ضروری است";
            }
            else if (B_NameShobe == null || B_NameShobe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام شعبه-بازنشستگی ضروری است";
            }
            else if (B_ShomareHesabId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب بازنشستگی ضروری است";
            }
            else if (B_CodeShenasaee == null || B_CodeShenasaee == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شناسایی بازنشستگی ضروری است";
            }
            else if (CodeDastgah == null || CodeDastgah == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد دستگاه ضروری است";
            }
            else if (H_NameShobe.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه-حقوق وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (H_NameShobe.Length > 250)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه-حقوق وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (H_CodeOrgan.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد پست سازمانی-حقوق وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (H_CodeShobe.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شعبه-حقوق وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodeEghtesadi.Length > 20)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد اقتصادی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodeParvande.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد پرونده وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodeOrganPasAndaz.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد پست سازمانی پس انداز وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (B_NameShobe.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه-بازنشستگی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (B_NameShobe.Length > 250)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام شعبه-بازنشستگی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (B_CodeShenasaee.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد شناسایی بازنشستگی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CodeDastgah.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر کد دستگاه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (StatusMahalKedmatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "وضعیت محل خدمت ضروری است. ";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Setting.Update(Id, H_BankFixId, H_NameShobe, H_CodeOrgan, H_CodeShobe, ShowBankLogo, OrganId, CodeEghtesadi, Prs_PersonalId, CodeParvande, CodeOrganPasAndaz, Sh_HesabCheckId, B_BankFixId, B_NameShobe, B_ShomareHesabId, B_CodeShenasaee, CodeDastgah, P_BankFixId, P_ShobeId, UserId, Desc, StatusMahalKedmatId );
        }
        #endregion
        #region Select
        public List<OBJ_Setting> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Setting.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}