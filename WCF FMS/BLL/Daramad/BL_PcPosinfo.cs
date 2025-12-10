using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosinfo
    {
         DL_PcPosInfo pcposinfo = new DL_PcPosInfo();
        #region Detail
        public OBJ_PcPosInfo Detail(int id, string value1, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return pcposinfo.Detail(id,value1);


        }
        #endregion
        #region Select
        public List<OBJ_PcPosInfo> select(string FieldName, string Value, string value1, int h)
        {
            return pcposinfo.select(FieldName, Value,  value1, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldPspId, int fldOrganId, int fldUserId, string fldDesc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldDesc == null)
                fldDesc = "";
            if (fldUserId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان است.";
            }
            else if (fldPspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است.";
            }
            else if (pcposinfo.CheckRepeatedRow(0, fldPspId, fldOrganId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";
            return pcposinfo.Insert(fldPspId, fldOrganId, fldUserId, fldDesc);
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldPspId, int fldOrganId, int fldUserId, string fldDesc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldDesc == null)
                fldDesc = "";
            if (fldId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان است.";
            }
            else if (fldPspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است.";
            }
            else if (pcposinfo.CheckRepeatedRow(fldId, fldPspId, fldOrganId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";
            return pcposinfo.Update(fldId, fldPspId, fldOrganId, fldUserId, fldDesc);
        }
        #endregion
        #region Delete
        public string Delete(int fldID, int fldUserID, out ClsError error)
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
            else if (pcposinfo.CheckDelete(fldID))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return pcposinfo.Delete(fldID, fldUserID);
        }
        #endregion
    }
}           