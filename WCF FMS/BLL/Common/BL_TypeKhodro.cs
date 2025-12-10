using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_TypeKhodro
    {
        DL_TypeKhodro TypeKhodro = new DL_TypeKhodro();

        #region Detail
        public OBJ_TypeKhodro Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TypeKhodro.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TypeKhodro> Select(string FieldName, string FilterValue, int h)
        {
            return TypeKhodro.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع خودرو ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TypeKhodro.CheckRepeatedRow(fldName,0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع خودرو وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TypeKhodro.Insert(fldName, userId, Desc, IP);

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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع خودرو ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TypeKhodro.CheckRepeatedRow(fldName, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع خودرو وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TypeKhodro.Update(fldId, fldName, userId, Desc, IP);

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

            if (error.ErrorType == true)
                return "خطا";

            return TypeKhodro.Delete(id, userId);
        }
        #endregion
        #region UpdateOrder
        public string UpdateOrder(string FieldName, int fldId, int OrderId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TypeKhodro.UpdateOrder(FieldName, fldId, OrderId);

        }
        #endregion
    }
}