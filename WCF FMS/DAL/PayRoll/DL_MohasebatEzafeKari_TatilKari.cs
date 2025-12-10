using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MohasebatEzafeKari_TatilKari
    {
        #region Detail
        public OBJ_MohasebatEzafeKari_TatilKari Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebatEzafeKari_TatilKariSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_MohasebatEzafeKari_TatilKari()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeSakht = q.fldBimeSakht,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTedad = q.fldTedad,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MohasebatEzafeKari_TatilKari> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMohasebatEzafeKari_TatilKariSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_MohasebatEzafeKari_TatilKari()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldBimeSakht = q.fldBimeSakht,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldDarsadBimeSakht = q.fldDarsadBimeSakht,
                        fldKhalesPardakhti = q.fldKhalesPardakhti,
                        fldMablagh = q.fldMablagh,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMonth = q.fldMonth,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldTedad = q.fldTedad,
                        fldType = q.fldType,
                        fldTypeName = q.fldTypeName,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int OrganId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebatEzafeKari_TatilKariInsert(PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                    , DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat, FiscalHeaderId, MoteghayerHoghoghiId, UserId, OrganId, Desc, HesabTypeId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int CostCenterId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebatEzafeKari_TatilKariUpdate(Id, PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                    , DarsadBimeSakht, MashmolBime, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat,CostCenterId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMohasebatEzafeKari_TatilKariDelete(Id, UserId);
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
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckEzafe_TatilKariId", Id.ToString(), 0, 0).Any();
                return q;
            }
        }
        #endregion
    }
}