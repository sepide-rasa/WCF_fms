using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ItemsEstekhdam_MoteghayerHoghoghi
    {
        DL_ItemsEstekhdam_MoteghayerHoghoghi ItemsEstekhdam_MoteghayerHoghoghi = new DL_ItemsEstekhdam_MoteghayerHoghoghi();
        #region Select
        public List<OBJ_ItemsEstekhdam_MoteghayerHoghoghi> Select(string FieldName, string NoeEstekhdam,int HeaderId, int h)
        {
            return ItemsEstekhdam_MoteghayerHoghoghi.Select(FieldName, NoeEstekhdam, HeaderId, h);
        }
        #endregion
    }
}