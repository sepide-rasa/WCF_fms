using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MoteghayerhayeEydi
    {
        #region Detail
        public OBJ_MoteghayerhayeEydi Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeEydiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_MoteghayerhayeEydi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadMaliyatKargar = q.fldDarsadMaliyatKargar,
                        fldDarsadMaliyatKarmand = q.fldDarsadMaliyatKarmand,
                        fldMablaghMoafiatKargar = q.fldMablaghMoafiatKargar,
                        fldMablaghMoafiatKarmand = q.fldMablaghMoafiatKarmand,
                        fldMaxEydiKargar = q.fldMaxEydiKargar,
                        fldMaxEydiKarmand = q.fldMaxEydiKarmand,
                        fldTypeMohasebatMaliyat = q.fldTypeMohasebatMaliyat,
                        fldTypeMohasebatMaliyatName = q.fldTypeMohasebatMaliyatName,
                        fldTypeMohasebe = q.fldTypeMohasebe,
                        fldTypeMohasebeName = q.fldTypeMohasebeName,
                        fldYear = q.fldYear,
                        fldZaribEydiKargari = q.fldZaribEydiKargari
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeEydi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMoteghayerhayeEydiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MoteghayerhayeEydi()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadMaliyatKargar = q.fldDarsadMaliyatKargar,
                        fldDarsadMaliyatKarmand = q.fldDarsadMaliyatKarmand,
                        fldMablaghMoafiatKargar = q.fldMablaghMoafiatKargar,
                        fldMablaghMoafiatKarmand = q.fldMablaghMoafiatKarmand,
                        fldMaxEydiKargar = q.fldMaxEydiKargar,
                        fldMaxEydiKarmand = q.fldMaxEydiKarmand,
                        fldTypeMohasebatMaliyat = q.fldTypeMohasebatMaliyat,
                        fldTypeMohasebatMaliyatName = q.fldTypeMohasebatMaliyatName,
                        fldTypeMohasebe = q.fldTypeMohasebe,
                        fldTypeMohasebeName = q.fldTypeMohasebeName,
                        fldYear = q.fldYear,
                        fldZaribEydiKargari = q.fldZaribEydiKargari
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeEydiInsert(Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeEydiUpdate(Id, Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMoteghayerhayeEydiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(short Year, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMoteghayerhayeEydiSelect("fldYear", Year.ToString(), 0).Any();

                }
                else
                {
                    var query = p.spr_tblMoteghayerhayeEydiSelect("fldYear", Year.ToString(), 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}