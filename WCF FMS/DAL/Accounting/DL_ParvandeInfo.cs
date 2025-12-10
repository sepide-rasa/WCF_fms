using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;
namespace WCF_FMS.DAL.Accounting
{
    public class DL_ParvandeInfo
    {
        #region Select
        public List<OBJ_ParvandeInfo> Select(string FieldName, string FilterValue, byte ParvandeType,int OrganId,short Year, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_GetParvandeInfo(FieldName,FilterValue,ParvandeType,Year, OrganId,h)
                    .Select(q => new OBJ_ParvandeInfo()
                    {
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldCodemeli = q.fldCodemeli,
                        fldStartContract = q.fldStartContract,
                        fldEndContract = q.fldEndContract,
                        fldIsEbtal=q.fldIsEbtal,
                        fldMablagh=q.fldMablagh,
                        fldSharh=q.fldSharh,
                        fldShenaseGhabz=q.fldShenaseGhabz,
                        fldShenasePardakht=q.fldShenasePardakht,
                        fldShomareHesab=q.fldShomareHesab,
                        fldType = q.fldType,
                        fldTypeId=q.fldTypeId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}