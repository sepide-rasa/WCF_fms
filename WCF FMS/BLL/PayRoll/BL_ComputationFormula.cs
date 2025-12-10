using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ComputationFormula
    {
        DL_ComputationFormula ComputationFormula = new DL_ComputationFormula();
        #region Detail
        public OBJ_ComputationFormula Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return ComputationFormula.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ComputationFormula> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            return ComputationFormula.Select(FieldName, FilterValue, FilterValue2, FilterValue3, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(bool? Type, string Formule, int? OrganId, string Library, string AzTarikh, int id, string fieldname, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return ComputationFormula.Insert(Type, Formule, OrganId, Library,AzTarikh,id,fieldname, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(string FieldName, int Id, bool? Type, string Formule, int? OrganId, string Library, string AzTarikh, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (FieldName == "formulMohasebat")
            {
                var q=ComputationFormula.Detail(Id, 0);
                if (q == null)
                {
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "فرمول مورد نظر حذف شده است.";
                    }
                }
            }
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Desc == null)
                Desc = "";

            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return ComputationFormula.Update(Id, Type, Formule, OrganId, Library, AzTarikh, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (ComputationFormula.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return ComputationFormula.Delete(Id, UserId);
        }
        #endregion
    }
}