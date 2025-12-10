using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_BillsType
    {
        DL_BillsType BillsType = new DL_BillsType();

        #region Detail
        public OBJ_BillsType Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return BillsType.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_BillsType> Select(string FieldName, string FilterValue, int h)
        {
            return BillsType.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int userId, string Desc,string IP, out ClsError error)
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
            if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (BillsType.CheckRepeatedRow(fldName, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return BillsType.Insert(fldName,IP, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int userId, string Desc, string IP, out ClsError error)
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
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع قبوض جهت ویرایش ضروری است";
            }
            if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (BillsType.CheckRepeatedRow(fldName, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return BillsType.Update(fldId, fldName, IP, userId, Desc);

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
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return BillsType.Delete(id, userId);
        }
        #endregion
    }
}