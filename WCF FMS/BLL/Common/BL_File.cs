using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_File
    {
        DL_File File = new DL_File();

        #region Select
        public List<OBJ_File> Select(string FieldName, string FilterValue, int h)
        {
            return File.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}