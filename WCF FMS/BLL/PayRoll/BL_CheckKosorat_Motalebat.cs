using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_CheckKosorat_Motalebat
    {
        DL_CheckKosorat_Motalebat CheckKosorat_Motalebat = new DL_CheckKosorat_Motalebat();
        #region Select
        public List<OBJ_CheckKosorat_Motalebat> Select(string FieldName, int id)
        {
            return CheckKosorat_Motalebat.Select(FieldName, id);
        }
        #endregion
    }
}