using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SelectPasAndazBank
    {
        DL_SelectPasAndazBank PasAndazBank = new DL_SelectPasAndazBank();
        public int? Select(short Year, byte Mah, int OrganId)
        {
            return PasAndazBank.Select(Year, Mah, OrganId);
        }

    }
}