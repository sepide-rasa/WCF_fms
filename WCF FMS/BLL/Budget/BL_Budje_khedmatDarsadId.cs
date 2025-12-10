using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_Budje_khedmatDarsadId
    {
        DL_Budje_khedmatDarsadId Budje_khedmatDarsadId = new DL_Budje_khedmatDarsadId();

        #region Detail
        public OBJ_Budje_khedmatDarsadId Detail(int id,  out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Budje_khedmatDarsadId.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Budje_khedmatDarsadId> Select(string FieldName, string FilterValue,int h)
        {
            return Budje_khedmatDarsadId.Select(FieldName, FilterValue,  h);
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingAcc_detailId, int? fldCodingBudje_DetailsId, int userId, double fldDarsad,System.Data.DataTable Pishbini,  out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
         
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldCodingAcc_detailId == 0 || fldCodingAcc_detailId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حسابداری ضروری است";
            }
            else if (fldCodingBudje_DetailsId!=0 && fldCodingBudje_DetailsId!=null &&(fldDarsad == 0 || fldDarsad == null))
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد ضروری است";
            }
            if (Pishbini.Rows.Count > 0)
            {
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
            }

            if (error.ErrorType == true)
                return "خطا";

            return Budje_khedmatDarsadId.Insert(fldCodingAcc_detailId, fldCodingBudje_DetailsId, userId, fldDarsad,Pishbini);

        }
        #endregion
        #region InsertOnlyKhedmat
        public string InsertOnlyKhedmat(int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, int userId, double fldDarsad, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldCodingAcc_detailId == 0 || fldCodingAcc_detailId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حسابداری ضروری است";
            }
            else if (fldCodingBudje_DetailsId == 0 || fldCodingBudje_DetailsId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد خدمت ضروری است";
            }
            else if (fldDarsad == 0 || fldDarsad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد ضروری است";
            }
            else if (fldDarsad == 0 || fldDarsad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Budje_khedmatDarsadId.InsertOnlyKhedmat(fldCodingAcc_detailId, fldCodingBudje_DetailsId, userId, fldDarsad);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, int userId, double fldDarsad, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


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
            if (fldCodingAcc_detailId == 0 || fldCodingAcc_detailId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حسابداری ضروری است";
            }
            if (fldCodingBudje_DetailsId == 0 || fldCodingBudje_DetailsId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد بودجه ضروری است";
            }
            if (fldDarsad == 0 || fldDarsad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "درصد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Budje_khedmatDarsadId.Update(Id, fldCodingAcc_detailId, fldCodingBudje_DetailsId, userId, fldDarsad);

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

            return Budje_khedmatDarsadId.Delete(id, userId);
        }
        #endregion
    }
}