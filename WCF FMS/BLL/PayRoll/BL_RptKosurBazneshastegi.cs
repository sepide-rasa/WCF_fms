using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_RptKosurBazneshastegi
    {
        DL_RptKosurBazneshastegi RptKosurBazneshastegi = new DL_RptKosurBazneshastegi();

        #region Select
        public List<OBJ_RptKosurBazneshastegi> Select(short Year, byte Mah, byte Nobat, int OrganId)
        {
            return RptKosurBazneshastegi.Select(Year, Mah, Nobat, OrganId);
        }
        #endregion
    }
}