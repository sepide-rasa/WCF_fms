using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DisketBimeKhadamatDarmani
    {
        #region Select
        public List<OBJ_DisketBimeKhadamatDarmani> Select(short Sal, byte mah, byte nobat,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_DisketBimeKhadamatDarmani(Sal, mah, nobat,OrganId)
                    .Select(q => new OBJ_DisketBimeKhadamatDarmani()
                    {
                        fldCodeMeli = q.fldCodeMeli,
                        fldFamily = q.fldFamily,
                        fldHaghDarman = q.fldHaghDarman,
                        fldKarkard = q.fldKarkard,
                        fldMashmolBime = q.fldMashmolBime,
                        fldName = q.fldName,
                        fldName_Family = q.fldName_Family,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTedadBime1 = q.fldTedadBime1,
                        fldTedadBime2 = q.fldTedadBime2,
                        fldTedadBime3 = q.fldTedadBime3,
                        fldMoavaghe=q.fldMoavaghe
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}