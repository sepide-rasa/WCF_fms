using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MohasebatEzafeKari_TatilKari
    {
        DL_MohasebatEzafeKari_TatilKari MohasebatEzafeKari_TatilKari = new DL_MohasebatEzafeKari_TatilKari();
        #region Detail
        public OBJ_MohasebatEzafeKari_TatilKari Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MohasebatEzafeKari_TatilKari.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_MohasebatEzafeKari_TatilKari> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return MohasebatEzafeKari_TatilKari.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
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
            return MohasebatEzafeKari_TatilKari.Insert(PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                    , DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat, FiscalHeaderId, MoteghayerHoghoghiId, HesabTypeId, OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int CostCenterId, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
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
            return MohasebatEzafeKari_TatilKari.Update(Id, PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                    , DarsadBimeSakht, MashmolBime, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat,CostCenterId, UserId, Desc);
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
            else if (MohasebatEzafeKari_TatilKari.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MohasebatEzafeKari_TatilKari.Delete(Id, UserId);
        }
        #endregion
    }
}