using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_OrganizationalPostsEjraee
    {
        DL_OrganizationalPostsEjraee OrganizationalPostsEjraee = new DL_OrganizationalPostsEjraee();

        #region Detail
        public OBJ_OrganizationalPostsEjraee Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return OrganizationalPostsEjraee.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_OrganizationalPostsEjraee> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return OrganizationalPostsEjraee.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (OrgPostCode == "" || OrgPostCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (OrgPostCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد سازمان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ChartOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت پست سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPostsEjraee.Insert(Title, OrgPostCode, ChartOrganId, PID, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (OrgPostCode == "" || OrgPostCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (OrgPostCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد سازمان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ChartOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت پست سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPostsEjraee.Update(Id, Title, OrgPostCode, ChartOrganId, PID, userId, Desc);

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
            else if (OrganizationalPostsEjraee.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = " آیتم در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return OrganizationalPostsEjraee.Delete(id, userId);
        }
        #endregion
    }
}