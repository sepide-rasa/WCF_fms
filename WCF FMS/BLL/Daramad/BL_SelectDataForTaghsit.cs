using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_SelectDataForTaghsit
    {
        DL_SelectDataForTaghsit SelectDataForTaghsit = new DL_SelectDataForTaghsit();
        #region Select
        public List<OBJ_SelectDataForTaghsit> Select(string FieldName, string Value, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            return SelectDataForTaghsit.Select(FieldName, Value, AzTarikh, TaTarikh, OrganId, h);
        }
        #endregion
    }
}