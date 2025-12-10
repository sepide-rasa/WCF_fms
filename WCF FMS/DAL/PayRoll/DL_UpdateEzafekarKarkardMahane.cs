using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_UpdateEzafekarKarkardMahane
    {
        #region Update
        public string Update(decimal ezafekar, bool ghati, int personalId, byte mah, short year)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_Pay_UpdateEzafekarKarkardMahane(ezafekar, ghati, personalId, mah, year);
                return "تائید با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}