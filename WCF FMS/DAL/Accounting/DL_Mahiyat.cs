using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_Mahiyat
    {
        #region Select
        public List<OBJ_Mahiyat> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblMahiyatSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Mahiyat()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIp = q.fldIp,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}