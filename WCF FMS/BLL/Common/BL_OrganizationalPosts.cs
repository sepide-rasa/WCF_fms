using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_OrganizationalPosts
    {
        DL_OrganizationalPosts OrganizationalPosts = new DL_OrganizationalPosts();

        #region Detail
        public OBJ_OrganizationalPosts Detail(int id, int UserId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return OrganizationalPosts.Detail(id,UserId);
        }
        #endregion
        #region Select
        public List<OBJ_OrganizationalPosts> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return OrganizationalPosts.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, int userId, string Desc, out ClsError error)
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
            if (fldOrgPostCode == "" || fldOrgPostCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            //else if (fldOrgPostCode.Length < 2)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر کد پست وارد شده کمتر از حد مجاز میباشد.";
            //}
            else if (fldOrgPostCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد پست وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPosts.Insert(fldTitle,fldOrgPostCode,fldChartOrganId, fldPId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "عنوان چارت سازمانی ضروری است";
            }
            if (fldOrgPostCode == "" || fldOrgPostCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            //else if (fldOrgPostCode.Length < 2)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر کد پست وارد شده کمتر از حد مجاز میباشد.";
            //}
            else if (fldOrgPostCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد پست وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPosts.Update(fldId, fldTitle, fldOrgPostCode, fldChartOrganId, fldPId, userId, Desc);

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
            else if (OrganizationalPosts.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPosts.Delete(id, userId);
        }
        #endregion
    }
}