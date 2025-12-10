using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_MapCodingDaramad
    {
        #region MapCodingDaramad
        public string Map(string oldCode, string newCode, string title, int UserId, string pcode)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.prs_MapCodingDaramad(oldCode, newCode, title, UserId, pcode);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}