using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
namespace WCF_FMS.DAL.PayRoll
{
    public class DL_LoginFailed
    {
        #region Insert
        public string Insert(string UserName,  string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblLoginFailedInsert(UserName, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}