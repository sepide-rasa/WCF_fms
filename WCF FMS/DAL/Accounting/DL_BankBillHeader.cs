using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_BankBillHeader
    {
        #region Detail
        public OBJ_BankBillHeader Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblBankBill_HeaderSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_BankBillHeader
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldShomareHesab = q.fldShomareHesab,
                        fldFiscalYearId=q.fldFiscalYearId,
                        fldJsonFile=q.fldJsonFile,
                        fldName=q.fldName,
                        fldNamePattern=q.fldNamePattern,
                        fldPatternId=q.fldPatternId,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldBankName=q.fldBankName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_BankBillHeader> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblBankBill_HeaderSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_BankBillHeader()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldFiscalYearId = q.fldFiscalYearId,
                        fldJsonFile = q.fldJsonFile,
                        fldName = q.fldName,
                        fldNamePattern = q.fldNamePattern,
                        fldPatternId = q.fldPatternId,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldBankName=q.fldBankName,
                        fldShomareHesab = q.fldShomareHesab
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectMoghayeratBanki
        public List<OBJ_MoghayeratBanki> SelectMoghayeratBanki(string FieldName, int FiscalYearId,string AzTarikh,string TaTarikh,int ShomareHesabId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_SelectMoghayeratBanki(FieldName,  FiscalYearId, AzTarikh, TaTarikh, ShomareHesabId)
                    .Select(q => new OBJ_MoghayeratBanki()
                    {
                        fldBedehkar=q.fldBedehkar,
                        fldBestankar=q.fldBestankar,
                        fldCode=q.fldCode,
                        fldCodePeygiri=q.fldCodePeygiri,
                        fldDocumentNum=q.fldDocumentNum,
                        fldMandeh=q.fldMandeh,
                        fldTarikh=q.fldTarikh,
                        fldTitle=q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region CheckCountData
        public bool CheckCountData(int HeaderId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.tblBankBill_DetailsDeleteNotExists(HeaderId).FirstOrDefault().flag;
                return Convert.ToBoolean(test);
            }
        }
        #endregion
        #region Insert
        public int Insert(string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldid", typeof(int));
                p.spr_tblBankBill_HeaderInsert(id,fldName,fldShomareHesabId,fldFiscalYearId,fldJsonFile, Desc, IP, UserId, fldPatternId);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblBankBill_HeaderUpdate(fldId, fldName, fldShomareHesabId, fldFiscalYearId, fldJsonFile, Desc, IP, UserId, fldPatternId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblBankBill_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                q = p.spr_tblAccountingTypeSelect("fldName", Name, 0).Any();
            }
            return q;
        }
        #endregion
    }
}