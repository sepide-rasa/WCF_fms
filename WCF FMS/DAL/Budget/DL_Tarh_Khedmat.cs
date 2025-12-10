using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Tarh_Khedmat
    {
        #region Detail
        public OBJ_Tarh_Khedmat Detail(int id, int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var k = p.spr_tblTarh_KhedmatSelect("fldId", id.ToString(),"", OrganId,0, 1)
                    .Select(q => new OBJ_Tarh_Khedmat
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod = q.fldCod,
                        fldProgramId = q.fldProgramId,
                        fldTarh_KhedmatType = q.fldTarh_KhedmatType,
                        fldType = q.fldType,
                        fldTitle_Program = q.fldTitle_Program,
                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
                        fldCod_Program = q.fldCod_Program
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Tarh_Khedmat> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId,short Year, int h)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_tblTarh_KhedmatSelect(FieldName, FilterValue,FilterValue2, OrganId,Year, h)
                    .Select(q => new OBJ_Tarh_Khedmat()
                    {
                        fldId = q.fldId,
                        fldDate = q.flddate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId,
                        fldCod = q.fldCod,
                        fldProgramId = q.fldProgramId,
                        fldTarh_KhedmatType = q.fldTarh_KhedmatType,
                        fldType = q.fldType,
                        fldTitle_Program = q.fldTitle_Program,
                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
                        fldCod_Program = q.fldCod_Program
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ProgramId, string Code, string Title,byte Type,short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTarh_KhedmatInsert(ProgramId, Code, Title, Type, Year, OrganId, Desc, userId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ProgramId, string Code, string Title, byte Type, short Year, int OrganId, int userId, string Desc)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTarh_KhedmatUpdate(Id, ProgramId, Code, Title, Type,Year, OrganId, Desc, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblTarh_KhedmatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Code, string Title,short Year,int OrganId, int Id)
        {
            bool q = false;
            using (BudgetEntities p = new BudgetEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTarh_KhedmatSelect("Code_Title", Title, Code, OrganId,Year, 0).Any();

                }
                else
                {
                    var query = p.spr_tblTarh_KhedmatSelect("Code_Title", Title, Code, OrganId,Year, 0).FirstOrDefault();
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
                //var P = p.spr_tblProject_FaaliyatSelect("CheckTarh_KhedmatId", Id.ToString(),"",0, 0, 0).FirstOrDefault();
                //if (P != null)
                //    q = true;
                return q;
            }
        }
        #endregion
    }
}