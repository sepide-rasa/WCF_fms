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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Pay" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Pay.svc or Pay.svc.cs at the Solution Explorer and start debugging.
    public class Comon_PayService : IComon_PayService
    {
        // ComputationFormula      
        #region GetComputationFormulaDetail
        public OBJ_ComputationFormula GetComputationFormulaDetail(int ComputationFormulaId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ComputationFormula().Detail(ComputationFormulaId, OrganId, out Error);
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
        #region GetComputationFormulaWithFilter
        public List<OBJ_ComputationFormula> GetComputationFormulaWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ComputationFormula().Select(FieldName, FilterValue, FilterValue2, FilterValue3, OrganId, Top);
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
        #region InsertComputationFormula
        public string InsertComputationFormula(bool? Type, string Formule, int? fldOrganId, string Library, string AzTarikh, int id, string fieldname, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    int AppId = 0;
                    if (fieldname == "" && Type == true)
                        AppId = 478;
                    if (fieldname == "" && Type == false)
                        AppId = 529;
                    if (fieldname == "FormulOmoomi")
                        AppId = 530;
                    if (fieldname == "FormulSabet")
                        AppId = 531;
                    if (fieldname == "formulMohasebat")
                        AppId = 483;
                    if (fieldname == "FormulKoli")
                        AppId = 532;
                    if (fieldname == "FormulDarmadGroup")
                        AppId = 742;
                    if (fieldname == "FormulArchiveProperties")
                        AppId = 816;
                    if (new BL().BLPermission(AppId, UserId, OrganId))
                        return new BL_ComputationFormula().Insert(Type, Formule, fldOrganId, Library, AzTarikh, id, fieldname, UserId, Desc, IP, out Error);
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
        #region UpdateComputationFormula
        public string UpdateComputationFormula(string FieldName, int Id, bool? Type, string Formule, int? fldOrganId, string Library, string AzTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    int AppId = 0;
                    if (FieldName == "" && Type == true)
                        AppId = 478;
                    if (FieldName == "" && Type == false)
                        AppId = 529;
                    if (FieldName == "FormulOmoomi")
                        AppId = 530;
                    if (FieldName == "FormulSabet")
                        AppId = 531;
                    if (FieldName == "formulMohasebat")
                        AppId = 483;
                    if (FieldName == "FormulKoli")
                        AppId = 532;
                    if (FieldName == "FormulDarmadGroup")
                        AppId = 742;
                    if (FieldName == "FormulArchiveProperties")
                        AppId = 816;
                    if (new BL().BLPermission(AppId, UserId, OrganId))
                        return new BL_ComputationFormula().Update(FieldName, Id, Type, Formule, fldOrganId, Library, AzTarikh, UserId, Desc, IP, out Error);
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
        #region DeleteComputationFormula
        public string DeleteComputationFormula(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    int AppId = 0;
                    DL_ComputationFormula m = new DL_ComputationFormula();
                    var q = m.Detail(id, 0);
                    if (q != null)
                    {
                        if (q.fldType == true)
                            AppId = 533;
                        else if (q.fldType == false)
                            AppId = 534;
                    }
                    if (new BL().BLPermission(AppId, UserId, OrganId))
                        return new BL_ComputationFormula().Delete(id, UserId, IP, out Error);
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

        //MaxPersonalEstekhdamType
        #region GetMaxPersonalEstekhdamTypeWithFilter
        public List<OBJ_MaxPersonalEstekhdamType> GetMaxPersonalEstekhdamTypeWithFilter(string fieldName, int PersonalId, string tarikh, string IP, out ClsError Error)
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
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return null;
            }
                
                
        }
        #endregion

        //Items_Estekhdam
        #region GetItems_EstekhdamWithFilter
        public List<OBJ_Items_Estekhdam> GetItems_EstekhdamWithFilter(string FieldName, string NoeEstekhdam, int HokmId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Items_Estekhdam().Select(FieldName, NoeEstekhdam, HokmId, Top);
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
        #region UpdateItems_Estekhdam
        public string UpdateItems_Estekhdam(int Id, string Title, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(341, UserId, OrganId))
                    return new BL_Items_Estekhdam().Update(Id, Title,UserId, IP, out Error);
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

        //TypeEstekhdam
        #region GetTypeEstekhdamWithFilter
        public List<OBJ_TypeEstekhdam> GetTypeEstekhdamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeEstekhdam().Select(FieldName, FilterValue, Top);
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

        //DiffDayMahSal
        #region GetDiffDayMahSalWithFilter
        public List<OBJ_DiffDayMahSal> GetDiffDayMahSalWithFilter(int rozCount, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DiffDayMahSal().Select(rozCount);
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

        //DiffDayMahSalNumber
        #region GetDiffDayMahSalNumberWithFilter
        public List<OBJ_DiffDayMahSal> GetDiffDayMahSalNumberWithFilter(int rozCount,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DiffDayMahSal().DiffDayMahSalNumber(rozCount);
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

        //TypeEstekhdam_Formul
        #region GetTypeEstekhdam_FormulDetail
        public OBJ_TypeEstekhdam_Formul GetTypeEstekhdam_FormulDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TypeEstekhdam_Formul().Detail(Id, out Error);
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
        #region GetTypeEstekhdam_FormulWithFilter
        public List<OBJ_TypeEstekhdam_Formul> GetTypeEstekhdam_FormulWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeEstekhdam_Formul().Select(FieldName, FilterValue, Top);
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

        //AnvaEstekhdam
        #region GetAnvaEstekhdamDetail
        public OBJ_AnvaEstekhdam GetAnvaEstekhdamDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_AnvaEstekhdam().Detail(Id, out Error);
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
        #region GetAnvaEstekhdamWithFilter
        public List<OBJ_AnvaEstekhdam> GetAnvaEstekhdamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AnvaEstekhdam().Select(FieldName, FilterValue, Top);
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
        #region InsertAnvaEstekhdam
        public string InsertAnvaEstekhdam(string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(49, UserId, OrganId))
                        return new BL_AnvaEstekhdam().Insert(Title, NoeEstekhdamId, fldPatternNoeEstekhdamId,fldTypeEstekhdamFormul, Desc, UserId, IP, out Error);
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
        public string UpdateAnvaEstekhdam(int Id, string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(50, UserId, OrganId))
                        return new BL_AnvaEstekhdam().Update(Id, Title, NoeEstekhdamId, fldPatternNoeEstekhdamId,fldTypeEstekhdamFormul, Desc, UserId, IP, out  Error);
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
        #region DeleteAnvaEstekhdam
        public string DeleteAnvaEstekhdam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(51, UserId, OrganId))
                    return new BL_AnvaEstekhdam().Delete(Id, UserId, IP, out Error);
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


        //ItemsHoghughi
        #region GetItemsHoghughiWithFilter
        public List<OBJ_ItemsHoghughi> GetItemsHoghughiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ItemsHoghughi().Select(FieldName, FilterValue, Top);
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
        #region UpdateItemsHoghughi
        public string UpdateItemsHoghughi(int Id, byte TypeHesabId, byte Mostamar, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1269, UserId, OrganId))
                        return new BL_ItemsHoghughi().Update(Id, TypeHesabId, Mostamar, UserId, out  Error);
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

        //TypeBime
        #region GetTypeBimeWithFilter
        public List<OBJ_TypeBime> GetTypeBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeBime().Select(FieldName, FilterValue, Top);
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

        //ItemsEstekhdam_FiscalTitle
        #region GetItemsEstekhdam_FiscalTitleFilter
        public List<OBJ_ItemsEstekhdam_FiscalTitle> GetItemsEstekhdam_FiscalTitleWithFilter(string FieldName, string NoeEstekhdam, int FiscalHeaderId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_ItemsEstekhdam_FiscalTitle().Select(FieldName, NoeEstekhdam, FiscalHeaderId, Top);
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

        //Status
        #region GetStatusWithFilter
        public List<OBJ_Status> GetStatusWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Status().Select(FieldName, FilterValue, Top);
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

        //PersonalStatus
        #region GetPersonalStatusDetail
        public OBJ_PersonalStatus GetPersonalStatusDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_PersonalStatus().Detail(Id, out Error);
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
        public string InsertPersonalStatus(int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(49, UserId))
                    return new BL_PersonalStatus().Insert(StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, Desc, UserId, IP, out Error);
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
        #region UpdatePersonalStatus
        public string UpdatePersonalStatus(int Id,int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(50, UserId))
                    return new BL_PersonalStatus().Update(Id, StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, Desc, UserId, IP, out  Error);
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
        public string DeletePersonalStatus(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(51, UserId))
                    return new BL_PersonalStatus().Delete(Id, UserId, IP, out Error);
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
    }
}
