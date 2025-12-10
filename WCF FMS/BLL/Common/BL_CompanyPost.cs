using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_CompanyPost
    {
        DL_CompanyPost CompanyPost = new DL_CompanyPost();

        #region Detail
        public OBJ_CompanyPost Detail(short id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CompanyPost.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CompanyPost> Select(string FieldName, string FilterValue, int h)
        {
            return CompanyPost.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, int UserId,  string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CompanyPost.CheckRepeatedRow(Name, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CompanyPost.Insert(Name, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(short Id, string Name, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CompanyPost.CheckRepeatedRow(Name, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CompanyPost.Update(Id, Name, UserId,Desc);

        }
        #endregion
        #region Delete
        public string Delete(short id, int userId, out ClsError error)
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

            return CompanyPost.Delete(id, userId);
        }
        #endregion
    }
}