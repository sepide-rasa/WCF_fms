using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;


namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosParametr
    {
        
        DL_PcPosParametr PcPosParametr = new DL_PcPosParametr();

        #region Detail
        public OBJ_PcPosParametr Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg= "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PcPosParametr.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_PcPosParametr> Select(string fieldname, string value, int OrganId, int h)
        {
            return PcPosParametr.Select(fieldname, value, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldFaName, string fldEnName, int PspId, int fldUserId, string fldDesc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldDesc == null)
                fldDesc = "";
            if (fldFaName == null || fldFaName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است .";
            }
            else if (fldFaName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }

            else if (fldFaName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (fldEnName == null || fldEnName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انگلیسی ضروری است .";
            }
            else if (fldEnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }

            else if (fldEnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (PspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PcPosParametr.CheckRepeatedRow(0, fldFaName, fldEnName, PspId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است .";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosParametr.Insert(fldFaName, fldEnName, PspId, fldUserId, fldDesc);
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldFaName, string fldEnName, int PspId, int fldUserId, string fldDesc, out ClsError error)
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
            else if (fldFaName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }

            else if (fldFaName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (fldEnName == null || fldEnName == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انگلیسی ضروری است .";
            }
            else if (fldEnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }

            else if (fldEnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (PspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است.";
            }
            else if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PcPosParametr.CheckRepeatedRow(fldId, fldFaName, fldEnName, PspId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است .";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosParametr.Update(fldId, fldFaName, fldEnName, PspId, fldUserId, fldDesc);
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
            else if (PcPosParametr.CheckDelete(fldID))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosParametr.Delete(fldID, fldUserID);
        }
        #endregion
        #region SelectPcPos_Param_Value
        public List<OBJ_PcPosParametr> SelectPcPos_Param_Value(int Value)
        {
            return PcPosParametr.SelectPcPos_Param_Value(Value);
        }
        #endregion
    }
}