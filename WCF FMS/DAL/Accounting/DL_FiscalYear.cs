using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_FiscalYear
    {
        #region Detail
        public OBJ_FiscalYear Detail(int id,int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblFiscalYearSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_FiscalYear
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_FiscalYear> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblFiscalYearSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_FiscalYear()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(short fldYear,int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblFiscalYearInsert(OrganId,fldYear, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short fldYear, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblFiscalYearUpdate(Id, OrganId, fldYear, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblFiscalYearDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(short Year, int OrganId, int Id)
        {
            bool q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblFiscalYearSelect("fldYear", Year.ToString(), OrganId, 0).Any();
                }
                else
                {
                    var query = p.spr_tblFiscalYearSelect("fldYear", Year.ToString(), OrganId, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id,int OrganId)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var DocumentR = p.spr_tblDocumentRecord_HeaderSelect("CheckYear", Id.ToString(),"","", OrganId,0,0,1, 0).FirstOrDefault();
                if (DocumentR != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}