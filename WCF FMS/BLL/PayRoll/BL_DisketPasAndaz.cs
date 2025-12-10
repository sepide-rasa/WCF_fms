using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketPasAndaz
    {
        DL_DisketPasAndaz DisketPasAndaz = new DL_DisketPasAndaz();
        #region Select
        public List<OBJ_DisketPasAndaz> Select(short sal, byte mah, byte nobat,int organid)
        {
            return DisketPasAndaz.Select(sal, mah, nobat,organid);
        }
        #endregion
    }
}