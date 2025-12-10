using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SelectVariziForBank
    {
        DL_SelectVariziForBank SelectVariziForBank = new DL_SelectVariziForBank();
        #region Select
        public List<OBJ_SelectVariziForBank> Select(string FieldName,string Value , short Year, byte Mah, byte NobatePardakht, byte MarhalePardakht, int OrganId)
        {
            return SelectVariziForBank.Select(FieldName, Value , Year, Mah, NobatePardakht, MarhalePardakht,OrganId);
        }
        #endregion
    }
}