using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_FileForHokm
    {
        #region Insert
        public string Insert(int fldPersonalHokmId, byte[] fldImage, string fldPasvand, int fldUserId, string fldDesc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_InsertFileForHokm(fldPersonalHokmId, fldImage, fldPasvand, fldUserId, fldDesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}