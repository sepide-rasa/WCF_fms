using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_AccountingLevel
    {
        DL_AccountingLevel AccountingLevel = new DL_AccountingLevel();

        #region Detail
        public OBJ_AccountingLevel Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AccountingLevel.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_AccountingLevel> Select(string FieldName, string FilterValue,string value2, int OrganId, int h)
        {
            return AccountingLevel.Select(FieldName, FilterValue,value2, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name,short Year, int ArghamNum, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (ArghamNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ارقام ضروری است";
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
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AccountingLevel.Insert(Name,Year, ArghamNum, OrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, short Year, int ArghamNum, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد سطوح حسابداری جهت ویرایش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (ArghamNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ارقام ضروری است";
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
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AccountingLevel.Update(Id,Name, Year, ArghamNum, OrganId, UserId, IP, Desc);

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
            else if (AccountingLevel.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AccountingLevel.Delete(id, userId);
        }
        #endregion
        #region SelectAccountingLevel
        public List<OBJ_AccountingLevel> SelectAccountingLevel(short Year, int OrganId)
        {
            return AccountingLevel.SelectAccountingLevel(Year, OrganId);
        }
        #endregion
        #region DeleteAccountingLevel
        public string DeleteAccountingLevel(short Year, int OrganId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AccountingLevel.DeleteAccountingLevel(Year, OrganId);
        }
        #endregion
        #region CheckAccountingLevel
        public List<OBJ_AccountingLevel> CheckAccountingLevel(int AccountingTypeId, int OrganPostId, short Year)
        {
            return AccountingLevel.CheckAccountingLevel(AccountingTypeId, OrganPostId, Year);
        }
        #endregion
    }
}