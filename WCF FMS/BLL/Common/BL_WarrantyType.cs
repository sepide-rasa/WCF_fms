using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_WarrantyType
    {
        DL_WarrantyType WarrantyType = new DL_WarrantyType();

        #region Detail
        public OBJ_WarrantyType Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return WarrantyType.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_WarrantyType> Select(string FieldName, string FilterValue, int h)
        {
            return WarrantyType.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name,int UserId, string IP, string Desc, out ClsError error)
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
            else if (WarrantyType.CheckRepeatedRow(Name, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return WarrantyType.Insert(Name, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name,  int UserId, string IP, string Desc, out ClsError error)
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
            else if (WarrantyType.CheckRepeatedRow(Name, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return WarrantyType.Update(Id, Name, UserId, IP, Desc);

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

            return WarrantyType.Delete(id, userId);
        }
        #endregion
    }
}