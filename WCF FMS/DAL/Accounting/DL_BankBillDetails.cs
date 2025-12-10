using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_BankBillDetails
    {
        #region Detail
        public OBJ_BankBillDetails Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblBankBill_DetailsSelect("fldId", id.ToString(),"", 1)
                    .Select(q => new OBJ_BankBillDetails
                    {
                        fldId = q.fldId,
                        fldBedehkar=q.fldBedehkar,
                        fldBestankar=q.fldBestankar,
                        fldCodePeygiri=q.fldCodePeygiri,
                        fldHedearId=q.fldHedearId,
                        fldMandeh=q.fldMandeh,
                        fldTarikh=q.fldTarikh,
                        fldTime=q.fldTime,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_BankBillDetails> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblBankBill_DetailsSelect(FieldName, FilterValue,FilterValue2, h)
                    .Select(q => new OBJ_BankBillDetails()
                    {
                        fldId = q.fldId,
                        fldBedehkar = q.fldBedehkar,
                        fldBestankar = q.fldBestankar,
                        fldCodePeygiri = q.fldCodePeygiri,
                        fldHedearId = q.fldHedearId,
                        fldMandeh = q.fldMandeh,
                        fldTarikh = q.fldTarikh,
                        fldTime = q.fldTime
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectBankBill_Tarikh
        public OBJ_BankBill_Tarikh SelectBankBill_Tarikh(int FiscalYearId, int shomareHesabId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectBankBillBazeTarikh(FiscalYearId,shomareHesabId)
                    .Select(q => new OBJ_BankBill_Tarikh()
                    {
                        fldMaxTarikh=q.fldMaxTarikh,
                        fldMinTarikh=q.fldMinTarikh
                    }).FirstOrDefault();
                return test;
            }
        }
        #endregion
        #region BankBillMap
        public string BankBillMap(int BankBillId,int Document_HeaderId,byte Type,string SourceIds,  int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var q=p.spr_tblArtiklMapInsert(BankBillId, Document_HeaderId,Type,SourceIds, Desc, IP, UserId);
                return q.FirstOrDefault().ErrorMessage;
                //return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}