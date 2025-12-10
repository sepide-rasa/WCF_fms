using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ItemsEstekhdam_FiscalTitle
    {
        DL_ItemsEstekhdam_FiscalTitle ItemsEstekhdam_FiscalTitle = new DL_ItemsEstekhdam_FiscalTitle();
        #region Select
        public List<OBJ_ItemsEstekhdam_FiscalTitle> Select(string FieldName, string NoeEstekhdam, int FiscalHeaderId, int h)
        {
            return ItemsEstekhdam_FiscalTitle.Select(FieldName, NoeEstekhdam,FiscalHeaderId, h);
        }
        #endregion
    }
}