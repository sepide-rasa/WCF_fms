using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MoteghayerhayeHoghoghi_Detail
    {
        DL_MoteghayerhayeHoghoghi_Detail MoteghayerhayeHoghoghi_Detail = new DL_MoteghayerhayeHoghoghi_Detail();
        #region Detail
        public OBJ_MoteghayerhayeHoghoghi_Detail Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MoteghayerhayeHoghoghi_Detail.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeHoghoghi_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return MoteghayerhayeHoghoghi_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, bool fldMazayaMashmool, int UserId, string Desc, out ClsError Error)
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
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeHoghoghi_Detail.Insert(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldMazayaMashmool, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (MoteghayerhayeHoghoghiId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد متغیرهای حقوقی ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MoteghayerhayeHoghoghi_Detail.Update(Id, MoteghayerhayeHoghoghiId, ItemEstekhdamId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int Id, int UserId, out ClsError Error)
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
            return MoteghayerhayeHoghoghi_Detail.Delete(FieldName, Id, UserId);
        }
        #endregion
    }
}