using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Morakhasi
    {
        DL_Morakhasi Morakhasi = new DL_Morakhasi();
        #region Detail
        public OBJ_Morakhasi Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Morakhasi.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Morakhasi> Select(string FieldName, string FilterValue, int id, short Year, byte Month, byte NobatPardakht, int OrganId, int h)
        {
            return Morakhasi.Select(FieldName, FilterValue, id, Year, Month, NobatPardakht, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, int UserId, string Desc, out ClsError Error)
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
            else if (Year==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (SalAkharinHokm == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال آخرین حکم ضروری است";
            }
            else if (Morakhasi.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Morakhasi.Insert(PersonalId, Year,Month,NobatePardakht,SalAkharinHokm,Tedad, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, int UserId, string Desc, out ClsError Error)
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
            else if (SalAkharinHokm == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال آخرین حکم ضروری است";
            }
            else if (Morakhasi.CheckRepeatedRow(PersonalId, Year, Month, NobatePardakht, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Morakhasi.Update(Id, PersonalId, Year, Month, NobatePardakht, SalAkharinHokm, Tedad, UserId, Desc);
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
            return Morakhasi.Delete(Id, UserId);
        }
        #endregion

        #region MorakhasiGroup
        public List<OBJ_Morakhasi> MorakhasiGroup(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart)
        {
            return Morakhasi.MorakhasiGroup(FieldName, Year, Month, NobatPardakht, OrganId, CostCenter_Chart);
        }
        #endregion
    }
}