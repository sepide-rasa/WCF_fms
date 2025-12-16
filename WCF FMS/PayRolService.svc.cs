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

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PayRolService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PayRolService.svc or PayRolService.svc.cs at the Solution Explorer and start debugging.
    public class PayRolService : IPayRolService
    {
        //MaxBime
        #region GetMaxBimeWithFilter
        public List<OBJ_MaxBime> GetMaxBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MaxBime().Select(FieldName, FilterValue, Top);
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

        //RptMaliyatSaliyane
        #region GetRptMaliyatSaliyane
        public List<OBJ_RptMaliyatSaliyane> GetRptMaliyatSaliyane(int PersonId, short Year, byte Month, int OrganId, byte type, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptMaliyatSaliyane().GetRptMaliyatSaliyane( PersonId,Year, Month, OrganId, type, UserId);
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
        #region GetRptEkhtelafMaliyatBaDaraei
        public List<OBJ_RptEkhtelafMaliyatBaDaraei> GetRptEkhtelafMaliyatBaDaraei(short Year, byte Month, byte nobatPardakht, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptMaliyatSaliyane().GetRptEkhtelafMaliyatBaDaraei(Year, Month, nobatPardakht,OrganId);
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

        //OnAccount
        #region GetMaxBimeWithFilter
        public List<OBJ_OnAccount> GetOnAccountWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, string FilterValue4, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_OnAccount().Select(FieldName, FilterValue,  FilterValue2,  FilterValue3,  FilterValue4, OrganId, Top);
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

        //Parametrs
        #region GetParametrsDetail
        public OBJ_Parametrs GetParametrsDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Parametrs().Detail(Id, OrganId, out Error);
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
        #region GetParametrsWithFilter
        public List<OBJ_Parametrs> GetParametrsWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Parametrs().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertParametrs
        public string InsertParametrs(string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(162, UserId, OrganId))
                        return new BL_Parametrs().Insert(Title, TypeParametr, TypeMablagh, TypeEstekhdamId, Active, Private, HesabTypeParam,  IsMostamar, OrganId, UserId, Desc, out Error);
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
        #region UpdateParametrs
        public string UpdateParametrs(int Id, string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(163, UserId, OrganId))
                        return new BL_Parametrs().Update(Id, Title, TypeParametr, TypeMablagh, TypeEstekhdamId, Active, Private, HesabTypeParam, IsMostamar, OrganId, UserId, Desc, out Error);
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
        #region DeleteParametrs
        public string DeleteParametrs(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(164, UserId, OrganId))
                        return new BL_Parametrs().Delete(Id, UserId, out Error);
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

        //CostCenter
        #region GetCostCenterDetail
        public OBJ_CostCenter GetCostCenterDetail(int Id,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CostCenter().Detail(Id,OrganId, out Error);
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
        #region GetCostCenterWithFilter
        public List<OBJ_CostCenter> GetCostCenterWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CostCenter().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertCostCenter
        public string InsertCostCenter(string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(170, UserId, OrganId))
                        return new BL_CostCenter().Insert(Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId,OrganId, UserId, Desc, out Error);
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
        #region UpdateCostCenter
        public string UpdateCostCenter(int Id, string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(171, UserId, OrganId))
                        return new BL_CostCenter().Update(Id, Title, ReportTypeId, TypeOfCostCenterId, EmploymentCenterId,OrganId, UserId, Desc, out Error);
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
        #region DeleteCostCenter
        public string DeleteCostCenter(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(172, UserId, OrganId))
                        return new BL_CostCenter().Delete(Id, UserId, out Error);
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
        //AfradTahtePoosheshSelect_FromExcel 
        #region GetAfradTahtePoosheshSelect_FromExcelWithFilter
        public List<OBJ_AfradTahtePoosheshSelect_FromExcel> GetAfradTahtePoosheshSelect_FromExcelWithFilter(string CodeMeli, int GharardadBimeId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_AfradTahtePoosheshSelect_FromExcel().Select(CodeMeli,GharardadBimeId,UserId);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        //AfradeTahtePoshesheBimeTakmily
        #region GetAfradeTahtePoshesheBimeTakmily
        public OBJ_AfradeTahtePoshesheBimeTakmily GetAfradeTahtePoshesheBimeTakmilyDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_AfradeTahtePoshesheBimeTakmily().Detail(Id, OrganId, out Error);
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
        #region GetAfradeTahtePoshesheBimeTakmilyWithFilter
        public List<OBJ_AfradeTahtePoshesheBimeTakmily> GetAfradeTahtePoshesheBimeTakmilyWithFilter(string FieldName, string FilterValue, int PersonalId, short sal, byte mah, byte nobat, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AfradeTahtePoshesheBimeTakmily().Select(FieldName, FilterValue, PersonalId,sal,mah,nobat, OrganId, Top);
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
        #region InsertAfradeTahtePoshesheBimeTakmily
        public string InsertAfradeTahtePoshesheBimeTakmily(int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(174, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily().Insert(PersonalId, TedadAsli, TedadTakafol60Sal, TedadTakafol70Sal, GHarardadBimeId,  AfradTahtePoshehsId,  TedadBedonePoshesh, UserId, Desc, out Error);
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
        #region UpdateAfradeTahtePoshesheBimeTakmily
        public string UpdateAfradeTahtePoshesheBimeTakmily(int Id, int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(175, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily().Update(Id, PersonalId, TedadAsli, TedadTakafol60Sal, TedadTakafol70Sal, GHarardadBimeId, AfradTahtePoshehsId,  TedadBedonePoshesh, UserId, Desc, out Error);
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

        #region CopyAfradeTahtePoshesheBimeTakmily
        public string CopyAfradeTahtePoshesheBimeTakmily(int GHarardadBimeId_From, int GHarardadBimeId_To, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(175, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily().Copy(GHarardadBimeId_From, GHarardadBimeId_To, UserId, out Error);
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
        #region DeleteAfradeTahtePoshesheBimeTakmily
        public string DeleteAfradeTahtePoshesheBimeTakmily(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(176, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily().Delete(Id, UserId, out Error);
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

        //AfradeTahtePoshesheBimeTakmily_Details
        #region GetAfradeTahtePoshesheBimeTakmily_Details
        public OBJ_AfradeTahtePoshesheBimeTakmily_Details GetAfradeTahtePoshesheBimeTakmily_DetailsDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_AfradeTahtePoshesheBimeTakmily_Details().Detail(Id, out Error);
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
        #region GetAfradeTahtePoshesheBimeTakmily_DetailsWithFilter
        public List<OBJ_AfradeTahtePoshesheBimeTakmily_Details> GetAfradeTahtePoshesheBimeTakmily_DetailsWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AfradeTahtePoshesheBimeTakmily_Details().Select(FieldName, FilterValue,  FilterValue2, Top);
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
        #region InsertAfradeTahtePoshesheBimeTakmily_Details
        public string InsertAfradeTahtePoshesheBimeTakmily_Details(int AfradTahtePoshehsId, int BimeTakmiliId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(174, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily_Details().Insert( AfradTahtePoshehsId,  BimeTakmiliId, UserId, Desc, out Error);
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
        #region UpdateAfradeTahtePoshesheBimeTakmily_Details
        public string UpdateAfradeTahtePoshesheBimeTakmily_Details(int Id, int AfradTahtePoshehsId, int BimeTakmiliId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(175, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily_Details().Update(Id,  AfradTahtePoshehsId,  BimeTakmiliId, UserId, Desc, out Error);
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
        #region DeleteAfradeTahtePoshesheBimeTakmily_Details
        public string DeleteAfradeTahtePoshesheBimeTakmily_Details(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(176, UserId, OrganId))
                        return new BL_AfradeTahtePoshesheBimeTakmily_Details().Delete(Id, UserId, out Error);
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
        //EtelaatEydi
        #region GetEtelaatEydiDetail
        public OBJ_EtelaatEydi GetEtelaatEydiDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_EtelaatEydi().Detail(Id, OrganId, out Error);
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
        #region GetEtelaatEydiWithFilter
        public List<OBJ_EtelaatEydi> GetEtelaatEydiWithFilter(string FieldName, string FilterValue, int Id, short Year, byte NobatePardakht, int OrganId, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_EtelaatEydi().Select(FieldName, FilterValue, Id, Year, NobatePardakht, OrganId, Top);
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
        #region InsertEtelaatEydi
        public string InsertEtelaatEydi(int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(178, UserId, OrganId))
                        return new BL_EtelaatEydi().Insert(PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc, out Error);
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
        #region UpdateEtelaatEydi
        public string UpdateEtelaatEydi(int Id, int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(179, UserId, OrganId))
                        return new BL_EtelaatEydi().Update(Id, PersonalId, Year, DayCount, Kosurat, NobatePardakht, UserId, Desc, out Error);
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
        #region DeleteEtelaatEydi
        public string DeleteEtelaatEydi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(180, UserId, OrganId))
                        return new BL_EtelaatEydi().Delete(Id, UserId, out Error);
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
        #region GetEtelaatEydiGroupWithFilter
        public List<OBJ_EtelaatEydi> GetEtelaatEydiGroupWithFilter(string FieldName, short Sal, byte NobatPardakht, string Value, int OrganId, int CostCenter_Chart, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_EtelaatEydi().EtelaatEydiGroup(FieldName, Sal, NobatPardakht, Value, OrganId, CostCenter_Chart);
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

        //EzafeKari_TatilKari
        #region GetEzafeKari_TatilKariDetail
        public OBJ_EzafeKari_TatilKari GetEzafeKari_TatilKariDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_EzafeKari_TatilKari().Detail(Id, OrganId, out Error);
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
        #region GetEzafeKari_TatilKariWithFilter
        public List<OBJ_EzafeKari_TatilKari> GetEzafeKari_TatilKariWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatePardakht, byte Type, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_EzafeKari_TatilKari().Select(FieldName, FilterValue, Id, Year, Month, NobatePardakht, Type, OrganId, Top);
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
        #region InsertEzafeKari_TatilKari
        public string InsertEzafeKari_TatilKari(int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (Type == 1)
                        APPId = 182;
                    else if (Type == 2)
                        APPId = 608;
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_EzafeKari_TatilKari().Insert(PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc, out Error);
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
        #region UpdateEzafeKari_TatilKari
        public string UpdateEzafeKari_TatilKari(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (Type == 1)
                        APPId = 183;
                    else if (Type == 2)
                        APPId = 609;
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_EzafeKari_TatilKari().Update(Id, PersonalId, Year, Month, NobatePardakht, Count, Type, HasBime, HasMaliyat, UserId, Desc, out Error);
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
        #region DeleteEzafeKari_TatilKari
        public string DeleteEzafeKari_TatilKari(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    DL_EzafeKari_TatilKari m=new DL_EzafeKari_TatilKari();
                    var q = m.Select("CheckId", Id.ToString(), 0, 0, 0, 0, 0, 0, 0).FirstOrDefault();
                    if (q.fldType == 1)
                        APPId = 184;
                    else if (q.fldType == 2)
                        APPId = 610;
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_EzafeKari_TatilKari().Delete(Id, UserId, out Error);
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
        #region GetEzafeKari_TatilKariGroupWithFilter
        public List<OBJ_EzafeKari_TatilKari> GetEzafeKari_TatilKariGroupWithFilter(string FieldName, string Sal, string Mah, byte NobatePardakht, byte Type, int OrganId, int CostCenter_Chart, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_EzafeKari_TatilKari().EzafeKari_TatilKariGroup(FieldName, Sal, Mah, NobatePardakht, Type, OrganId, CostCenter_Chart);
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

        //Fiscal_Detail
        #region GetFiscal_DetailDetail
        public OBJ_Fiscal_Detail GetFiscal_DetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Fiscal_Detail().Detail(Id, out Error);
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
        #region GetFiscal_DetailWithFilter
        public List<OBJ_Fiscal_Detail> GetFiscal_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Fiscal_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertFiscal_Detail
        public string InsertFiscal_Detail(int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(186, UserId, OrganId))
                        return new BL_Fiscal_Detail().Insert(FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc, out Error);
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
        #region UpdateFiscal_Detail
        public string UpdateFiscal_Detail(int Id, int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(187, UserId, OrganId))
                        return new BL_Fiscal_Detail().Update(Id, FiscalHeaderId, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc, out Error);
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
        #region DeleteFiscal_Detail
        public string DeleteFiscal_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(188, UserId, OrganId))
                        return new BL_Fiscal_Detail().Delete(Id, UserId, out Error);
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
        #region InsertFiscal_Header_Detail
        public string InsertFiscal_Header_Detail(string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(186, UserId, OrganId))
                        return new BL_Fiscal_Detail().Fiscal_Header_DetailInsert(EffectiveDate, DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc, out Error);
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
        #region UpdateFiscal_Header_Detail
        public string UpdateFiscal_Header_Detail(int Id, string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(187, UserId, OrganId))
                        return new BL_Fiscal_Detail().Fiscal_Header_DetailUpdate(Id, EffectiveDate, DateOfIssue, AmountFrom, AmountTo, PercentTaxOnWorkers, TaxationOfEmployees, Tax, UserId, Desc, out Error);
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
        #region DeleteFiscal_Header_Detail
        public string DeleteFiscal_Header_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(188, UserId, OrganId))
                        return new BL_Fiscal_Detail().Fiscal_Header_DetailDelete(Id, UserId, out Error);
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

        //Fiscal_Header
        #region GetFiscal_HeaderDetail
        public OBJ_Fiscal_Header GetFiscal_HeaderDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Fiscal_Header().Detail(Id, out Error);
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
        #region GetFiscal_HeaderWithFilter
        public List<OBJ_Fiscal_Header> GetFiscal_HeaderWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Fiscal_Header().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertFiscal_Header
        public int InsertFiscal_Header(string EffectiveDate, string DateOfIssue, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(186, UserId, OrganId))
                        return new BL_Fiscal_Header().Insert(EffectiveDate, DateOfIssue, UserId, Desc, out Error);
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
        #region UpdateFiscal_Header
        public string UpdateFiscal_Header(int Id, string EffectiveDate, string DateOfIssue, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(187, UserId, OrganId))
                        return new BL_Fiscal_Header().Update(Id, EffectiveDate, DateOfIssue, UserId, Desc, out Error);
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
        #region DeleteFiscal_Header
        public string DeleteFiscal_Header(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(188, UserId, OrganId))
                        return new BL_Fiscal_Header().Delete(Id, UserId, out Error);
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

        //FiscalTitle
        #region GetFiscalTitleDetail
        public OBJ_FiscalTitle GetFiscalTitleDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_FiscalTitle().Detail(Id, out Error);
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
        #region GetFiscalTitleWithFilter
        public List<OBJ_FiscalTitle> GetFiscalTitleWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_FiscalTitle().Select(FieldName, FilterValue, Top);
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
        #region InsertFiscalTitle
        public string InsertFiscalTitle(int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(194, UserId, OrganId))
                        return new BL_FiscalTitle().Insert(FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc, out Error);
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
        #region UpdateFiscalTitle
        public string UpdateFiscalTitle(int Id, int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(195, UserId, OrganId))
                        return new BL_FiscalTitle().Update(Id, FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc, out Error);
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
        #region DeleteFiscalTitle
        public string DeleteFiscalTitle(string FieldName, string FilterValue, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(196, UserId, OrganId))
                        return new BL_FiscalTitle().Delete(FieldName, FilterValue, Id, UserId, out Error);
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

        //GHarardadBime
        #region GetGHarardadBimeDetail
        public OBJ_GHarardadBime GetGHarardadBimeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_GHarardadBime().Detail(Id, out Error);
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
        #region GetGHarardadBimeWithFilter
        public List<OBJ_GHarardadBime> GetGHarardadBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GHarardadBime().Select(FieldName, FilterValue, Top);
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
        #region InsertGHarardadBime
        public string InsertGHarardadBime(string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(198, UserId, OrganId))
                        return new BL_GHarardadBime().Insert(fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal, fldMablaghe70Sal
                            , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh, UserId, Desc, out Error);
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
        #region UpdateGHarardadBime
        public string UpdateGHarardadBime(int Id, string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(199, UserId, OrganId))
                        return new BL_GHarardadBime().Update(Id, fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal, fldMablaghe70Sal
                            , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh, UserId, Desc, out Error);
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
        #region DeleteGHarardadBime
        public string DeleteGHarardadBime(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(200, UserId, OrganId))
                        return new BL_GHarardadBime().Delete(Id, UserId, out Error);
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

        //MaliyatDaraei

        #region UpdateMaliyatDaraei
        public string UpdateMaliyatDaraei(short fldYear, byte fldMonth, byte fldNobatePardakht,  string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(355, UserId, OrganId))
                        return new BL_MaliyatDaraei().Update(fldYear, fldMonth, fldNobatePardakht, OrganId, UserId, IP, out Error);
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
        #region DeleteMaliyatDaraei
        public string DeleteMaliyatDaraei(short fldYear, byte fldMonth, byte fldNobatePardakht, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(355, UserId, OrganId))
                        return new BL_MaliyatDaraei().Delete(fldYear, fldMonth, fldNobatePardakht, OrganId, UserId, IP, out Error);
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

        //TypeOfCostCenters
        #region GetTypeOfCostCentersDetail
        public OBJ_TypeOfCostCenters GetTypeOfCostCentersDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TypeOfCostCenters().Detail(Id, out Error);
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
        #region GetTypeOfCostCentersWithFilter
        public List<OBJ_TypeOfCostCenters> GetTypeOfCostCentersWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeOfCostCenters().Select(FieldName, FilterValue, Top);
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
        #region InsertTypeOfCostCenters
        public string InsertTypeOfCostCenters(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(202, UserId, OrganId))
                        return new BL_TypeOfCostCenters().Insert(Title, UserId, Desc, out Error);
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
        #region UpdateTypeOfCostCenters
        public string UpdateTypeOfCostCenters(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(203, UserId, OrganId))
                        return new BL_TypeOfCostCenters().Update(Id, Title, UserId, Desc, out Error);
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
        #region DeleteTypeOfCostCenters
        public string DeleteTypeOfCostCenters(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(204, UserId, OrganId))
                        return new BL_TypeOfCostCenters().Delete(Id, UserId, out Error);
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

        //InsuranceWorkshop
        #region GetInsuranceWorkshopDetail
        public OBJ_InsuranceWorkshop GetInsuranceWorkshopDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_InsuranceWorkshop().Detail(Id, OrganId, out Error);
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
        #region GetInsuranceWorkshopWithFilter
        public List<OBJ_InsuranceWorkshop> GetInsuranceWorkshopWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_InsuranceWorkshop().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertInsuranceWorkshop
        public string InsertInsuranceWorkshop(string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(206, UserId, OrganId))
                        return new BL_InsuranceWorkshop().Insert(WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman, fldOrganId, UserId, Desc, out Error);
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
        #region UpdateInsuranceWorkshop
        public string UpdateInsuranceWorkshop(int Id, string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(207, UserId, OrganId))
                        return new BL_InsuranceWorkshop().Update(Id, WorkShopName, EmployerName, WorkShopNum, Persent, Address, Peyman,fldOrganId, UserId, Desc, out Error);
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
        #region DeleteInsuranceWorkshop
        public string DeleteInsuranceWorkshop(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(208, UserId, OrganId))
                        return new BL_InsuranceWorkshop().Delete(Id, UserId, out Error);
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

        //TypeOfEmploymentCenter
        #region GetTypeOfEmploymentCenterDetail
        public OBJ_TypeOfEmploymentCenter GetTypeOfEmploymentCenterDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TypeOfEmploymentCenter().Detail(Id, out Error);
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
        #region GetTypeOfEmploymentCenterWithFilter
        public List<OBJ_TypeOfEmploymentCenter> GetTypeOfEmploymentCenterWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeOfEmploymentCenter().Select(FieldName, FilterValue, Top);
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
        #region InsertTypeOfEmploymentCenter
        public string InsertTypeOfEmploymentCenter(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(210, UserId, OrganId))
                        return new BL_TypeOfEmploymentCenter().Insert(Title, UserId, Desc, out Error);
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
        #region UpdateTypeOfEmploymentCenter
        public string UpdateTypeOfEmploymentCenter(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(211, UserId, OrganId))
                        return new BL_TypeOfEmploymentCenter().Update(Id, Title, UserId, Desc, out Error);
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
        #region DeleteTypeOfEmploymentCenter
        public string DeleteTypeOfEmploymentCenter(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(212, UserId, OrganId))
                        return new BL_TypeOfEmploymentCenter().Delete(Id, UserId, out Error);
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

        //ReportType
        #region GetReportTypeWithFilter
        public List<OBJ_ReportType> GetReportTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ReportType().Select(FieldName, FilterValue, Top);
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

        //KarKardeMahane
        #region GetKarKardeMahaneDetail
        public OBJ_KarKardeMahane GetKarKardeMahaneDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_KarKardeMahane().Detail(Id, OrganId, out Error);
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
        #region GetKarKardeMahaneWithFilter
        public List<OBJ_KarKardeMahane> GetKarKardeMahaneWithFilter(string FieldName, string FilterValue, string Year, string Month, byte NobatPardakht, int id, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KarKardeMahane().Select(FieldName, FilterValue, Year, Month, NobatPardakht, id, OrganId, Top);
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
        #region InsertKarKardeMahane
        public int InsertKarKardeMahane(int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(214, UserId, OrganId))
                        return new BL_KarKardeMahane().Insert(PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                        , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount,  fldEstelagi, UserId, Desc, out Error);
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
        #region UpdateKarKardeMahane
        public string UpdateKarKardeMahane(int Id, int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(215, UserId, OrganId))
                        return new BL_KarKardeMahane().Update(Id, PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                        , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount, fldEstelagi, UserId, Desc, out Error);
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
        #region DeleteKarKardeMahane
        public string DeleteKarKardeMahane(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(216, UserId, OrganId))
                        return new BL_KarKardeMahane().Delete(Id, UserId, out Error);
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
        #region GetKarKardeMahaneGroupWithFilter
        public List<OBJ_KarKardeMahane> GetKarKardeMahaneGroupWithFilter(string FieldName, string FilterValue, short Year, byte Month, byte NobatPardakht, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KarKardeMahane().KarKardeMahaneGroup(FieldName, FilterValue, Year, Month, NobatPardakht, OrganId);
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

        //KarKardHokm
        #region GetKarKardHokmDetail
        public OBJ_KarKardHokm GetKarKardHokmDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_KarKardHokm().Detail(Id, out Error);
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
        #region GetKarKardHokmWithFilter
        public List<OBJ_KarKardHokm> GetKarKardHokmWithFilter(string FieldName, string FilterValue, string FilterValue2, int KarkardId, decimal Roz, decimal Gheybat, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KarKardHokm().Select(FieldName, FilterValue, FilterValue2, KarkardId, Roz,Gheybat, Top);
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
        #region InsertKarKardHokm
        public string InsertKarKardHokm(int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(214, UserId, OrganId))
                        return new BL_KarKardHokm().Insert(fldKarkardId, fldHokmId, fldRoze,  fldGheybat, out Error);
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
        #region UpdateKarKardHokm
        public string UpdateKarKardHokm(int fldId, int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(215, UserId, OrganId))
                        return new BL_KarKardHokm().Update(fldId,fldKarkardId,fldHokmId,fldRoze, fldGheybat, out Error);
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
        #region DeleteKarKardHokm
        public string DeleteKarKardHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(216, UserId, OrganId))
                        return new BL_KarKardHokm().Delete(Id, UserId, out Error);
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
       

        //PayPersonalInfo
        #region GetPayPersonalInfoDetail
        public OBJ_PayPersonalInfo GetPayPersonalInfoDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PayPersonalInfo().Detail(Id, OrganId, out Error);
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
        #region GetPayPersonalInfoWithFilter
        public List<OBJ_PayPersonalInfo> GetPayPersonalInfoWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PayPersonalInfo().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertPayPersonalInfo
        public string InsertPayPersonalInfo(int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int StatusId, string DateTaghirVaziyat, int? fldTarikhMazad30Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(218, UserId, OrganId))
                        return new BL_PayPersonalInfo().Insert(Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                        , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman, StatusId, DateTaghirVaziyat,fldTarikhMazad30Sal, UserId, Desc, out Error);
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
        #region UpdatePayPersonalInfo
        public string UpdatePayPersonalInfo(int Id, int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int? fldTarikhMazad30Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(219, UserId, OrganId))
                        return new BL_PayPersonalInfo().Update(Id, Prs_PersonalInfoId, TypeBimeId, ShomareBime, BimeOmr, BimeTakmili, MashagheleSakhtVaZianAvar, CostCenterId, Mazad30Sal
                        , PasAndaz, SanavatPayanKhedmat, JobeCode, InsuranceWorkShopId, HamsarKarmand, MoafDarman, fldTarikhMazad30Sal, UserId, Desc, out Error);
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
        #region DeletePayPersonalInfo
        public string DeletePayPersonalInfo(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(220, UserId, OrganId))
                        return new BL_PayPersonalInfo().Delete(Id, UserId, out Error);
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

        //KosorateParametri_Personal
        #region GetKosorateParametri_PersonalDetail
        public OBJ_KosorateParametri_Personal GetKosorateParametri_PersonalDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_KosorateParametri_Personal().Detail(Id, OrganId, out Error);
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
        #region GetKosorateParametri_PersonalWithFilter
        public List<OBJ_KosorateParametri_Personal> GetKosorateParametri_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_KosorateParametri_Personal().Select(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, OrganId, Top);
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
        #region InsertKosorateParametri_Personal
        public string InsertKosorateParametri_Personal(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(222, UserId, OrganId))
                        return new BL_KosorateParametri_Personal().Insert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                        , MondeGHabl, Status, DateDeactive, UserId, Desc, out Error);
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
        #region InsertGroupKosorateParametri_Personal
        public string InsertGroupKosorateParametri_Personal(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(222, UserId, OrganId))
                        return new BL_KosorateParametri_Personal().InsertGroup(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                        , MondeGHabl, Status, DateDeactive, UserId, Desc, out Error);
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
        #region UpdateKosorateParametri_Personal
        public string UpdateKosorateParametri_Personal(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(223, UserId, OrganId))
                        return new BL_KosorateParametri_Personal().Update(Id, PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhePardakht, SumFish, MondeFish, SumPardakhtiGHabl
                        , MondeGHabl, Status, DateDeactive, UserId, Desc, out Error);
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
        #region UpdateKosorateParametri_Personal
        public string UpdateDeactiveKosorateParametri_Personal( string PersonalId, int ParametrId,  int Mablagh,  string TarikhePardakht
            , bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1220, UserId, OrganId))
                        return new BL_KosorateParametri_Personal().UpdateDeactive(PersonalId,ParametrId,  Mablagh,  TarikhePardakht,
                        Status, DateDeactive, UserId, Desc, out Error);
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
        #region DeleteKosorateParametri_Personal
        public string DeleteKosorateParametri_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(224, UserId, OrganId))
                        return new BL_KosorateParametri_Personal().Delete(Id, UserId, out Error);
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

        //KosuratBank
        #region GetKosuratBankDetail
        public OBJ_KosuratBank GetKosuratBankDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
                try
                {
                    return new BL_KosuratBank().Detail(Id, OrganId, out Error);
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
        #region GetKosuratBankWithFilter
        public List<OBJ_KosuratBank> GetKosuratBankWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KosuratBank().Select(FieldName, FilterValue, FilterValue1,FilterValue2, OrganId, Top);
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
        #region RptKosouratBank
        public List<OBJ_RptKosouratBank> RptKosouratBank(byte NobatPardakhtId, short Year, byte Month, int CostCenterId, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KosuratBank().RptKosouratBank(NobatPardakhtId, Year, Month, CostCenterId,CalcType, OrganId);
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
        #region InsertKosuratBank
        public string InsertKosuratBank(int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish,string ShomareSheba, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(226, UserId, OrganId))
                        return new BL_KosuratBank().Insert(PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab, Status, DeactiveDate,MandeAzGhabl,MandeDarFish,ShomareSheba, UserId, Desc, out Error);
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
        #region UpdateKosuratBank
        public string UpdateKosuratBank(int Id, int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish,string ShomareSheba, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(227, UserId, OrganId))
                        return new BL_KosuratBank().Update(Id, PersonalId, ShobeId, Mablagh, Count, TarikhPardakht, ShomareHesab, Status, DeactiveDate, MandeAzGhabl, MandeDarFish,ShomareSheba, UserId, Desc, out Error);
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
        #region DeleteKosuratBank
        public string DeleteKosuratBank(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(228, UserId, OrganId))
                        return new BL_KosuratBank().Delete(Id, UserId, out Error);
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

        //SayerPardakhts
        #region GetSayerPardakhts
        public OBJ_SayerPardakhts GetSayerPardakhtsDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SayerPardakhts().Detail(Id, OrganId, out Error);
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
        #region GetSayerPardakhtsWithFilter
        public List<OBJ_SayerPardakhts> GetSayerPardakhtsWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_SayerPardakhts().Select(FieldName, FilterValue, Id, Year, Month, NobatPardakht, MarhalePardakht, OrganId, Top);
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
        #region InsertSayerPardakhts
        public string InsertSayerPardakhts(int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(230, UserId, OrganId))
                        return new BL_SayerPardakhts().Insert(PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti, ShomareHesabId, CostCenterId,  Mostamar, UserId, Desc, out Error);
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
        #region UpdateSayerPardakhts
        public string UpdateSayerPardakhts(int Id, int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(231, UserId, OrganId))
                        return new BL_SayerPardakhts().Update(Id, PersonalId, Year, Month, Amount, Title, NobatePardakt, MarhalePardakht, HasMaliyat, Maliyat, KhalesPardakhti, ShomareHesabId, CostCenterId,  Mostamar, UserId, Desc, out Error);
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
        #region DeleteSayerPardakhts
        public string DeleteSayerPardakhts(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(232, UserId, OrganId))
                        return new BL_SayerPardakhts().Delete(Id, UserId, out Error);
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

        //Mamuriyat
        #region GetMamuriyat
        public OBJ_Mamuriyat GetMamuriyatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mamuriyat().Detail(Id, OrganId, out Error);
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
        #region GetMamuriyatWithFilter
        public List<OBJ_Mamuriyat> GetMamuriyatWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mamuriyat().Select(FieldName, FilterValue, Id, Year, Month, NobatPardakht, OrganId, Top);
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
        #region InsertMamuriyat
        public string InsertMamuriyat(int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30,
            byte Be10, byte Be20, byte Be30, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(234, UserId, OrganId))
                        return new BL_Mamuriyat().Insert(PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc, out Error);
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
        #region UpdateMamuriyat
        public string UpdateMamuriyat(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30
            , byte Be10, byte Be20, byte Be30, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(235, UserId, OrganId))
                        return new BL_Mamuriyat().Update(Id, PersonalId, Year, Month, NobatePardakht, BaBeytute, BeduneBeytute, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc, out Error);
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
        #region DeleteMamuriyat
        public string DeleteMamuriyat(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(236, UserId, OrganId))
                        return new BL_Mamuriyat().Delete(Id, UserId, out Error);
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
        #region GetMamuriyatGroupWithFilter
        public List<OBJ_Mamuriyat> GetMamuriyatGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mamuriyat().MamuriyatGroup(FieldName, Year, Month, NobatPardakht, OrganId, CostCenter_Chart);
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

        //MandehPasAndaz
        #region GetMandehPasAndaz
        public OBJ_MandehPasAndaz GetMandehPasAndazDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MandehPasAndaz().Detail(Id, OrganId, out Error);
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
        #region GetMandehPasAndazWithFilter
        public List<OBJ_MandehPasAndaz> GetMandehPasAndazWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MandehPasAndaz().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMandehPasAndaz
        public string InsertMandehPasAndaz(int PersonalId, int Mablagh, string TarikhSabt, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(238, UserId, OrganId))
                        return new BL_MandehPasAndaz().Insert(PersonalId, Mablagh, TarikhSabt, UserId, Desc, out Error);
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
        #region UpdateMandehPasAndaz
        public string UpdateMandehPasAndaz(int Id, int PersonalId, int Mablagh, string TarikhSabt, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(239, UserId, OrganId))
                        return new BL_MandehPasAndaz().Update(Id, PersonalId, Mablagh, TarikhSabt, UserId, Desc, out Error);
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
        #region DeleteMandehPasAndaz
        public string DeleteMandehPasAndaz(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(240, UserId, OrganId))
                        return new BL_MandehPasAndaz().Delete(Id, UserId, out Error);
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

        //Moavaghat_Items
        #region GetMoavaghat_Items
        public OBJ_Moavaghat_Items GetMoavaghat_ItemsDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Moavaghat_Items().Detail(Id, out Error);
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
        #region GetMoavaghat_ItemsWithFilter
        public List<OBJ_Moavaghat_Items> GetMoavaghat_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Moavaghat_Items().Select(FieldName, FilterValue, Top);
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
        #region InsertMoavaghat_Items
        public string InsertMoavaghat_Items(int MoavaghatId, int ItemEstekhdamId, int Mablagh, string Desc, string Tarikh, int AnvaeEstekhdamId,
            int TypeBimeId, int SourceId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Moavaghat_Items().Insert(MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId,  SourceId,OrganId, out Error);
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
        #region UpdateMoavaghat_Items
        public string UpdateMoavaghat_Items(int Id, int MoavaghatId, int ItemEstekhdamId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Moavaghat_Items().Update(Id, MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc, out Error);
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
        #region DeleteMoavaghat_Items
        public string DeleteMoavaghat_Items(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(244, UserId))
                        return new BL_Moavaghat_Items().Delete(Id, UserId, out Error);
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

        //Moavaghat
        #region GetMoavaghat
        public OBJ_Moavaghat GetMoavaghatDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Moavaghat().Detail(Id, out Error);
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
        #region GetMoavaghatWithFilter
        public List<OBJ_Moavaghat> GetMoavaghatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Moavaghat().Select(FieldName, FilterValue, Top);
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
        #region InsertMoavaghat
        public int InsertMoavaghat(int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int Maliyat, int? HokmId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Moavaghat().Insert(MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                        , BimeMashaghel, PasAndaz, MashmolBime, fldMashmolBimeNaKhales, MashmolMaliyat, Maliyat, HokmId, UserId, Desc, out Error);
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
        #region UpdateMoavaghat
        public string UpdateMoavaghat(int Id, int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
            , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int MashmolMaliyat, int Maliyat, int? HokmId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Moavaghat().Update(Id, MohasebatId, Year, Month, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari
                        , BimeMashaghel, PasAndaz, MashmolBime, MashmolMaliyat, Maliyat, HokmId, UserId, Desc, out Error);
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
        #region DeleteMoavaghat
        public string DeleteMoavaghat(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(248, UserId))
                        return new BL_Moavaghat().Delete(Id, UserId, out Error);
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

        //Mohasebat
        #region GetMohasebat
        public OBJ_Mohasebat GetMohasebatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
                try
                {
                    return new BL_Mohasebat().Detail(Id, OrganId, out Error);
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
        #region GetMohasebatWithFilter
        public List<OBJ_Mohasebat> GetMohasebatWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().Select(FieldName, FilterValue,FilterValue2,FilterValue3, OrganId, Top);
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
        #region InsertMohasebat
        public int InsertMohasebat(int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
             int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat,
            int HaghDarman, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari,
            decimal DarsadBimeSakht, byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, bool Flag, int KhalesPardakhti
            , int Mogharari, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, int HokmId, byte T_Asli, byte T_70, byte T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? VamId, Nullable<int> TedadBime1, Nullable<int> TedadBime2, Nullable<int> TedadBime3, byte HesabTypeId, byte MaliyatType, short fldMeetingCount, byte fldCalcType,byte fldEstelagi, int fldOrganId, int fldShift, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat().Insert(PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                        , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                        , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, Flag, KhalesPardakhti, Mogharari, Maliyat
                        , FiscalHeaderId, MoteghayerHoghoghiId, HokmId, T_Asli, T_70, T_60,  fldT_BedonePoshesh, HamsareKarmand, Mazad30Sal, VamId, TedadBime1, TedadBime2, TedadBime3, fldShift, HesabTypeId, MaliyatType, fldMeetingCount,fldCalcType, fldEstelagi, fldOrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebat
        public string UpdateMohasebat(int Id, int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
            int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman
            , int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht,
            byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int MashmolMaliyat, bool Flag, int khalesPardakhti, int Mogharari,
            int Maliyat, int fldShift, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat().Update(Id, PersonalId, Year, Month, Karkard, Gheybat, TedadEzafeKar, TedadTatilKar, BaBeytute, BedunBeytute, BimeOmrKarFarma, BimeOmr
                        , BimeTakmilyKarFarma, BimeTakmily, HaghDarmanKarfFarma, HaghDarmanDolat, HaghDarman, BimePersonal, BimeKarFarma, BimeBikari, BimeMashaghel, DarsadBimePersonal, DarsadBimeKarFarma
                        , DarsadBimeBikari, DarsadBimeSakht, TedadNobatKari, Mosaede, NobatPardakht, GhestVam, PasAndaz, MashmolBime, MashmolMaliyat, Flag, khalesPardakhti, Mogharari, Maliyat,fldShift, UserId, Desc, out Error);
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
        #region DeleteMohasebat
        public string DeleteMohasebat(int Id, byte CalcType, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(252, UserId))
                        return new BL_Mohasebat().Delete(Id, CalcType, UserId, out Error);
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

        //Mohasebat_Items
        #region GetMohasebat_Items
        public OBJ_Mohasebat_Items GetMohasebat_ItemsDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_Items().Detail(Id, out Error);
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
        #region GetMohasebat_ItemsWithFilter
        public List<OBJ_Mohasebat_Items> GetMohasebat_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_Items().Select(FieldName, FilterValue, Top);
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
        #region InsertMohasebat_Items
        public string InsertMohasebat_Items(int MohasebatId, int ItemEstekhdamId, int Mablagh, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId,byte fldCalcType,  string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Items().Insert(MohasebatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId,SourceId,fldCalcType,  OrganId, out Error);
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
        #region UpdateMohasebat_Items
        public string UpdateMohasebat_Items(int Id, int MohasebatId, int ItemEstekhdamId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Items().Update(Id, MohasebatId, ItemEstekhdamId, Mablagh, UserId, Desc, out Error);
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
        #region DeleteMohasebat_Items
        public string DeleteMohasebat_Items(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                   // if (new BL().BLPermission(256, UserId))
                        return new BL_Mohasebat_Items().Delete(Id, UserId, out Error);
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

        //Mohasebat_kosorat_MotalebatParam
        #region GetMohasebat_kosorat_MotalebatParam
        public OBJ_Mohasebat_kosorat_MotalebatParam GetMohasebat_kosorat_MotalebatParamDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_kosorat_MotalebatParam().Detail(Id, out Error);
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
        #region GetMohasebat_kosorat_MotalebatParamWithFilter
        public List<OBJ_Mohasebat_kosorat_MotalebatParam> GetMohasebat_kosorat_MotalebatParamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_kosorat_MotalebatParam().Select(FieldName, FilterValue, Top);
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
        #region InsertMohasebat_kosorat_MotalebatParam
        public string InsertMohasebat_kosorat_MotalebatParam(int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_kosorat_MotalebatParam().Insert(MohasebatId, KosoratId, MotalebatId, Mablagh,OrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebat_kosorat_MotalebatParam
        public string UpdateMohasebat_kosorat_MotalebatParam(int Id, int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_kosorat_MotalebatParam().Update(Id, MohasebatId, KosoratId, MotalebatId, Mablagh, UserId, Desc, out Error);
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
        #region DeleteMohasebat_kosorat_MotalebatParam
        public string DeleteMohasebat_kosorat_MotalebatParam(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(260, UserId))
                        return new BL_Mohasebat_kosorat_MotalebatParam().Delete(Id, UserId, out Error);
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

        //Mohasebat_KosoratBank
        #region GetMohasebat_KosoratBank
        public OBJ_Mohasebat_KosoratBank GetMohasebat_KosoratBankDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_KosoratBank().Detail(Id, out Error);
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
        #region GetMohasebat_KosoratBankWithFilter
        public List<OBJ_Mohasebat_KosoratBank> GetMohasebat_KosoratBankWithFilter(string FieldName, string FilterValue,string IP, int Top, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_KosoratBank().Select(FieldName, FilterValue, Top);
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
        #region InsertMohasebat_KosoratBank
        public string InsertMohasebat_KosoratBank(int MohasebatId, int KosoratBankId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_KosoratBank().Insert(MohasebatId, KosoratBankId, Mablagh, UserId, Desc, out Error);
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
        #region UpdateMohasebat_KosoratBank
        public string UpdateMohasebat_KosoratBank(int Id, int MohasebatId, int KosoratBankId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_KosoratBank().Update(Id, MohasebatId, KosoratBankId, Mablagh, UserId, Desc, out Error);
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
        #region DeleteMohasebat_KosoratBank
        public string DeleteMohasebat_KosoratBank(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(264, UserId))
                        return new BL_Mohasebat_KosoratBank().Delete(Id, UserId, out Error);
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

        //Morakhasi
        #region GetMorakhasi
        public OBJ_Morakhasi GetMorakhasiDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Morakhasi().Detail(Id, OrganId, out Error);
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
        #region GetMorakhasiWithFilter
        public List<OBJ_Morakhasi> GetMorakhasiWithFilter(string FieldName, string FilterValue, int id, short Year, byte Month, byte NobatPardakht, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Morakhasi().Select(FieldName, FilterValue, id, Year, Month, NobatPardakht, OrganId, Top);
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
        #region InsertMorakhasi
        public string InsertMorakhasi(int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(266, UserId, OrganId))
                        return new BL_Morakhasi().Insert(PersonalId, Year, Month, NobatePardakht, SalAkharinHokm, Tedad, UserId, Desc, out Error);
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
        #region UpdateMorakhasi
        public string UpdateMorakhasi(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(267, UserId, OrganId))
                        return new BL_Morakhasi().Update(Id, PersonalId, Year, Month, NobatePardakht, SalAkharinHokm, Tedad, UserId, Desc, out Error);
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
        #region DeleteMorakhasi
        public string DeleteMorakhasi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(268, UserId, OrganId))
                        return new BL_Morakhasi().Delete(Id, UserId, out Error);
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
        #region GetMorakhasiGroupFilter
        public List<OBJ_Morakhasi> GetMorakhasiGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Morakhasi().MorakhasiGroup(FieldName, Year, Month, NobatPardakht, OrganId, CostCenter_Chart);
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

        //Mohasebat_Mamuriyat
        #region GetMohasebat_Mamuriyat
        public OBJ_Mohasebat_Mamuriyat GetMohasebat_MamuriyatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_Mamuriyat().Detail(Id, OrganId, out Error);
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
        #region GetMohasebat_MamuriyatWithFilter
        public List<OBJ_Mohasebat_Mamuriyat> GetMohasebat_MamuriyatWithFilter(string FieldName, string FilterValue, int OrganId, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_Mamuriyat().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMohasebat_Mamuriyat
        public string InsertMohasebat_Mamuriyat(int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Mamuriyat().Insert(PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                        , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht, FiscalHeaderId, MoteghayerHoghoghiId, HesabTypeId, fldOrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebat_Mamuriyat
        public string UpdateMohasebat_Mamuriyat(int Id, int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Mamuriyat().Update(Id, PersonalId, Year, Month, TedadBaBeytute, TedadBedunBeytute, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal
                        , DarsadBimeKarFarma, DarsadBimeBiKari, DarsadBimeSakht, MashmolBime, MashmolMaliyat, KhalesPardakhti, Maliyat, Tashilat, NobatePardakht, CostCenterId, UserId, Desc, out Error);
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
        #region DeleteMohasebat_Mamuriyat
        public string DeleteMohasebat_Mamuriyat(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(272, UserId))
                        return new BL_Mohasebat_Mamuriyat().Delete(Id, UserId, out Error);
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

        //SayerPardakhtGroup
        #region GetSayerPardakhtGroupWithFilter
        public List<OBJ_SayerPardakhtGroup> GetSayerPardakhtGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int CostCenterId, int? BankId, byte Type, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SayerPardakhtGroup().Select(FieldName, Year, Month, NobatPardakht, MarhalePardakht, CostCenterId, BankId, Type, OrganId);
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

        //ShomareHesabs
        #region GetShomareHesabs
        public OBJ_ShomareHesabs GetShomareHesabsDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ShomareHesabs().Detail(Id, OrganId, out Error);
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
        #region GetShomareHesabsWithFilter
        public List<OBJ_ShomareHesabs> GetShomareHesabsWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ShomareHesabs().Select(FieldName, FilterValue, FilterValue2, FilterValue3, OrganId, Top);
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
        #region InsertShomareHesabs
        public string InsertShomareHesabs(int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(274, UserId, OrganId))
                        return new BL_ShomareHesabs().Insert(PersonalId, ShobeId, ShomareHesab, ShomareKart, TypeHesab,  HesabTypeId, UserId, Desc, out Error);
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
        #region UpdateShomareHesabs
        public string UpdateShomareHesabs(int Id, int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(275, UserId, OrganId))
                        return new BL_ShomareHesabs().Update(Id, PersonalId, ShobeId, ShomareHesab, ShomareKart, TypeHesab,  HesabTypeId, UserId, Desc, out Error);
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
        #region DeleteShomareHesabs
        public string DeleteShomareHesabs(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(276, UserId, OrganId))
                        return new BL_ShomareHesabs().Delete(Id, UserId, out Error);
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
        #region GetShomareHesabGroupWithFilter
        public List<OBJ_ShomareHesabs> GetShomareHesabGroupWithFilter(bool NoeHesab, int BankId, int OrganId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ShomareHesabs().ShomareHesabGroup(NoeHesab, BankId, OrganId);
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

        //Setting
        #region GetSettingWithFilter
        public List<OBJ_Setting> GetSettingWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Setting().Select(FieldName, FilterValue, OrganId, Top);
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
        #region UpdateSetting
        public string UpdateSetting(int Id, int? H_BankFixId, string H_NameShobe, string H_CodeOrgan, string H_CodeShobe, bool ShowBankLogo, int fldOrganId, string CodeEghtesadi, int? Prs_PersonalId,
            string CodeParvande, string CodeOrganPasAndaz, int? Sh_HesabCheckId, int? B_BankFixId, string B_NameShobe, int? B_ShomareHesabId, string B_CodeShenasaee, string CodeDastgah, int? P_BankFixId, int P_ShobeId, string Desc, byte StatusMahalKedmatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(69, UserId, OrganId))
                        return new BL_Setting().Update(Id, H_BankFixId, H_NameShobe, H_CodeOrgan, H_CodeShobe, ShowBankLogo, fldOrganId, CodeEghtesadi, Prs_PersonalId, CodeParvande, CodeOrganPasAndaz, Sh_HesabCheckId, B_BankFixId, B_NameShobe, B_ShomareHesabId, B_CodeShenasaee, CodeDastgah, P_BankFixId, P_ShobeId, UserId, Desc, StatusMahalKedmatId, out Error);
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

        //StatusMahalKedmat
        #region GetStatusMahalKedmatWithFilter
        public List<OBJ_StatusMahalKedmat> GetStatusMahalKedmatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_StatusMahalKedmat().Select(FieldName, FilterValue,  Top);
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
        //Vam
        #region GetVamDetail
        public OBJ_Vam GetVamDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Vam().Detail(Id, OrganId, out Error);
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
        #region GetVamWithFilter
        public List<OBJ_Vam> GetVamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Vam().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertVam
        public string InsertVam(int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(278, UserId, OrganId))
                        return new BL_Vam().Insert(PersonalId, TarikhDaryaft, TypeVam, MablaghVam, StartDate, Count, Mablagh, MandeVam, Status, UserId, Desc, out Error);
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
        #region UpdateVam
        public string UpdateVam(int Id, int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(279, UserId, OrganId))
                        return new BL_Vam().Update(Id, PersonalId, TarikhDaryaft, TypeVam, MablaghVam, StartDate, Count, Mablagh, MandeVam, Status, UserId, Desc, out Error);
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
        #region DeleteVam
        public string DeleteVam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(280, UserId, OrganId))
                        return new BL_Vam().Delete(Id, UserId, out Error);
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
        #region VamStatusUpdate
        public string VamStatusUpdate(int Id, bool Status, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(698, UserId, OrganId))
                        return new BL_Vam().VamStatusUpdate(Id, Status, UserId, out Error);
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

        //Mohasebat_PersonalInfo
        #region GetMohasebat_PersonalInfoDetail
        public OBJ_Mohasebat_PersonalInfo GetMohasebat_PersonalInfoDetail(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Mohasebat_PersonalInfo().Detail(Id, UserId, out Error);
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
        #region GetMohasebat_PersonalInfoWithFilter
        public List<OBJ_Mohasebat_PersonalInfo> GetMohasebat_PersonalInfoWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_Mohasebat_PersonalInfo().Select(FieldName, FilterValue, UserId, Top);
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
        #region InsertMohasebat_PersonalInfo
        public string InsertMohasebat_PersonalInfo(int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int ChartOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_PersonalInfo().Insert(MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                        , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60,  fldT_BedonePoshesh, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId,ChartOrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebat_PersonalInfo
        public string UpdateMohasebat_PersonalInfo(int Id, int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_PersonalInfo().Update(Id, MohasebatId, VamId, Ezafe_TatilKariId, MamuriyatId, SayerPardakhthaId, CostCenterId, InsuranceWorkShopId, CodeShoghliBime, TypeBimeId, AnvaEstekhdamId, FiscalHeaderId
                        , MoteghayerHoghoghiId, ShomareHesabId, ShomareBime, ShPasAndazPersonal, ShPasAndazKarFarma, HokmId, TedadBime1, TedadBime2, TedadBime3, T_Asli, T_70, T_60, HamsareKarmand, Mazad30Sal, StatusIsargariId, MohasebatEydiId, KomakGheyerNaghdiId, MorakhasiId, UserId, Desc, out Error);
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
        #region DeleteMohasebat_PersonalInfo
        public string DeleteMohasebat_PersonalInfo(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(284, UserId))
                        return new BL_Mohasebat_PersonalInfo().Delete(Id, UserId, out Error);
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

        //MohasebatEzafeKari_TatilKari
        #region GetMohasebatEzafeKari_TatilKariDetail
        public OBJ_MohasebatEzafeKari_TatilKari GetMohasebatEzafeKari_TatilKariDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MohasebatEzafeKari_TatilKari().Detail(Id, OrganId, out Error);
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
        #region GetMohasebatEzafeKari_TatilKariWithFilter
        public List<OBJ_MohasebatEzafeKari_TatilKari> GetMohasebatEzafeKari_TatilKariWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MohasebatEzafeKari_TatilKari().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMohasebatEzafeKari_TatilKari
        public string InsertMohasebatEzafeKari_TatilKari(int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_MohasebatEzafeKari_TatilKari().Insert(PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                        , DarsadBimeSakht, MashmolBime,  fldMashmolBimeNaKhales, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat, FiscalHeaderId, MoteghayerHoghoghiId, HesabTypeId, fldOrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebatEzafeKari_TatilKari
        public string UpdateMohasebatEzafeKari_TatilKari(int Id, int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_MohasebatEzafeKari_TatilKari().Update(Id, PersonalId, Year, Month, Tedad, Mablagh, BimePersonal, BimeKarFarma, BimeBikari, BimeSakht, DarsadBimePersonal, DarsadBimeKarFarma, DarsadBimeBikari
                        , DarsadBimeSakht, MashmolBime, MashmolMaliyat, NobatPardakht, Type, KhalesPardakhti, Maliyat, CostCenterId, UserId, Desc, out Error);
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
        #region DeleteMohasebatEzafeKari_TatilKari
        public string DeleteMohasebatEzafeKari_TatilKari(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(288, UserId))
                        return new BL_MohasebatEzafeKari_TatilKari().Delete(Id, UserId, out Error);
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

        //MotalebateParametri_Personal
        #region GetMotalebateParametri_PersonalDetail
        public OBJ_MotalebateParametri_Personal GetMotalebateParametri_PersonalDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MotalebateParametri_Personal().Detail(Id, OrganId, out Error);
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
        #region GetMotalebateParametri_PersonalWithFilter
        public List<OBJ_MotalebateParametri_Personal> GetMotalebateParametri_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MotalebateParametri_Personal().Select(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, OrganId, Top);
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
        #region InsertMotalebateParametri_Personal
        public string InsertMotalebateParametri_Personal(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(290, UserId, OrganId))
                        return new BL_MotalebateParametri_Personal().Insert(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime,  fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc, out Error);
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
        #region InsertGroupMotalebateParametri_Personal
        public string InsertGroupMotalebateParametri_Personal(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(290, UserId, OrganId))
                        return new BL_MotalebateParametri_Personal().InsertGroup(PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime,  fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc, out Error);
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
        #region UpdateMotalebateParametri_Personal
        public string UpdateMotalebateParametri_Personal(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(291, UserId, OrganId))
                        return new BL_MotalebateParametri_Personal().Update(Id, PersonalId, ParametrId, NoePardakht, Mablagh, Tedad, TarikhPardakht, MashmoleBime,  fldMazayaMashmool, MashmoleMaliyat, Status, DateDeactive, UserId, Desc, out Error);
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
        #region UpdateDeactiveMotalebateParametri_Personal
        public string UpdateDeactiveMotalebateParametri_Personal(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht
            , bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1221, UserId, OrganId))
                        return new BL_MotalebateParametri_Personal().UpdateDeactive(PersonalId, ParametrId, Mablagh, TarikhePardakht,
                        Status, DateDeactive, UserId, Desc, out Error);
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
        #region DeleteMotalebateParametri_Personal
        public string DeleteMotalebateParametri_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(292, UserId, OrganId))
                        return new BL_MotalebateParametri_Personal().Delete(Id, UserId, out Error);
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

        //MoteghayerhayeEydi
        #region GetMoteghayerhayeEydiDetail
        public OBJ_MoteghayerhayeEydi GetMoteghayerhayeEydiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MoteghayerhayeEydi().Detail(Id, out Error);
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
        #region GetMoteghayerhayeEydiWithFilter
        public List<OBJ_MoteghayerhayeEydi> GetMoteghayerhayeEydiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MoteghayerhayeEydi().Select(FieldName, FilterValue, Top);
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
        #region InsertMoteghayerhayeEydi
        public string InsertMoteghayerhayeEydi(short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(294, UserId, OrganId))
                        return new BL_MoteghayerhayeEydi().Insert(Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc, out Error);
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
        #region UpdateMoteghayerhayeEydi
        public string UpdateMoteghayerhayeEydi(int Id, short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(295, UserId, OrganId))
                        return new BL_MoteghayerhayeEydi().Update(Id, Year, MaxEydiKarmand, MaxEydiKargar, ZaribEydiKargari, TypeMohasebatMaliyat, MablaghMoafiatKarmand, MablaghMoafiatKargar, DarsadMaliyatKarmand, DarsadMaliyatKargar, TypeMohasebe, UserId, Desc, out Error);
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
        #region DeleteMoteghayerhayeEydi
        public string DeleteMoteghayerhayeEydi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(296, UserId, OrganId))
                        return new BL_MoteghayerhayeEydi().Delete(Id, UserId, out Error);
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

        //MoteghayerhayeHoghoghi_Detail
        #region GetMoteghayerhayeHoghoghi_DetailDetail
        public OBJ_MoteghayerhayeHoghoghi_Detail GetMoteghayerhayeHoghoghi_DetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MoteghayerhayeHoghoghi_Detail().Detail(Id, out Error);
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
        #region GetMoteghayerhayeHoghoghi_DetailWithFilter
        public List<OBJ_MoteghayerhayeHoghoghi_Detail> GetMoteghayerhayeHoghoghi_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MoteghayerhayeHoghoghi_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertMoteghayerhayeHoghoghi_Detail
        public string InsertMoteghayerhayeHoghoghi_Detail(int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, bool fldMazayaMashmool, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(298, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi_Detail().Insert(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldMazayaMashmool, UserId, Desc, out Error);
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
        #region UpdateMoteghayerhayeHoghoghi_Detail
        public string UpdateMoteghayerhayeHoghoghi_Detail(int Id, int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(299, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi_Detail().Update(Id, MoteghayerhayeHoghoghiId, ItemEstekhdamId, UserId, Desc, out Error);
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
        #region DeleteMoteghayerhayeHoghoghi_Detail
        public string DeleteMoteghayerhayeHoghoghi_Detail(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(300, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi_Detail().Delete(FieldName, Id, UserId, out Error);
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

        //MoteghayerhayeHoghoghi
        #region GetMoteghayerhayeHoghoghiDetail
        public OBJ_MoteghayerhayeHoghoghi GetMoteghayerhayeHoghoghiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MoteghayerhayeHoghoghi().Detail(Id, out Error);
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
        #region GetMoteghayerhayeHoghoghiWithFilter
        public List<OBJ_MoteghayerhayeHoghoghi> GetMoteghayerhayeHoghoghiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MoteghayerhayeHoghoghi().Select(FieldName, FilterValue, Top);
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
        #region InsertMoteghayerhayeHoghoghi
        public string InsertMoteghayerhayeHoghoghi(string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, string ItemEstekhdam, bool FoghTalash, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(298, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi().Insert(TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma
                        , HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar, MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat, ItemEstekhdam, FoghTalash, UserId, Desc, out Error);
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
        #region UpdateMoteghayerhayeHoghoghi
        public string UpdateMoteghayerhayeHoghoghi(int Id, string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, bool FoghTalash, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(299, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi().Update(Id, TarikhEjra, TarikhSodur, AnvaeEstekhdamId, TypeBimeId, ZaribEzafeKar, SaatKari, DarsadBimePersonal, DarsadbimeKarfarma, DarsadBimeBikari, DarsadBimeJanbazan, HaghDarmanKarmand, HaghDarmanKarfarma
                        , HaghDarmanDolat, HaghDarmanMazad, HaghDarmanTahteTakaffol, DarsadBimeMashagheleZiyanAvar, MaxHaghDarman, ZaribHoghoghiSal, Hoghogh, FoghShoghl, TafavotTatbigh, FoghVizhe, HaghJazb, Tadil, BarJastegi, Sanavat, FoghTalash, UserId, Desc, out Error);
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
        #region DeleteMoteghayerhayeHoghoghi
        public string DeleteMoteghayerhayeHoghoghi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(300, UserId, OrganId))
                        return new BL_MoteghayerhayeHoghoghi().Delete(Id, UserId, out Error);
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
        #region CopyMoteghayerhayHoghoghi
        public string CopyMoteghayerhayHoghoghi(string TarikhEjra, string TarikhSodur, int headerId, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(14, UserId))
                    return new BL_MoteghayerhayeHoghoghi().CopyMoteghayerhayHoghoghi(TarikhEjra, TarikhSodur, headerId, UserId, Desc, out Error);
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
        #region GetMoteghayerhayeHoghopghi_Zarib
        public List<OBJ_MoteghayerhayeHoghoghi> GetMoteghayerhayeHoghopghi_Zarib(int AnvaeEstekhdamId, int TypeBimeId, string TarikhEjra, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_MoteghayerhayeHoghoghi().moteghayerhayeHoghopghi_Zarib(AnvaeEstekhdamId, TypeBimeId, TarikhEjra);
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

        //ParameteriItemsFormul
        #region GetParameteriItemsFormulDetail
        public OBJ_ParameteriItemsFormul GetParameteriItemsFormulDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ParameteriItemsFormul().Detail(Id, out Error);
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
        #region GetParameteriItemsFormulWithFilter
        public List<OBJ_ParameteriItemsFormul> GetParameteriItemsFormulWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ParameteriItemsFormul().Select(FieldName, FilterValue, Top);
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
        #region InsertParameteriItemsFormul
        public string InsertParameteriItemsFormul(int ParametrId, string Formul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(697, UserId, OrganId))
                        return new BL_ParameteriItemsFormul().Insert(ParametrId, Formul, UserId, Desc, out Error);
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
        #region UpdateParameteriItemsFormul
        public string UpdateParameteriItemsFormul(int Id, int ParametrId, string Formul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(697, UserId, OrganId))
                        return new BL_ParameteriItemsFormul().Update(Id, ParametrId, Formul, UserId, Desc, out Error);
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
        #region DeleteParameteriItemsFormul
        public string DeleteParameteriItemsFormul(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                    return new BL_ParameteriItemsFormul().Delete(Id, UserId, out Error);
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

        //ShomareHesabPasAndaz
        #region GetShomareHesabPasAndazDetail
        public OBJ_ShomareHesabPasAndaz GetShomareHesabPasAndazDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ShomareHesabPasAndaz().Detail(Id, OrganId, out Error);
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
        #region GetShomareHesabPasAndazWithFilter
        public List<OBJ_ShomareHesabPasAndaz> GetShomareHesabPasAndazWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ShomareHesabPasAndaz().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertShomareHesabPasAndaz
        public string InsertShomareHesabPasAndaz(int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(306, UserId, OrganId))
                        return new BL_ShomareHesabPasAndaz().Insert(ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc, out Error);
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
        #region UpdateShomareHesabPasAndaz
        public string UpdateShomareHesabPasAndaz(int Id, int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(307, UserId, OrganId))
                        return new BL_ShomareHesabPasAndaz().Update(Id, ShomareHesabPersonalId, ShomareHesabKarfarmaId, UserId, Desc, out Error);
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
        #region DeleteShomareHesabPasAndaz
        public string DeleteShomareHesabPasAndaz(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(308, UserId, OrganId))
                        return new BL_ShomareHesabPasAndaz().Delete(Id, UserId, out Error);
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

        //KosuratParametriGroup
        #region GetKosuratParametriGroupWithFilter
        public List<OBJ_KosuratParametriGroup> GetKosuratParametriGroupWithFilter(string FieldName, string FilterValue, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KosuratParametriGroup().Select(FieldName, FilterValue, OrganId);
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

        //MotalebatParametriGroup
        #region GetMotalebatParametriGroupWithFilter
        public List<OBJ_MotalebatParametriGroup> GetMotalebatParametriGroupWithFilter(string FieldName, string FilterValue, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MotalebatParametriGroup().Select(FieldName, FilterValue, OrganId);
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

      

        //KarkardMahane_Detail
        #region GetKarkardMahane_DetailDetail
        public OBJ_KarkardMahane_Detail GetKarkardMahane_DetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_KarkardMahane_Detail().Detail(Id, out Error);
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
        #region GetKarkardMahane_DetailWithFilter
        public List<OBJ_KarkardMahane_Detail> GetKarkardMahane_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KarkardMahane_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertKarkardMahane_Detail
        public string InsertKarkardMahane_Detail(int KarkardMahaneId, int Karkard, int KargahBimeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(314, UserId, OrganId))
                        return new BL_KarkardMahane_Detail().Insert(KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc, out Error);
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
        #region UpdateKarkardMahane_Detail
        public string UpdateKarkardMahane_Detail(int Id, int KarkardMahaneId, int Karkard, int KargahBimeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(315, UserId, OrganId))
                        return new BL_KarkardMahane_Detail().Update(Id, KarkardMahaneId, Karkard, KargahBimeId, UserId, Desc, out Error);
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
        #region DeleteKarkardMahane_Detail
        public string DeleteKarkardMahane_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(316, UserId, OrganId))
                        return new BL_KarkardMahane_Detail().Delete(Id, UserId, out Error);
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

        //KomakGheyerNaghdi
        #region GetKomakGheyerNaghdiDetail
        public OBJ_KomakGheyerNaghdi GetKomakGheyerNaghdiDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_KomakGheyerNaghdi().Detail(Id, OrganId, out Error);
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
        #region GetKomakGheyerNaghdiWithFilter
        public List<OBJ_KomakGheyerNaghdi> GetKomakGheyerNaghdiWithFilter(string FieldName, string FilterValue, int id, int PersonalId, short Year, byte Month, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KomakGheyerNaghdi().Select(FieldName, FilterValue, id, PersonalId, Year, Month, OrganId, Top);
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
        #region InsertKomakGheyerNaghdi
        public string InsertKomakGheyerNaghdi(int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(318, UserId, OrganId))
                        return new BL_KomakGheyerNaghdi().Insert(PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc, out Error);
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
        #region UpdateKomakGheyerNaghdi
        public string UpdateKomakGheyerNaghdi(int Id, int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(319, UserId, OrganId))
                        return new BL_KomakGheyerNaghdi().Update(Id, PersonalId, Year, Month, NoeMostamer, Mablagh, KhalesPardakhti, Maliyat, ShomareHesabId, UserId, Desc, out Error);
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
        #region DeleteKomakGheyerNaghdi
        public string DeleteKomakGheyerNaghdi(int Id, string UserName, string Password,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(320, UserId, OrganId))
                        return new BL_KomakGheyerNaghdi().Delete(Id, UserId, out Error);
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
        #region GetKomakGheyerNaghdiGroupWithFilter
        public List<OBJ_KomakGheyerNaghdi> GetKomakGheyerNaghdiGroupWithFilter(string FieldName, byte Month, short Year, bool NoeMostamer, int PersonalId, int OrganId, int CostCenter_Chart, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_KomakGheyerNaghdi().KomakGheyerNaghdiGroup(FieldName, Month, Year, NoeMostamer, PersonalId, OrganId, CostCenter_Chart);
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

        //Mohasebat_Eydi
        #region GetMohasebat_EydiDetail
        public OBJ_Mohasebat_Eydi GetMohasebat_EydiDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_Eydi().Detail(Id, OrganId, out Error);
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
        #region GetMohasebat_EydiWithFilter
        public List<OBJ_Mohasebat_Eydi> GetMohasebat_EydiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_Eydi().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMohasebat_Eydi
        public string InsertMohasebat_Eydi(int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Eydi().Insert(PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht, HesabTypeId, fldOrganId, UserId, Desc, out Error);
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
        #region UpdateMohasebat_Eydi
        public string UpdateMohasebat_Eydi(int Id, int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Eydi().Update(Id, PersonalId, Year, Month, DayCount, Mablagh, Maliyat, Kosurat, KhalesPardakhti, NobatPardakht, CostCenterId, UserId, Desc, out Error);
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
        #region DeleteMohasebat_Eydi
        public string DeleteMohasebat_Eydi(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(324, UserId))
                        return new BL_Mohasebat_Eydi().Delete(Id, UserId, out Error);
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

        //CalcMaliyatGheyerNaghdi
        #region GetCalcMaliyatGheyerNaghdiWithFilter
        public List<OBJ_CalcMaliyatGheyerNaghdi> GetCalcMaliyatGheyerNaghdiWithFilter(string Year, int Mablagh, int TypeEstekhdam, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CalcMaliyatGheyerNaghdi().Select(Year, Mablagh, TypeEstekhdam);
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

        //SumKomakGheyerNaghdi
        #region GetSumKomakGheyerNaghdiWithFilter
        public List<OBJ_SumKomakGheyerNaghdi> GetSumKomakGheyerNaghdiWithFilter(int PersonalId, bool Type, byte Mah, short Year, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SumKomakGheyerNaghdi().Select(PersonalId, Type, Mah, Year);
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

        //ItemsEstekhdam_MoteghayerHoghoghi
        #region GetItemsEstekhdam_MoteghayerHoghoghiWithFilter
        public List<OBJ_ItemsEstekhdam_MoteghayerHoghoghi> GetItemsEstekhdam_MoteghayerHoghoghiWithFilter(string FieldName, string NoeEstekhdam, int HeaderId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ItemsEstekhdam_MoteghayerHoghoghi().Select(FieldName, NoeEstekhdam, HeaderId, Top);
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

        //Mohasebat_Morakhasi
        #region GetMohasebat_MorakhasiDetail
        public OBJ_Mohasebat_Morakhasi GetMohasebat_MorakhasiDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Mohasebat_Morakhasi().Detail(Id, OrganId, out Error);
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
        #region GetMohasebat_MorakhasiWithFilter
        public List<OBJ_Mohasebat_Morakhasi> GetMohasebat_MorakhasiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat_Morakhasi().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMohasebat_Morakhasi
        public string InsertMohasebat_Morakhasi(int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Morakhasi().Insert(PersonalId, Tedad, Mablagh, Month, Year, NobatPardakht, SalHokm, HokmId, HesabTypeId, fldOrganId, UserId, Desc, IP, out Error);
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
        #region UpdateMohasebat_Morakhasi
        public string UpdateMohasebat_Morakhasi(int Id, int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(249, UserId, OrganId))
                        return new BL_Mohasebat_Morakhasi().Update(Id, PersonalId, Tedad, Mablagh, Month, Year, NobatPardakht, SalHokm, HokmId, CostCenterId, UserId, Desc, IP, out Error);
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
        #region DeleteMohasebat_Morakhasi
        public string DeleteMohasebat_Morakhasi(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(328, UserId))
                        return new BL_Mohasebat_Morakhasi().Delete(Id, UserId, IP, out Error);
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

        //PersonalInfo_Mohasebe
        #region GetPersonalInfo_MohasebeWithFilter
        public List<OBJ_PersonalInfo_Mohasebe> GetPersonalInfo_MohasebeWithFilter(string FieldName, short Year, byte Month, byte NobatePardakht, byte Type, byte Ezafe_Tatil, int OrganId, string CostCenterId, string AnvaEstekhdamId, string Tarikh,byte CalcType, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_PersonalInfo_Mohasebe().Select(FieldName,Year, Month, NobatePardakht, Type, Ezafe_Tatil, OrganId, CostCenterId, AnvaEstekhdamId, Tarikh, CalcType);
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

        //GetTabJobOfBimeWithFilter
        #region GetTabJobOfBimeWithFilter
        public List<OBJ_TabJobOfBime> GetTabJobOfBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TabJobOfBime().Select(FieldName, FilterValue, Top);
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

        //Disket
        #region GetDisketDetail
        public OBJ_Disket GetDisketDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Disket().Detail(Id, out Error);
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
        #region GetDisketWithFilter
        public List<OBJ_Disket> GetDisketWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Disket().Select(FieldName, FilterValue, Top);
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
        #region InsertDisket
        public int InsertDisket(string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht,
            string ShobeCode, string OrganCode, byte[] File, string Pasvand, string NameFile,
            int BankFixId, string NameShobe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(343, UserId, OrganId))
                        return new BL_Disket().Insert(Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode,
                            File, Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc, OrganId, out Error);
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
        #region UpdateDisket
        public string UpdateDisket(int Id, string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, int FielId, byte[] File, string Pasvand, string NameFile, int BankFixId, string NameShobe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(344, UserId, OrganId))
                        return new BL_Disket().Update(Id, Tarikh, Tedad, Type, Jam, TypePardakht, ShobeCode, OrganCode, FielId, File, Pasvand, NameFile, BankFixId, NameShobe, UserId, Desc, out Error);
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
        #region DeleteDisket
        public string DeleteDisket(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(345, UserId, OrganId))
                        return new BL_Disket().Delete(Id, UserId, out Error);
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

        //SelectVariziForBank
        #region GetSelectVariziForBank
        public List<OBJ_SelectVariziForBank> GetSelectVariziForBank(string FieldName, string Value, short Year, byte Mah, byte NobatePardakht, byte MarhalePardakht, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectVariziForBank().Select(FieldName, Value , Year, Mah, NobatePardakht, MarhalePardakht, OrganId);
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

        //MaliyatManfi
        #region GetMaliyatManfiDetail
        public OBJ_MaliyatManfi GetMaliyatManfiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MaliyatManfi().Detail(Id, out Error);
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
        #region GetMaliyatManfiWithFilter
        public List<OBJ_MaliyatManfi> GetMaliyatManfiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MaliyatManfi().Select(FieldName, FilterValue, Top);
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
        #region InsertMaliyatManfi
        public string InsertMaliyatManfi(int Mablagh, int MohasebeId, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                   // if (new BL().BLPermission(347, UserId))تو محاسبات پر میشه نیاز ندارد
                        return new BL_MaliyatManfi().Insert(Mablagh, MohasebeId, Sal, Mah, UserId, Desc, out Error);
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
        #region UpdateMaliyatManfi
        public string UpdateMaliyatManfi(int Id, int Mablagh, int MohasebeId, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(348, UserId))تو محاسبات پر میشه نیاز ندارد
                        return new BL_MaliyatManfi().Update(Id, Mablagh, MohasebeId, Sal, Mah, UserId, Desc, out Error);
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
        #region DeleteMaliyatManfi
        public string DeleteMaliyatManfi(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                   // if (new BL().BLPermission(349, UserId))
                        return new BL_MaliyatManfi().Delete(Id, UserId, out Error);
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

        //P_MaliyatManfi
        #region GetP_MaliyatManfiDetail
        public OBJ_P_MaliyatManfi GetP_MaliyatManfiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_P_MaliyatManfi().Detail(Id, out Error);
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
        #region GetP_MaliyatManfiWithFilter
        public List<OBJ_P_MaliyatManfi> GetP_MaliyatManfiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_P_MaliyatManfi().Select(FieldName, FilterValue, Top);
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
        #region InsertP_MaliyatManfi
        public string InsertP_MaliyatManfi(int MohasebeId, int Mablagh, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    // if (new BL().BLPermission(351, UserId))تو محاسبات پر میشه نیاز ندارد
                        return new BL_P_MaliyatManfi().Insert(MohasebeId, Mablagh, Sal, Mah, UserId, Desc, out Error);
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
        #region UpdateP_MaliyatManfi
        public string UpdateP_MaliyatManfi(int Id, int MohasebeId, int Mablagh, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    // if (new BL().BLPermission(352, UserId))تو محاسبات پر میشه نیاز ندارد
                        return new BL_P_MaliyatManfi().Update(Id, MohasebeId, Mablagh, Sal, Mah, UserId, Desc, out Error);
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
        #region DeleteP_MaliyatManfi
        public string DeleteP_MaliyatManfi(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(353, UserId))
                        return new BL_P_MaliyatManfi().Delete(Id, UserId, out Error);
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

        //RptSumMotalebat_Kosurat
        #region RptSumMotalebat_Kosurat
        public List<OBJ_RptSumMotalebat_Kosurat> RptSumMotalebat_Kosurat(string FieldName, short sal, byte Month, int CostCenter, int TypeBime, byte nobat, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptSumMotalebat_Kosurat().Select(FieldName, sal, Month, CostCenter, TypeBime, nobat, OrganId, CalcType);
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

        //SelectDisketMaliyatForHoghogh
        #region GetSelectDisketMaliyatForHoghogh
        public List<OBJ_SelectDisketMaliyatForHoghogh> GetSelectDisketMaliyatForHoghogh(short Year, byte Mah, byte Nobat, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectDisketMaliyatForHoghogh().Select(Year, Mah, Nobat, OrganId);
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
        #region GetSelectHoghogh_OnAccount
        public List<OBJ_SelectDisketMaliyatForHoghogh> GetSelectHoghogh_OnAccount(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectDisketMaliyatForHoghogh().SelectHoghogh_OnAccount(Year, Mah, Nobat, OrganId, CalcType);
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
        //DisketBazneshastegi
        #region GetDisketBazneshastegi
        public List<OBJ_DisketBazneshastegi> GetDisketBazneshastegi(short Year, byte Mah, byte Nobat, int OrganId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBazneshastegi().Select(Year, Mah, Nobat, OrganId);
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

        //DisketSina
        #region GetDisketSina_Kargari
        public List<OBJ_DisketSina> GetDisketSina_Kargari(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketSina().Select(Year, Mah, Nobat, OrganId,typeEstekhdam);
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
        #region GetDisketSina_Karmandi
        public List<OBJ_DisketSinaKarmandi> GetDisketSina_Karmandi(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketSina().SelectKarmandi(Year, Mah, Nobat, OrganId, typeEstekhdam);
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

        //DisketBime
        #region GetDisketBime
        public List<OBJ_DisketBime> GetDisketBime(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime().Select(sal, mah, kargaBime, nobat);
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
        #region GetDisketBimeSum
        public List<OBJ_DisketBimeSum> GetDisketBimeSum(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime().SelectDisketBimeSum(sal, mah, kargaBime, nobat);
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
        //DisketBimeBASTAM
        #region GetDisketBimeBASTAM
        public List<OBJ_DisketBime> GetDisketBimeBASTAM(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime().SelectBASTAM(sal, mah, kargaBime, nobat);
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
        //GetDisketBime_DBF
        #region GetDisketBime_DBF
        public List<OBJ_DisketBime_DBF> GetDisketBime_DBF(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime().SelectDisketBime_DBF(sal, mah, kargaBime, nobat);
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
        //GetDisketBime_DBF_Header
        #region GetDisketBime_DBF_Header
        public OBJ_DisketBime_DBF_Header GetDisketBime_DBF_Header(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime().SelectDisketBime_DBF_Header(sal, mah, kargaBime, nobat);
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
        //DisketBime_Moavaghe
        #region GetDisketBime_Moavaghe
        public List<OBJ_DisketBime_Moavaghe> GetDisketBime_Moavaghe(short sal, byte mah, int kargaBime, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime_Moavaghe().Select(sal, mah, kargaBime);
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
        //DisketBime_Tatilkar_Ezafekar
        #region GetDisketBime_Tatilkar_Ezafekar
        public List<OBJ_DisketBime_Tatilkar_Ezafekar> GetDisketBime_Tatilkar_Ezafekar(string FieldName, short sal, byte mah, byte nobat, int kargaBime, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBime_Tatilkar_Ezafekar().Select(FieldName, sal, mah, nobat, kargaBime);
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

        //SelectInsuranceWorkshop
        #region SelectInsuranceWorkshop
        public List<OBJ_InsuranceWorkshop> SelectInsuranceWorkshop(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_InsuranceWorkshop().Select(FieldName, FilterValue, OrganId, Top);
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

        //RptSanad2
        #region GetRptSanad2
        public List<OBJ_RptSanad2> GetRptSanad2(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptSanad2().Select(Year, Mah, Nobat, OrganId, CalcType);
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
        //RptSanad3
        #region GetRptSanad3
        public List<OBJ_RptSanad3> GetRptSanad3(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptSanad3().Select(Year, Mah, Nobat, OrganId, CalcType);
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

        //RptKosurBazneshastegi
        #region GetRptKosurBazneshastegi
        public List<OBJ_RptKosurBazneshastegi> GetRptKosurBazneshastegi(short Year, byte Mah, byte Nobat, int OrganId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptKosurBazneshastegi().Select(Year, Mah, Nobat, OrganId);
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

        //UpdateEzafekarKarkardMahane
        #region UpdateEzafekarKarkardMahane
        public string UpdateEzafekarKarkardMahane(decimal ezafekar, bool ghati, int personalId, byte mah, short year, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(348, UserId))
                    return new BL_UpdateEzafekarKarkardMahane().Update(ezafekar, ghati, personalId, mah, year, out Error);
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

        //UpdateFlag
        #region UpdateFlag
        public string UpdateFlag(string fieldName, short sal, byte mah, byte nobat, byte marhalePardaht, int OrganId, byte Type, string UserName, string Password, string IP,byte fldCalcType, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(348, UserId))
                    return new BL_UpdateFlag().Update(fieldName, sal, mah, nobat, marhalePardaht,OrganId, Type, UserId, IP, fldCalcType, out Error);
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

        //SelectPayPersonalInfo_Ezafekar
        #region SelectPayPersonalInfo_Ezafekar
        public List<OBJ_SelectPayPersonalInfo_Ezafekar> SelectPayPersonalInfo_Ezafekar(string FieldName, int costcenter_ChartOrganId, int organId, short year, byte mah, int h,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectPayPersonalInfo_Ezafekar().Select(FieldName, costcenter_ChartOrganId, organId, year, mah, h);
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

        //SelectFlagKarKard_Mohasebe
        #region SelectFlagKarKard_Mohasebe
        public List<OBJ_SelectFlagKarKard_Mohasebe> SelectFlagKarKard_Mohasebe(short sal, byte mah, int OrganId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectFlagKarKard_Mohasebe().Select(sal, mah, OrganId);
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

        //MohasebatForConvert
        #region InsertMohasebatForConvert
        public int InsertMohasebatForConvert(OBJ_Mohasebat Mohasebat, OBJ_Mohasebat_PersonalInfo Mohasebat_PersonalInfo, int ChartOrganId, int fldShift, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(348, UserId))
                    return new BL_MohasebatForConvert().Insert(Mohasebat, Mohasebat_PersonalInfo, ChartOrganId, fldShift, UserId, out Error);
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

        //CheckMohasebat
        #region CheckMohasebat
        public List<OBJ_Mohasebat> CheckMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().CheckMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht,  OrganId);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, 0);
                return null;
            }


        }
        #endregion
        #region MohasebatDelete
        public string MohasebatDelete(string FieldName, int PersonalId, byte Mah, short sal,
            byte nobatpardakht, string CostCenter, string AnvaeEstekhdam, byte CalcType, string UserName, string Password, string IP, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Mohasebat().DeleteMohasebat(FieldName, PersonalId, Mah, sal, nobatpardakht,  CostCenter,  AnvaeEstekhdam, OrganId, CalcType, out Error);
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

        //DisketBimeKhadamatDarmani
        #region GetDisketBimeKhadamatDarmani
        public List<OBJ_DisketBimeKhadamatDarmani> GetDisketBimeKhadamatDarmani(short Sal, byte mah, byte nobat, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketBimeKhadamatDarmani().Select(Sal, mah, nobat,OrganId);
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

        //CheckKosorat_Motalebat
        #region GetCheckKosorat_Motalebat
        public List<OBJ_CheckKosorat_Motalebat> GetCheckKosorat_Motalebat(string FieldName, int id, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CheckKosorat_Motalebat().Select(FieldName,id);
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

        //Operation
        #region GetOperationWithFilter
        public List<OBJ_Operation> GetOperationWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Operation().Select(FieldName, FilterValue, Top);
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

        //TavighKosurat
        #region GetTavighKosuratDetail
        public OBJ_TavighKosurat GetTavighKosuratDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError(); 
            try
            {
                return new BL_TavighKosurat().Detail(Id, out Error);
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
        #region GetTavighKosuratWithFilter
        public List<OBJ_TavighKosurat> GetTavighKosuratWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TavighKosurat().Select(FieldName, FilterValue, Top);
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
        #region InsertTavighKosurat
        public string InsertTavighKosurat(int KosuratId, short Year, byte Month, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(639, UserId, OrganId))
                    return new BL_TavighKosurat().Insert(KosuratId,Year,Month, UserId, Desc, out Error);
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
        #region UpdateTavighKosurat
        public string UpdateTavighKosurat(int Id, int KosuratId, short Year, byte Month, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(640, UserId, OrganId))
                    return new BL_TavighKosurat().Update(Id, KosuratId, Year, Month, UserId, Desc, out Error);
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
        #region DeleteTavighKosurat
        public string DeleteTavighKosurat(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    // if (new BL().BLPermission(641, UserId))
                    return new BL_TavighKosurat().Delete(Id, UserId, out Error);
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

        //FishLog
        #region GetFishLog
        public OBJ_FishLog GetFishLogDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_FishLog().Detail(Id, out Error);
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
        #region GetFishLogWithFilter
        public List<OBJ_FishLog> GetFishLogWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_FishLog().Select(FieldName, FilterValue, Top);
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
        #region InsertFishLog
        public string InsertFishLog(byte fldType, int? fldPersonalId, int fldOrganId, short fldYear, byte fldMonth, byte fldNobatPardakht, byte? fldFilterType, byte? fldFishType, int? fldCostCenterId, int? fldMahaleKhedmat, byte fldCalcType, byte? fldMostamar,string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    
                        return new BL_FishLog().Insert(  fldType,  fldPersonalId,  fldOrganId,  fldYear,  fldMonth,  fldNobatPardakht,  fldFilterType,  fldFishType,  fldCostCenterId,  fldMahaleKhedmat,  fldCalcType,  fldMostamar,  IP,  UserId, out Error);
                    
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

        //SpecialPermission
        #region GetSpecialPermissionDetail
        public OBJ_SpecialPermission GetSpecialPermissionDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
                try
                {
                    return new BL_SpecialPermission().Detail(Id, out Error);
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
        #region GetSpecialPermissionWithFilter
        public List<OBJ_SpecialPermission> GetSpecialPermissionWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SpecialPermission().Select(FieldName, FilterValue, Top);
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
        #region InsertSpecialPermission
        public string InsertSpecialPermission(int UserSelectId, int ChartOrganId, int OpertionId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(643, UserId, OrganId))
                        return new BL_SpecialPermission().Insert(UserSelectId, ChartOrganId, OpertionId, UserId, Desc, out Error);
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
        #region UpdateSpecialPermission
        public string UpdateSpecialPermission(int Id, int UserSelectId, int ChartOrganId, int OpertionId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(644, UserId, OrganId))
                        return new BL_SpecialPermission().Update(Id, UserSelectId, ChartOrganId, OpertionId, UserId, Desc, out Error);
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
        #region DeleteSpecialPermission
        public string DeleteSpecialPermission(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(645, UserId, OrganId))
                        return new BL_SpecialPermission().Delete(Id, UserId, out Error);
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

        //UpdateKosurat_Motalebat
        #region UpdateKosurat_Motalebat
        public string UpdateKosurat_Motalebat(string FieldName, bool Status, int id, int dateActive, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int AppId = 0;
                    if (FieldName == "Kosurat")
                        AppId = 671;
                    else if (FieldName == "Motalebat")
                        AppId = 670;
                    else if (FieldName == "Kosurat_DateActive")
                        AppId = 639;
                    if (new BL().BLPermission(AppId, UserId, OrganId))
                    return new BL_KosorateParametri_Personal().UpdateKosurat_Motalebat(FieldName, Status, id, dateActive, UserId, out Error);
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

        //UpdateKosuratBankStatus
        #region UpdateKosuratBankStatus
        public string UpdateKosuratBankStatus(bool Status, int Id, int tarikhDeactive, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(672, UserId, OrganId))
                        return new BL_KosuratBank().UpdateKosuratBankStatus(Status, Id, tarikhDeactive, UserId, out Error);
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

        //GetPasAndazBank
        #region GetPasAndazBank
        public int? GetPasAndazBank(short Year, byte Mah, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SelectPasAndazBank().Select(Year, Mah, OrganId);
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

        #region DisketPasAndaz
        public List<OBJ_DisketPasAndaz> GetDisketPasAndaz(short sal, byte mah, byte nobat,int organId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DisketPasAndaz().Select(sal, mah, nobat, organId);
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

        //UpdateDescKosuratBank
        #region UpdateDescKosuratBank
        public string UpdateDescKosuratBank(int Id, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(701, UserId, OrganId))
                        return new BL_KosuratBank().UpdateDescKosuratBank(Id, Desc, UserId, out Error);
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

        //GetHistoryAfradTahtePoshesheBimeTakmily
        #region GetHistoryAfradTahtePoshesheBimeTakmily
        public List<OBJ_HistoryAfradTahtePoshesheBimeTakmily> GetHistoryAfradTahtePoshesheBimeTakmily(int PersonalId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AfradeTahtePoshesheBimeTakmily().HistoryAfradTahtePoshesheBimeTakmily(PersonalId, OrganId);
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

        //CheckShomareHesabPasAndazForMohasebat
        #region CheckShomareHesabPasAndazForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabPasAndazForMohasebat(string Year ,string Month,byte NobatPardakht,int OrganId,int PersonalId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().CheckShomareHesabPasAndazForMohasebat(Year,Month,NobatPardakht,OrganId,PersonalId);
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
        //CheckConflictKarkard_Mohasebat 
        #region CheckConflictKarkard_Mohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckConflictKarkard_Mohasebat(short Year, byte Month, string costCenter, string anvaEstekhdam, 
            int OrganId, int PersonalId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().CheckConflictKarkard_Mohasebat(Year,Month,costCenter,anvaEstekhdam,OrganId,PersonalId);
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
        //CheckShomareHesabForMohasebat
        #region CheckShomareHesabForMohasebat
        public List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId, byte HesabType, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().CheckShomareHesabForMohasebat(Year, Month, NobatPardakht, OrganId, PersonalId, HesabType);
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
        //CheckMohasebeForDisket
        #region CheckMohasebeForDisket
        public bool CheckMohasebeForDisket(short Year, byte Month,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Mohasebat().CheckMohasebeForDisket(Year, Month, OrganId);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return false;
            }
        }
        #endregion
        //InsertInsuranceJobs
        #region InsertInsuranceJobs
        public string InsertInsuranceJobs(string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_DisketBime().InsertInsuranceJobs();                   
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
        #region GetTypeEstekhdam_UserGroupDetail
        public OBJ_TypeEstekhdam_UserGroup GetTypeEstekhdam_UserGroupDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TypeEstekhdam_UserGroup().Detail(Id, OrganId, out Error);
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
        #region GetTypeEstekhdam_UserGroupWithFilter
        public List<OBJ_TypeEstekhdam_UserGroup> GetTypeEstekhdam_UserGroupWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeEstekhdam_UserGroup().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertTypeEstekhdam_UserGroup
        public string InsertTypeEstekhdam_UserGroup(string fldTypeEstekhamId, int fldUseGroupId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1062, UserId, OrganId))
                        return new BL_TypeEstekhdam_UserGroup().Insert(fldTypeEstekhamId, fldUseGroupId, OrganId, UserId, Desc, IP, out Error);
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
        #region UpdateTypeEstekhdam_UserGroup
        public string UpdateTypeEstekhdam_UserGroup(int Id, string fldTypeEstekhamId, int fldUseGroupId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1063, UserId, OrganId))
                        return new BL_TypeEstekhdam_UserGroup().Update(Id, fldTypeEstekhamId, fldUseGroupId, OrganId, UserId, Desc, IP, out Error);
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
        #region DeleteTypeEstekhdam_UserGroup
        public string DeleteTypeEstekhdam_UserGroup(int UserGroupId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1064, UserId, OrganId))
                        return new BL_TypeEstekhdam_UserGroup().Delete(UserGroupId, UserId,OrganId, out Error);
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


        #region RptListAghsatVam_Excel
        public List<OBJ_RptListAghsatVam> RptListAghsatVam_Excel(short Year, byte Month, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptListAghsatVam().RptListAghsatVam_Excel(Year, Month, OrganId, CalcType);
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

        #region RptKosourat_MotalebatParam_Excel
        public List<OBJ_RptKosourat_MotalebatParam> RptKosourat_MotalebatParam_Excel(short Year, byte Month, int ParametrId, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptKosourat_MotalebatParam().RptKosourat_MotalebatParam_Excel(Year, Month, ParametrId, OrganId, CalcType);
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
        #region Rpt12Mahe
        public List<OBJ_Rpt12Mahe> Rpt12Mahe(short Year, byte NobatPardakht, byte CalcType, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Rpt12Mahe().Select(Year, NobatPardakht, OrganId, CalcType);
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

        #region RptListPardakhtEydi
        public List<OBJ_RptListPardakhtEydi> RptListPardakhtEydi(int CostCenter, short Year, byte Month, byte NobatPardakht, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RptListPardakhtEydi().Select(CostCenter, Year, Month, NobatPardakht, OrganId);
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

        #region CheckAllMohasebat
        public List<OBJ_CheckAllMohasebat> CheckAllMohasebat(int PersonalId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CheckAllMohasebat().Select(PersonalId);
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
        //FishHoghoughiDetails
        #region SelectMotalebat_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Details(int PersonalId, int NobatPardakht, int AzYear, int TaYear, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_RptFishHoghoughi_Details().SelectMotalebat_Details(PersonalId, AzYear, TaYear, NobatPardakht, UserId, TypeHesab, CalcType).ToList();              
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
        #region SelectMotalebat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectMotalebat_Moavaghe_Details(int PersonalId, int NobatPardakht, short Year, byte Month, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_RptFishHoghoughi_Details().SelectMotalebat_Moavaghe_Details(PersonalId, Year, Month, NobatPardakht, UserId, TypeHesab, CalcType).ToList();
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
        #region SelectKosourat_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Details(int PersonalId, int NobatPardakht, int AzYear, int TaYear, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_RptFishHoghoughi_Details().SelectKosourat_Details(PersonalId, AzYear, TaYear, NobatPardakht, UserId, TypeHesab, CalcType).ToList();
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
        #region SelectKosourat_Moavaghe_Details
        public List<OBJ_MotalebatDetails> SelectKosourat_Moavaghe_Details(int PersonalId, int NobatPardakht, short Year, byte Month, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_RptFishHoghoughi_Details().SelectKosourat_Moavaghe_Details(PersonalId, Year, Month, NobatPardakht, UserId, TypeHesab, CalcType).ToList();
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
        #region SelectMoavaghe_Details
        public List<OBJ_FishHoghoghi_Moavaghe> SelectMoavaghe_Details(int fldPersonalId, int nobatPardakht, short Year, byte Month, short YearPardakht, byte MonthPardakht,
            byte TypeHesab, byte CalcType,byte MoavagheType, string UserName, string Password, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_RptFishHoghoughi_Details().SelectMoavaghe_Details(fldPersonalId, nobatPardakht, Year, Month, YearPardakht, MonthPardakht, UserId, TypeHesab, CalcType, MoavagheType).ToList();
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

        //Monasebat
        #region GetMonasebatDetail
        public OBJ_Monasebat GetMonasebatDetail(byte Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Monasebat().Detail(Id, out Error);
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
        #region GetMonasebatWithFilter
        public List<OBJ_Monasebat> GetMonasebatWithFilter(string FieldName, string FilterValue, string FilterValue2,bool DateType, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Monasebat().Select(FieldName, FilterValue,FilterValue2,DateType, Top);
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
        #region InsertMonasebat
        public string InsertMonasebat(string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1279, UserId, OrganId))
                        return new BL_Monasebat().Insert(Name, MonasebatType, Month, Day, DateType, Holiday, Mazaya, UserId, IP, out Error);
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
        #region UpdateMonasebat
        public string UpdateMonasebat(byte Id, string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1280, UserId, OrganId))
                        return new BL_Monasebat().Update(Id, Name, MonasebatType, Month, Day, DateType, Holiday, Mazaya, UserId, IP, out Error);
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
        #region DeleteMonasebat
        public string DeleteMonasebat(byte Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1281, UserId, OrganId))
                        return new BL_Monasebat().Delete(Id, UserId, out Error);
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

        //MonasebatType
        #region GetMonasebatTypeWithFilter
        public List<OBJ_MonasebatType> GetMonasebatTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Monasebat().SelectMonasebatType(FieldName, FilterValue, Top);
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
        
        //MonasebatHeader
        #region GetMonasebatHeaderDetail
        public OBJ_MonasebatHeader GetMonasebatHeaderDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MonasebatHeader().Detail(Id, out Error);
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
        #region GetMonasebatHeaderWithFilter
        public List<OBJ_MonasebatHeader> GetMonasebatHeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MonasebatHeader().Select(FieldName, FilterValue, Top);
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
        #region InsertMonasebatHeader
        public string InsertMonasebatHeader(int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1263, UserId, OrganId))
                        return new BL_MonasebatHeader().Insert(ActiveDate, UserId,IP, out Error);
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
        #region UpdateMonasebatHeader
        public string UpdateMonasebatHeader(int Id, int? DeactiveDate,bool Active, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1264, UserId, OrganId))
                        return new BL_MonasebatHeader().Update(Id, DeactiveDate, Active, UserId, IP, out Error);
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
        #region DeleteMonasebatHeader
        public string DeleteMonasebatHeader(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1265, UserId, OrganId))
                        return new BL_MonasebatHeader().Delete(Id, UserId, out Error);
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
        #region CopyMonasebatHeader
        public string CopyMonasebatHeader(int HeaderId,int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1263, UserId, OrganId))
                        return new BL_MonasebatHeader().Copy(HeaderId,ActiveDate, UserId, IP, out Error);
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

        //MonasebatMablagh
        #region GetMonasebatMablaghDetail
        public OBJ_MonasebatMablagh GetMonasebatMablaghDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MonasebatMablagh().Detail(Id, out Error);
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
        #region GetMonasebatMablaghWithFilter
        public List<OBJ_MonasebatMablagh> GetMonasebatMablaghWithFilter(string FieldName, string FilterValue,string FilterValue2,string FilterValue3, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MonasebatMablagh().Select(FieldName, FilterValue, FilterValue2, FilterValue3,Top);
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
        #region InsertMonasebatMablagh
        public string InsertMonasebatMablagh(int HeaderId, byte MonasebatId, int Mablagh, byte TypeNesbatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1263, UserId, OrganId))
                        return new BL_MonasebatMablagh().Insert(HeaderId,MonasebatId,Mablagh,TypeNesbatId, UserId, IP, out Error);
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
        #region UpdateMonasebatMablagh
        public string UpdateMonasebatMablagh(int Id, int HeaderId, byte MonasebatId, int Mablagh, byte TypeNesbatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1264, UserId, OrganId))
                        return new BL_MonasebatMablagh().Update(Id, HeaderId, MonasebatId,Mablagh,TypeNesbatId, UserId, IP, out Error);
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
        #region DeleteMonasebatMablagh
        public string DeleteMonasebatMablagh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1265, UserId, OrganId))
                        return new BL_MonasebatMablagh().Delete(Id, UserId, out Error);
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

        //MonasebatTarikh
        #region GetMonasebatTarikhDetail
        public OBJ_MonasebatTarikh GetMonasebatTarikhDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MonasebatTarikh().Detail(Id, out Error);
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
        #region GetMonasebatTarikhWithFilter
        public List<OBJ_MonasebatTarikh> GetMonasebatTarikhWithFilter(string FieldName, string FilterValue,string FilterValue1, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MonasebatTarikh().Select(FieldName, FilterValue,FilterValue1, FilterValue2, FilterValue3, Top);
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
        #region InsertMonasebatTarikh
        public string InsertMonasebatTarikh(short Year,byte Month,byte Day, byte MonasebatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1267, UserId, OrganId))
                        return new BL_MonasebatTarikh().Insert(Year, Month, Day,MonasebatId, UserId, IP, out Error);
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
        #region UpdateMonasebatTarikh
        public string UpdateMonasebatTarikh(int Id, short Year,byte Month,byte Day, byte MonasebatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1267, UserId, OrganId))
                        return new BL_MonasebatTarikh().Update(Id, Year,Month,Day, MonasebatId, UserId, IP, out Error);
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
        #region DeleteMonasebatTarikh
        public string DeleteMonasebatTarikh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1267, UserId, OrganId))
                        return new BL_MonasebatTarikh().Delete(Id, UserId, out Error);
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

        //ListNoMaliyat_BimePersonal
        #region ListNoMaliyat_BimePersonal
        public List<OBJ_ListNoMaliyat_BimePersonal> ListNoMaliyat_BimePersonal(string FieldName,int PersonelId, short sal, byte mah, byte nobat, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ListNoMaliyat_BimePersonal().Select(FieldName,PersonelId, sal, mah, nobat, OrganId);
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

         //BudgetPayHeader
        #region GetBudgetPayHeaderDetail
        public OBJ_BudgetPayHeader GetBudgetPayHeaderDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_BudgetPayHeader().Detail(Id, out Error);
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
        #region GetBudgetPayHeaderWithFilter
        public List<OBJ_BudgetPayHeader> GetBudgetPayHeaderWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_BudgetPayHeader().Select(FieldName, FilterValue,FilterValue2, Top);
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
        #region InsertBudgetPayHeader
        public string InsertBudgetPayHeader(int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, string fldIP, string fldDesc, string fldTypeEstekhdamId, string UserName, string Password, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1330, UserId, OrganId))
                        return new BL_BudgetPayHeader().Insert(fldFiscalYearId, fldItemsHoghughiId, fldParametrId, fldKosouratId,fldBudgetCode, UserId, fldIP, fldDesc, fldTypeEstekhdamId, out Error);
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
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, fldIP, UserId);
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
        #region UpdateBudgetPayHeader
        public string UpdateBudgetPayHeader(int Id, int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, string fldIP, string fldDesc, string fldTypeEstekhdamId, string UserName, string Password, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1331, UserId, OrganId))
                        return new BL_BudgetPayHeader().Update(Id, fldFiscalYearId, fldItemsHoghughiId, fldParametrId, fldKosouratId,fldBudgetCode, UserId, fldIP, fldDesc, fldTypeEstekhdamId, out Error);
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
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, fldIP, UserId);
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
        #region DeleteBudgetPayHeader
        public string DeleteBudgetPayHeader(string FieldName, int ItemId, int FiscalYearId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1332, UserId, OrganId))
                        return new BL_BudgetPayHeader().Delete(FieldName,ItemId,FiscalYearId, UserId, out Error);
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

        //BudgetPayDetail
        #region GetBudgetPayDetailDetail
        public OBJ_BudgetPayDetail GetBudgetPayDetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_BudgetPayDetail().Detail(Id, out Error);
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
        #region GetBudgetPayDetailWithFilter
        public List<OBJ_BudgetPayDetail> GetBudgetPayDetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_BudgetPayDetail().Select(FieldName, FilterValue, Top);
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
        #region InsertBudgetPayDetail
        public string InsertBudgetPayDetail(int fldHeaderId, string TypeEstekhdamId, string UserName, string Password, int OrganId, string IP,  out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1330, UserId, OrganId))
                        return new BL_BudgetPayDetail().Insert(fldHeaderId, TypeEstekhdamId, UserId, out Error);
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
        #region UpdateBudgetPayDetail
        public string UpdateBudgetPayDetail(int Id, int fldHeaderId, int fldTypeEstekhdamId, int fldTypeBimeId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1331, UserId, OrganId))
                        return new BL_BudgetPayDetail().Update(Id, fldHeaderId, fldTypeEstekhdamId, fldTypeBimeId, out Error);
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
        #region DeleteBudgetPayDetail
        public string DeleteBudgetPayDetail(int HeaderId, int TypeEstekhdamId, int TypeBimeId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1332, UserId, OrganId))
                        return new BL_BudgetPayDetail().Delete(HeaderId,TypeEstekhdamId,TypeBimeId, UserId, out Error);
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

        //CalcHeader
        #region GetCalcHeaderDetail
        public OBJ_CalcHeader GetCalcHeaderDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CalcHeader().Detail(Id, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
        }
        #endregion
        #region GetCalcHeaderWithFilter
        public List<OBJ_CalcHeader> GetCalcHeaderWithFilter(string FieldName, string FilterValue, short Year, byte Month, int NobatPardakhtId,
            int Top,string UserName, string Password,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_CalcHeader().Select(FieldName, FilterValue, Year, Month, NobatPardakhtId, OrganId,UserId, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
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
        #region InsertCalcHeader
        public int InsertCalcHeader(short Year, byte Month, int NobatPardakhtId, byte Status, string PersonalId, byte CalcType, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_CalcHeader().Insert(Year, Month, NobatPardakhtId, Status, PersonalId, CalcType, OrganId, UserId,IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
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
        #region DeleteCalcHeader
        public string DeleteCalcHeader(short Year, byte Month, int NobatPardakhtId, string TypeEstekhdam, string CostCenterId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CalcHeader().Delete(Year,Month,NobatPardakhtId,TypeEstekhdam,CostCenterId,OrganId, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return "خطا";
            }
        }
        #endregion

        //MoteghayerhayeHoghoghiItems
        #region GetMoteghayerhayeHoghoghiItemsDetail
        public OBJ_MoteghayerhayeHoghoghiItems GetMoteghayerhayeHoghoghiItemsDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MoteghayerhayeHoghoghiItems().Detail(Id, out Error);
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
        #region GetMoteghayerhayeHoghoghiItemsWithFilter
        public List<OBJ_MoteghayerhayeHoghoghiItems> GetMoteghayerhayeHoghoghiItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MoteghayerhayeHoghoghiItems().Select(FieldName, FilterValue, Top);
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
        #region InsertMoteghayerhayeHoghoghiItems
        public string InsertMoteghayerhayeHoghoghiItems(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType,  string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(298, UserId, OrganId))
                    return new BL_MoteghayerhayeHoghoghiItems().Insert(MoteghayerhayeHoghoghiId, ItemEstekhdamId, fldType, UserId, out Error);
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
        #region UpdateMoteghayerhayeHoghoghiItems
        public string UpdateMoteghayerhayeHoghoghiItems(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(299, UserId, OrganId))
                    return new BL_MoteghayerhayeHoghoghiItems().Update(MoteghayerhayeHoghoghiId, ItemEstekhdamId,fldType, UserId, out Error);
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
        #region DeleteMoteghayerhayeHoghoghiItems
        public string DeleteMoteghayerhayeHoghoghiItems( int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(300, UserId, OrganId))
                    return new BL_MoteghayerhayeHoghoghiItems().Delete(Id, UserId, out Error);
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
        //ItemMablgh_Header
        #region GetItemMablgh_HeaderDetail
        public OBJ_ItemMablgh_Header GetItemMablgh_HeaderDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ItemMablgh_Header().Detail(Id, out Error);
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
        #region GetItemMablgh_HeaderWithFilter
        public List<OBJ_ItemMablgh_Header> GetItemMablgh_HeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ItemMablgh_Header().Select(FieldName, FilterValue, Top);
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
        #region InsertItemMablgh_Header
        public string InsertItemMablgh_Header(int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1337, UserId, OrganId))
                        return new BL_ItemMablgh_Header().Insert(ActiveDate, UserId, IP, out Error);
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
        #region UpdateItemMablgh_Header
        public string UpdateItemMablgh_Header(int Id, int? DeactiveDate, bool Active, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1338, UserId, OrganId))
                        return new BL_ItemMablgh_Header().Update(Id, DeactiveDate, Active, UserId, IP, out Error);
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
        #region DeleteItemMablgh_Header
        public string DeleteItemMablgh_Header(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1339, UserId, OrganId))
                        return new BL_ItemMablgh_Header().Delete(Id, UserId, out Error);
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
        #region CopyItemMablgh_Header
        public string CopyItemMablgh_Header(int HeaderId, int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1337, UserId, OrganId))
                        return new BL_ItemMablgh_Header().Copy(HeaderId, ActiveDate, UserId, IP, out Error);
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

        //ItemsMablgh
        #region GetItemsMablghDetail
        public OBJ_ItemsMablgh GetItemsMablghDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ItemsMablgh().Detail(Id, out Error);
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
        #region GetItemsMablghWithFilter
        public List<OBJ_ItemsMablgh> GetItemsMablghWithFilter(string FieldName, string FilterValue, string FilterValue2,  int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ItemsMablgh().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertItemsMablgh
        public string InsertItemsMablgh(int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1337, UserId, OrganId))
                        return new BL_ItemsMablgh().Insert(HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild, Count, UserId,  out Error);
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
        #region UpdateItemsMablgh
        public string UpdateItemsMablgh(int Id, int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1338, UserId, OrganId))
                        return new BL_ItemsMablgh().Update(Id, HeaderId, ItemsHoghughiId, Mablagh, PercentW_H, PercentChild, Count, UserId,  out Error);
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
        #region DeleteItemsMablgh
        public string DeleteItemsMablgh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1339, UserId, OrganId))
                        return new BL_ItemsMablgh().Delete(Id, UserId, out Error);
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
