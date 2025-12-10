using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.DAL.Budget
{
    public class DL_Pishbini_Daramad
    {
        #region Select
        public List<OBJ_Pishbini_Daramad> Select(string fieldName, string Year, int? MotamamId, int organId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.SelectPishbiniBudje(fieldName,Year,MotamamId,organId)
                    .Select(q => new OBJ_Pishbini_Daramad()
                    {
                        last = q.last,
                        fldCol1 = q.Col1,
                        fldCol2 = q.Col2,
                        fldCol3 = q.Col3,
                        fldCol4 = q.Col4,
                        fldCol5 = q.Col5,
                        fldCol6 = q.Col6,
                        fldCol7 = q.Col7,
                        fldCol8 = q.Col8,
                        fldCol9 = q.Col9,
                        fldCol10 = q.Col10,
                        fldCode = q.fldCode,
                        fldCodingId=q.fldCodingId,
                        fldTitle=q.fldTitle,
                        fldNameDarasad=q.fldNameDarasad,
                        fldflagSanad = q.fldflagSanad,
                        fldLevelId=q.fldLevelId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectProjectCoding
        public List<OBJ_Pishbini_Daramad> SelectProjectCoding(int fldBudgetCodingId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.SelectProjectCoding(fldBudgetCodingId.ToString())
                    .Select(q => new OBJ_Pishbini_Daramad()
                    {
                        fldCol1 = q.Col1,
                        fldCol2 = q.Col2,
                        fldCol3 = q.Col3,
                        fldCol4 = q.Col4,
                        fldCol5 = q.Col5,
                        fldCol6 = q.Col6,
                        fldCol7 = q.Col7,
                        fldCol8 = q.Col8,
                        fldCol9 = q.Col9,
                        fldCol10 = q.Col10,
                        fldCode = q.fldCode,
                        fldCodingId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldEditable = q.fldEditable
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectCodingAccNotBudje
        public List<OBJ_SelectCodingAccNotBudje> SelectCodingAccNotBudje(string fieldName, string aztarikh, string tatarikh, byte? salmaliID, byte? organId, int? azsanad, int? tasanad, byte? sanadtype)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_SelectCodingAccNotBudje(fieldName, aztarikh,tatarikh,salmaliID,organId,azsanad,tasanad,sanadtype)
                    .Select(q => new OBJ_SelectCodingAccNotBudje()
                    {
                        fldCode = q.fldCode,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectSalGhabl
        public List<OBJ_Pishbini_Daramad> SelectSalGhabl(string fieldName, string Year, int? MotamamId, int organId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.SelectPishbiniBudje_SalGhabl(fieldName, Year, MotamamId, organId)
                    .Select(q => new OBJ_Pishbini_Daramad()
                    {
                        last = q.last,
                        fldCol1 = q.Col1,
                        fldCol2 = q.Col2,
                        fldCol3 = q.Col3,
                        fldCol4 = q.Col4,
                        fldCol5 = q.Col5,
                        fldCol6 = q.Col6,
                        fldCol7 = q.Col7,
                        fldCol8 = q.Col8,
                        fldCol9 = q.Col9,
                        fldCol10 = q.Col10,
                        fldCode = q.fldCode,
                        fldCodingId = q.fldCodingId,
                        fldTitle = q.fldTitle,
                        fldNameDarasad = q.fldNameDarasad,
                        fldflagSanad = q.fldflagSanad
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region CheckPishbiniBudje
        public List<OBJ_CodingBudje_Detail> CheckPishbiniBudje(short Year)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_CheckPishbiniBudje(Year)
                    .Select(q => new OBJ_CodingBudje_Detail()
                    {
                        fldBudCode = q.fldBudCode,
                        fldCode = q.fldCode,
                        fldTitle = q.fldTitle,
                        fldId=q.fldCodeingBudjeId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectTashimDaramadCode
        public List<OBJ_CodehayeDaramad_Tas_him> SelectTashimDaramadCode(short Year,int OrganId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                var test = p.spr_SelectTashimDaramadCode(Year, OrganId)
                    .Select(q => new OBJ_CodehayeDaramad_Tas_him()
                    {
                        fldCodingAcc_DetailsId=q.fldCodingAcc_DetailsId,
                        fldCode=q.fldCode,
                        fldDaramadCode=q.fldDaramadCode,
                        fldHazine=q.fldHazine,
                        fldMali=q.fldMali,
                        fldSarmaye=q.fldSarmaye,
                        fldHozeMamooriyat=q.fldHozeMamooriyat,
                        fldHozeMasraf=q.fldHozeMasraf,
                        fldPercentHazine=q.fldPercentHazine,
                        fldPercentTamallok=q.fldPercentTamallok,
                        fldTitle=q.fldTitle
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region InsertTas_him
        public string InsertTas_him(int CodingId,string Type_TypeId, decimal percentHazine,decimal percentTamalok, int userId, string IP)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_tblDaramadCodeDetails_ACCInsert(CodingId, Type_TypeId, percentHazine, percentTamalok, userId,IP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CopytoMosavab
        public string CopytoMosavab(short Year, int OrganId, int userId)
        {
            using (BudgetEntities p = new BudgetEntities())
            {
                p.spr_CopytoMosavab(Year, OrganId, userId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion

    }
}