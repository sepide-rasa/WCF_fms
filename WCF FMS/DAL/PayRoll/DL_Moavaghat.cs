using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Moavaghat
    {
        #region Detail
        public OBJ_Moavaghat Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoavaghatSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Moavaghat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimeMashaghel = q.fldBimeMashaghel,
                        fldBimePersonal = q.fldBimePersonal,
                        fldHaghDarman = q.fldHaghDarman,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfFarma = q.fldHaghDarmanKarfFarma,
                        fldkhalesPardakhti = q.fldkhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMohasebatId = q.fldMohasebatId,
                        fldMonth = q.fldMonth,
                        fldPasAndaz = q.fldPasAndaz,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Moavaghat> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoavaghatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Moavaghat()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimeMashaghel = q.fldBimeMashaghel,
                        fldBimePersonal = q.fldBimePersonal,
                        fldHaghDarman = q.fldHaghDarman,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfFarma = q.fldHaghDarmanKarfFarma,
                        fldkhalesPardakhti = q.fldkhalesPardakhti,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        fldMohasebatId = q.fldMohasebatId,
                        fldMonth = q.fldMonth,
                        fldPasAndaz = q.fldPasAndaz,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime,int fldMashmolBimeNaKhales, int MashmolMaliyat,  int Maliyat,int? HokmId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblMoavaghatInsert(Id, MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                    , BimeMashaghel, PasAndaz, MashmolBime, fldMashmolBimeNaKhales, MashmolMaliyat, Maliyat,HokmId, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int MashmolMaliyat, int Maliyat, int? HokmId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoavaghatUpdate(Id, MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                    , BimeMashaghel, PasAndaz, MashmolBime, MashmolMaliyat, Maliyat,HokmId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoavaghatDelete(Id, UserId);
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
                q = p.spr_tblMoavaghat_ItemsSelect("fldMoavaghatId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion
    }
}