using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Weighbridge
    {
        DL_Weighbridge Weighbridge = new DL_Weighbridge();

        #region Detail
        public OBJ_Weighbridge Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Weighbridge.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Weighbridge> Select(string FieldName, string FilterValue, int h)
        {
            return Weighbridge.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldAshkhasHoghoghiId, string fldName, string fldAddress, string fldPassword, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldAshkhasHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام باسکول ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام باسکول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام باسکول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldAddress == "" || fldAddress == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "آدرس ضروری است";
            }
            else if (fldAddress.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldPassword == "" || fldPassword == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "رمز عبور ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Weighbridge.Insert(fldAshkhasHoghoghiId, fldName, fldAddress,fldPassword, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldAshkhasHoghoghiId, string fldName, string fldAddress, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldAshkhasHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام باسکول ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام باسکول وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام باسکول وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldAddress == "" || fldAddress == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "آدرس ضروری است";
            }
            else if (fldAddress.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Weighbridge.Update(fldId, fldAshkhasHoghoghiId, fldName, fldAddress, userId, Desc, IP);

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
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (Weighbridge.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Weighbridge.Delete(id, userId);
        }
        #endregion

        #region UpdatePassBaskool
        public string UpdatePassBaskool(int fldId, string fldPassword, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldPassword == "" || fldPassword == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "رمز عبور ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Weighbridge.UpdatePassBaskool(fldId,fldPassword, userId);

        }
        #endregion
    }
}