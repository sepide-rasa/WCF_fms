using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_TypeHesab
    {
        #region Detail
        public OBJ_TypeHesab Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblTypeHesabSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_TypeHesab
                    {
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TypeHesab> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblTypeHesabSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_TypeHesab()
                    {
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}