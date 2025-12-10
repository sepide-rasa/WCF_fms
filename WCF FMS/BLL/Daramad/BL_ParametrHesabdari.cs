using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ParametrHesabdari
    {
        DL_ParametrHesabdari ParametrHesabdari = new DL_ParametrHesabdari();

        #region Detail
        public OBJ_ParametrHesabdari Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParametrHesabdari.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParametrHesabdari> Select(string FieldName, string FilterValue, int h)
        {
            return ParametrHesabdari.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesabCodeDaramadId, string CodeHesab, Nullable<int> HesabId, int CompanyId, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب کددرآمد ضروری است";
            }
            else if (CompanyId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametrHesabdari.Insert(ShomareHesabCodeDaramadId, CodeHesab, HesabId, CompanyId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string CodeHesab, Nullable<int> HesabId, int CompanyId, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب کددرآمد ضروری است";
            }
            else if (CompanyId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شرکت ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametrHesabdari.Update(Id, ShomareHesabCodeDaramadId, CodeHesab, HesabId, CompanyId, userId, Desc);

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

            return ParametrHesabdari.Delete(id, userId);
        }
        #endregion
    }
}