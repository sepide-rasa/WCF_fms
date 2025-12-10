using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MoteghayerhayeHoghoghi_Detail
    {
        #region Detail
        public OBJ_MoteghayerhayeHoghoghi_Detail Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghi_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghi_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeJanbazan = q.fldDarsadBimeJanbazan,
                        fldDarsadbimeKarfarma = q.fldDarsadbimeKarfarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfarma = q.fldHaghDarmanKarfarma,
                        fldHaghDarmanKarmand = q.fldHaghDarmanKarmand,
                        fldHaghDarmanMazad = q.fldHaghDarmanMazad,
                        fldHaghDarmanTahteTakaffol = q.fldHaghDarmanTahteTakaffol,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMoteghayerhayeHoghoghiId = q.fldMoteghayerhayeHoghoghiId,
                        fldSaatKari = q.fldSaatKari,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTarikhSodur = q.fldTarikhSodur,
                        fldTitle = q.fldTitle,
                        fldZaribEzafeKar = q.fldZaribEzafeKar
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghi_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeHoghoghi_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MoteghayerhayeHoghoghi_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadBimeBikari = q.fldDarsadBimeBikari,
                        fldDarsadBimeJanbazan = q.fldDarsadBimeJanbazan,
                        fldDarsadbimeKarfarma = q.fldDarsadbimeKarfarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldHaghDarmanDolat = q.fldHaghDarmanDolat,
                        fldHaghDarmanKarfarma = q.fldHaghDarmanKarfarma,
                        fldHaghDarmanKarmand = q.fldHaghDarmanKarmand,
                        fldHaghDarmanMazad = q.fldHaghDarmanMazad,
                        fldHaghDarmanTahteTakaffol = q.fldHaghDarmanTahteTakaffol,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldMoteghayerhayeHoghoghiId = q.fldMoteghayerhayeHoghoghiId,
                        fldSaatKari = q.fldSaatKari,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTarikhSodur = q.fldTarikhSodur,
                        fldTitle = q.fldTitle,
                        fldZaribEzafeKar = q.fldZaribEzafeKar,
                        fldMazayaMashmool = q.fldMazayaMashmool
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MoteghayerhayeHoghoghiId, int ItemEstekhdamId,bool fldMazayaMashmool , int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghi_DetailInsert(MoteghayerhayeHoghoghiId, ItemEstekhdamId,fldMazayaMashmool, UserId, Desc);
                return "ذخیره با موفقیت انجام شد."; 
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghi_DetailUpdate(Id, MoteghayerhayeHoghoghiId, ItemEstekhdamId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeHoghoghi_DetailDelete(FieldName, Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}