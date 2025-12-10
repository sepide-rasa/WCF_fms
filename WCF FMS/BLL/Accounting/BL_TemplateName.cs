using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_TemplateName
    {
        DL_TemplateName TemplateName = new DL_TemplateName();

        #region Detail
        public OBJ_TemplateName Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TemplateName.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TemplateName> Select(string FieldName, string FilterValue, int h)
        {
            return TemplateName.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, int AccountingTypeId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (AccountingTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع حسابداری ضروری است";
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
            else if (TemplateName.CheckRepeatedRow(Name, AccountingTypeId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateName.Insert(Name, AccountingTypeId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int AccountingTypeId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (AccountingTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع حسابداری ضروری است";
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
            else if (TemplateName.CheckRepeatedRow(Name, AccountingTypeId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateName.Update(Id, Name, AccountingTypeId, UserId, IP, Desc);

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
            else if (TemplateName.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateName.Delete(id, userId);
        }
        #endregion
    }
}