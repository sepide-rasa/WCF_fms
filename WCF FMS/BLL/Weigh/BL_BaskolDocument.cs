using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_BaskolDocument
    {
        DL_BaskolDocument BaskolDocument = new DL_BaskolDocument();

        #region Select
        public List<OBJ_BaskolDocument> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return BaskolDocument.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}