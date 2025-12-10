using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_UpdateStatusSanad
    {
        #region Update
        public string Update(byte Type, int Id, byte Status,string DateStatus, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateStatusSanad(Type, Id, Status, DateStatus, UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}