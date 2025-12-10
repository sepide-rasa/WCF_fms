using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Mamoriyat
    {
        #region Detail
        public OBJ_Mamoriyat Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblMamoriyatSelect("fldId", id.ToString(),"", OrganId,0, 1)
                    .Select(q => new OBJ_Mamoriyat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod=q.fldCod,
                        fldYear=q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Mamoriyat> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId,short Year, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblMamoriyatSelect(FieldName, FilterValue,FilterValue2, OrganId,Year, h)
                    .Select(q => new OBJ_Mamoriyat()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod = q.fldCod,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Code, string Title, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMamoriyatInsert(Code, Title, Year, OrganId, Desc, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Code, string Title, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMamoriyatUpdate(Id, Code, Title, Year, OrganId, Desc, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblMamoriyatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Code, string Title, short Year,int OrganId, int Id)
        {
            bool q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMamoriyatSelect("Code_Title", Title,Code, OrganId,Year, 0).Any();

                }
                else
                {
                    var query = p.spr_tblMamoriyatSelect("Code_Title", Title,Code, OrganId,Year, 0).FirstOrDefault();
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
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                var P = p.spr_tblProgramSelect("CheckMamoriyatId", Id.ToString(),"",0, 0, 0).FirstOrDefault();
                if (P != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}