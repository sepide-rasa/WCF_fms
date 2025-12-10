using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Employee
    {
        DL_Employee Employee = new DL_Employee();

        #region Detail
        public OBJ_Employee Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Employee.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Employee> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            return Employee.Select(FieldName, FilterValue,FilterValue1, h);
        }
        #endregion
        #region Insert
        public int Insert(string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            int chck = 1;
            if (Desc == null)
                Desc = "";


            if (TypeShakhs != 1)
            {
                chck = new BL().checkCodeMeli(fldCodemeli);
                if (chck != 1)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
                }
            }
            if (TypeShakhs == 1)
            {
                if (fldCodemeli == "" || fldCodemeli == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد فراگیر ضروری است";
                }
            }
            var q = Employee.Select("CheckCodemeli", fldCodemeli, "", 1).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ملی وارد شده قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                else if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
                }
                else if (fldFamily == "" || fldFamily == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام خانوادگی ضروری است";
                }
                else if (fldFamily.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldFamily.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارده شده بیشتر از حد مجاز می باشد.";
                }
            }

            if (error.ErrorType == true)
                return 0;

            return Employee.Insert(fldName, fldFamily, fldCodemeli, fldStatus, TypeShakhs, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            int chck = 1;
            if (Desc == null)
                Desc = "";
            if (TypeShakhs != 1)
            {
                chck = new BL().checkCodeMeli(fldCodemeli);
                if (chck != 1)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
                }
            }
            if (TypeShakhs == 1)
            {
                if (fldCodemeli == "" || fldCodemeli == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد فراگیر ضروری است";
                }
            }
            var q = Employee.Select("CheckCodemeli", fldCodemeli, "", 1).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ملی وارد شده قبلا در سیستم ثبت شده است.";
            }
            else
            {

                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                else if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد کارمند ضروری است";
                }
                else if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
                }
                else if (fldFamily == "" || fldFamily == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام خانوادگی ضروری است";
                }
                else if (fldFamily.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldFamily.Length > 100)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارده شده بیشتر از حد مجاز می باشد.";
                }
            }


            if (error.ErrorType == true)
                return "خطا";

            return Employee.Update(fldId, fldName, fldFamily, fldCodemeli, fldStatus, TypeShakhs, userId, Desc);

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
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            if (Employee.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Employee.Delete(id, userId);
        }
        #endregion
    }
}