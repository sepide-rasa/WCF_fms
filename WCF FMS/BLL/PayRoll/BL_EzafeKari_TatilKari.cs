using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_EzafeKari_TatilKari
    {
        DL_EzafeKari_TatilKari EzafeKari_TatilKari = new DL_EzafeKari_TatilKari();
        #region Detail
        public OBJ_EzafeKari_TatilKari Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return EzafeKari_TatilKari.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_EzafeKari_TatilKari> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatePardakht, byte Type,int OrganId, int h)
        {
            return EzafeKari_TatilKari.Select(FieldName, FilterValue, Id, Year, Month, NobatePardakht, Type, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "کد پرسنل ضروری است";
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
            else if (NobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            
            else if (EzafeKari_TatilKari.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, Type, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Type == 1)
            {
                if (Count > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مقدار وارد شده بیش از حد مجاز است حداکثر مقدار 175 است";
                }
            }
            if (Type == 2)
            {
                if (Count > 30)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مقدار وارد شده بیش از حد مجاز است حداکثر مقدار 30 است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return EzafeKari_TatilKari.Insert(PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "کد پرسنل ضروری است";
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
            else if (NobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            
            else if (EzafeKari_TatilKari.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, Type , Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Type == 1)
            {
                if (Count > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مقدار وارد شده بیش از حد مجاز است حداکثر مقدار 175 است";
                }
            }
            if (Type == 2)
            {
                if (Count > 30)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مقدار وارد شده بیش از حد مجاز است حداکثر مقدار 30 است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return EzafeKari_TatilKari.Update(Id, PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc);
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
            return EzafeKari_TatilKari.Delete(Id, UserId);
        }
        #endregion

        #region EzafeKari_TatilKariGroup
        public List<OBJ_EzafeKari_TatilKari> EzafeKari_TatilKariGroup(string FieldName, string Sal, string Mah, byte NobatePardakht, byte Type, int OrganId, int CostCenter_Chart)
        {
            return EzafeKari_TatilKari.EzafeKari_TatilKariGroup(FieldName, Sal, Mah, NobatePardakht, Type, OrganId,CostCenter_Chart);
        }
        #endregion
    }
}