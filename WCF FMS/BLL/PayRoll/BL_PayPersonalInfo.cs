using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_PayPersonalInfo
    {
        DL_PayPersonalInfo PayPersonalInfo = new DL_PayPersonalInfo();
        #region Detail
        public OBJ_PayPersonalInfo Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return PayPersonalInfo.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_PayPersonalInfo> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return PayPersonalInfo.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int StatusId, string DateTaghirVaziyat, int? fldTarikhMazad30Sal, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (Prs_PersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل احکام ضروری است";
            }
            else if (TypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع بیمه ضروری است";
            }
            else if (ShomareBime == null || ShomareBime=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره بیمه ضروری است";
            }
            else if (CostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (InsuranceWorkShopId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارگاه بیمه ضروری است";
            }
            else if (StatusId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد وضعیت ضروری است.";
            }
            else if (DateTaghirVaziyat == null || DateTaghirVaziyat == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است.";
            }
            else if (ShomareBime.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PayPersonalInfo.CheckRepeatedRow(Prs_PersonalInfoId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شخص انتخاب شده قبلا در سیستم ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return PayPersonalInfo.Insert(Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                    , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman,StatusId,DateTaghirVaziyat, fldTarikhMazad30Sal, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int? fldTarikhMazad30Sal, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است";
            }

            else if (Prs_PersonalInfoId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل احکام ضروری است";
            }
            else if (TypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع بیمه ضروری است";
            }
            else if (ShomareBime == null || ShomareBime == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره بیمه ضروری است";
            }
            else if (CostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (InsuranceWorkShopId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارگاه بیمه ضروری است";
            }
            else if (ShomareBime.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره بیمه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PayPersonalInfo.CheckRepeatedRow(Prs_PersonalInfoId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شخص انتخاب شده قبلا در سیستم ثبت شده است.";
            }
            else if (PayPersonalInfo.CheckRepeatedField("CheckShomareBime", ShomareBime,TypeBimeId,Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره بیمه وارد شده قبلا در سیستم ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return PayPersonalInfo.Update(Id, Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                    , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman, fldTarikhMazad30Sal, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است.";
            }
            else if (PayPersonalInfo.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return PayPersonalInfo.Delete(Id, UserId);
        }
        #endregion
    }
}