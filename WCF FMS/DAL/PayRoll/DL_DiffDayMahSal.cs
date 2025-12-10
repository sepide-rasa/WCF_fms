using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DiffDayMahSal
    {
        #region Select
        public List<OBJ_DiffDayMahSal> Select(int rozCount)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_DiffDayMahSal(rozCount)
                    .Select(q => new OBJ_DiffDayMahSal()
                    {
                        CountString = q.CountString
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region DiffDayMahSalNumber
        public List<OBJ_DiffDayMahSal> DiffDayMahSalNumber(int rozCount)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_DiffDayMahSalNumber(rozCount)
                    .Select(q => new OBJ_DiffDayMahSal()
                    {
                        CountString = q.CountString
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}