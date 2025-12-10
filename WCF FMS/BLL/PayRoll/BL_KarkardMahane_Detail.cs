using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_KarkardMahane_Detail
    {
        DL_KarkardMahane_Detail KarkardMahane_Detail = new DL_KarkardMahane_Detail();
        #region Detail
        public OBJ_KarkardMahane_Detail Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return KarkardMahane_Detail.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_KarkardMahane_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return KarkardMahane_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int KarkardMahaneId, int Karkard, int KargahBimeId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (KarkardMahaneId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارکرد ماهانه ضروری است";
            }
            else if (KargahBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارگاه بیمه ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return KarkardMahane_Detail.Insert(KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int KarkardMahaneId, int Karkard, int KargahBimeId, int UserId, string Desc, out ClsError Error)
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

            else if (KarkardMahaneId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارکرد ماهانه ضروری است";
            }
            else if (KargahBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارگاه بیمه ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KarkardMahane_Detail.Update(Id, KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc);
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
            return KarkardMahane_Detail.Delete(Id, UserId);
        }
        #endregion
    }
}