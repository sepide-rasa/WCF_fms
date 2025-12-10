using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_BankTemplate_Header
    {
        #region Detail
        public OBJ_BankTemplate_Header Detail(int id)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblBankTemplate_HeaderSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_BankTemplate_Header
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldBankName=q.fldBankName,
                        fldNamePattern=q.fldNamePattern,
                        fldStartRow=q.fldStartRow,
                        fldFileId=q.fldFileId,
                        fldPasvand=q.fldPasvand,
                        fldBankId=q.fldBankId,
                        fldDetailsId=q.fldDetailsId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_BankTemplate_Header> Select(string FieldName, string FilterValue, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblBankTemplate_HeaderSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_BankTemplate_Header()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldBankName = q.fldBankName,
                        fldNamePattern = q.fldNamePattern,
                        fldStartRow = q.fldStartRow,
                        fldFileId = q.fldFileId,
                        fldPasvand = q.fldPasvand,
                        fldBankId = q.fldBankId,
                        fldDetailsId = q.fldDetailsId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string NamePattern,short StartRow,byte[] fldImage,string fldPasvand,System.Data.DataTable Details, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblBankTemplate_HeaderInsert(NamePattern, StartRow,fldImage,fldPasvand, Desc, IP, UserId, Details);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string NamePattern, short StartRow,int? fldFileId, byte[] fldImage, string fldPasvand, System.Data.DataTable Details, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblBankTemplate_HeaderUpdate(fldId,NamePattern, StartRow,fldFileId,fldImage,fldPasvand, Desc, IP, UserId, Details);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion  
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblBankTemplate_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAccountingTypeSelect("fldName", Name, 0).Any();

                }
                else
                {
                    var query = p.spr_tblAccountingTypeSelect("fldName", Name, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        
    }
}