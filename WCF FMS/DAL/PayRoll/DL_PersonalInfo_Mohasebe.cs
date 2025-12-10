using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_PersonalInfo_Mohasebe
    {
        #region Select
        public List<OBJ_PersonalInfo_Mohasebe> Select(string FieldName, short Year, byte Month, byte NobatePardakht, byte Type, byte Ezafe_Tatil, int OrganId, string CostCenterId, string AnvaEstekhdamId, string Tarikh,byte CalcType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_PersonalInfo_Mohasebe(Year, Month, NobatePardakht, Type, Ezafe_Tatil, OrganId, CostCenterId, AnvaEstekhdamId, Tarikh, FieldName, CalcType)
                    .Select(q => new OBJ_PersonalInfo_Mohasebe()
                    {
                        fldCodemeli = q.fldCodemeli,
                        fldName_Family = q.fldName_Family,
                        fldOrganId = q.fldOrganId,
                        fldSh_Personali = q.fldSh_Personali,
                        PayId = q.PayId,
                        PrsId = q.PrsId,
                        fldCostCenterId = q.fldCostCenterId,
                        fldAnvaeEstekhdamId = q.fldAnvaeEstekhdamId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}