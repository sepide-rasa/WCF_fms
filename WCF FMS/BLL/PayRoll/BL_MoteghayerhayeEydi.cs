using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MoteghayerhayeEydi
    {
        DL_MoteghayerhayeEydi MoteghayerhayeEydi = new DL_MoteghayerhayeEydi();
        #region Detail
        public OBJ_MoteghayerhayeEydi Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MoteghayerhayeEydi.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhayeEydi> Select(string FieldName, string FilterValue, int h)
        {
            return MoteghayerhayeEydi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (MoteghayerhayeEydi.CheckRepeatedRow(Year, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده در سال مورد نظر تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhayeEydi.Insert(Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, int UserId, string Desc, out ClsError Error)
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
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (MoteghayerhayeEydi.CheckRepeatedRow(Year, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده در سال مورد نظر تکراری است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MoteghayerhayeEydi.Update(Id, Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc);
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
            return MoteghayerhayeEydi.Delete(Id, UserId);
        }
        #endregion
    }
}