using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_LevelsAccountingType
    {
        DL_LevelsAccountingType LevelsAccountingType = new DL_LevelsAccountingType();

        #region Detail
        public OBJ_LevelsAccountingType Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LevelsAccountingType.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_LevelsAccountingType> Select(string FieldName, string FilterValue, int h)
        {
            return LevelsAccountingType.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, int AccountTypeId, int ArghumNum, int UserId, string IP, string Desc, out ClsError error)
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
            else if (AccountTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انواع حسابداری ضروری است";
            }
            else if (ArghumNum == 0)
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
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LevelsAccountingType.Insert(Name, AccountTypeId, ArghumNum, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int AccountTypeId, int ArghumNum, int UserId, string IP, string Desc, out ClsError error)
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
            else if (AccountTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انواع حسابداری ضروری است";
            }
            else if (ArghumNum == 0)
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
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LevelsAccountingType.Update(Id, Name, AccountTypeId, ArghumNum, UserId, IP, Desc);

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
            else if (LevelsAccountingType.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LevelsAccountingType.Delete(id, userId);
        }
        #endregion
        #region selectAccountingTypeLevel
        public List<OBJ_LevelsAccountingType> selectAccountingTypeLevel(int AccountTypeId)
        {
            return LevelsAccountingType.selectAccountingTypeLevel(AccountTypeId);
        }
        #endregion
    }
}