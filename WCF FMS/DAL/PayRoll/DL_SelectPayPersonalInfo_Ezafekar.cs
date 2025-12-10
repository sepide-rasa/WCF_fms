using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SelectPayPersonalInfo_Ezafekar
    {
        #region Select
        public List<OBJ_SelectPayPersonalInfo_Ezafekar> Select(string FieldName,int costcenter_ChartOrganId, int organId,short year,byte mah, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_SelectPayPersonalInfo_Ezafekar(FieldName, h, costcenter_ChartOrganId, organId, year, mah)
                    .Select(q => new OBJ_SelectPayPersonalInfo_Ezafekar()
                    {
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeOmrName = q.fldBimeOmrName,
                        fldBimeTakmili = q.fldBimeTakmili,
                        fldBimeTakmiliName = q.fldBimeTakmiliName,
                        fldCodemeli = q.fldCodemeli,
                        fldCostCenterId = q.fldCostCenterId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldEsargariId = q.fldEsargariId,
                        fldEzafeKari = q.fldEzafeKari,
                        fldFatherName = q.fldFatherName,
                        fldHamsarKarmand = q.fldHamsarKarmand,
                        fldId = q.fldId,
                        fldInsuranceWorkShopId = q.fldInsuranceWorkShopId,
                        fldJobDesc = q.fldJobDesc,
                        fldJobeCode = q.fldJobeCode,
                        fldMashagheleSakhtVaZianAvar = q.fldMashagheleSakhtVaZianAvar,
                        fldMashagheleSakhtVaZianAvarName = q.fldMashagheleSakhtVaZianAvarName,
                        fldMazad30Sal = q.fldMazad30Sal,
                        fldMazadCSalName = q.fldMazadCSalName,
                        fldMoafDarman = q.fldMoafDarman,
                        fldName = q.fldName,
                        fldName_Father = q.fldName_Father,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPasAndazName = q.fldPasAndazName,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldSanavatPayanKhedmat = q.fldSanavatPayanKhedmat,
                        fldSanavatPayanKhedmatName = q.fldSanavatPayanKhedmatName,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareBime = q.fldShomareBime,
                        fldTitleCostCenter = q.fldTitleCostCenter,
                        fldTitleTypeBime = q.fldTitleTypeBime,
                        fldTypeBimeId = q.fldTypeBimeId,
                        fldUserId = q.fldUserId,
                        fldWorkShopName = q.fldWorkShopName,
                        UserName = q.UserName,
                        fldGhati = q.fldGhati
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}