using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AfradeTahtePoshesheBimeTakmily
    {
        DL_AfradeTahtePoshesheBimeTakmily AfradeTahtePoshesheBimeTakmily = new DL_AfradeTahtePoshesheBimeTakmily();
        #region Detail
        public OBJ_AfradeTahtePoshesheBimeTakmily Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return AfradeTahtePoshesheBimeTakmily.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_AfradeTahtePoshesheBimeTakmily> Select(string FieldName, string FilterValue, int PersonalId, short sal, byte mah, byte nobat, int OrganId, int h)
        {
            return AfradeTahtePoshesheBimeTakmily.Select(FieldName, FilterValue, PersonalId,sal,mah,nobat, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (GHarardadBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد قرارداد بیمه ضروری است";
            }
              
            else if (AfradeTahtePoshesheBimeTakmily.CheckRepeatedRow(PersonalId, GHarardadBimeId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای قرارداد بیمه مورد نظر اطلاعات قبلا ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return AfradeTahtePoshesheBimeTakmily.Insert(PersonalId,TedadAsli,TedadTakafol60Sal,TedadTakafol70Sal,GHarardadBimeId, AfradTahtePoshehsId,  TedadBedonePoshesh, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, int UserId, string Desc, out ClsError Error)
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

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل حقوقی ضروری است";
            }
            else if (GHarardadBimeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد قرارداد بیمه ضروری است";
            }
            
            else if (AfradeTahtePoshesheBimeTakmily.CheckRepeatedRow(PersonalId, GHarardadBimeId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "برای قرارداد بیمه مورد نظر اطلاعات قبلا ثبت شده است.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AfradeTahtePoshesheBimeTakmily.Update(Id, PersonalId, TedadAsli, TedadTakafol60Sal, TedadTakafol70Sal, GHarardadBimeId, AfradTahtePoshehsId,  TedadBedonePoshesh, UserId, Desc);
        }
        #endregion
        #region Copy
        public string Copy(int GHarardadBimeId_From, int GHarardadBimeId_To, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
          
            else if (GHarardadBimeId_From == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد قرارداد بیمه ضروری است";
            }
            else if (GHarardadBimeId_To == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد قرارداد بیمه ضروری است";
            }
            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AfradeTahtePoshesheBimeTakmily.Copy(GHarardadBimeId_From, GHarardadBimeId_To, UserId);
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
                Error.ErrorMsg = "شناسه ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return AfradeTahtePoshesheBimeTakmily.Delete(Id, UserId);
        }
        #endregion

        #region HistoryAfradTahtePoshesheBimeTakmily
        public List<OBJ_HistoryAfradTahtePoshesheBimeTakmily> HistoryAfradTahtePoshesheBimeTakmily(int PersonalId, int OrganId)
        {
            return AfradeTahtePoshesheBimeTakmily.HistoryAfradTahtePoshesheBimeTakmily(PersonalId, OrganId);
        }
        #endregion
    }
}