using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_TimeLine
    {
        #region Select
        public List<OBJ_TimeLine> Select(int RequestId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_SelectTimeLine(RequestId)
                    .Select(q => new OBJ_TimeLine()
                    {
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldTitleAction = q.fldTitleAction,
                        fldName_familyUser = q.fldName_familyUser,
                        fldTarikh = q.fldTarikh,
                        fldTime = q.fldTime,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}