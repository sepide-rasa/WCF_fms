using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MohasebatForConvert
    {
        DL_MohasebatForConvert MohasebatForConvert = new DL_MohasebatForConvert();
        #region Insert
        public int Insert(OBJ_Mohasebat Mohasebat, OBJ_Mohasebat_PersonalInfo Mohasebat_PersonalInfo, int ChartOrganId, int fldShift, int fldUserId, out ClsError Error)
        {
            Error = new ClsError();
            if (fldUserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (Mohasebat.fldPersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldVamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد وام ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldCostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldInsuranceWorkShopId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارگاه بیمه ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldTypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع بیمه ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldAnvaEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldFiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد جدول مالیات ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldMoteghayerHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldShomareHesabId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldStatusIsargariId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "وضعیت ایثارگری ضروری است";
            }
            else if (Mohasebat_PersonalInfo.fldOrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ارگان ضروری است";
            }
            
            if (Mohasebat.fldDesc == null)
                Mohasebat.fldDesc = "";
            if (Error.ErrorType == true)
                return 0;
            return MohasebatForConvert.Insert(Mohasebat, Mohasebat_PersonalInfo, ChartOrganId, fldShift, fldUserId);
        }
        #endregion
    }
}