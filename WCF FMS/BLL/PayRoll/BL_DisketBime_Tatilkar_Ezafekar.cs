using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketBime_Tatilkar_Ezafekar
    {
        DL_DisketBime_Tatilkar_Ezafekar DisketBime_Tatilkar_Ezafekar = new DL_DisketBime_Tatilkar_Ezafekar();
        #region Select
        public List<OBJ_DisketBime_Tatilkar_Ezafekar> Select(string FieldName, short sal, byte mah, byte nobat, int kargaBime)
        {
            return DisketBime_Tatilkar_Ezafekar.Select(FieldName, sal, mah, nobat, kargaBime);
        }
        #endregion
    }
}