using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_Mamuriyat
    {
        DL_Mohasebat_Mamuriyat Mohasebat_Mamuriyat = new DL_Mohasebat_Mamuriyat();
        #region Detail
        public OBJ_Mohasebat_Mamuriyat Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_Mamuriyat.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Mamuriyat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Mohasebat_Mamuriyat.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int FiscalHeaderId, int MoteghayerHoghoghiId,byte HesabTypeId, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد جدول مالیاتی ضروری است";
            }
            else if (MoteghayerHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_Mamuriyat.Insert(PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                    , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht, FiscalHeaderId, MoteghayerHoghoghiId, HesabTypeId, OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int CostCenterId, int UserId, string Desc, out ClsError Error)
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

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (CostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_Mamuriyat.Update(Id, PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                    , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht, CostCenterId, UserId, Desc);
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
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (Mohasebat_Mamuriyat.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_Mamuriyat.Delete(Id, UserId);
        }
        #endregion
    }
}