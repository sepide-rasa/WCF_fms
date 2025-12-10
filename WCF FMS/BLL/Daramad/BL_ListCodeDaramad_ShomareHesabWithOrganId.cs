using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ListCodeDaramad_ShomareHesabWithOrganId
    {
        DL_ListCodeDaramad_ShomareHesabWithOrganId ListCodeDaramad_ShomareHesabWithOrganId = new DL_ListCodeDaramad_ShomareHesabWithOrganId();
        #region Select
        public List<OBJ_ListCodeDaramad_ShomareHesabWithOrganId> Select(int OrganId, byte Type, int FiscalYearId)
        {
            return ListCodeDaramad_ShomareHesabWithOrganId.Select(OrganId, Type,FiscalYearId);
        }
        #endregion
    }
}