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
    public class DL_MaliyatDaraei
    {
        
        #region Update
        public string Update(short fldYear,byte fldMonth,byte fldNobatePardakht,int fldOrganId,int fldUserId,string fldIp)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMaliyatDaraeiUpdate(fldYear, fldMonth, fldNobatePardakht, fldOrganId, fldUserId, fldIp);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(short fldYear, byte fldMonth, byte fldNobatePardakht, int fldOrganId, int fldUserId, string fldIp)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMaliyatDaraeiDelete(fldYear, fldMonth, fldNobatePardakht, fldOrganId, fldUserId, fldIp);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}