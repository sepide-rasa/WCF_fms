using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_Motammam
    {
        DL_Motammam Motammam = new DL_Motammam();

        #region Detail
        public OBJ_Motammam Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Motammam.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Motammam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Motammam.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldFiscalYearId, string fldTarikh, int OrganId, int userId, string Desc, out ClsError error)
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
            if (fldFiscalYearId == 0 || fldFiscalYearId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است";
            }
            if (fldTarikh == "" || fldTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Motammam.Insert(fldFiscalYearId,fldTarikh, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldFiscalYearId, string fldTarikh, int OrganId, int userId, string Desc, out ClsError error)
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
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (fldFiscalYearId == 0 || fldFiscalYearId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است";
            }
            if (fldTarikh == "" || fldTarikh == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Motammam.Update(Id, fldFiscalYearId, fldTarikh, OrganId, userId, Desc);

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

            return Motammam.Delete(id, userId);
        }
        #endregion
    }
}