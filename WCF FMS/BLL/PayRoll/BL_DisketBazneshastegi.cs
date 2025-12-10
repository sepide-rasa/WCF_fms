using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketBazneshastegi
    {
        DL_DisketBazneshastegi DisketBazneshastegi = new DL_DisketBazneshastegi();
        #region Select
        public List<OBJ_DisketBazneshastegi> Select(short Year, byte Mah, byte Nobat, int OrganId)
        {
            return DisketBazneshastegi.Select(Year, Mah, Nobat, OrganId);
        }
        #endregion
    }
}