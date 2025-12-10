using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DisketBime_Tatilkar_Ezafekar
    {
        #region Select
        public List<OBJ_DisketBime_Tatilkar_Ezafekar> Select(string FieldName, short sal, byte mah, byte nobat, int kargaBime)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBime_Tatilkar_Ezafekar(FieldName, sal, mah, nobat, kargaBime)
                    .Select(q => new OBJ_DisketBime_Tatilkar_Ezafekar()
                    {
                        fldBimeBikari = q.fldBimeBikari,
                        fldBimeKarFarma = q.fldBimeKarFarma,
                        fldBimePersonal = q.fldBimePersonal,
                        fldCodemeli = q.fldCodemeli,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldJensiyat = q.fldJensiyat,
                        fldJobDesc = q.fldJobDesc,
                        fldJobeCode = q.fldJobeCode,
                        fldMablagh = q.fldMablagh,
                        fldMashmolBime = q.fldMashmolBime,
                        fldMeliyat = q.fldMeliyat,
                        fldName = q.fldName,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldShomareBime = q.fldShomareBime,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldTarikhTavalod = q.fldTarikhTavalod,
                        NameSodoor = q.NameSodoor,
                        PersonalId = q.PersonalId,
                        fldSh_Personali = q.fldSh_Personali
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}