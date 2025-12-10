using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_CodHayeDarAmad_Asli
    {
        DL_CodHayeDarAmad_Asli codHayedaramad_asli = new DL_CodHayeDarAmad_Asli();
        #region select
        public List<OBJ_CodHayeDarAmad_Asli> select(string azTarikh, string taTarikh, int? shomareHesabId, int? codeDaramadId, int? organId, string fieldname, byte DateType)
        {
            return codHayedaramad_asli.select(azTarikh, taTarikh, shomareHesabId, codeDaramadId, organId, fieldname, DateType);
        }
        #endregion
    }
}