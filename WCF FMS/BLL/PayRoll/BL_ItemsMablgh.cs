using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ItemsMablgh
    {
        DL_ItemsMablgh ItemsMablgh = new DL_ItemsMablgh();

        #region Detail
        public OBJ_ItemsMablgh Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ItemsMablgh.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ItemsMablgh> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return ItemsMablgh.Select(FieldName, FilterValue, FilterValue2,  h);
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد هدر ضروری است.";
            }
            else if (ItemsHoghughiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد آیتم ضروری است.";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemsMablgh.Insert(HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild, Count, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد هدر ضروری است.";
            }
            else if (ItemsHoghughiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد آیتم ضروری است.";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemsMablgh.Update(Id, HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild, Count, UserId);
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
            //else if (ItemsMablgh.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return ItemsMablgh.Delete(id, userId);
        }
        #endregion
    }
}