using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ItemMablgh_Header
    {
        DL_ItemMablgh_Header ItemMablgh_Header = new DL_ItemMablgh_Header();

        #region Detail
        public OBJ_ItemMablgh_Header Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ItemMablgh_Header.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ItemMablgh_Header> Select(string FieldName, string FilterValue, int h)
        {
            return ItemMablgh_Header.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ActiveDate, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (ActiveDate.ToString().Length != 6)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ را به درستی وارد کنید.";
            }
            else if (ItemMablgh_Header.CheckRepeatedRow(Convert.ToInt32(ActiveDate)))
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemMablgh_Header.Insert(ActiveDate, UserId, IP);
        }
        #endregion
        #region Update
        public string Update(int Id, int? DeactiveDate, bool Active, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (DeactiveDate != null && DeactiveDate.ToString().Length != 6)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ را به درستی وارد کنید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemMablgh_Header.Update(Id, DeactiveDate, Active, UserId, IP);
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
            //else if (ItemMablgh_Header.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return ItemMablgh_Header.Delete(id, userId);
        }
        #endregion
        #region Copy
        public string Copy(int HeaderId, int ActiveDate, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انتخاب سطر مبدا ضروری است.";
            }
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (ActiveDate.ToString().Length != 6)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ را به درستی وارد کنید.";
            }
            else if (ItemMablgh_Header.CheckRepeatedRow(Convert.ToInt32(ActiveDate)))
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemMablgh_Header.Copy(HeaderId, ActiveDate, UserId, IP);
        }
        #endregion
    }
}