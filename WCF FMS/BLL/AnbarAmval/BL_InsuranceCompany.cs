using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_InsuranceCompany
    {
        DL_InsuranceCompany InsuranceCompany = new DL_InsuranceCompany();

        #region Detail
        public OBJ_InsuranceCompany Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return InsuranceCompany.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_InsuranceCompany> Select(string FieldName, string FilterValue, int h)
        {
            return InsuranceCompany.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, byte[] fldFile, string Pasvand, int userId, string Desc, int OrganId, string IP, out ClsError error)
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
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InsuranceCompany.Insert(fldName, fldFile, Pasvand, userId, Desc, OrganId, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int FileId, byte[] fldFile, string Pasvand, int userId, string Desc, int OrganId, string IP, out ClsError error)
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
                error.ErrorMsg = "کد ضروری است";
            }
            if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InsuranceCompany.Update(fldId, fldName, FileId, fldFile, Pasvand, userId, Desc,OrganId,IP);

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

            return InsuranceCompany.Delete(id, userId);
        }
        #endregion
    }
}