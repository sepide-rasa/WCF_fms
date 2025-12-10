using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mamuriyat
    {
        DL_Mamuriyat Mamuriyat = new DL_Mamuriyat();
        #region Detail
        public OBJ_Mamuriyat Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return Mamuriyat.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Mamuriyat> Select(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, int OrganId, int h)
        {
            return Mamuriyat.Select(FieldName, FilterValue, Id, Year, Month, NobatPardakht, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30,
            byte Be10, byte Be20, byte Be30, int UserId, string Desc, out ClsError Error)
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
            else if (Mamuriyat.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
           if (BaBeytute + BeduneBeytute > 50) 
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مجموع ماموریت وارد شده بیش از حد مجاز حداکثر مقدار 50 است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mamuriyat.Insert(PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30
            , byte Be10, byte Be20, byte Be30, int UserId, string Desc, out ClsError Error)
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
            else if (Mamuriyat.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (BaBeytute + BeduneBeytute > 50) 
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مجموع ماموریت وارد شده بیش از حد مجاز حداکثر مقدار 50 است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mamuriyat.Update(Id, PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc);
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
            return Mamuriyat.Delete(Id, UserId);
        }
        #endregion

        #region MamuriyatGroup
        public List<OBJ_Mamuriyat> MamuriyatGroup(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart)
        {
            return Mamuriyat.MamuriyatGroup(FieldName, Year, Month, NobatPardakht, OrganId, CostCenter_Chart);
        }
        #endregion
    }
}