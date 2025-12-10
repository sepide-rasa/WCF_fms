using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;


namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MaliyatManfi
    {
        DL_MaliyatManfi MaliyatManfi = new DL_MaliyatManfi();
        #region Detail
        public OBJ_MaliyatManfi Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MaliyatManfi.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MaliyatManfi> Select(string FieldName, string FilterValue, int h)
        {
            return MaliyatManfi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int Mablagh, int MohasebeId, short Sal, byte Mah, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();

            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (MohasebeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (Sal == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            

            if (Error.ErrorType == true)
                return "خطا";
            return MaliyatManfi.Insert(Mablagh, MohasebeId, Sal, Mah, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int Mablagh, int MohasebeId, short Sal, byte Mah, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (Desc == null)
                Desc = "";
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
            else if (MohasebeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (Sal == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }

            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MaliyatManfi.Update(Id, Mablagh, MohasebeId, Sal, Mah, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MaliyatManfi.Delete(Id, UserId);
        }
        #endregion
    }
}