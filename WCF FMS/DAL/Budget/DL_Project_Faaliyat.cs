//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using WCF_FMS.DAL.Model;
//using WCF_FMS.TOL.Budget;

//namespace WCF_FMS.DAL.Budget
//{
//    public class DL_Project_Faaliyat
//    {
//        #region Detail
//        public OBJ_Project_Faaliyat Detail(int id, int OrganId)
//        {
//            using (BudgetEntities p = new BudgetEntities())
//            {
//                var k = p.spr_tblProject_FaaliyatSelect("fldId", id.ToString(),"", OrganId,0, 1)
//                    .Select(q => new OBJ_Project_Faaliyat
//                    {
//                        fldId = q.fldId,
//                        fldDate = q.flddate,
//                        fldDesc = q.fldDesc,
//                        fldUserId = q.fldUserId,
//                        fldTitle = q.fldTitle,
//                        fldOrganId = q.fldOrganId,
//                        fldCod = q.fldCod,
//                        fldChartOrganId = q.fldChartOrganId,
//                        fldEtebarId = q.fldEtebarId,
//                        fldMasrafId = q.fldMasrafId,
//                        fldProject_faaliyatType = q.fldProject_faaliyatType,
//                        fldTrah_KhedmatId = q.fldTrah_KhedmatId,
//                        fldTitle_ChartOrgan = q.fldTitle_ChartOrgan,
//                        fldType = q.fldType,
//                        fldTitle_EtebarType = q.fldTitle_EtebarType,
//                        fldTitle_MasrafType = q.fldTitle_MasrafType,
//                        fldTitle_Tarh_Khedmat = q.fldTitle_Tarh_Khedmat,
//                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
//                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
//                        fldCod_Program = q.fldCod_Program,
//                        fldTitle_Program = q.fldTitle_Program,
//                        fldCod_Tarh_Khedmat = q.fldCod_Tarh_Khedmat,
//                        fldYear = q.fldYear
//                    }).FirstOrDefault();
//                return k;
//            }
//        }
//        #endregion
//        #region Select
//        public List<OBJ_Project_Faaliyat> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId,short Year, int h)
//        {
//            using (BudgetEntities p = new BudgetEntities())
//            {
//                var test = p.spr_tblProject_FaaliyatSelect(FieldName, FilterValue, FilterValue2, OrganId, Year, h)
//                    .Select(q => new OBJ_Project_Faaliyat()
//                    {
//                        fldId = q.fldId,
//                        fldDate = q.flddate,
//                        fldDesc = q.fldDesc,
//                        fldUserId = q.fldUserId,
//                        fldTitle = q.fldTitle,
//                        fldOrganId = q.fldOrganId,
//                        fldCod = q.fldCod,
//                        fldChartOrganId = q.fldChartOrganId,
//                        fldEtebarId = q.fldEtebarId,
//                        fldMasrafId = q.fldMasrafId,
//                        fldProject_faaliyatType = q.fldProject_faaliyatType,
//                        fldTrah_KhedmatId = q.fldTrah_KhedmatId,
//                        fldTitle_ChartOrgan=q.fldTitle_ChartOrgan,
//                        fldType = q.fldType,
//                        fldTitle_EtebarType = q.fldTitle_EtebarType,
//                        fldTitle_MasrafType = q.fldTitle_MasrafType,
//                        fldTitle_Tarh_Khedmat = q.fldTitle_Tarh_Khedmat,
//                        fldCod_Mamoriyat = q.fldCod_Mamoriyat,
//                        fldTitle_Mamoriyat = q.fldTitle_Mamoriyat,
//                        fldCod_Program = q.fldCod_Program,
//                        fldTitle_Program = q.fldTitle_Program,
//                        fldCod_Tarh_Khedmat = q.fldCod_Tarh_Khedmat,
//                        fldYear = q.fldYear
//                    }).ToList();
//                return test;
//            }
//        }
//        #endregion
//        #region Insert
//        public string Insert(int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId,short Year, int OrganId, int userId, string Desc)
//        {
//            using (BudgetEntities p = new BudgetEntities())
//            {
//                p.spr_tblProject_FaaliyatInsert(Tarh_KhedmatId, Code, Title, Type, EtebarId, MasrafId, Year, ChartOrganId, OrganId, Desc, userId);
//                return "ذخیره با موفقیت انجام شد.";
//            }
//        }
//        #endregion
//        #region Update
//        public string Update(int Id, int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId, short Year, int OrganId, int userId, string Desc)
//        {
//            using (BudgetEntities p = new BudgetEntities())
//            {
//                p.spr_tblProject_FaaliyatUpdate(Id, Tarh_KhedmatId, Code, Title, Type, EtebarId, MasrafId, Year, ChartOrganId, OrganId, Desc, userId);
//                return "ویرایش با موفقیت انجام شد.";
//            }
//        }
//        #endregion
//        #region Delete
//        public string Delete(int id, int userId)
//        {
//            using (BudgetEntities p = new BudgetEntities())
//            {
//                p.spr_tblProject_FaaliyatDelete(id, userId);
//                return "حذف با موفقیت انجام شد.";
//            }
//        }
//        #endregion
//    }
//}