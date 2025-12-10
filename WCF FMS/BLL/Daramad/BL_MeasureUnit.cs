using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MeasureUnit
    {
        DL_MeasureUnit MeasureUnit = new DL_MeasureUnit();

        #region Detail
        public OBJ_MeasureUnit Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MeasureUnit.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MeasureUnit> Select(string FieldName, string FilterValue, int h)
        {
            return MeasureUnit.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string NameVahed, int userId, string Desc, out ClsError error)
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
            else if (NameVahed == "" || NameVahed==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام واحد ضروری است";
            }
            else if (NameVahed.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameVahed.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد. ";
            }
            else if (MeasureUnit.CheckRepeatedRow(NameVahed, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام واحد تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MeasureUnit.Insert(NameVahed, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameVahed, int userId, string Desc, out ClsError error)
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
            else if (NameVahed == "" || NameVahed == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام واحد ضروری است";
            }
            else if (NameVahed.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameVahed.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MeasureUnit.CheckRepeatedRow(NameVahed, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام واحد تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MeasureUnit.Update(Id, NameVahed, userId, Desc);

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
            else if (MeasureUnit.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MeasureUnit.Delete(id, userId);
        }
        #endregion
    }
}