using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_PersonalInfo_Mohasebe
    {
        DL_PersonalInfo_Mohasebe PersonalInfo_Mohasebe = new DL_PersonalInfo_Mohasebe();
        #region Select
        public List<OBJ_PersonalInfo_Mohasebe> Select(string FieldName, short Year, byte Month, byte NobatePardakht, byte Type, byte Ezafe_Tatil, int OrganId, string CostCenterId, string AnvaEstekhdamId, string Tarikh, byte CalcType)
        {
            return PersonalInfo_Mohasebe.Select(FieldName,Year, Month, NobatePardakht, Type, Ezafe_Tatil, OrganId, CostCenterId, AnvaEstekhdamId, Tarikh, CalcType);
        }
        #endregion
    }
}