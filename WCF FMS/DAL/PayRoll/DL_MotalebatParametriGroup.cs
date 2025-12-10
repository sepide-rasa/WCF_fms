using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MotalebatParametriGroup
    {
        #region Select
        public List<OBJ_MotalebatParametriGroup> Select(string FieldName, string FilterValue, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMotalebatParametriGroupSelect(FieldName, FilterValue, OrganId)
                    .Select(q => new OBJ_MotalebatParametriGroup()
                    {
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldName_Father = q.fldName_Father,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}