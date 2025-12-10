using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_InsuranceType
    {
        DL_InsuranceType InsuranceType = new DL_InsuranceType();

        #region Detail
        public OBJ_InsuranceType Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return InsuranceType.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_InsuranceType> Select(string FieldName, string FilterValue, int h)
        {
            return InsuranceType.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int userId, string Desc, int OrganId, string IP, out ClsError error)
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
            if (fldTitle == "" || fldTitle == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InsuranceType.Insert(fldTitle, userId, Desc,OrganId,IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, int userId, string Desc, int OrganId, string IP, out ClsError error)
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
            if (fldTitle == "" || fldTitle == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InsuranceType.Update(fldId, fldTitle, userId, Desc, OrganId, IP);

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

            return InsuranceType.Delete(id, userId);
        }
        #endregion
    }
}