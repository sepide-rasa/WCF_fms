using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_ItemsHoghughi
    {
        DL_ItemsHoghughi ItemsHoghughi = new DL_ItemsHoghughi();
        #region Select
        public List<OBJ_ItemsHoghughi> Select(string FieldName, string FilterValue, int h)
        {
            return ItemsHoghughi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Update
        public string Update(int Id, byte TypeHesabId, byte Mostamar, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (TypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (Mostamar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع آیتم حقوقی ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ItemsHoghughi.Update(Id, TypeHesabId, Mostamar, UserId);

        }
        #endregion
    }
}