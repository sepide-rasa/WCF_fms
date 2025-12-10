using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Chek;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.BLL.Chek
{
    public class BL_SodorCheck
    {
        DL_SodorCheck SodorCheck = new DL_SodorCheck();

        #region Detail
        public OBJ_SodorCheck Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SodorCheck.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_SodorCheck> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return SodorCheck.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region SelectSumMablaghCheck_Factor
        public long SelectSumMablaghCheck_Factor(string FieldName, string FilterValue)
        {
            return SodorCheck.SelectSumMablaghCheck_Factor(FieldName, FilterValue);
        }
        #endregion
        #region Insert
        public string Insert(int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh,int? FactorId,int? ContractId,
            int? TankhahGroupId,int OrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (DasteCheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دسته چک ضروری است";
            }
            else if (TarikhVosol == "" || TarikhVosol == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وصول ضروری است";
            }
            else if (!r.IsMatch(TarikhVosol) || !r.IsMatch(TarikhVosol))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "در وجه ضروری است";
            }
            else if (CodeSerialCheck == "" || CodeSerialCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سریال چک ضروری است";
            }
            else if (CodeSerialCheck.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد سریال چک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodorCheck.Insert(DasteCheckId, TarikhVosol, AshkhasId, CodeSerialCheck, Babat, BabatFlag, Mablagh,FactorId,ContractId,TankhahGroupId, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh,int? FactorId,int? ContractId,
            int? TankhahGroupId,int OrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

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
            else if (DasteCheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دسته چک ضروری است";
            }
            else if (TarikhVosol == "" || TarikhVosol == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وصول ضروری است";
            }
            else if (!r.IsMatch(TarikhVosol) || !r.IsMatch(TarikhVosol))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "در وجه ضروری است";
            }
            else if (CodeSerialCheck == "" || CodeSerialCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سریال چک ضروری است";
            }
            else if (CodeSerialCheck.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد سریال چک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodorCheck.Update(Id, DasteCheckId, TarikhVosol, AshkhasId, CodeSerialCheck, Babat, BabatFlag, Mablagh,FactorId,ContractId,TankhahGroupId, OrganId, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (SodorCheck.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodorCheck.Delete(id, userId);
        }
        #endregion
    }
}