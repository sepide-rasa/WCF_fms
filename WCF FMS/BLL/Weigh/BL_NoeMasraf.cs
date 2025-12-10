using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_NoeMasraf
    {
        DL_NoeMasraf NoeMasraf = new DL_NoeMasraf();

        
        #region Select
        public List<OBJ_NoeMasraf> Select(string FieldName, string FilterValue, int h)
        {
            return NoeMasraf.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}