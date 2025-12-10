using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MoteghayerhayeHoghoghi
    {
        #region Detail
        public OBJ_MoteghayerhayeHoghoghi Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAnvaeEstekhdamId = q.fldAnvaeEstekhdamId,
                        fldAnvaeEstekhdamTitle = q.fldAnvaeEstekhdamTitle,
                        fldBarJastegi = q.fldBarJastegi,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeJanbazan = q.fldDarsadBimeJanbazan,
                        fldDarsadbimeKarfarma = q.fldDarsadbimeKarfarma,
                        fldDarsadBimeMashagheleZiyanAvar = q.fldDarsadBimeMashagheleZiyanAvar,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldFoghShoghl = q.fldFoghShoghl,
                        fldFoghVizhe = q.fldFoghVizhe,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarFarma = q.fldHaghDarmanKarFarma,
                        fldHaghDarmanKarmand = q.fldHaghDarmanKarmand,
                        fldHaghDarmanMazad = q.fldHaghDarmanMazad,
                        fldHaghDarmanTahteTakaffol = q.fldHaghDarmanTahteTakaffol,
                        fldHaghJazb = q.fldHaghJazb,
                        fldHoghogh = q.fldHoghogh,
                        fldMaxHaghDarman = q.fldMaxHaghDarman,
                        fldSaatKari = q.fldSaatKari,
                        fldSanavat = q.fldSanavat,
                        fldTadil = q.fldTadil,
                        fldTafavotTatbigh = q.fldTafavotTatbigh,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTarikhSodur = q.fldTarikhSodur,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeBimeName = q.fldTypeBimeName,
                        fldZaribEzafeKar = q.fldZaribEzafeKar,
                        fldZaribHoghoghiSal = q.fldZaribHoghoghiSal,
                        fldFoghTalash = q.fldFoghTalash
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAnvaeEstekhdamId = q.fldAnvaeEstekhdamId,
                        fldAnvaeEstekhdamTitle = q.fldAnvaeEstekhdamTitle,
                        fldBarJastegi = q.fldBarJastegi,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeJanbazan = q.fldDarsadBimeJanbazan,
                        fldDarsadbimeKarfarma = q.fldDarsadbimeKarfarma,
                        fldDarsadBimeMashagheleZiyanAvar = q.fldDarsadBimeMashagheleZiyanAvar,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldFoghShoghl = q.fldFoghShoghl,
                        fldFoghVizhe = q.fldFoghVizhe,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarFarma = q.fldHaghDarmanKarFarma,
                        fldHaghDarmanKarmand = q.fldHaghDarmanKarmand,
                        fldHaghDarmanMazad = q.fldHaghDarmanMazad,
                        fldHaghDarmanTahteTakaffol = q.fldHaghDarmanTahteTakaffol,
                        fldHaghJazb = q.fldHaghJazb,
                        fldHoghogh = q.fldHoghogh,
                        fldMaxHaghDarman = q.fldMaxHaghDarman,
                        fldSaatKari = q.fldSaatKari,
                        fldSanavat = q.fldSanavat,
                        fldTadil = q.fldTadil,
                        fldTafavotTatbigh = q.fldTafavotTatbigh,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTarikhSodur = q.fldTarikhSodur,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldTypeBimeName = q.fldTypeBimeName,
                        fldZaribEzafeKar = q.fldZaribEzafeKar,
                        fldZaribHoghoghiSal = q.fldZaribHoghoghiSal,
                        fldFoghTalash = q.fldFoghTalash
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, string ItemEstekhdam, bool FoghTalash, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblMoteghayerhayeHoghoghiInsert(TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma
                    , HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar, MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat, ItemEstekhdam, FoghTalash, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat,
            int HaghDarmanMazad, int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, bool FoghTalash, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghiUpdate(Id, TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma, HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar
                    , MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat, FoghTalash, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghiDelete(Id, UserId);
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
                var mohasebat = p.spr_tblMohasebat_PersonalInfoSelect("CheckMoteghayerHoghoghiId", Id.ToString(),0, 1).FirstOrDefault();
                /*var M = p.spr_Pay_tblMoteghayerhayeHoghoghi_DetailSelect("fldMoteghayerhayeHoghoghiId", Id.ToString(), 1).FirstOrDefault();*/
                if (mohasebat != null /*|| M != null*/)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMoteghayerhayeHoghoghiSelect("fldTarikhEjra", TarikhEjra, 0).Where(l => l.fldTarikhSodur == TarikhSodur && l.fldAnvaeEstekhdamId == AnvaeEstekhdamId && l.fldTypeBimeId == TypeBimeId).Any();

                }
                else
                {
                    var query = p.spr_tblMoteghayerhayeHoghoghiSelect("fldTarikhEjra", TarikhEjra, 0).Where(l => l.fldTarikhSodur == TarikhSodur && l.fldAnvaeEstekhdamId == AnvaeEstekhdamId && l.fldTypeBimeId == TypeBimeId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CopyMoteghayerhayHoghoghi
        public string CopyMoteghayerhayHoghoghi(string TarikhEjra, string TarikhSodur, int headerId, int userId, string desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_CopyMoteghayerhayHoghoghi(TarikhEjra, TarikhSodur, headerId, userId, desc);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow_Copy
        public bool CheckRepeatedRow_Copy(string TarikhEjra, string TarikhSodur, int headerId)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var m = p.spr_tblMoteghayerhayeHoghoghiSelect("fldId", headerId.ToString(), 1).FirstOrDefault();
                if (m != null)
                {
                    q = p.spr_tblMoteghayerhayeHoghoghiSelect("fldTarikhEjra", TarikhEjra, 0).Where(l => l.fldTarikhSodur == TarikhSodur && l.fldAnvaeEstekhdamId == m.fldAnvaeEstekhdamId && l.fldTypeBimeId == m.fldTypeBimeId).Any();
                }
                
            }
            return q;
        }
        #endregion

        #region moteghayerhayeHoghopghi_Zarib
        public List<OBJ_MoteghayerhayeHoghoghi> moteghayerhayeHoghopghi_Zarib(int AnvaeEstekhdamId, int TypeBimeId, string TarikhEjra)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_moteghayerhayeHoghopghi_Zarib(AnvaeEstekhdamId, TypeBimeId, TarikhEjra)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghi()
                    {
                        fldAnvaeEstekhdamId=q.fldAnvaeEstekhdamId,
                        fldBarJastegi=q.fldBarJastegi,
                        fldDarsadBimeBikari=q.fldDarsadBimeBikari,
                        fldDarsadBimeJanbazan=q.fldDarsadBimeJanbazan,
                        fldDarsadbimeKarfarma=q.fldDarsadbimeKarfarma,
                        fldDarsadBimeMashagheleZiyanAvar=q.fldDarsadBimeMashagheleZiyanAvar,
                        fldDarsadBimePersonal=q.fldDarsadBimePersonal,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldFoghShoghl=q.fldFoghShoghl,
                        fldFoghTalash=q.fldFoghTalash,
                        fldFoghVizhe=q.fldFoghVizhe,
                        fldHaghDarmanDolat=q.fldHaghDarmanDolat,
                        fldHaghDarmanKarFarma=q.fldHaghDarmanKarfarma,
                        fldHaghDarmanKarmand=q.fldHaghDarmanKarmand,
                        fldHaghDarmanMazad=q.fldHaghDarmanMazad,
                        fldHaghDarmanTahteTakaffol=q.fldHaghDarmanTahteTakaffol,
                        fldHaghJazb=q.fldHaghJazb,
                        fldHoghogh=q.fldHoghogh,
                        fldId=q.fldId,
                        fldMaxHaghDarman=q.fldMaxHaghDarman,
                        fldSaatKari=q.fldSaatKari,
                        fldSanavat=q.fldSanavat,
                        fldTadil=q.fldTadil,
                        fldTafavotTatbigh=q.fldTafavotTatbigh,
                        fldTarikhEjra=q.fldTarikhEjra,
                        fldTarikhSodur=q.fldTarikhSodur,
                        fldTypeBimeId=q.fldTypeBimeId,
                        fldUserId=q.fldUserId,
                        fldZaribEzafeKar=q.fldZaribEzafeKar,
                        fldZaribHoghoghiSal = q.fldZaribHoghoghiSal,
                        
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}