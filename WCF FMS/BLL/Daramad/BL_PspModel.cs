using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PspModel
    {
        DL_PspModel PspModel = new DL_PspModel();

        #region Detail
        public OBJ_PspModel Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PspModel.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PspModel> Select(string FieldName, string FilterValue, int h)
        {
            return PspModel.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PspId, string Model, bool MultiHesab, int userId, string Desc, out ClsError error)
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
            else if (PspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است";
            }
            else if (Model == "" || Model == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مدل Psp ضروری است";
            }
            else if (Model.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مدل Psp وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Model.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مدل Psp وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PspModel.CheckRepeatedRow(PspId, Model, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "برای شرکت Psp مورد نظر مدل وارد شده  تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PspModel.Insert(PspId, Model,MultiHesab, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int PspId, string Model, bool MultiHesab, int userId, string Desc, out ClsError error)
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
            else if (PspId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت Psp ضروری است";
            }
            else if (Model == "" || Model == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مدل Psp ضروری است";
            }
            else if (Model.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مدل Psp وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Model.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مدل Psp وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (PspModel.CheckRepeatedRow(PspId, Model, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "برای شرکت Psp مورد نظر مدل وارد شده  تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PspModel.Update(Id, PspId, Model,MultiHesab, userId, Desc);

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
            else if (PspModel.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PspModel.Delete(id, userId);
        }
        #endregion
    }
}