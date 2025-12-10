using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_SayerPardakhts
    {
        DL_SayerPardakhts SayerPardakhts = new DL_SayerPardakhts();
        #region Detail
        public OBJ_SayerPardakhts Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سایر پرداخت ها ضروری است";
            }
            return SayerPardakhts.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_SayerPardakhts> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int OrganId, int h)
        {
            return SayerPardakhts.Select(FieldName, FilterValue, Id, Year, Month, NobatPardakht, MarhalePardakht, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, int UserId, string Desc, out ClsError Error)
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
            else if (Title ==null ||Title=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (ShomareHesabId == 0)
            {
                Error.ErrorMsg = "کد شماره حساب ضروری است.";
                Error.ErrorType = true;
            }
            else if (SayerPardakhts.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakt, MarhalePardakht, 0))
            {
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
                Error.ErrorType = true;
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return SayerPardakhts.Insert(PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti,ShomareHesabId,CostCenterId,  Mostamar, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "کد سایر پرداخت ها ضروری است";
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
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (ShomareHesabId == 0)
            {
                Error.ErrorMsg = "کد شماره حساب ضروری است.";
                Error.ErrorType = true;
            }
            else if (SayerPardakhts.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakt, MarhalePardakht, Id))
            {
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
                Error.ErrorType = true;
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return SayerPardakhts.Update(Id, PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti, ShomareHesabId, CostCenterId,  Mostamar, UserId, Desc);
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
                Error.ErrorMsg = "کد سایر پرداخت ها ضروری است";
            }
           /* else if (SayerPardakhts.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }*/
            if (Error.ErrorType == true)
                return "خطا";
            return SayerPardakhts.Delete(Id, UserId);
        }
        #endregion
    }
}