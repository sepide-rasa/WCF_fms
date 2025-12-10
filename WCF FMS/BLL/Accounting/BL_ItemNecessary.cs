using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_ItemNecessary
    {
        DL_ItemNecessary ItemNecessary = new DL_ItemNecessary();

        #region Detail
        public OBJ_ItemNecessary Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ItemNecessary.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ItemNecessary> Select(string FieldName, string FilterValue,string FilterValue2, int h)
        {
            return ItemNecessary.Select(FieldName, FilterValue,FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(Nullable<int> PID, string NameItem, int MahiyatId,int? Mahiyat_GardeshId, byte fldTypeHesabId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (fldTypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (NameItem == "" || NameItem == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (NameItem.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameItem.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ItemNecessary.CheckRepeatedRow(NameItem,0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemNecessary.Insert(PID, NameItem, MahiyatId,Mahiyat_GardeshId, fldTypeHesabId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameItem, int MahiyatId,int? Mahiyat_GardeshId, byte fldTypeHesabId, int UserId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد آیتم های الزامی جهت ویرایش ضروری است";
            }
            else if (fldTypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (NameItem == "" || NameItem == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (NameItem.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameItem.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ItemNecessary.CheckRepeatedRow(NameItem, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemNecessary.Update(Id, NameItem, MahiyatId,Mahiyat_GardeshId, fldTypeHesabId, UserId, IP, Desc);

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
            else if (ItemNecessary.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemNecessary.Delete(id, userId);
        }
        #endregion
        #region UpdatePID_ItemNecessary
        public string UpdatePID_ItemNecessary(int ChildId, int ParentId, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemNecessary.UpdatePID_ItemNecessary(ChildId, ParentId, UserId);
        }
        #endregion
    }
}