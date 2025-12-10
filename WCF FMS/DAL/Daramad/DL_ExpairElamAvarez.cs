using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ExpairElamAvarez
    {
        #region ExpireElamAvarez
        public bool ExpireElamAvarez()
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_ChangeLetter().FirstOrDefault();
                return Convert.ToBoolean(k.flag);
            }
        }
        #endregion
    }
}