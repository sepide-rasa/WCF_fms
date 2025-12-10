using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DiffDayMahSal
    {
        DL_DiffDayMahSal DiffDayMahSal = new DL_DiffDayMahSal();
        #region Select
        public List<OBJ_DiffDayMahSal> Select(int rozCount)
        {
            return DiffDayMahSal.Select(rozCount);
        }
        #endregion

        #region DiffDayMahSalNumber
        public List<OBJ_DiffDayMahSal> DiffDayMahSalNumber(int rozCount)
        {
            return DiffDayMahSal.DiffDayMahSalNumber(rozCount);
        }
        #endregion
    }
}