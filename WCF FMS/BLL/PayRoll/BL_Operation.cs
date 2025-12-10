using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Operation
    {
        DL_Operation Operation = new DL_Operation();


        #region Select
        public List<OBJ_Operation> Select(string FieldName, string FilterValue, int h)
        {
            return Operation.Select(FieldName, FilterValue, h);
        }
        #endregion

    }
}