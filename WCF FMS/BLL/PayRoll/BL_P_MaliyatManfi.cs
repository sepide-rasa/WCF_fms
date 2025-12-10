using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_P_MaliyatManfi
    {
        DL_P_MaliyatManfi P_MaliyatManfi = new DL_P_MaliyatManfi();
        #region Detail
        public OBJ_P_MaliyatManfi Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return P_MaliyatManfi.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_P_MaliyatManfi> Select(string FieldName, string FilterValue, int h)
        {
            return P_MaliyatManfi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MohasebeId, int Mablagh, short Sal, byte Mah, int UserId, string Desc, out ClsError Error)
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
            return P_MaliyatManfi.Insert(MohasebeId, Mablagh, Sal, Mah, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebeId, int Mablagh, short Sal, byte Mah, int UserId, string Desc, out ClsError Error)
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
            return P_MaliyatManfi.Update(Id, MohasebeId, Mablagh, Sal, Mah, UserId, Desc);
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
            return P_MaliyatManfi.Delete(Id, UserId);
        }
        #endregion
    }
}