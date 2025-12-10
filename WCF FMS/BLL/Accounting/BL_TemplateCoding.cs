using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_TemplateCoding
    {
        DL_TemplateCoding TemplateCoding = new DL_TemplateCoding();
        #region Detail
        public OBJ_TemplateCoding Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TemplateCoding.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TemplateCoding> Select(string FieldName, string FilterValue, string FilterValue2,string FilterValue3,int HeaderCodingId, int h)
        {
            return TemplateCoding.Select(FieldName, FilterValue, FilterValue2, FilterValue3,HeaderCodingId, h);
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> PID, Nullable<int> ItemId, string Name, string PCod, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId, Boolean? AddChildNode, string CodeBudget, int UserId, string IP, string Desc, out ClsError error)
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
            else if (LevelsAccountTypId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطح ضروری است";
            }
            else if (TempNameId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نام الگو ضروری است";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
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
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldTypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (TemplateCoding.CheckRepeatedRow(TempNameId,Code, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateCoding.Insert(PID, ItemId, Name, PCod, MahiyatId,Mahiyat_GardeshId, Code, TempNameId, LevelsAccountTypId, fldTypeHesabId,AddChildNode,CodeBudget, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> ItemId, string Name, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId, Boolean? AddChildNode, string CodeBudget, int UserId, string IP, string Desc, out ClsError error)
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
            else if (fldTypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (LevelsAccountTypId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطح ضروری است";
            }
            else if (TempNameId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نام الگو ضروری است";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
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
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TemplateCoding.CheckRepeatedRow(TempNameId, Code, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateCoding.Update(Id, ItemId, Name, MahiyatId,Mahiyat_GardeshId, Code, TempNameId, LevelsAccountTypId, fldTypeHesabId, AddChildNode, CodeBudget, UserId, IP, Desc);

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
            else if (TemplateCoding.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplateCoding.Delete(id, userId);
        }
        #endregion
        #region CheckValidCode
        public int CheckValidCode(int AccountTypId, string Code, string PCod, int Id, int TempNameId)
        {
            return TemplateCoding.CheckValidCode(AccountTypId, Code, PCod, Id, TempNameId);
        }
        #endregion
        #region GetDefaultCode
        public List<OBJ_TemplateCoding> GetDefaultCode(int AccountTypId, string PCod, int TempNameId)
        {
            return TemplateCoding.GetDefaultCode(AccountTypId, PCod, TempNameId);
        }
        #endregion
        
    }
}