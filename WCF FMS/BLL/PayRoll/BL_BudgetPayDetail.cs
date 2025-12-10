using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_BudgetPayDetail
    {
        DL_BudgetPayDetail BudgetPayDetail = new DL_BudgetPayDetail();
        #region Detail
        public OBJ_BudgetPayDetail Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return BudgetPayDetail.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_BudgetPayDetail> Select(string FieldName, string FilterValue,  int h)
        {
            return BudgetPayDetail.Select(FieldName, FilterValue,  h);
        }
        #endregion
        #region Insert
        public string Insert(int fldHeaderId, string TypeEstekhdamId,int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (fldHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد  ضروری است";
            }
            else if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (TypeEstekhdamId == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع استخدام ضروری است";
            }
           
            if (Error.ErrorType == true)
                return "خطا";
            return BudgetPayDetail.Insert(fldHeaderId, TypeEstekhdamId, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldHeaderId, int fldTypeEstekhdamId, int fldTypeBimeId, out ClsError Error)
        {
            Error = new ClsError();
            if (fldHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }

            else if (fldTypeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع استخدام ضروری است";
            }
            else if (fldTypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع  بیمه ضروری است";
            }

            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return BudgetPayDetail.Update(Id, fldHeaderId, fldTypeEstekhdamId, fldTypeBimeId);
        }
        #endregion
       

        #region Delete
        public string Delete(int HeaderId, int TypeEstekhdamId, int TypeBimeId, int UserId, out ClsError Error)
        {
            Error = new ClsError();

            if (HeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (TypeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع استخدام ضروری است";
            }
            else if (TypeBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع بیمه ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return BudgetPayDetail.Delete(HeaderId, TypeEstekhdamId, TypeBimeId, UserId);
        }
        #endregion
    }
}