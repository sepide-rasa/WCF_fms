using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_DaramadGroup_Parametr
    {
        DL_DaramadGroup_Parametr DaramadGroup_Parametr = new DL_DaramadGroup_Parametr();

        #region Detail
        public OBJ_DaramadGroup_Parametr Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DaramadGroup_Parametr.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_DaramadGroup_Parametr> Select(string FieldName, string FilterValue, int h)
        {
            return DaramadGroup_Parametr.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int DaramadGroupId, string EnName, string FnName, bool Status, byte NoeField, int? ComboBoxId, int userId, string Desc, out ClsError error)
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
            else if (EnName == "" || EnName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان انگلیسی ضروری است";
            }
            else if (EnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (EnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FnName == "" || FnName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان فارسی ضروری است";
            }
            else if (FnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (FnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DaramadGroup_Parametr.Insert(DaramadGroupId, EnName, FnName, Status, NoeField, ComboBoxId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int DaramadGroupId, string EnName, string FnName, bool Status, byte NoeField, int? ComboBoxId, int userId, string Desc, out ClsError error)
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
            else if (EnName == "" || EnName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان انگلیسی ضروری است";
            }
            else if (EnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (EnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FnName == "" || FnName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان فارسی ضروری است";
            }
            else if (FnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (FnName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DaramadGroup_Parametr.Update(Id, DaramadGroupId, EnName, FnName, Status, NoeField, ComboBoxId, userId, Desc);

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
            if (error.ErrorType == true)
                return "خطا";

            return DaramadGroup_Parametr.Delete(id, userId);
        }
        #endregion
    }
}