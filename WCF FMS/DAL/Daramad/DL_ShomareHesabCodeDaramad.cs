using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ShomareHesabCodeDaramad
    {
        #region Detail
        public OBJ_ShomareHesabCodeDaramad Detail(int Id, int FiscalYearId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblShomareHesabCodeDaramadSelect("fldId", Id.ToString(),"",FiscalYearId, 1)
                    .Select(q => new OBJ_ShomareHesabCodeDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldShomareHesadId = q.fldShomareHesadId,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldFormolsaz = q.fldFormolsaz,
                        fldFormulKoliId = q.fldFormulKoliId,
                        fldFormulMohasebatId = q.fldFormulMohasebatId,
                        fldReportFileId = q.fldReportFileId,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldUnitId = q.fldUnitId,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldNameVahed = q.fldNameVahed,
                        fldSharhCodDaramd = q.fldSharhCodDaramd,
                        fldShomareHesab = q.fldShomareHesab,
                        fldStatus = q.fldStatus,
                        fldAmuzeshParvaresh=q.fldAmuzeshParvaresh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabCodeDaramad> Select(string FieldName, string FilterValue, string FilterValue1,int FiscalYearId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblShomareHesabCodeDaramadSelect(FieldName, FilterValue, FilterValue1,FiscalYearId, h)
                    .Select(q => new OBJ_ShomareHesabCodeDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldShomareHesadId = q.fldShomareHesadId,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldFormolsaz = q.fldFormolsaz,
                        fldFormulKoliId = q.fldFormulKoliId,
                        fldFormulMohasebatId = q.fldFormulMohasebatId,
                        fldReportFileId = q.fldReportFileId,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldUnitId = q.fldUnitId,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldNameVahed = q.fldNameVahed,
                        fldSharhCodDaramd = q.fldSharhCodDaramd,
                        fldShomareHesab = q.fldShomareHesab,
                        fldStatus = q.fldStatus,
                        fldAmuzeshParvaresh = q.fldAmuzeshParvaresh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesadId, int CodeDaramadId, int OrganId, byte ShorooshenaseGhabz, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareHesabCodeDaramadInsert(ShomareHesadId, CodeDaramadId, OrganId, UserId, Desc, ShorooshenaseGhabz);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesadId, int CodeDaramadId, int OrganId, byte ShorooshenaseGhabz, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareHesabCodeDaramadUpdate(Id, ShomareHesadId, CodeDaramadId, OrganId, UserId, Desc, ShorooshenaseGhabz);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblShomareHesabCodeDaramadDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ShomareHesadId, int CodeDaramadId, int OrganId, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblShomareHesabCodeDaramadSelect("fldCodeDaramadId", CodeDaramadId.ToString(),"",0, 0).Where(l => l.fldShomareHesadId == ShomareHesadId && l.fldOrganId == OrganId).Any();

                }
                else
                {
                    var query = p.spr_tblShomareHesabCodeDaramadSelect("fldCodeDaramadId", CodeDaramadId.ToString(),"",0, 0).Where(l => l.fldShomareHesadId == ShomareHesadId && l.fldOrganId == OrganId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var ParametreS = m.spr_tblParametreSabetSelect("fldShomareHesabCodeDaramadId", Id.ToString(), "", 0).FirstOrDefault();
                var c = m.spr_tblCodhayeDaramadiElamAvarezSelect("fldShomareHesabCodeDaramadId", Id.ToString(), 0).FirstOrDefault();
                var letter = m.spr_tblLetterMinutSelect("fldShomareHesabCodeDaramadId", Id.ToString(), 1).FirstOrDefault();
                var ronevesht = m.spr_tblRooneveshtSelect("fldShomareHesabCodeDaramadId", Id.ToString(), 0).FirstOrDefault();
                //var t = m.spr_tblTanzimateDaramadSelect("fldTakhirId", Id.ToString(), 0).FirstOrDefault();
                //var t1 = m.spr_tblTanzimateDaramadSelect("fldMaliyatId", Id.ToString(), 0).FirstOrDefault();
                //var t2 = m.spr_tblTanzimateDaramadSelect("fldAvarezId", Id.ToString(), 0).FirstOrDefault();
                var Mahdodiyat = m.spr_tblMahdoodiyatMohasebat_ShomareHesabDaramadSelect("fldShomarehesabDarmadId", Id.ToString(), 0).FirstOrDefault();
                var ParametrH = m.spr_tblParametrHesabdariSelect("fldShomareHesabCodeDaramadId", Id.ToString(), 0).FirstOrDefault();
                if (ParametreS != null || c != null || letter != null || ronevesht != null /*|| t != null || t1 != null || t2 != null*/ || Mahdodiyat != null||ParametrH!=null)
                    q = true;
            }
            return q;
        }
        #endregion
        #region UpdateSharhecodeDaramd
        public string UpdateSharhecodeDaramd(int Id, string SharhCodeDaramad, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateSharhecodeDaramd(Id, SharhCodeDaramad, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateStatus_CodeDaramad
        public string UpdateStatus_CodeDaramad(int Id, bool Status, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateStatus_CodeDaramad(Id, Status, UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}