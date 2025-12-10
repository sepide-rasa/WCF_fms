using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_StatusMahalKedmat
    {
        DL_StatusMahalKedmat StatusMahalKedmat = new DL_StatusMahalKedmat();
        #region Select
        public List<OBJ_StatusMahalKedmat> Select(string FieldName, string FilterValue, int h)
        {
            return StatusMahalKedmat.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}