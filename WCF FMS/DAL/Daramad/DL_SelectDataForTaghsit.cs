using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_SelectDataForTaghsit
    {
        #region Select
        public List<OBJ_SelectDataForTaghsit> Select(string FieldName,string Value,string AzTarikh,string TaTarikh,int OrganId,int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectDataForTaghsit(Value, FieldName,AzTarikh,TaTarikh, h,OrganId)
                    .Select(q => new OBJ_SelectDataForTaghsit()
                     {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBaratDarId = q.fldBaratDarId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldShomareHesab = q.fldShomareHesab,
                        fldBankName = q.fldBankName,
                        fldBankId = q.fldBankId,
                        fldNameShobe = q.fldNameShobe,
                        fldShobeId = q.fldShobeId,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusFishId = q.fldStatusFishId,
                        fldFishId = q.fldFishId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldName = q.fldName,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldDateStatus = q.fldDateStatus,
                        fldTarikhSabt = q.fldTarikhSabt,
                        fldNameSaderKonandeCheck = q.fldNameSaderKonandeCheck,
                        TarikhPardakht = q.TarikhPardakht,
                        fldIsSanad=q.fldIsSanad
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}