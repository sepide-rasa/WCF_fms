using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_Eydi
    {
        DL_Mohasebat_Eydi Mohasebat_Eydi = new DL_Mohasebat_Eydi();
        #region Detail
        public OBJ_Mohasebat_Eydi Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_Eydi.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Eydi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Mohasebat_Eydi.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, byte HesabTypeId, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (HesabTypeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع حساب ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_Eydi.Insert(PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht, HesabTypeId, OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, int CostCenterId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (CostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_Eydi.Update(Id, PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht,CostCenterId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_Eydi.Delete(Id, UserId);
        }
        #endregion
    }
}