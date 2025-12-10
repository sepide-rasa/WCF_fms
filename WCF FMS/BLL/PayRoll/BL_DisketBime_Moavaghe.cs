using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketBime_Moavaghe
    {
        DL_DisketBime_Moavaghe DisketBime = new DL_DisketBime_Moavaghe();

        #region Select
        public List<OBJ_DisketBime_Moavaghe> Select(short sal, byte mah, int kargaBime)
        {
            return DisketBime.Select(sal, mah, kargaBime);
        }
        #endregion
    }
}