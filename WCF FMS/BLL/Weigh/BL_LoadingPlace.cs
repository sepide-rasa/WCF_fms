using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_LoadingPlace
    {
        DL_LoadingPlace LoadingPlace = new DL_LoadingPlace();

        #region Detail
        public OBJ_LoadingPlace Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LoadingPlace.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_LoadingPlace> Select(string FieldName, string FilterValue, int h)
        {
            return LoadingPlace.Select(FieldName, FilterValue, h);
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
                error.ErrorMsg = "محل بارگیری ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل بارگیری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل بارگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (LoadingPlace.CheckRepeatedRow(fldName, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل بارگیری وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LoadingPlace.Insert( fldName, userId, Desc, IP);

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
                error.ErrorMsg = "محل بارگیری ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل بارگیری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 150)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل بارگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (LoadingPlace.CheckRepeatedRow(fldName, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل بارگیری وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LoadingPlace.Update(fldId, fldName, userId, Desc, IP);

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

            return LoadingPlace.Delete(id, userId);
        }
        #endregion
    }
}