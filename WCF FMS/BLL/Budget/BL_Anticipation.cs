using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;


namespace WCF_FMS.BLL.Budget
{
    public class BL_Anticipation
    {
        DL_Anticipation Anticipation = new DL_Anticipation();
        #region Detail
        public OBJ_Anticipation Detail(int id,  out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Anticipation.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Anticipation> Select(string FieldName, string FilterValue,string FilterValue2,  int h)
        {
            return Anticipation.Select(FieldName, FilterValue, FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingAcc_DetailsId, int? fldCodingBudje_DetailsId, System.Data.DataTable Pishbini, int UserId,out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldCodingAcc_DetailsId == 0 || fldCodingAcc_DetailsId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حساب ضروری است";
            }

            for (int i = 0; i < Pishbini.Rows.Count; i++)
            {
                if (Convert.ToInt32(Pishbini.Rows[i]["BudgetTypeId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نوع بودجه ضروری است";
                }
                else if (Pishbini.Rows[i]["Mablagh"] == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "مبلغ ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anticipation.Insert(fldCodingAcc_DetailsId,fldCodingBudje_DetailsId,Pishbini,UserId);

        }
        #endregion
        #region Update
        public string Update(int Id, int? fldCodingAccId, int? fldCodingBudId, long fldMablagh, int fldBudgetTypeId,int? MotamamId, int userId, out ClsError error)
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
            
            else if (fldBudgetTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع بودجه ای ضروری است.";
            }
                     
            if (error.ErrorType == true)
                return "خطا";

            return Anticipation.Update(Id, fldCodingAccId, fldCodingBudId, fldMablagh, fldBudgetTypeId, MotamamId, userId);

        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int AccCodingId, int BudgetCodingId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AccCodingId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (BudgetCodingId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anticipation.Delete(FieldName, AccCodingId, BudgetCodingId, userId);
        }
        #endregion
    }
}