using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Program
    {
        #region Detail
        public OBJ_Program Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblProgramSelect("fldId", id.ToString(),"",0, OrganId, 1)
                    .Select(q => new OBJ_Program
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod = q.fldCod,
                        fldMamoriyatId=q.fldMamoriyatId,
                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
                        fldYear = q.fldYear
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Program> Select(string FieldName, string FilterValue, string FilterValue2,short Year, int OrganId, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblProgramSelect(FieldName, FilterValue,FilterValue2,Year, OrganId, h)
                    .Select(q => new OBJ_Program()
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod = q.fldCod,
                        fldMamoriyatId = q.fldMamoriyatId,
                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
                        fldYear = q.fldYear
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int MamoriyatId, string Code, string Title, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProgramInsert(MamoriyatId, Code,Year, Title, OrganId, Desc, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int MamoriyatId, string Code, string Title, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProgramUpdate(Id, MamoriyatId, Code,Year, Title, OrganId, Desc, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblProgramDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Code, string Title, short Year, int OrganId, int Id)
        {
            bool q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblProgramSelect("Code_Title", Title,Code,Year, OrganId, 0).Any();

                }
                else
                {
                    var query = p.spr_tblProgramSelect("Code_Title", Title,Code,Year, OrganId, 0).FirstOrDefault();
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
                var P = p.spr_tblTarh_KhedmatSelect("CheckProgramId", Id.ToString(),"", 0,0, 0).FirstOrDefault();
                if (P != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}