using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_CodHayeDarAmad_Asli
    {
        #region select
        public List<OBJ_CodHayeDarAmad_Asli> select(string azTarikh,string taTarikh,int? shomareHesabId,int? codeDaramadId,int? organId,string fieldname,byte DateType)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_RptListCodeDaramad_Asli(azTarikh, taTarikh, shomareHesabId, codeDaramadId, organId, fieldname, DateType)
                    .Select(q => new OBJ_CodHayeDarAmad_Asli()
                    {
                        fldShomareHesab=q.fldShomareHesab,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldTarikh=q.fldTarikh
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}