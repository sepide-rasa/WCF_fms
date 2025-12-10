using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_TaahodatSanavati
    {
        DL_TaahodatSanavati TaahodatSanavati = new DL_TaahodatSanavati();

        #region Detail
        public OBJ_TaahodatSanavati Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TaahodatSanavati.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TaahodatSanavati> Select(string FieldName, string FilterValue, int h)
        {
            return TaahodatSanavati.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, int fldFiscalYearId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldFiscalYearId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سال مالی ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return TaahodatSanavati.Insert(fldD1, fldD2, fldD3, fldH1, fldH2, fldH3, fldH4, fldFiscalYearId, userId, IP);
        }
        #endregion
        #region Update
        public string Update(int Id, long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

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
            
            if (error.ErrorType == true)
                return "خطا";

            return TaahodatSanavati.Update(Id, fldD1, fldD2, fldD3, fldH1, fldH2, fldH3, fldH4, userId, IP);

        }
        #endregion
    }
}