using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SayerPardakhtGroup
    {
        DL_SayerPardakhtGroup SayerPardakhtGroup = new DL_SayerPardakhtGroup();
        #region Select
        public List<OBJ_SayerPardakhtGroup> Select(string FieldName, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int CostCenterId, int? BankId, byte Type, int OrganId)
        {
            return SayerPardakhtGroup.Select(FieldName, Year, Month, NobatPardakht, MarhalePardakht, CostCenterId, BankId, Type, OrganId);
        }
        #endregion
    }
}