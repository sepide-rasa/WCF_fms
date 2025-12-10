using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SelectVariziForBank
    {
        #region Select
        public List<OBJ_SelectVariziForBank> Select(string FieldName,string Value ,short Year, byte Mah, byte NobatePardakht, byte MarhalePardakht,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectVariziForBank(FieldName, Year, Mah, NobatePardakht, MarhalePardakht,OrganId,Value)
                    .Select(q => new OBJ_SelectVariziForBank()
                    {
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldkhalesPardakhti =Convert.ToInt32( q.fldkhalesPardakhti),
                        fldName = q.fldName,
                        fldShomareHesab = q.fldShomareHesab,
                        fldCodemeli = q.fldCodemeli,
                        fldAddress = q.fldAddress,
                        fldEsargariId = q.fldEsargariId,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareBime = q.fldShomareBime,
                        fldMadrakId = Convert.ToInt32(q.fldMadrakId),
                        fldRasteShoghli = q.fldRasteShoghli,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldMeliyat = Convert.ToBoolean(q.fldMeliyat),
                        MahalKhedmat = q.MahalKhedmat,
                        Semat = q.Semat,
                        fldMaliyat = Convert.ToInt32(q.fldMaliyat),
                        fldNoeEstekhdam = Convert.ToInt32(q.fldNoeEstekhdam),
                        fldPersonalId = q.fldPersonalId,
                        fldMablagh = q.fldMablagh,
                        fldMaliyatEsargari=q.fldMaliyatEsargari,
                        fldPayPersonalId=q.fldPayPersonalId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}