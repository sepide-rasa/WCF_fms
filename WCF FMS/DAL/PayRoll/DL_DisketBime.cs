using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DisketBime
    {
        #region Select
        public List<OBJ_DisketBime> Select(short sal, byte mah, int kargaBime, byte nobat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBime(sal, mah, kargaBime, nobat)
                    .Select(q => new OBJ_DisketBime()
                    {
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldCodemeli = q.fldCodemeli,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldItem = q.fldItem,
                        fldJobDesc = q.fldJobDesc,
                        fldJobeCode = q.fldJobeCode,
                        fldKarkard = q.fldKarkard,
                        fldMashmolBime = q.fldMashmolBime,
                        fldName = q.fldName,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldShomareBime = q.fldShomareBime,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        KargariMahane = q.KargariMahane,
                        KarmandiMahane =Convert.ToInt64( q.KarmandiMahane),
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldMeliyat = q.fldMeliyat,
                        fldJensiyat = q.fldJensiyat,
                        NameSodoor = q.NameSodoor,
                        fldSh_Personali = q.fldSh_Personali,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldPayeSanavati=q.fldPayeSanavati,
                        fldTaahol=q.fldTaahol
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectDisketBimeSum
        public List<OBJ_DisketBimeSum> SelectDisketBimeSum(short sal, byte mah, int kargaBime, byte nobat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBimeSum(sal, mah, kargaBime, nobat)
                    .Select(q => new OBJ_DisketBimeSum()
                    {
                        fldBimeBikari=q.fldBimeBikari,
                        fldBimeKarFarma=q.fldBimeKarFarma,
                        fldBimePersonal=q.fldBimePersonal,
                        fldItem=q.fldItem,
                        fldJBime=q.fldJBime,
                        fldMan=q.fldMan,
                        fldMashmolBime=q.fldMashmolBime,
                        fldWomen=q.fldWomen,
                        fldWorkShopName=q.fldWorkShopName,
                        fldWorkShopNum=q.fldWorkShopNum
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region SelectBASTAM
        public List<OBJ_DisketBime> SelectBASTAM(short sal, byte mah, int kargaBime, byte nobat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBimeBASTAM(sal, mah, kargaBime, nobat)
                    .Select(q => new OBJ_DisketBime()
                    {
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldCodemeli = q.fldCodemeli,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldItem = q.fldItem,
                        fldJobDesc = q.fldJobDesc,
                        fldJobeCode = q.fldJobeCode,
                        fldKarkard = q.fldKarkard,
                        fldMashmolBime = q.fldMashmolBime,
                        fldName = q.fldName,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldShomareBime = q.fldShomareBime,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        KargariMahane = q.KargariMahane,
                        KarmandiMahane = q.KarmandiMahane,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        fldMeliyat = q.fldMeliyat,
                        fldJensiyat = q.fldJensiyat,
                        NameSodoor = q.NameSodoor,
                        fldSh_Personali = q.fldSh_Personali,
                        fldDarsadBimeKarFarma = q.fldDarsadBimeKarFarma,
                        fldDarsadBimePersonal = q.fldDarsadBimePersonal,
                        fldPayeSanavati = q.fldPayeSanavati,
                        fldTaahol = q.fldTaahol
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectDisketBime_DBF
        public List<OBJ_DisketBime_DBF> SelectDisketBime_DBF(short sal, byte mah, int kargaBime, byte nobat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBime_DBF(sal, mah, kargaBime, nobat)
                    .Select(q => new OBJ_DisketBime_DBF()
                    {
                        Dsw_ID=q.Dsw_ID,
                        Dsw_EDate=q.Dsw_EDate,
                        Dsw_IDate=q.Dsw_IDate,
                        Dsw_SDate=q.Dsw_SDate,
                        fldJobDesc=q.fldJobDesc,
                        fldBimePersonal=q.fldBimePersonal,
                        fldFamily=q.fldFamily,
                        fldFatherName=q.fldFatherName,
                        fldItem=q.fldItem,
                        fldJensiyatName=q.fldJensiyatName,
                        fldJobeCode=q.fldJobeCode,
                        fldKarkard=q.fldKarkard,
                        fldMashmolBime=q.fldMashmolBime,
                        fldMazayaMahiyane=q.fldMazayaMahiyane,
                        fldMeliyatName=q.fldMeliyatName,
                        fldName=q.fldName,
                        fldPayeSanavati=q.fldPayeSanavati,
                        fldRozane=q.fldRozane,
                        fldSh_Shenasname=q.fldSh_Shenasname,
                        fldShomareBime=q.fldShomareBime,
                        fldTaahol=q.fldTaahol,
                        fldTarikhTavalod=q.fldTarikhTavalod,
                        NameSodoor=q.NameSodoor,
                        fldMahane=q.fldMahane,
                        fldCodemeli=q.fldCodemeli,
                        DSW_PRATE=q.DSW_PRATE
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region SelectDisketBime_DBF_Header
        public OBJ_DisketBime_DBF_Header SelectDisketBime_DBF_Header(short sal, byte mah, int kargaBime, byte nobat)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBime_Header_DBF(sal, mah, kargaBime, nobat)
                    .Select(q => new OBJ_DisketBime_DBF_Header()
                    {
                        DSK_Bimh=q.DSK_Bimh,
                        DSK_Disc=q.DSK_Disc,
                        DSK_KIND=q.DSK_KIND,
                        DSK_NUM=q.DSK_NUM,
                        DSK_PRate=q.DSK_PRate,
                        DSK_Rate=q.DSK_Rate,
                        fldAddress=q.fldAddress,
                        fldBimePersonal=q.fldBimePersonal,
                        fldEmployerName=q.fldEmployerName,
                        fldItem=q.fldItem,
                        fldKarkard=q.fldKarkard,
                        fldMahane=q.fldMahane,
                        fldMashmolBime=q.fldMashmolBime,
                        fldMazayaMahiyane=q.fldMazayaMahiyane,
                        fldPayeSanavati=q.fldPayeSanavati,
                        fldRozane=q.fldRozane,
                        fldTaahol=q.fldTaahol,
                        Mon_Pay=q.Mon_Pay,
                        fldBimeKarFarma=q.fldBimeKarFarma,
                        fldWorkShopName=q.fldWorkShopName,
                        DSK_ID=q.DSK_ID,
                        fldBimeBikari=q.fldBimeBikari
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region InsertInsuranceJobs
        public string InsertInsuranceJobs()
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTabJobOfBimeBulkCopyInsert();
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}