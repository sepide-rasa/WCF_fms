using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Mohasebat_Mamuriyat
    {
        #region Detail
        public OBJ_Mohasebat_Mamuriyat Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_MamuriyatSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Mohasebat_Mamuriyat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeSakht = q.fldBimeSakht,
                        fldDarsadBimeBiKari = q.fldDarsadBimeBiKari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTashilat = q.fldTashilat,
                        fldTedadBaBeytute = q.fldTedadBaBeytute,
                        fldTedadBedunBeytute = q.fldTedadBedunBeytute,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Mamuriyat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebat_MamuriyatSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Mohasebat_Mamuriyat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeSakht = q.fldBimeSakht,
                        fldDarsadBimeBiKari = q.fldDarsadBimeBiKari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTashilat = q.fldTashilat,
                        fldTedadBaBeytute = q.fldTedadBaBeytute,
                        fldTedadBedunBeytute = q.fldTedadBedunBeytute,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MamuriyatInsert(PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                    , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht, FiscalHeaderId, MoteghayerHoghoghiId, UserId, OrganId, Desc, HesabTypeId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht,int CostCenterId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MamuriyatUpdate(Id, PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                    , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht,CostCenterId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebat_MamuriyatDelete(Id, UserId);
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
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckMamuriyatId", Id.ToString(),0, 0).Any();
                return q;
            }
        }
        #endregion
    }
}