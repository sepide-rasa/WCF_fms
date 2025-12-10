using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_RptKosurBazneshastegi
    {
        #region Select
        public List<OBJ_RptKosurBazneshastegi> Select(short Year, byte Mah, byte Nobat, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_RptKosurBazneshastegi(Year, Mah, Nobat, OrganId)
                    .Select(q => new OBJ_RptKosurBazneshastegi()
                    {
                        fldfoghjazb = q.fldfoghjazb,
                        fldfoghjazbMoavaghe = q.fldfoghjazbMoavaghe,
                        fldfoghshoghl = q.fldfoghshoghl,
                        fldfoghshoghlMoavaghe = q.fldfoghshoghlMoavaghe,
                        fldHoghogh = q.fldHoghogh,
                        fldHoghoghMoavaghe = q.fldHoghoghMoavaghe,
                        fldKosur = q.fldKosur,
                        fldMazad30sal = q.fldMazad30sal,
                        fldMazad30salMoavaghe = q.fldMazad30salMoavaghe,
                        fldNobatKari = q.fldNobatKari,
                        fldNobatKariMoavaghe = q.fldNobatKariMoavaghe,
                        fldpersonalId = q.fldpersonalId,
                        fldSakhtikar = q.fldSakhtikar,
                        fldSakhtikarMoavaghe = q.fldSakhtikarMoavaghe,
                        KosurMoavaghe = q.KosurMoavaghe,
                        Mogharari = q.Mogharari,
                        MogharariMahAval = q.MogharariMahAval,
                        SahamKarmand = q.SahamKarmand,
                        SahamKarmandMoavaghe = q.SahamKarmandMoavaghe,
                        SahmKarfarma = q.SahmKarfarma,
                        SahmKarfarmaMoavaghe = q.SahmKarfarmaMoavaghe,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}