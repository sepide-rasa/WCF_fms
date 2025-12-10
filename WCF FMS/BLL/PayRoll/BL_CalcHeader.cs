using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_CalcHeader
    {
        DL_CalcHeader CalcHeader = new DL_CalcHeader();
        #region Detail
        public OBJ_CalcHeader Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CalcHeader.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CalcHeader> Select(string FieldName, string FilterValue, short Year, byte Month, int NobatPardakhtId, int OrganId, int UserId, int h)
        {
            return CalcHeader.Select(FieldName, FilterValue, Year, Month, NobatPardakhtId, OrganId, UserId, h);
        }
        #endregion
        #region Insert
        public int Insert(short Year, byte Month, int NobatPardakhtId, byte Status, string PersonalId, byte CalcType, int OrganId, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است.";
            }
            else if (Month == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است.";
            }
            else if (NobatPardakhtId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوبت پرداخت ضروری است.";
            }
            else if (PersonalId == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه پرسنل ضروری است.";
            }
            else if (CalcType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع محاسبه ضروری است.";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه ارگان ضروری است.";
            }
            else if (IP == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "IP ضروری است.";
            }
            if (error.ErrorType == true)
                return 0;

            return CalcHeader.Insert(Year,Month,NobatPardakhtId,Status,PersonalId,CalcType,OrganId,UserId,IP);
        }
        #endregion
        #region Delete
        public string Delete(short Year, byte Month, int NobatPardakhtId, string TypeEstekhdam, string CostCenterId, int OrganId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است";
            }
            else if (NobatPardakhtId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوبت پرداخت ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه ارگان ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return CalcHeader.Delete(Year,Month,NobatPardakhtId,OrganId,TypeEstekhdam,CostCenterId);
        }
        #endregion
    }
}