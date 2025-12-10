using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_TanzimateDaramad
    {
        #region Detail
        public OBJ_TanzimateDaramad Detail(int Id,int FiscalYearId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTanzimateDaramadSelect("fldId", Id.ToString(),FiscalYearId, 1)
                    .Select(q => new OBJ_TanzimateDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAvarezId = q.fldAvarezId,
                        fldMablaghGerdKardan = q.fldMablaghGerdKardan,
                        fldMaliyatId = q.fldMaliyatId,
                        fldOrganId = q.fldOrganId,
                        fldTakhirId = q.fldTakhirId,
                        fldTitle_CodeAvarez = q.fldTitle_CodeAvarez,
                        fldTitle_CodeMaliyat = q.fldTitle_CodeMaliyat,
                        fldTitle_CodeTakhir = q.fldTitle_CodeTakhir,
                        fldNerkh = q.fldNerkh,
                        fldChapShenaseGhabz_Pardakht = q.fldChapShenaseGhabz_Pardakht,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldBankName = q.fldBankName,
                        fldNameShobe = q.fldNameShobe,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldOrganName = q.fldOrganName,
                        fldAddressOrgan = q.fldAddressOrgan,
                        fldShomareHesabIdPishfarz = q.fldShomareHesabIdPishfarz,
                        fldShomareHesab = q.fldShomareHesab,
                        fldFormul = q.fldFormul,
                        fldSumMaliyat_Avarez=q.fldSumMaliyat_Avarez
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TanzimateDaramad> Select(string FieldName, string FilterValue,int FiscalYearId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblTanzimateDaramadSelect(FieldName, FilterValue, FiscalYearId, h)
                    .Select(q => new OBJ_TanzimateDaramad()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAvarezId = q.fldAvarezId,
                        fldMablaghGerdKardan = q.fldMablaghGerdKardan,
                        fldMaliyatId = q.fldMaliyatId,
                        fldOrganId = q.fldOrganId,
                        fldTakhirId = q.fldTakhirId,
                        fldTitle_CodeAvarez = q.fldTitle_CodeAvarez,
                        fldTitle_CodeMaliyat = q.fldTitle_CodeMaliyat,
                        fldTitle_CodeTakhir = q.fldTitle_CodeTakhir,
                        fldNerkh = q.fldNerkh,
                        fldChapShenaseGhabz_Pardakht = q.fldChapShenaseGhabz_Pardakht,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldBankName = q.fldBankName,
                        fldNameShobe = q.fldNameShobe,
                        fldCodeSHobe = q.fldCodeSHobe,
                        fldOrganName = q.fldOrganName,
                        fldAddressOrgan = q.fldAddressOrgan,
                        fldShomareHesabIdPishfarz = q.fldShomareHesabIdPishfarz,
                        fldShomareHesab = q.fldShomareHesab,
                        fldFormul = q.fldFormul,
                        fldSumMaliyat_Avarez = q.fldSumMaliyat_Avarez
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public  string Insert(int? AvarezId, int? MaliyatId, int TakhirId, int MablaghGerdKardan, int OrganId, decimal Nerkh, bool ChapShenaseGhabz_Pardakht, byte ShorooshenaseGhabz, int ShomareHesabIdPishfarz,bool SumMaliyat_Avarez, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTanzimateDaramadInsert(AvarezId, MaliyatId, TakhirId, UserId, Desc, MablaghGerdKardan, OrganId, Nerkh, ChapShenaseGhabz_Pardakht, ShorooshenaseGhabz, ShomareHesabIdPishfarz, SumMaliyat_Avarez);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int? AvarezId, int? MaliyatId, int TakhirId, int MablaghGerdKardan, int OrganId, bool ChapShenaseGhabz_Pardakht, byte ShorooshenaseGhabz, int ShomareHesabIdPishfarz,bool SumMaliyat_Avarez, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTanzimateDaramadUpdate(Id, AvarezId, MaliyatId, TakhirId, UserId, Desc, MablaghGerdKardan, OrganId, ChapShenaseGhabz_Pardakht, ShorooshenaseGhabz, ShomareHesabIdPishfarz, SumMaliyat_Avarez);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblTanzimateDaramadDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedData
        public bool CheckRepeatedData(int AvarezId, int MaliyatId, int TakhirId, int OrganId)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var query = p.spr_CheckTanzimatDaramad(AvarezId, MaliyatId, TakhirId).FirstOrDefault();
                if (query.fldOrganId != 0 && query.fldOrganId != OrganId)
                {
                    q = true;
                }
                //if (AvarezId == MaliyatId)
                //    q = true;
                if (AvarezId == TakhirId)
                    q = true;
                if (MaliyatId == TakhirId)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}