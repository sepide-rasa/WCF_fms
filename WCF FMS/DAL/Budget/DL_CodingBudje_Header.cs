using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_CodingBudje_Header
    {
        #region Detail
        public OBJ_CodingBudje_Header Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblCodingBudje_HeaderSelect("fldId", id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CodingBudje_Header
                    {
                        fldId = q.fldHedaerId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodingBudje_Header> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblCodingBudje_HeaderSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_CodingBudje_Header()
                    {
                        fldId = q.fldHedaerId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public int Insert(short Year, int OrganId, int userId, string Desc, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblCodingBudje_HeaderInsert(id, Year, OrganId, userId, Desc, IP);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, int OrganId, int userId, string Desc, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingBudje_HeaderUpdate(Id, Year, OrganId, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblCodingBudje_HeaderDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}