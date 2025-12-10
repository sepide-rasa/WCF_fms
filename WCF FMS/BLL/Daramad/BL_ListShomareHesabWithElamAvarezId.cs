using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ListShomareHesabWithElamAvarezId
    {
        DL_ListShomareHesabWithElamAvarezId ShomareHesabWithElamAvarezId = new DL_ListShomareHesabWithElamAvarezId();
        #region Select
        public List<OBJ_ShomareHesabWithElamAvarezId> Select(string fieldname, string value)
        {
            return ShomareHesabWithElamAvarezId.Select(fieldname, value);
        }
        #endregion
    }
}