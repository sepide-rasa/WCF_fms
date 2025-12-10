using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_CalcMaliyatGheyerNaghdi
    {
        #region Select
        public List<OBJ_CalcMaliyatGheyerNaghdi> Select(string Year, int Mablagh, int TypeEstekhdam)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_CalcMaliyatGheyerNaghdi(Year, Mablagh, TypeEstekhdam)
                    .Select(q => new OBJ_CalcMaliyatGheyerNaghdi()
                    {
                        fldAmountFrom = q.fldAmountFrom,
                        fldAmountTo = q.fldAmountTo,
                        fldDate = q.fldDate,
                        fldDateOfIssue = q.fldDateOfIssue,
                        fldDesc = q.fldDesc,
                        fldEffectiveDate = q.fldEffectiveDate,
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldId = q.fldId,
                        fldTax = q.fldTax,
                        fldUserId = q.fldUserId,
                        Darsad = q.Darsad,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}