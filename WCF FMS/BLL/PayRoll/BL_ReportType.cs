using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ReportType
    {
        DL_ReportType ReportType = new DL_ReportType();
        #region Select
        public List<OBJ_ReportType> Select(string FieldName, string FilterValue, int h)
        {
            return ReportType.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}