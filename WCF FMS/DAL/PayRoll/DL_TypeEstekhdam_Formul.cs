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
    public class DL_TypeEstekhdam_Formul
    {
        #region Detail
        public OBJ_TypeEstekhdam_Formul Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTypeEstekhdam_FormulSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_TypeEstekhdam_Formul()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TypeEstekhdam_Formul> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTypeEstekhdam_FormulSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TypeEstekhdam_Formul()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}