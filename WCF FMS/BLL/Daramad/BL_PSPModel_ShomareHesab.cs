using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PSPModel_ShomareHesab
    {
        DL_PSPModel_ShomareHesab PSPModel_ShomareHesab = new DL_PSPModel_ShomareHesab();

        #region Detail
        public OBJ_PSPModel_ShomareHesab Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PSPModel_ShomareHesab.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PSPModel_ShomareHesab> Select(string FieldName, string FilterValue, int h)
        {
            return PSPModel_ShomareHesab.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PSPModelId, int ShHesabId, byte Order, int userId, string Desc, out ClsError error)
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
            else if (PSPModelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدل PSP ضروری است";
            }
            else if (ShHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (Order > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ترتیب وارد شده بیشتر از حد مجاز است";
            }
            else if (Order == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ترتیب ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PSPModel_ShomareHesab.Insert(PSPModelId, ShHesabId, Order, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int PSPModelId, int ShHesabId, byte Order, int userId, string Desc, out ClsError error)
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
            else if (PSPModelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدل PSP ضروری است";
            }
            else if (ShHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (Order > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ترتیب وارد شده بیشتر از حد مجاز است";
            }
            else if (Order == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ترتیب ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PSPModel_ShomareHesab.Update(Id, PSPModelId, ShHesabId, Order, userId, Desc);

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

            return PSPModel_ShomareHesab.Delete(id, userId);
        }
        #endregion
    }
}