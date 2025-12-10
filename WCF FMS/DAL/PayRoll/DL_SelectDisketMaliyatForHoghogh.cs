using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SelectDisketMaliyatForHoghogh
    {
        #region Select
        public List<OBJ_SelectDisketMaliyatForHoghogh> Select(short Year, byte Mah, byte Nobat,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectDisketMaliyatForHoghogh(Year, Mah, Nobat,OrganId)
                    .Select(q => new OBJ_SelectDisketMaliyatForHoghogh()
                    {
                        ezafekar =Convert.ToInt32( q.ezafekar),
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldMaliyat = q.fldMaliyat,
                        fldMashmolMaliyat = q.fldMashmolMaliyat,
                        ItemEstekhdam = q.ItemEstekhdam,
                        KolMotalebat = q.KolMotalebat,
                        MaliyatManfi = q.MaliyatManfi,
                        MaliyatMoavaghe = q.MaliyatMoavaghe,
                        mamoriat = Convert.ToInt32(q.mamoriat),
                        MashmolMaliyatMoavaghe = q.MashmolMaliyatMoavaghe,
                        s_payankhedmat = q.s_payankhedmat,
                        tatilkari = Convert.ToInt32(q.tatilkari),
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldFatherName = q.fldFatherName,
                        fldEsargariId = q.fldEsargariId,
                        fldAddress = q.fldAddress,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldCodePosti = q.fldCodePosti,
                        fldShomareBime = q.fldShomareBime,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldMeliyat = q.fldMeliyat,
                        MahalKhedmat = q.MahalKhedmat,
                        Semat = q.Semat,
                        fldNoeEstekhdam = q.fldNoeEstekhdam,
                        fldPersonalId = q.fldPersonalId,
                        fldMadrakId = q.fldMadrakId,
                        fldBimePersonal = q.fldBimePersonal,
                        SayerMoafiyat = q.SayerMoafiyat,
                        karane=q.karane,
                        fldBimeOmrPersonal=q.fldBimeOmrPersonal,
                        fldkhalesPardakhti=q.fldkhalesPardakhti,
                        fldMaliyatEsargari=q.fldMaliyatEsargari,
                        eydi=q.eydi,
                        fldMaliyatDaraei=q.fldMaliyatDaraei,
                        fldBonGheyrMostamar=Convert.ToInt32(q.fldBonGheyrMostamar),
                        fldBonMostamar=Convert.ToInt32(q.fldBonMostamar),
                        fldKhalesPardakhti_Ezafekar=q.fldKhalesPardakhti_Ezafekar,
                        fldKhalesPardakhti_komakGheirMostamar=q.fldKhalesPardakhti_komakGheirMostamar,
                        fldKhalesPardakhti_komakMostamar = q.fldKhalesPardakhti_komakMostamar,
                        fldKhalesPardakhti_Mamoriat=q.fldKhalesPardakhti_Mamoriat,
                        fldKhalesPardakhti_Sayer=q.fldKhalesPardakhti_Sayer,
                        fldKhalesPardakhti_Tatilkar=q.fldKhalesPardakhti_Tatilkar,
                        fldMablagh_Ezafekar=q.fldMablagh_Ezafekar,
                        fldMablagh_komakGheirMostamar=q.fldMablagh_komakGheirMostamar,
                        fldMablagh_komakMostamar=q.fldMablagh_komakMostamar,
                        fldMablagh_Mamoriat=q.fldMablagh_Mamoriat,
                        fldMablagh_Sayer=q.fldMablagh_Sayer,
                        fldMablagh_Tatilkar=q.fldMablagh_Tatilkar,
                        fldBonGheyrMostamarMoavagh=q.fldBonGheyrMostamarMoavagh,
                        fldBonMostamarMoavagh=q.fldBonMostamarMoavagh,
                        MashmolMaliyatMoavagheGHeirMostamar = q.MashmolMaliyatMoavagheGHeirMostamar,
                        fldMazayaRefahi_Angizeshi=q.fldMazayaRefahi_Angizeshi

                    }).ToList();
                return k;
            }
        }
        #endregion

        #region SelectHoghogh_OnAccount
        public List<OBJ_SelectDisketMaliyatForHoghogh> SelectHoghogh_OnAccount(short Year, byte Mah, byte Nobat, int OrganId, byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectHoghogh_OnAccount(Year, Mah, Nobat, OrganId,Convert.ToByte(CalcType))
                    .Select(q => new OBJ_SelectDisketMaliyatForHoghogh()
                    {
                        
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldCodemeli = q.fldCodemeli,
                        fldFatherName = q.fldFatherName,
                        fldkhalesPardakhti = q.fldkhalesPardakhti,
                        fldMaliyatDaraei = q.fldMaliyatDaraei,
                        fldType=q.fldType,
                        fldOnAccount=q.fldOnAccount
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}