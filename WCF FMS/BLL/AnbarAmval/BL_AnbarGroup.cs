using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_AnbarGroup
    {
        DL_AnbarGroup AnbarGroup = new DL_AnbarGroup();

        #region Detail
        public OBJ_AnbarGroup Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AnbarGroup.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_AnbarGroup> Select(string FieldName, string FilterValue, int h)
        {
            return AnbarGroup.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, int UserId, string IP, string Desc, out ClsError error)
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
            if (error.ErrorType == true)
                return "خطا";

            return AnbarGroup.Insert(Name, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int UserId, string IP, string Desc, out ClsError error)
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
            if (error.ErrorType == true)
                return "خطا";

            return AnbarGroup.Update(Id, Name, UserId, IP, Desc);

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
            else if (AnbarGroup.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AnbarGroup.Delete(id, userId);
        }
        #endregion
    }
}