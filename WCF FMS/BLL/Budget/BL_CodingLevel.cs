using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_CodingLevel
    {
        DL_CodingLevel CodingLevel = new DL_CodingLevel();

        #region Detail
        public OBJ_CodingLevel Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingLevel.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CodingLevel> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CodingLevel.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldFiscalBudjeId, int fldArghamNum, int OrganId, int userId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldFiscalBudjeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سال بودجه ملی ضروری است";
            }
            else if (fldArghamNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ارقام ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingLevel.Insert(fldName, fldFiscalBudjeId, fldArghamNum, OrganId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldFiscalBudjeId, int fldArghamNum, int OrganId, int userId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldFiscalBudjeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سال بودجه ملی ضروری است";
            }
            else if (fldArghamNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ارقام ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return CodingLevel.Update(Id, fldName, fldFiscalBudjeId, fldArghamNum, OrganId, userId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingLevel.Delete(id, userId);
        }
        #endregion

        #region BudjeLevel
        public List<OBJ_BudjeLevel> BudjeLevel(short Year, int OrganId)
        {
            return CodingLevel.BudjeLevel(Year, OrganId);
        }
        #endregion        
    }
}