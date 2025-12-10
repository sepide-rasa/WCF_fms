using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ListNoMaliyat_BimePersonal
    {
        DL_ListNoMaliyat_BimePersonal ListNoMaliyat_BimePersonal = new DL_ListNoMaliyat_BimePersonal();
        #region Select
        public List<OBJ_ListNoMaliyat_BimePersonal> Select(string FieldName, int PersonelId, short sal, byte mah, byte nobat, int OrganId)
        {
            return ListNoMaliyat_BimePersonal.Select(FieldName,PersonelId,  sal, mah, nobat, OrganId);
        }
        #endregion
    }
}