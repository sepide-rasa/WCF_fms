using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ExpirElamAvarez
    {
        DL_ExpairElamAvarez ExpirElamAvarez = new DL_ExpairElamAvarez();
        public bool ExpireElamAvarez()
        {
            return ExpirElamAvarez.ExpireElamAvarez();
        }
    }
}