using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_KosoratBank
    {
        DL_Mohasebat_KosoratBank Mohasebat_KosoratBank = new DL_Mohasebat_KosoratBank();
        #region Detail
        public OBJ_Mohasebat_KosoratBank Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_KosoratBank.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_KosoratBank> Select(string FieldName, string FilterValue, int h)
        {
            return Mohasebat_KosoratBank.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MohasebatId, int KosoratBankId, int Mablagh, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (KosoratBankId==0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کسورات بانک ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_KosoratBank.Insert(MohasebatId, KosoratBankId, Mablagh, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, int KosoratBankId, int Mablagh, int UserId, string Desc, out ClsError Error)
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

            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (KosoratBankId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کسورات بانک ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_KosoratBank.Update(Id, MohasebatId, KosoratBankId, Mablagh, UserId, Desc);
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
            return Mohasebat_KosoratBank.Delete(Id, UserId);
        }
        #endregion
    }
}