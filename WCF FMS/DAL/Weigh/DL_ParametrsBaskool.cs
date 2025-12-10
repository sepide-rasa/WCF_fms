using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.DAL.Weigh
{
    public class DL_ParametrsBaskool
    {
        #region Select
        public List<OBJ_ParametrsBaskool> Select(string FieldName, string FilterValue, int h)
        {
            using (WeighEntities p = new WeighEntities())
            {
                var test = p.spr_tblParametrsBaskoolSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_ParametrsBaskool()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldEnName = q.fldEnName,
                        fldIP = q.fldIP,
                        fldFaName = q.fldFaName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string EnName, string FaName, int userId, string Desc, string IP)
        {
            using (WeighEntities p = new WeighEntities())
            {

                p.spr_tblParametrsBaskoolInsert(EnName, FaName, userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}