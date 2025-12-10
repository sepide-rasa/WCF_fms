using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_SelectFishSaderShode
    {
        DL_SelectFishSaderShode FishSaderShode = new DL_SelectFishSaderShode();
        #region Select
        public List<OBJ_FishSaderShode> Select(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int UserId, int OrganId, int h)
        {
            return FishSaderShode.Select(FieldName, FilterValue, AzTarikh, TaTarikh, UserId, OrganId,h);
        }
        #endregion
    }
}