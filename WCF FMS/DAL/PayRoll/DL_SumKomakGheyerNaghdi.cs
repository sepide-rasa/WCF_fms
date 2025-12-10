using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SumKomakGheyerNaghdi
    {
        #region Select
        public List<OBJ_SumKomakGheyerNaghdi> Select(int PersonalId, bool Type, byte Mah,short Year)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SumKomakGheyerNaghdi(PersonalId, Type, Mah, Year)
                    .Select(q => new OBJ_SumKomakGheyerNaghdi()
                    {
                        Jam = q.Jam,
                        JamMaliyat = q.JamMaliyat
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}