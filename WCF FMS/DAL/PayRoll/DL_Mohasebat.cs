using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat
    {
        #region Detail
        public OBJ_Mohasebat Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebatSelect("fldId", Id.ToString(),"","", OrganId, 1)
                    .Select(q => new OBJ_Mohasebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBaBeytute = q.fldBaBeytute,
                        fldBedunBeytute = q.fldBedunBeytute,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimeMashaghel = q.fldBimeMashaghel,
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeOmrKarFarma = q.fldBimeOmrKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeTakmily = q.fldBimeTakmily,
                        fldBimeTakmilyKarFarma = q.fldBimeTakmilyKarFarma,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldFlag = q.fldFlag,
                        fldGhestVam = q.fldGhestVam,
                        fldGheybat = q.fldGheybat,
                        fldHaghDarman = q.fldHaghDarman,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfFarma = q.fldHaghDarmanKarfFarma,
                        fldKarkard = q.fldKarkard,
                        fldkhalesPardakhti = q.fldkhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMogharari = q.fldMogharari,
                        fldMonth = q.fldMonth,
                        fldMosaede = q.fldMosaede,
                        fldNameMonth = q.fldNameMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPersonalId = q.fldPersonalId,
                        fldTedadEzafeKar = q.fldTedadEzafeKar,
                        fldTedadNobatKari = q.fldTedadNobatKari,
                        fldTedadTatilKar = q.fldTedadTatilKar,
                        fldYear = q.fldYear,
                        fldShift=q.fldShift,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldBankId = q.fldBankId,
                        fldMeetingCount = q.fldMeetingCount,
                        fldCalcType = q.fldCalcType,
                        fldEstelagi = q.fldEstelagi,
                        fldkhalesPardakhtiBon = q.fldkhalesPardakhtiBon,
                        fldMaliyatSum =Convert.ToInt64(q.fldMaliyatSum)
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat> Select(string FieldName, string FilterValue,string FilterValue2,string FilterValue3, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebatSelect(FieldName, FilterValue,FilterValue2,FilterValue3, OrganId, h)
                    .Select(q => new OBJ_Mohasebat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBaBeytute = q.fldBaBeytute,
                        fldBedunBeytute = q.fldBedunBeytute,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimeMashaghel = q.fldBimeMashaghel,
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeOmrKarFarma = q.fldBimeOmrKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeTakmily = q.fldBimeTakmily,
                        fldBimeTakmilyKarFarma = q.fldBimeTakmilyKarFarma,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldFlag = q.fldFlag,
                        fldGhestVam = q.fldGhestVam,
                        fldGheybat = q.fldGheybat,
                        fldHaghDarman = q.fldHaghDarman,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfFarma = q.fldHaghDarmanKarfFarma,
                        fldKarkard = q.fldKarkard,
                        fldkhalesPardakhti = q.fldkhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMogharari = q.fldMogharari,
                        fldMonth = q.fldMonth,
                        fldMosaede = q.fldMosaede,
                        fldNameMonth = q.fldNameMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPersonalId = q.fldPersonalId,
                        fldTedadEzafeKar = q.fldTedadEzafeKar,
                        fldTedadNobatKari = q.fldTedadNobatKari,
                        fldTedadTatilKar = q.fldTedadTatilKar,
                        fldYear = q.fldYear,
                        fldShift = q.fldShift,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldBankId = q.fldBankId,
                        fldMeetingCount=q.fldMeetingCount,
                        fldCalcType = q.fldCalcType,
                        fldEstelagi=q.fldEstelagi,
                        fldkhalesPardakhtiBon=q.fldkhalesPardakhtiBon,
                        fldMaliyatSum = Convert.ToInt64(q.fldMaliyatSum)
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
            int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat,
            int HaghDarman, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari,
            decimal DarsadBimeSakht, byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, bool Flag, int KhalesPardakhti
            , int Mogharari, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, int HokmId, byte T_Asli, byte T_70, byte T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? VamId, Nullable<int> TedadBime1, Nullable<int> TedadBime2, Nullable<int> TedadBime3, byte HesabTypeId, byte MaliyatType, short fldMeetingCount, byte fldCalcType, int OrganId, int fldShift,byte fldEstelagi, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id=new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblMohasebatInsert(id,PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                    , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                    , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime, fldMashmolBimeNaKhales, MashmolMaliyat, Flag, Mogharari, Maliyat
                    , FiscalHeaderId, MoteghayerHoghoghiId, HokmId, T_Asli, T_70, T_60, HamsareKarmand, Mazad30Sal, TedadBime1, TedadBime2, TedadBime3, VamId, UserId, OrganId, Desc, fldShift, HesabTypeId, MaliyatType, fldMeetingCount, fldCalcType, fldT_BedonePoshesh, fldEstelagi);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
             int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman
            , int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht,
            byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int MashmolMaliyat, bool Flag, int khalesPardakhti, int Mogharari,
            int Maliyat, int fldShift, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebatUpdate(Id, PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                    , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                    , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime, MashmolMaliyat, Flag, Mogharari, Maliyat, UserId, Desc, fldShift); 
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebatDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var Moavaghat = p.spr_tblMoavaghatSelect("fldMohasebatId", Id.ToString(), 1).FirstOrDefault();
                var M = p.spr_tblMohasebat_ItemsSelect("fldMohasebatId", Id.ToString(), 1).FirstOrDefault();
                var z = p.spr_tblMohasebat_kosorat_MotalebatParamSelect("fldMohasebatId", Id.ToString(), 1).FirstOrDefault();
                var a = p.spr_tblMohasebat_KosoratBankSelect("fldMohasebatId", Id.ToString(), 1).FirstOrDefault();
                if (Moavaghat != null || M != null || z != null || a != null)
                    q = true;
                return q;
            }
        }
        #endregion

        #region CheckMohasebat
        public List<OBJ_Mohasebat> CheckMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_CheckMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht,  OrganId)
                    .Select(q => new OBJ_Mohasebat()
                    {
                        fldId = q.fldId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DeleteMohasebat
        public string DeleteMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, string CostCenter, string AnvaeEstekhdam, int OrganId,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_DeleteMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht, OrganId,CostCenter,AnvaeEstekhdam,Convert.ToByte(CalcType));
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckShomareHesabPasAndazForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabPasAndazForMohasebat(string Year ,string Month,byte NobatPardakht,int OrganId,int PersonalId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_CheckShomareHesabPasAndazForMohasebat(Year,Month,NobatPardakht,OrganId,PersonalId)
                    .Select(q => new OBJ_CheckShomareHesabPasAndazForMohasebat()
                    {
                        fldId = q.fldId,
                        fldName_Family = q.fldName_Family,
                        fldCodemeli = q.fldCodemeli,
                        
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckConflictKarkard_Mohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckConflictKarkard_Mohasebat(short Year, byte Month, string costCenter,string anvaEstekhdam, int OrganId, int PersonalId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectConflictKarkard_Mohasebat(Year, Month,OrganId,PersonalId,costCenter,anvaEstekhdam)
                    .Select(q => new OBJ_CheckShomareHesabPasAndazForMohasebat()
                    {
                        fldName_Family = q.fldName_Family,
                        fldCodemeli = q.fldCodemeli
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckShomareHesabForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId,byte HesabType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_CheckShomareHesabForMohasebat(Year, Month, NobatPardakht, OrganId, PersonalId, HesabType)
                    .Select(q => new OBJ_CheckShomareHesabPasAndazForMohasebat()
                    {
                        fldId = q.fldId,
                        fldName_Family = q.fldName_Family,
                        fldCodemeli = q.fldCodemeli,

                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckMohasebeForDisket
        public bool CheckMohasebeForDisket(short Year, byte Month, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k= p.spr_CheckMohasebeForDisket(Year,Month, OrganId).FirstOrDefault().fldCheck;
                return Convert.ToBoolean(k);
            }
        }
        #endregion
    }
}