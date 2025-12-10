using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_Morakhasi
    {
        DL_Mohasebat_Morakhasi Mohasebat_Morakhasi = new DL_Mohasebat_Morakhasi();
        #region Detail
        public OBJ_Mohasebat_Morakhasi Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_Morakhasi.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Morakhasi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Mohasebat_Morakhasi.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, byte HesabTypeId, int OrganId, int UserId, string Desc, string IP, out ClsError Error)
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
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (HokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم پرسنل ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (SalHokm == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال حکم ضروری است";
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
            return Mohasebat_Morakhasi.Insert(PersonalId,Tedad,Mablagh,Month,Year,NobatPardakht,SalHokm,HokmId, HesabTypeId,OrganId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, int CostCenterId, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (HokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم پرسنل ضروری است";
            }
            else if (CostCenterId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (SalHokm == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال حکم ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_Morakhasi.Update(Id, PersonalId,Tedad,Mablagh,Month,Year,NobatPardakht,SalHokm,HokmId,CostCenterId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
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
            return Mohasebat_Morakhasi.Delete(Id, UserId);
        }
        #endregion
    }
}