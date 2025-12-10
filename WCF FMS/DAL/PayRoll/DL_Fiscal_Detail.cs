using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Fiscal_Detail
    {
        #region Detail
        public OBJ_Fiscal_Detail Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscal_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Fiscal_Detail()
                    {
                        fldAmountFrom=q.fldAmountFrom,
                        fldAmountTo=q.fldAmountTo,
                        fldDate=q.fldDate,
                        fldDateOfIssue=q.fldDateOfIssue,
                        fldDesc=q.fldDesc,
                        fldEffectiveDate=q.fldEffectiveDate,
                        fldFiscalHeaderId=q.fldFiscalHeaderId,
                        fldId=q.fldId,
                        fldPercentTaxOnWorkers=q.fldPercentTaxOnWorkers,
                        fldTax=q.fldTax,
                        fldTaxationOfEmployees=q.fldTaxationOfEmployees,
                        fldUserId = q.fldUserId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Fiscal_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscal_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Fiscal_Detail()
                    {
                        fldAmountFrom = q.fldAmountFrom,
                        fldAmountTo = q.fldAmountTo,
                        fldDate = q.fldDate,
                        fldDateOfIssue = q.fldDateOfIssue,
                        fldDesc = q.fldDesc,
                        fldEffectiveDate = q.fldEffectiveDate,
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldId = q.fldId,
                        fldPercentTaxOnWorkers = q.fldPercentTaxOnWorkers,
                        fldTax = q.fldTax,
                        fldTaxationOfEmployees = q.fldTaxationOfEmployees,
                        fldUserId = q.fldUserId,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_DetailInsert(FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_DetailUpdate(Id, FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion  

        #region Fiscal_Header_DetailInsert
        public string Fiscal_Header_DetailInsert(string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_Header_DetailInsert(EffectiveDate,DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Fiscal_Header_DetailUpdate
        public string Fiscal_Header_DetailUpdate(int Id, string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_Header_DetailUpdate(Id, EffectiveDate,DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Fiscal_Header_DetailDelete
        public string Fiscal_Header_DetailDelete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscal_Header_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion  
    }
}