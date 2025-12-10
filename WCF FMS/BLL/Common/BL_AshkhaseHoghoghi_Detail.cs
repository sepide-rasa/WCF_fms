using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_AshkhaseHoghoghi_Detail
    {
        DL_AshkhaseHoghoghi_Detail AshkhaseHoghoghi_Detail = new DL_AshkhaseHoghoghi_Detail();

        #region Detail
        public OBJ_AshkhaseHoghoghi_Detail Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AshkhaseHoghoghi_Detail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_AshkhaseHoghoghi_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return AshkhaseHoghoghi_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AshkhaseHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            else if (AshkhaseHoghoghi_Detail.CheckRepeatedRow(AshkhaseHoghoghiId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات تکمیلی شخص حقوقی مورد نظر قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AshkhaseHoghoghi_Detail.Insert(AshkhaseHoghoghiId,CodEghtesadi,Address,CodePosti,ShomareTelephone, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AshkhaseHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            else if (AshkhaseHoghoghi_Detail.CheckRepeatedRow(AshkhaseHoghoghiId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات تکمیلی شخص حقوقی مورد نظر قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AshkhaseHoghoghi_Detail.Update(fldId, AshkhaseHoghoghiId, CodEghtesadi, Address, CodePosti, ShomareTelephone, userId, Desc);

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
                error.ErrorMsg = "کد شهر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AshkhaseHoghoghi_Detail.Delete(id, userId);
        }
        #endregion
    }
}