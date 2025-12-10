using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.BLL.PayRoll;
using WCF_FMS.BLL;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.TOL.Common;
using WCF_FMS.BLL.Common;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersoneliService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersoneliService.svc or PersoneliService.svc.cs at the Solution Explorer and start debugging.
    public class PersoneliService : IPersoneliService
    {

        

        // VaziyatEsargari
        #region GetVaziyatEsargariDetail
        public OBJ_VaziyatEsargari GetVaziyatEsargariDetail(int VaziyatEsargariId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_VaziyatEsargari().Detail(VaziyatEsargariId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetVaziyatEsargariWithFilter
        public List<OBJ_VaziyatEsargari> GetVaziyatEsargariWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_VaziyatEsargari().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertVaziyatEsargari
        public string InsertVaziyatEsargari(string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(57, UserId, OrganId))
                        return new BL_VaziyatEsargari().Insert(fldTitle, fldMoafAsBime, fldMoafAsMaliyat, fldMoafAsBimeOmr,  fldMoafAsBimeTakmili, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateVaziyatEsargari
        public string UpdateVaziyatEsargari(int fldId, string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(58, UserId, OrganId))
                        return new BL_VaziyatEsargari().Update(fldId, fldTitle, fldMoafAsBime, fldMoafAsMaliyat, fldMoafAsBimeOmr,  fldMoafAsBimeTakmili, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteVaziyatEsargari
        public string DeleteVaziyatEsargari(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(59, UserId, OrganId))
                    return new BL_VaziyatEsargari().Delete(id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //PersonalStatus
        #region GetPersonalStatusDetail
        public OBJ_PersonalStatus GetPersonalStatusDetail(int PersonalStatusId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PersonalStatus().Detail(PersonalStatusId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetPersonalStatusWithFilter
        public List<OBJ_PersonalStatus> GetPersonalStatusWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PersonalStatus().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertPersonalStatus
        public string InsertPersonalStatus(int StatusId, int? PrsPesonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (PrsPesonalInfoId != null)
                        APPId = 46;
                    if (PayPersonalInfoId != null)
                        APPId = 695;
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                    return new BL_PersonalStatus().Insert(StatusId,PrsPesonalInfoId,PayPersonalInfoId,DateTaghirVaziyat,Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdatePersonalStatus
        public string UpdatePersonalStatus(int PersonalStatusId, int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(15, UserId))
                    return new BL_PersonalStatus().Update(PersonalStatusId, StatusId,  PrsPersonalInfoId,  PayPersonalInfoId,  DateTaghirVaziyat,  Desc,  UserId,  IP, out  Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePersonalStatus
        public string DeletePersonalStatus(int PersonalStatusId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                    return new BL_PersonalStatus().Delete(PersonalStatusId, UserId, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion


        //HistoryNoeEstekhdam
        #region GetHistoryNoeEstekhdamDetail
        public OBJ_HistoryNoeEstekhdam GetHistoryNoeEstekhdamDetail(int HistoryNoeEstekhdamId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_HistoryNoeEstekhdam().Detail(HistoryNoeEstekhdamId, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetHistoryNoeEstekhdamWithFilter
        public List<OBJ_HistoryNoeEstekhdam> GetHistoryNoeEstekhdamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_HistoryNoeEstekhdam().Select(FieldName, FilterValue, OrganId, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertHistoryNoeEstekhdam
        public string InsertHistoryNoeEstekhdam(int PrsPersonalInfoId, int NoeEstekhdamId, string Tarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(47, UserId, OrganId))
                    return new BL_HistoryNoeEstekhdam().Insert(PrsPersonalInfoId, NoeEstekhdamId,Tarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateAnvaEstekhdam
        public string UpdateHistoryNoeEstekhdam(int HistoryNoeEstekhdamId, int PrsPersonalInfoId, int NoeEstekhdamId, string Tarikh, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(15, UserId))
                    return new BL_HistoryNoeEstekhdam().Update(HistoryNoeEstekhdamId,PrsPersonalInfoId, NoeEstekhdamId, Tarikh, Desc, UserId, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteHistoryNoeEstekhdam
        public string DeleteHistoryNoeEstekhdam(int HistoryNoeEstekhdamId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                    return new BL_HistoryNoeEstekhdam().Delete(HistoryNoeEstekhdamId, UserId, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //PersonalInfo
        #region GetPersoneliInfoDetail
        public OBJ_PersonalInfo GetPersoneliInfoDetail(int PersonalInfoId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PersonalInfo().Detail(PersonalInfoId, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetPersoneliInfoWithFilter
        public List<OBJ_PersonalInfo> GetPersoneliInfoWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_PersonalInfo().Select(FieldName, FilterValue, OrganId, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertPersoneliInfo
        public string InsertPersoneliInfo(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, byte[] Image, string Pasvand, string DateTaghirVaziyat, int NoeEstekhdamId, string Tarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(106, UserId, OrganId))
                        return new BL_PersonalInfo().Insert(Employee, Employee_Detail, PersonalInfo, Image,Pasvand, DateTaghirVaziyat, NoeEstekhdamId, Tarikh,UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdatePersonelilInfo
        public string UpdatePersonelilInfo(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, int FileId, byte[] Image, string Pasvand, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(107, UserId, OrganId))
                        return new BL_PersonalInfo().Update(Employee, Employee_Detail, PersonalInfo, FileId, Image, Pasvand,UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePersoneliInfo
        public string DeletePersoneliInfo(int PersoneliInfoId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(108, UserId, OrganId))
                    return new BL_PersonalInfo().Delete(PersoneliInfoId, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region GetPersoneliInfo_HokmWithFilter
        public List<OBJ_PersonalInfo> GetPersoneliInfo_HokmWithFilter(string FieldName, string FilterValue, int OrganId,int UserId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PersonalInfo().Select_Hokm(FieldName, FilterValue, OrganId, UserId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion


        // SavabeghGroupTashvighi
        #region GetSavabeghGroupTashvighiDetail
        public OBJ_SavabeghGroupTashvighi GetSavabeghGroupTashvighiDetail(int SavabeghGroupTashvighiId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SavabeghGroupTashvighi().Detail(SavabeghGroupTashvighiId, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetSavabeghGroupTashvighiWithFilter
        public List<OBJ_SavabeghGroupTashvighi> GetSavabeghGroupTashvighiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SavabeghGroupTashvighi().Select(FieldName, FilterValue, OrganId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
            
        }
        #endregion
        #region InsertSavabeghGroupTashvighi
        public string InsertSavabeghGroupTashvighi(int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(110, UserId, OrganId))
                    return new BL_SavabeghGroupTashvighi().Insert(fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, UserId,Desc,  out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateSavabeghGroupTashvighi
        public string UpdateSavabeghGroupTashvighi(int fldId, int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(111, UserId, OrganId))
                    return new BL_SavabeghGroupTashvighi().Update(fldId, fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteSavabeghGroupTashvighi
        public string DeleteSavabeghGroupTashvighi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(112, UserId, OrganId))
                    return new BL_SavabeghGroupTashvighi().Delete(id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //AnvaGroupTashvighi
        #region GetAnvaGroupTashvighiDetail
        public OBJ_AnvaGroupTashvighi GetAnvaGroupTashvighiDetail(byte Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_AnvaGroupTashvighi().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetAnvaGroupTashvighiWithFilter
        public List<OBJ_AnvaGroupTashvighi> GetAnvaGroupTashvighiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_AnvaGroupTashvighi().Select(FieldName, FilterValue, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertAnvaGroupTashvighi
        public string InsertAnvaGroupTashvighi(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(114, UserId, OrganId))
                    return new BL_AnvaGroupTashvighi().Insert(Title, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateAnvaGroupTashvighi
        public string UpdateAnvaGroupTashvighi(byte AnvaGroupTashvighiId, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(115, UserId, OrganId))
                    return new BL_AnvaGroupTashvighi().Update(AnvaGroupTashvighiId, Title,Desc, UserId, IP, out  Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteAnvaGroupTashvighi
        public string DeleteAnvaGroupTashvighi(byte AnvaGroupTashvighiId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(116, UserId, OrganId))
                    return new BL_AnvaGroupTashvighi().Delete(AnvaGroupTashvighiId, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        

        //MaxPersonalEstekhdamType
        #region GetMaxPersonalEstekhdamType
        public List<OBJ_MaxPersonalEstekhdamType> GetMaxPersonalEstekhdamType(string fieldName, int PersonalId, string tarikh, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MaxPersonalEstekhdamType().Select(fieldName, PersonalId, tarikh);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion

        //SavabegheSanavateKHedmat
        #region GetSavabegheSanavateKHedmatDetail
        public OBJ_SavabegheSanavateKHedmat GetSavabegheSanavateKHedmatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SavabegheSanavateKHedmat().Detail(Id, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetSavabegheSanavateKHedmatWithFilter
        public List<OBJ_SavabegheSanavateKHedmat> GetSavabegheSanavateKHedmatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SavabegheSanavateKHedmat().Select(FieldName, FilterValue, OrganId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertSavabegheSanavateKHedmat
        public string InsertSavabegheSanavateKHedmat(int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(118, UserId, OrganId))
                    return new BL_SavabegheSanavateKHedmat().Insert(PersonalId,NoeSabeghe,AzTarikh,TaTarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateSavabegheSanavateKHedmat
        public string UpdateSavabegheSanavateKHedmat(int Id, int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(119, UserId, OrganId))
                    return new BL_SavabegheSanavateKHedmat().Update(Id, PersonalId, NoeSabeghe, AzTarikh, TaTarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteSavabegheSanavateKHedmat
        public string DeleteSavabegheSanavateKHedmat(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(120, UserId, OrganId))
                    return new BL_SavabegheSanavateKHedmat().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //DigitalArchive
     /*   #region GetDigitalArchive
        public OBJ_DigitalArchive GetDigitalArchiveDetail(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().Detail(Id, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return null;
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region GetDigitalArchiveWithFilter
        public List<OBJ_DigitalArchive> GetDigitalArchiveWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_DigitalArchive().Select(FieldName, FilterValue, Top);
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region InsertDigitalArchive
        public string InsertDigitalArchive(int PersonalId, int TreeId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().Insert(PersonalId, TreeId, ImageFile, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region InsertMainDigitalArchive
        public string InsertMainDigitalArchive(int PersonalId, int TreeId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().InsertMain(PersonalId, TreeId, ImageFile, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateForBookMarkDigitalArchive
        public string UpdateForBookMarkDigitalArchive(string ImageFile, int TreeId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().UpdateForBookMark(ImageFile, TreeId, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteDigitalArchive
        public string DeleteDigitalArchive(int PersonalId, string ImageName, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().Delete(PersonalId, ImageName, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region RotateDigitalArchive
        public string RotateDigitalArchive(int Id, int PersonalId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().Rotate(Id, PersonalId, ImageFile, UserId, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region MoveDigitalArchive
        public string MoveDigitalArchive(int TreeId, string ImageFile, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DigitalArchive().Move(TreeId, ImageFile, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion*/

        //HoghoghMabna
        #region GetHoghoghMabnaDetail
        public OBJ_HoghoghMabna GetHoghoghMabnaDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_HoghoghMabna().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetHoghoghMabnaWithFilter
        public List<OBJ_HoghoghMabna> GetHoghoghMabnaWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_HoghoghMabna().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {

                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertHoghoghMabna
        public int InsertHoghoghMabna(int Year, bool Type, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(122, UserId, OrganId))
                    return new BL_HoghoghMabna().Insert(Year, Type, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return 0;
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return 0;
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return 0;
            }
        }
        #endregion
        #region UpdateHoghoghMabna
        public string UpdateHoghoghMabna(int Id, int Year, bool Type, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(123, UserId, OrganId))
                    return new BL_HoghoghMabna().Update(Id, Year, Type, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteHoghoghMabna
        public string DeleteHoghoghMabna(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(124, UserId, OrganId))
                    return new BL_HoghoghMabna().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //DetailHoghoghMabna
        #region GetDetailHoghoghMabnaDetail
        public OBJ_DetailHoghoghMabna GetDetailHoghoghMabnaDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_DetailHoghoghMabna().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetDetailHoghoghMabnaWithFilter
        public List<OBJ_DetailHoghoghMabna> GetDetailHoghoghMabnaWithFilter(string FieldName, string FilterValue, bool Type, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DetailHoghoghMabna().Select(FieldName, FilterValue, Type, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertDetailHoghoghMabna
        public string InsertDetailHoghoghMabna(int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(122, UserId, OrganId))
                    return new BL_DetailHoghoghMabna().Insert(HoghoghMabnaId, Groh, Mablagh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateDetailHoghoghMabna
        public string UpdateDetailHoghoghMabna(int Id, int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(123, UserId, OrganId))
                    return new BL_DetailHoghoghMabna().Update(Id, HoghoghMabnaId, Groh, Mablagh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteDetailHoghoghMabna
        public string DeleteDetailHoghoghMabna(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(124, UserId, OrganId))
                    return new BL_DetailHoghoghMabna().Delete(FieldName,Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //PersonalHokm
        #region GetPersonalHokmDetail
        public OBJ_PersonalHokm GetPersonalHokmDetail(int Id, int OrganId, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                if (new BL().BLPermission(129, UserId, OrganId))
                {
                    return new BL_PersonalHokm().Detail(Id, OrganId, UserId, out Error);
                }
                else
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    return null;
                }
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetPersonalHokmWithFilter
        public List<OBJ_PersonalHokm> GetPersonalHokmWithFilter(string FieldName, string FilterValue, string FilterValue1, int OrganId, int UserId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                if (new BL().BLPermission(129, UserId, OrganId))
                {
                    return new BL_PersonalHokm().Select(FieldName, FilterValue, FilterValue1, OrganId, UserId, Top);
                }
                else
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    return null;
                }
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertPersonalHokm
        public int InsertPersonalHokm(int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, string fldDesc, byte fldHokmType
            , string UserName, string Password, int OrganId, int IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(130, UserId, OrganId))
                    return new BL_PersonalHokm().Insert(fldPrs_PersonalInfoId,fldTarikhEjra,fldTarikhSodoor,fldTarikhEtmam,fldAnvaeEstekhdamId,fldGroup,fldMoreGroup
                        , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, File, Pasvand, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, UserId, fldDesc, fldHokmType, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return 0;
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP.ToString(), UserId);
                    return 0;
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return 0;
            }
        }
        #endregion
        #region UpdatePersonalHokm
        public string UpdatePersonalHokm(int Id, int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, int? FileId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, string fldDesc, byte fldHokmType, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(131, UserId, OrganId))
                    return new BL_PersonalHokm().Update(Id, fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, fldTarikhEtmam, fldAnvaeEstekhdamId, fldGroup, fldMoreGroup
                        , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, FileId, File, Pasvand, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, UserId, fldDesc, fldHokmType, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePersonalHokm
        public string DeletePersonalHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(132, UserId, OrganId))
                    return new BL_PersonalHokm().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //AfradTahtePooshesh
        #region GetAfradTahtePoosheshDetail
        public OBJ_AfradTahtePooshesh GetAfradTahtePoosheshDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_AfradTahtePooshesh().Detail(Id, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetAfradTahtePoosheshWithFilter
        public List<OBJ_AfradTahtePooshesh> GetAfradTahtePoosheshWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AfradTahtePooshesh().Select(FieldName, FilterValue, OrganId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertAfradTahtePooshesh
        public string InsertAfradTahtePooshesh(int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, string fldDesc, bool fldMashmoolPadash,string fldTarikhTalagh,string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(134, UserId,OrganId))
                    return new BL_AfradTahtePooshesh().Insert(fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli, fldSh_Shenasname, fldFatherName,fldTarikhEzdevaj, fldNesbatShakhs, UserId, fldDesc, fldMashmoolPadash,fldTarikhTalagh, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateAfradTahtePooshesh
        public string UpdateAfradTahtePooshesh(int Id, int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(135, UserId, OrganId))
                    return new BL_AfradTahtePooshesh().Update(Id, fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli,
                        fldSh_Shenasname, fldFatherName,fldTarikhEzdevaj,  fldNesbatShakhs, UserId, fldDesc, fldMashmoolPadash,fldTarikhTalagh, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateAfradTahtePoosheshMohasel
        public string UpdateAfradTahtePoosheshMohasel(int Id, byte fldStatus, string fldTarikhTalagh, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(135, UserId, OrganId))
                        return new BL_AfradTahtePooshesh().UpdateMohasel(Id,  fldStatus, fldTarikhTalagh,UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteAfradTahtePooshesh
        public string DeleteAfradTahtePooshesh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(136, UserId, OrganId))
                    return new BL_AfradTahtePooshesh().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        

        // HokmReport      
        #region GetHokmReportDetail
        public OBJ_HokmReport GetHokmReportDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_HokmReport().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetHokmReportWithFilter
        public List<OBJ_HokmReport> GetHokmReportWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_HokmReport().Select(FieldName, FilterValue, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertHokmReport
        public string InsertHokmReport(string Name, byte[] File, string Pasvand, int AnvaEstekhdamId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(138, UserId, OrganId))
                    return new BL_HokmReport().Insert(Name,File,Pasvand,AnvaEstekhdamId,UserId,Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateHokmReport
        public string UpdateHokmReport(int Id, string Name, int FileId, byte[] File, string Pasvand, int AnvaEstekhdamId, string Desc, int UserId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            //var UserId = authorize.ExistUser(Username, Password);
            //if (UserId != 0)
            //{
                try
                {
                    if (new BL().BLPermission(139, UserId, OrganId))
                    return new BL_HokmReport().Update(Id, Name, FileId, File, Pasvand, AnvaEstekhdamId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserId.ToString(), Er, IP, 0);
                    return "خطا";
                }
            //}
            //else
            //{
            //    Error.ErrorType = true;
            //    Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
            //    return "خطا";
            //}
        }
        #endregion
        #region DeleteHokmReport
        public string DeleteHokmReport(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(140, UserId, OrganId))
                    return new BL_HokmReport().Delete(id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion


        //DetailPayeSanavati
        #region GetDetailPayeSanavati
        public OBJ_DetailPayeSanavati GetDetailPayeSanavatiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_DetailPayeSanavati().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetDetailPayeSanavatiWithFilter
        public List<OBJ_DetailPayeSanavati> GetDetailPayeSanavatiFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DetailPayeSanavati().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertDetailPayeSanavati
        public string InsertDetailPayeSanavati(int PayeSanavatiId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(142, UserId, OrganId))
                    return new BL_DetailPayeSanavati().Insert(PayeSanavatiId,Groh,Mablagh, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateDetailPayeSanavati
        public string UpdateDetailPayeSanavati(int Id, int PayeSanavatiId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(143, UserId, OrganId))
                    return new BL_DetailPayeSanavati().Update(Id, PayeSanavatiId,Groh,Mablagh, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteDetailPayeSanavati
        public string DeleteDetailPayeSanavati(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(144, UserId, OrganId))
                    return new BL_DetailPayeSanavati().Delete(FieldName,Id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //Hokm_Item
        #region GetHokm_Item
        public OBJ_Hokm_Item GetHokm_ItemDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Hokm_Item().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetHokm_ItemWithFilter
        public List<OBJ_Hokm_Item> GetHokm_ItemFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Hokm_Item().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertHokm_Item
        public string InsertHokm_Item(int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(14, UserId))
                    return new BL_Hokm_Item().Insert(PersonalHokmId,Items_EstekhdamId, Mablagh, Zarib, UserId, Desc, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateHokm_Item
        public string UpdateHokm_Item(int Id, int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(15, UserId))
                    return new BL_Hokm_Item().Update(Id, PersonalHokmId, Items_EstekhdamId, Mablagh, Zarib, UserId, Desc, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteHokm_Item
        public string DeleteHokm_Item(string FieldName, int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                    return new BL_Hokm_Item().Delete(FieldName, Id, UserId, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //MoteghayerhaAhkam
        #region GetMoteghayerhaAhkam
        public OBJ_MoteghayerhaAhkam GetMoteghayerhaAhkamDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MoteghayerhaAhkam().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetMoteghayerhaAhkamWithFilter
        public List<OBJ_MoteghayerhaAhkam> GetMoteghayerhaAhkamFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_MoteghayerhaAhkam().Select(FieldName, FilterValue, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertMoteghayerhaAhkam
        public string InsertMoteghayerhaAhkam(short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(150, UserId, OrganId))
                    return new BL_MoteghayerhaAhkam().Insert(Year,Type,HagheOlad,HagheAeleMandi,KharoBar,Maskan,KharoBarMojarad,HadaghalDaryafti,HaghBon,HadaghalTadil, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateMoteghayerhaAhkam
        public string UpdateMoteghayerhaAhkam(int Id, short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(151, UserId, OrganId))
                    return new BL_MoteghayerhaAhkam().Update(Id, Year, Type, HagheOlad, HagheAeleMandi, KharoBar, Maskan, KharoBarMojarad, HadaghalDaryafti, HaghBon,HadaghalTadil, UserId, Desc, out Error);
                   else
                   {
                       Error.ErrorType = true;
                       Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                       return "خطا";
                   }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteMoteghayerhaAhkam
        public string DeleteMoteghayerhaAhkam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(152, UserId, OrganId))
                    return new BL_MoteghayerhaAhkam().Delete(Id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //AkharinHokmSal
        #region GetAkharinHokmSalWithFilter
        public List<OBJ_AkharinHokmSal> GetAkharinHokmSalFilter(int PersonalId, string Year, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AkharinHokmSal().Select(PersonalId, Year);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion

        //PayeSanavati
        #region GetPayeSanavatiDetail
        public OBJ_PayeSanavati GetPayeSanavatiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PayeSanavati().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetPayeSanavatiWithFilter
        public List<OBJ_PayeSanavati> GetPayeSanavatiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_PayeSanavati().Select(FieldName, FilterValue, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                    return null;
                }
                
        }
        #endregion
        #region InsertPayeSanavati
        public int InsertPayeSanavati(int Year, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(142, UserId, OrganId))
                    return new BL_PayeSanavati().Insert(Year, Desc, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return 0;
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return 0;
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return 0;
            }
        }
        #endregion
        #region UpdatePayeSanavati
        public string UpdatePayeSanavati(int Id, int Year, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(143, UserId, OrganId))
                    return new BL_PayeSanavati().Update(Id, Year, Desc, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePayeSanavati
        public string DeletePayeSanavati(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(144, UserId, OrganId))
                    return new BL_PayeSanavati().Delete(Id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //PatternSharhHokm
        #region GetPatternSharhHokmDetail
        public OBJ_PatternSharhHokm GetPatternSharhHokmDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PatternSharhHokm().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetPatternSharhHokmWithFilter
        public List<OBJ_PatternSharhHokm> GetPatternSharhHokmWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PatternSharhHokm().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertPatternSharhHokm
        public string InsertPatternSharhHokm(string PatternText, string HokmType, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(154, UserId, OrganId))
                    return new BL_PatternSharhHokm().Insert(PatternText, HokmType, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdatePatternSharhHokm
        public string UpdatePatternSharhHokm(int Id, string PatternText, string HokmType, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(155, UserId, OrganId))
                    return new BL_PatternSharhHokm().Update(Id, PatternText, HokmType, UserId, Desc, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePatternSharhHokm
        public string DeletePatternSharhHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(156, UserId, OrganId))
                    return new BL_PatternSharhHokm().Delete(Id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //FileForHokm
        #region InsertFileForHokm
        public string InsertFileForHokm(int fldPersonalHokmId, byte[] fldImage, string fldPasvand, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    // if (new BL().BLPermission(154, UserId))
                    return new BL_FileForHokm().Insert(fldPersonalHokmId, fldImage, fldPasvand, UserId, Desc, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
         
        //NesbatWithPersonalInfoId
        #region GetNesbatWithPersonalInfoId
        public List<OBJ_NesbatWithPersonalInfoId> GetNesbatWithPersonalInfoId(string FieldName, int PersonalId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_NesbatWithPersonalInfoId().Select( FieldName,PersonalId);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion

        //SavabeghJebhe_Items
        #region GetSavabeghJebhe_ItemsDetail
        public OBJ_SavabeghJebhe_Items GetSavabeghJebhe_ItemsDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SavabeghJebhe_Items().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetSavabeghJebhe_ItemsWithFilter
        public List<OBJ_SavabeghJebhe_Items> GetSavabeghJebhe_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SavabeghJebhe_Items().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertSavabeghJebhe_Items
        public string InsertSavabeghJebhe_Items(string Title, decimal Darsad_Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(615, UserId, OrganId))
                        return new BL_SavabeghJebhe_Items().Insert(Title,Darsad_Sal, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateSavabeghJebhe_Items
        public string UpdateSavabeghJebhe_Items(int Id, string Title, decimal Darsad_Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(616, UserId, OrganId))
                        return new BL_SavabeghJebhe_Items().Update(Id, Title,Darsad_Sal, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteSavabeghJebhe_Items
        public string DeleteSavabeghJebhe_Items(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(617, UserId, OrganId))
                        return new BL_SavabeghJebhe_Items().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion


        //SavabeghJebhe_Personal
        #region GetSavabeghJebhe_PersonalDetail
        public OBJ_SavabeghJebhe_Personal GetSavabeghJebhe_PersonalDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SavabeghJebhe_Personal().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetSavabeghJebhe_PersonalWithFilter
        public List<OBJ_SavabeghJebhe_Personal> GetSavabeghJebhe_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SavabeghJebhe_Personal().Select(FieldName, FilterValue, FilterValue1, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertSavabeghJebhe_Personal
        public string InsertSavabeghJebhe_Personal(int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(619, UserId, OrganId))
                        return new BL_SavabeghJebhe_Personal().Insert(ItemId, PrsPersonalId, AzTarikh, TaTarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateSavabeghJebhe_Personal
        public string UpdateSavabeghJebhe_Personal(int Id, int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(620, UserId, OrganId))
                        return new BL_SavabeghJebhe_Personal().Update(Id, ItemId, PrsPersonalId, AzTarikh, TaTarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteSavabeghJebhe_Personal
        public string DeleteSavabeghJebhe_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(621, UserId, OrganId))
                        return new BL_SavabeghJebhe_Personal().Delete(Id, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //SelectSavabegheSanavateKHedmatWithFilter     
        #region SelectSavabegheSanavateKHedmatWithFilter
        public List<OBJ_SavabegheSanavateKHedmat> SelectSavabegheSanavateKHedmatWithFilter(string FieldName, string FilterValue, int OrganId, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SavabegheSanavateKHedmat().Select(FieldName, FilterValue, OrganId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
            
        }
        #endregion
        //TasviehHesab
        #region GetTasviehHesabDetail
        public OBJ_TasviehHesab GetTasviehHesabDetail(int TasviehHesabId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TasviehHesab().Detail(TasviehHesabId, OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetTasviehHesabWithFilter
        public List<OBJ_TasviehHesab> GetTasviehHesabWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TasviehHesab().Select(FieldName, FilterValue, FilterValue2, OrganId, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertTasviehHesab
        public string InsertTasviehHesab(int PrsPersonalInfoId, string Tarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(47, UserId, OrganId))
                        return new BL_TasviehHesab().Insert(PrsPersonalInfoId, Tarikh, Desc, UserId, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateAnvaEstekhdam
        public string UpdateTasviehHesab(int TasviehHesabId, int PrsPersonalInfoId, string Tarikh, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(15, UserId))
                    return new BL_TasviehHesab().Update(TasviehHesabId, PrsPersonalInfoId, Tarikh, Desc, UserId, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteTasviehHesab
        public string DeleteTasviehHesab(int TasviehHesabId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                    return new BL_TasviehHesab().Delete(TasviehHesabId, UserId, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return "خطا";
                    //}
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion


        //PersonalSign

        #region GetPersonalSignWithFilter
        public List<OBJ_PersonalSign> GetPersonalSignWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PersonalSign().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }

        }
        #endregion
        #region InsertPersonalSign
        public string InsertPersonalSign(int CommitionId, byte[] FileEmza, string Passvand, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1184, UserId, OrganId))
                        return new BL_PersonalSign().Insert(CommitionId, FileEmza, Passvand, UserId, Desc, IP, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //Mohaseleen
        #region GetMohaseleenDetail
        public OBJ_Mohaseleen GetMohaseleenDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohaseleen().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetMohaseleenWithFilter
        public List<OBJ_Mohaseleen> GetMohaseleenWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohaseleen().Select(FieldName, FilterValue, Top);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region InsertMohaseleen
        public string InsertMohaseleen(int fldAfradTahtePoosheshId, int fldTarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(134, UserId, OrganId))
                        return new BL_Mohaseleen().Insert(fldAfradTahtePoosheshId, fldTarikh, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateMohaseleen
        public string UpdateMohaseleen(int Id, int fldAfradTahtePoosheshId, int fldTarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(135, UserId, OrganId))
                        return new BL_Mohaseleen().Update(Id, fldAfradTahtePoosheshId, fldTarikh, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteMohaseleen
        public string DeleteMohaseleen(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(136, UserId, OrganId))
                        return new BL_Mohaseleen().Delete(Id, UserId, out Error);
                    else
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                        return "خطا";
                    }
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
       
    }
}
