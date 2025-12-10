using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosParam_Dtail
    {
        DL_PcPosParam_Dtail PcPosParam = new DL_PcPosParam_Dtail();
        #region Detail
        public OBJ_PcPosParam_Dtail Detail(int Id, out ClsError error)
        {
            error = new ClsError();
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PcPosParam.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_PcPosParam_Dtail> Select(string fieldname, string value, int h)
        {
            return PcPosParam.Select(fieldname, value, h);
        }
        #endregion
        #region Insert
        public String Insert(int fldPcPosParamId, int fldPcPosInfoId, string fldValue, int fldUserId, string fldDesc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldDesc == null)
                fldDesc = "";
            if (fldPcPosParamId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "پارامترهای pc pos ضروری است.";
            }
            else if (fldPcPosInfoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات pc pos ضروری است.";
            }
            else if (fldValue == null || fldValue == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";
            return PcPosParam.Insert(fldPcPosParamId, fldPcPosInfoId, fldValue, fldUserId, fldDesc);


        }
        #endregion
        #region Update
        public string Update(int fldId, int fldPcPosParamId, int fldPcPosInfoId, string fldValue, int fldUserId, string fldDesc,out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldDesc == null)
                fldDesc = "";
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (fldPcPosParamId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "پارامترهای pc pos ضروری است.";
            }
            else if (fldPcPosInfoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات pc pos ضروری است.";
            }
            else if (fldValue == null || fldValue == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";
            return PcPosParam.Update(fldId,fldPcPosParamId, fldPcPosInfoId, fldValue, fldUserId, fldDesc);
        }
        #endregion
        #region Delete
        public string Delete(int fldID, int fldUserID,out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldUserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosParam.Delete(fldID, fldUserID);
        }
        #endregion
    }
}