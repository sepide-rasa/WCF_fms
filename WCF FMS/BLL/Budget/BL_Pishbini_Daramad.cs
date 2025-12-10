using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_Pishbini_Daramad
    {

        DL_Pishbini_Daramad Pishbini = new DL_Pishbini_Daramad();

        #region Select
        public List<OBJ_Pishbini_Daramad> Select(string fieldName, string Year, int? MotamamId, int organId)
        {
            return Pishbini.Select(fieldName, Year, MotamamId,organId);
        }
        #endregion
        #region CheckPishbiniBudje
        public List<OBJ_CodingBudje_Detail> CheckPishbiniBudje(short Year)
        {
            return Pishbini.CheckPishbiniBudje(Year);
        }
        #endregion
        #region SelectTashimDaramadCode
        public List<OBJ_CodehayeDaramad_Tas_him> SelectTashimDaramadCode(short Year,int OrganId)
        {
            return Pishbini.SelectTashimDaramadCode(Year,OrganId);
        }
        #endregion
        #region SelectProjectCoding
        public List<OBJ_Pishbini_Daramad> SelectProjectCoding(int fldBudgetCodingId)
        {
            return Pishbini.SelectProjectCoding(fldBudgetCodingId);
        }
        #endregion

        #region SelectCodingAccNotBudje
        public List<OBJ_SelectCodingAccNotBudje> SelectCodingAccNotBudje(string fieldName, string aztarikh, string tatarikh, byte? salmaliID, byte? organId, int? azsanad, int? tasanad, byte? sanadtype)
        {
            return Pishbini.SelectCodingAccNotBudje(fieldName, aztarikh, tatarikh, salmaliID, organId, azsanad, tasanad, sanadtype);
        }
        #endregion
        #region SelectSalGhabl
        public List<OBJ_Pishbini_Daramad> SelectSalGhabl(string fieldName, string Year, int? MotamamId, int organId)
        {
            return Pishbini.SelectSalGhabl(fieldName, Year, MotamamId, organId);
        }
        #endregion
        #region InsertTas_him
        public string InsertTas_him(int CodingId, string Type_TypeId, decimal percentHazine, decimal percentTamalok,int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (CodingId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حساب ضروری است";
            }
            else if (Type_TypeId == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد تایپ ضروری  است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Pishbini.InsertTas_him(CodingId, Type_TypeId, percentHazine, percentTamalok, userId, IP);
        }
        #endregion
        #region CopytoMosavab
        public string CopytoMosavab(short Year, int OrganId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری  است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Pishbini.CopytoMosavab(Year,OrganId, userId);
        }
        #endregion
    }
}