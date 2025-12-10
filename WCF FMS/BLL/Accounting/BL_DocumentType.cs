using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentType
    {
        DL_DocumentType DocumentType = new DL_DocumentType();

        
        #region Select
        public List<OBJ_DocumentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return DocumentType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
    }
}