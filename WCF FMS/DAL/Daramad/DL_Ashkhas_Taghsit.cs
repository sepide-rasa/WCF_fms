using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Ashkhas_Taghsit
    {
        #region Select
        public List<OBJ_Ashkhas_Taghsit> Select(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_Ashkhas_Taghsit(ElamAvarezId)
                    .Select(q => new OBJ_Ashkhas_Taghsit()
                    {
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldBaratDarId = q.fldBaratDarId,
                        fldDateStatus = q.fldDateStatus,
                        fldId = q.fldId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldNameSaderKonandeCheck = q.fldNameSaderKonandeCheck,
                        fldNameShobe = q.fldNameShobe,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSabt = q.fldTarikhSabt,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}