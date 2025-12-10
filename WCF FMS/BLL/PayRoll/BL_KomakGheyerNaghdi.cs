using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_KomakGheyerNaghdi
    {
        DL_KomakGheyerNaghdi KomakGheyerNaghdi = new DL_KomakGheyerNaghdi();
        #region Detail
        public OBJ_KomakGheyerNaghdi Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return KomakGheyerNaghdi.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_KomakGheyerNaghdi> Select(string FieldName, string FilterValue, int id, int PersonalId, short Year, byte Month, int OrganId, int h)
        {
            return KomakGheyerNaghdi.Select(FieldName, FilterValue, id, PersonalId, Year, Month, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, int UserId, string Desc, out ClsError Error)
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
            else if (ShomareHesabId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return KomakGheyerNaghdi.Insert(PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, int UserId, string Desc, out ClsError Error)
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
            else if (ShomareHesabId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KomakGheyerNaghdi.Update(Id, PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc);
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
            return KomakGheyerNaghdi.Delete(Id, UserId);
        }
        #endregion
        #region KomakGheyerNaghdiGroup
        public List<OBJ_KomakGheyerNaghdi> KomakGheyerNaghdiGroup(string FieldName,byte Month, short Year, bool NoeMostamer, int PersonalId, int OrganId, int CostCenter_Chart)
        {
            return KomakGheyerNaghdi.KomakGheyerNaghdiGroup(FieldName, Month, Year, NoeMostamer, PersonalId, OrganId, CostCenter_Chart);
        }
        #endregion
    }
}