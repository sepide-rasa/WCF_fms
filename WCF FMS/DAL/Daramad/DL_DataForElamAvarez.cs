using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_DataForElamAvarez
    {
        #region Select
        public List<OBJ_DataForElamAvarez> Select(string FieldName, string FilterValue,string AzTarikh,string TaTarikh,byte Type,int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_DataForElamAvarez(FilterValue, FieldName, AzTarikh, TaTarikh, h, OrganId, Type)
                    .Select(q => new OBJ_DataForElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldBaratDarId = q.fldBaratDarId,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldFishId = q.fldFishId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldName = q.fldName,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldNameShobe = q.fldNameShobe,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusFishId = q.fldStatusFishId,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldDateStatus = q.fldDateStatus
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DataForElamAvarez_Check
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Check(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_DataForElamAvarez_Check(FilterValue, FieldName, AzTarikh, TaTarikh, h, OrganId)
                    .Select(q => new OBJ_DataForElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldBaratDarId = q.fldBaratDarId,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldFishId = q.fldFishId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldName = q.fldName,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldNameShobe = q.fldNameShobe,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusFishId = q.fldStatusFishId,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldTarikhAkhz = q.fldTarikhAkhz,
                        fldDateStatus = q.fldDateStatus,
                        fldNameSaderkonandeCheck=q.fldNameSaderkonandeCheck
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DataForElamAvarez_Barat
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Barat(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_DataForElamAvarez_Barat(FilterValue, FieldName, AzTarikh, TaTarikh, h, OrganId)
                    .Select(q => new OBJ_DataForElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldBaratDarId = q.fldBaratDarId,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldFishId = q.fldFishId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldName = q.fldName,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldNameShobe = q.fldNameShobe,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusFishId = q.fldStatusFishId,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldTarikhAkhz = q.fldTarikhAkhz,
                        fldDateStatus = q.fldDateStatus
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DataForElamAvarez_Safte
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Safte(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_DataForElamAvarez_Safte(FilterValue, FieldName, AzTarikh, TaTarikh,h, OrganId)
                    .Select(q => new OBJ_DataForElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBankId = q.fldBankId,
                        fldBankName = q.fldBankName,
                        fldBaratDarId = q.fldBaratDarId,
                        fldFather_Sabt = q.fldFather_Sabt,
                        fldFishId = q.fldFishId,
                        fldMablaghSanad = q.fldMablaghSanad,
                        fldMakanPardakht = q.fldMakanPardakht,
                        fldName = q.fldName,
                        fldNameBaratDar = q.fldNameBaratDar,
                        fldNameShobe = q.fldNameShobe,
                        fldReplyTaghsitId = q.fldReplyTaghsitId,
                        fldShenaseMeli = q.fldShenaseMeli,
                        fldShobeId = q.fldShobeId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesabIdOrgan = q.fldShomareHesabIdOrgan,
                        fldShomareHesabOrgan = q.fldShomareHesabOrgan,
                        fldShomareSanad = q.fldShomareSanad,
                        fldStatus = q.fldStatus,
                        fldStatusFish = q.fldStatusFish,
                        fldStatusFishId = q.fldStatusFishId,
                        fldStatusName = q.fldStatusName,
                        fldTarikhSarResid = q.fldTarikhSarResid,
                        fldTypeSanad = q.fldTypeSanad,
                        fldTypeSanadName = q.fldTypeSanadName,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldTarikhAkhz = q.fldTarikhAkhz,
                        fldDateStatus = q.fldDateStatus
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}