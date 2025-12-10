using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_FormatFile
    {
        DL_FormatFile FormatFile = new DL_FormatFile();

        #region Detail
        public OBJ_FormatFile Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return FormatFile.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_FormatFile> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return FormatFile.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string FormatName, byte[] Icon, string Passvand, int fldSize, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (FormatName == "" || FormatName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فرمت ضروری است";
            }
            else if (FormatName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فرمت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (FormatName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فرمت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FormatFile.CheckRepeatedRow(FormatName,Passvand,OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return FormatFile.Insert(FormatName, Icon, Passvand,fldSize,OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(byte Id, string FormatName, byte[] Icon, string Passvand, int fldSize, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (FormatName == "" || FormatName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فرمت ضروری است";
            }
            else if (FormatName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فرمت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (FormatName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فرمت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FormatFile.CheckRepeatedRow(FormatName, Passvand, OrganId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return FormatFile.Update(Id, FormatName, Icon, Passvand, fldSize, OrganId, userId, Desc);

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
                error.ErrorMsg = "کد ضروری است";
            }
            else if (FormatFile.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return FormatFile.Delete(id, userId);
        }
        #endregion
    }
}