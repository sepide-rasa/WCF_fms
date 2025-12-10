using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohaseleen
    {
        DL_Mohaseleen Mohaseleen = new DL_Mohaseleen();

        #region Detail
        public OBJ_Mohaseleen Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Mohaseleen.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Mohaseleen> Select(string FieldName, string FilterValue, int h)
        {
            return Mohaseleen.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldAfradTahtePoosheshId, int fldTarikh, int UserId,  out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (fldTarikh.ToString().Length != 8)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ را به درستی وارد کنید.";
            }
            else if (Mohaseleen.CheckRepeatedRow(fldAfradTahtePoosheshId,fldTarikh))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Mohaseleen.Insert(fldAfradTahtePoosheshId, fldTarikh, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldAfradTahtePoosheshId,int fldTarikh, int UserId, out ClsError error)
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
            else if (fldTarikh != null && fldTarikh.ToString().Length != 8)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ را به درستی وارد کنید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Mohaseleen.Update(Id, fldAfradTahtePoosheshId, fldTarikh, UserId);
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
            //else if (Mohaseleen.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Mohaseleen.Delete(id, userId);
        }
        #endregion
       
    }
}