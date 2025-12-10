using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.DAL.Accounting
{
    public class DL_Coding_Header
    {
        #region Detail
        public OBJ_Coding_Header Detail(int id, int OrganId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var k = p.spr_tblCoding_HeaderSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_Coding_Header
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Coding_Header> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                var test = p.spr_tblCoding_HeaderSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_Coding_Header()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldOrganId = q.fldOrganId,
                        fldYear = q.fldYear,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(short Year, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_HeaderInsert(Year, OrganId, Desc, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, int OrganId, int UserId, string IP, string Desc)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_HeaderUpdate(Id, Year, OrganId, Desc, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.spr_tblCoding_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CopyFromTemplateCodingToCoding
        public string CopyFromTemplateCodingToCoding(int HeaderId, int TempNameId,System.Data.DataTable IncomeCodes, int UserId, string IP)
        {
            using (AccountingEntities p = new AccountingEntities())
            {
                p.CopyFromTemplateCodingToCoding(HeaderId, TempNameId, IP, UserId, IncomeCodes);
                return "کپی با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (AccountingEntities p = new AccountingEntities())
            {
                var Coding_D = p.spr_tblCoding_DetailsSelect("fldHeaderCodId", Id.ToString(),"","", 0).FirstOrDefault();
                if (Coding_D != null)
                    q = true;
            }
            return q;
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
                    q = p.spr_tblCoding_HeaderSelect("fldYear", Year.ToString(), OrganId, 0).Any();
                }
                else
                {
                    var query = p.spr_tblCoding_HeaderSelect("fldYear", Year.ToString(), OrganId, 0).FirstOrDefault();
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