using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_GeneralSetting_ComboBox
    {
        DL_GeneralSetting_ComboBox GeneralSetting = new DL_GeneralSetting_ComboBox();

        #region Detail
        public OBJ_GeneralSetting_ComboBox Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گروه کاربری ضروری است";
            }
            return GeneralSetting.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_GeneralSetting_ComboBox> Select(string FieldName, string FilterValue, int h)
        {
            return GeneralSetting.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldGeneralSettingId, string fldTtile, string fldValue, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldGeneralSettingId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد تنظیمات عمومی است";
            }
            else if (fldTtile == null || fldTtile == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldTtile.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTtile.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GeneralSetting.Insert(fldGeneralSettingId, fldTtile, fldValue, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(byte Id, byte fldGeneralSettingId, string fldTtile, string fldValue, int UserId, string Desc, out ClsError Error)
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
            else if (fldGeneralSettingId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد تنظیمات عمومی است";
            }
            else if (fldTtile == null || fldTtile == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (fldTtile.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTtile.Length > 200)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldValue == null || fldValue == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مقدار ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return GeneralSetting.Update(Id, fldGeneralSettingId, fldTtile, fldValue, UserId, Desc);
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

            return GeneralSetting.Delete(Id, UserId);
        }
        #endregion
    }
}