using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MoteghayerhayeHoghoghiItems
    {
        DL_MoteghayerhayeHoghoghiItems MoteghayerhayeHoghoghiItems = new DL_MoteghayerhayeHoghoghiItems();
        #region Detail
        public OBJ_MoteghayerhayeHoghoghiItems Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MoteghayerhayeHoghoghiItems.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghiItems> Select(string FieldName, string FilterValue, int h)
        {
            return MoteghayerhayeHoghoghiItems.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (MoteghayerhayeHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (ItemEstekhdamId == "" || ItemEstekhdamId ==null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }

            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghiItems.Insert(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldType, UserId);
        }
        #endregion
        #region Update
        public string Update(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (MoteghayerhayeHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (ItemEstekhdamId == "" || ItemEstekhdamId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MoteghayerhayeHoghoghiItems.Update(MoteghayerhayeHoghoghiId, ItemEstekhdamId,fldType, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghiItems.Delete( Id, UserId);
        }
        #endregion
    }
}