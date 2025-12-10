using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_EtelaatEydi
    {
        DL_EtelaatEydi EtelaatEydi = new DL_EtelaatEydi();
        #region Detail
        public OBJ_EtelaatEydi Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return EtelaatEydi.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_EtelaatEydi> Select(string FieldName, string FilterValue, int Id, short Year, byte NobatePardakht, int OrganId, int h)
        {
            return EtelaatEydi.Select(FieldName, FilterValue, Id, Year, NobatePardakht, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
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
            else if (NobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return EtelaatEydi.Insert(PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, int UserId, string Desc, out ClsError Error)
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
            else if (NobatePardakht == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return EtelaatEydi.Update(Id, PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return EtelaatEydi.Delete(Id, UserId);
        }
        #endregion

        #region EtelaatEydiGroup
        public List<OBJ_EtelaatEydi> EtelaatEydiGroup(string FieldName, short Sal, byte NobatPardakht, string Value, int OrganId, int CostCenter_Chart)
        {
            return EtelaatEydi.EtelaatEydiGroup(FieldName, Sal, NobatPardakht, Value, OrganId, CostCenter_Chart);
        }
        #endregion
    }
}