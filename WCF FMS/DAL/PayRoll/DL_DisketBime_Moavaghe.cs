using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DisketBime_Moavaghe
    {
        #region Select
        public List<OBJ_DisketBime_Moavaghe> Select(short sal, byte mah, int kargaBime)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBime_Moavaghe(sal, mah, kargaBime)
                    .Select(q => new OBJ_DisketBime_Moavaghe()
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
                        fldM_Month = q.fldM_Month,
                        fldM_Year = q.fldM_Year
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}