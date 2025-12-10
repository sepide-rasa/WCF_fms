using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_FiscalTitle
    {
        DL_FiscalTitle FiscalTitle = new DL_FiscalTitle();
        #region Detail
        public OBJ_FiscalTitle Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return FiscalTitle.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_FiscalTitle> Select(string FieldName, string FilterValue, int h)
        {
            return FiscalTitle.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مالیات ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            else if (AnvaEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return FiscalTitle.Insert(FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, int UserId, string Desc, out ClsError Error)
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
            else if (FiscalHeaderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مالیات ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            else if (AnvaEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return FiscalTitle.Update(Id, FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, string FilterValue, int Id, int UserId, out ClsError Error)
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
            return FiscalTitle.Delete(FieldName,FilterValue, Id, UserId);
        }
        #endregion
    }
}