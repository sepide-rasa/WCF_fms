using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_FMS.BLL.Common;
using WCF_FMS.BLL;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;
using WCF_FMS.BLL.Daramad;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.BLL.Contract;
using WCF_FMS.TOL.Contract;
using WCF_FMS.BLL.PayRoll;


namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CommonService : ICommonService
    {
        #region Permission
        public bool Permission(int AppId, int OrganId, string Username, string Password, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                return new WCF_FMS.BLL.BL().BLPermission(AppId, UserId, OrganId);
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return false;
            }
        }
          #endregion
        #region HashPass
        public string HashPass(string Password)
        {
            return authorize.GenerateHash(Password);
        }
        #endregion

        // Employee
        #region GetEmployeeDetail
        public OBJ_Employee GetEmployeeDetail(int EmployeeId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Employee().Detail(EmployeeId, out Error);
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
        #region GetEmployeeWithFilter
        public List<OBJ_Employee> GetEmployeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                if (new BL().BLPermission(11, UserId, OrganId) && new BL().BLPermission(413, UserId, OrganId))
                    return new BL_Employee().Select(FieldName, FilterValue,"1,0", Top);
                else if (new BL().BLPermission(413, UserId, OrganId))
                    return new BL_Employee().Select(FieldName, FilterValue, "0", Top);
                else if (new BL().BLPermission(11, UserId, OrganId))
                    return new BL_Employee().Select(FieldName, FilterValue, "1", Top);
                else
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    return new BL_Employee().Select("fldId", "0", "", Top); ;
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
        #region InsertEmployee
        public int InsertEmployee(string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (fldStatus==true)
                    {
                        APPId = 12;
                    }
                    else
                    {
                        APPId = 416;
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_Employee().Insert(fldName, fldFamily, fldCodemeli, fldStatus,TypeShakhs, UserId, Desc, out Error);
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
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region UpdateEmployee
        public string UpdateEmployee(int fldId, string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    DL_Employee Employee = new DL_Employee();
                    var q = Employee.Detail(fldId);
                    int APPId = 0;
                    if (q.fldStatus)
                    {
                        APPId = 13;
                    }
                    else
                    {
                        APPId = 414; 
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_Employee().Update(fldId, fldName, fldFamily, fldCodemeli, fldStatus, TypeShakhs, UserId, Desc, out Error);

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
        #region DeleteEmployee
        public string DeleteEmployee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    DL_Employee Employee = new DL_Employee();
                    var q = Employee.Detail(id);
                    int APPId = 0;
                    if (q.fldStatus)
                    {
                        APPId = 14;
                    }
                    else
                    {
                        APPId = 415;
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                        return new BL_Employee().Delete(id, UserId, out Error);
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
  
        // State
        #region GetStateDetail
        public OBJ_State GetStateDetail(int StateId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_State().Detail(StateId, out Error);
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
        #region GetStateWithFilter
        public List<OBJ_State> GetStateWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_State().Select(FieldName, FilterValue, Top);
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
        #region InsertState
        public string InsertState(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(20, UserId, OrganId))
                        return new BL_State().Insert(fldName, UserId, Desc, out Error);
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
        #region UpdateState
        public string UpdateState(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(21, UserId, OrganId))
                        return new BL_State().Update(fldId, fldName, UserId, Desc, out Error);
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
        #region DeleteState
        public string DeleteState(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(22, UserId, OrganId))
                        return new BL_State().Delete(id, UserId, out Error);
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

        //Raste
        #region GetRasteWithFilter
        public List<OBJ_Raste> GetRasteWithFilter(string FieldName, string FilterValue, int h,string Username, string Password, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {

                return new BL_Raste().Select( FieldName,  FilterValue,  h); 

            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }

        #endregion

        // City
        #region GetCityDetail
        public OBJ_City GetCityDetail(int CityId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_City().Detail(CityId, out Error);
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
        #region GetCityWithFilter
        public List<OBJ_City> GetCityWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_City().Select(FieldName, FilterValue, Top);
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
        #region InsertCity
        public string InsertCity(string fldName, int fldStateId, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(16, UserId, OrganId))
                        return new BL_City().Insert(fldName, fldStateId,fldLatitude,fldLongitude, UserId, Desc, out Error);
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
        #region UpdateCity
        public string UpdateCity(int fldId, string fldName, int fldStateId, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(17, UserId, OrganId))
                        return new BL_City().Update(fldId, fldName, fldStateId,fldLatitude,fldLongitude, UserId, Desc, out Error);
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
        #region DeleteCity
        public string DeleteCity(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(18, UserId, OrganId))
                        return new BL_City().Delete(id, UserId, out Error);
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

        // Organization
        #region GetOrganizationDetail
        public OBJ_Organization GetOrganizationDetail(int OrganizationId, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();

            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Organization().Detail(OrganizationId,UserId, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region GetOrganizationWithFilter
        public List<OBJ_Organization> GetOrganizationWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Organization().Select(FieldName, FilterValue, UserId, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region InsertOrganization
        public string InsertOrganization(string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(24, UserId, OrganId))
                        return new BL_Organization().Insert(fldName, fldPId, fldArm, Pasvand, fldCityId, fldCodAnformatic, fldCodKhedmat, AshkhaseHoghoghiId, UserId, Desc, out Error);
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
        #region UpdateOrganization
        public string UpdateOrganization(int fldId, string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldCityId, int fldFileId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(25, UserId, OrganId))
                        return new BL_Organization().Update(fldId, fldName, fldPId, fldArm, Pasvand, fldFileId, fldCityId, fldCodAnformatic, fldCodKhedmat, AshkhaseHoghoghiId, UserId, Desc, out Error);
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
        #region DeleteOrganization
        public string DeleteOrganization(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(26, UserId, OrganId))
                        return new BL_Organization().Delete(id, UserId, out Error);
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

        // ChartOrgan
        #region GetChartOrganDetail
        public OBJ_ChartOrgan GetChartOrganDetail(int ChartOrganId, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();

            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_ChartOrgan().Detail(ChartOrganId,UserId, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region GetChartOrganWithFilter
        public List<OBJ_ChartOrgan> GetChartOrganWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_ChartOrgan().Select(FieldName, FilterValue, UserId, Top);
                }
                catch (Exception x)
                {
                  Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region InsertChartOrgan
        public string InsertChartOrgan(string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(28, UserId, OrganId))
                        return new BL_ChartOrgan().Insert(fldTitle, fldPId, fldOrganId, fldNoeVahed, UserId, Desc, out Error);
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
        #region UpdateChartOrgan
        public string UpdateChartOrgan(int fldId, string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(29, UserId, OrganId))
                        return new BL_ChartOrgan().Update(fldId, fldTitle, fldPId, fldOrganId, fldNoeVahed, UserId, Desc, out Error);
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
        #region DeleteChartOrgan
        public string DeleteChartOrgan(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(30, UserId, OrganId))
                        return new BL_ChartOrgan().Delete(id, UserId, out Error);
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

        //User
        #region GetUserDetail
        public OBJ_User GetUserDetail(int User_Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_User().Detail(User_Id, out Error);
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
        #region GetUserWithFilter
        public List<OBJ_User> GetUserWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_User().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertUser
        public int InsertUser(int EmployeeId, string fldUserName, string fldPassword, bool State, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(32, UserId, OrganId))
                        return new BL_User().Insert(EmployeeId, fldUserName, fldPassword, State, UserId, Desc, IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
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
        #region UpdateUser
        public string UpdateUser(int User_Id, int EmployeeId, string fldUserName, bool State, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(33, UserId, OrganId))
                        return new BL_User().Update(User_Id, EmployeeId, fldUserName, State, UserId, Desc, IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteUser
        public string DeleteUser(int User_Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(34, UserId, OrganId))
                        return new BL_User().Delete(User_Id, UserId, IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UserPassUpdate
        public string UserPassUpdate(int User_Id, string Pass, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(64, UserId, OrganId))
                        return new BL_User().ResetPass(User_Id, Pass, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region ChangePass
        public string ChangePass(string Password, string UserName, string NewPass, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_User().ChangePass(UserId, Password, UserName, NewPass, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region ExistUser
        public string ExistUser(string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_authorize().ExistUser(UserName, Password, IP, out Error);
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
        #region SelectUserByUserId
        public List<OBJ_User> SelectUserByUserId(string FieldName, string FilterValue, int Top, string UserName, string Password, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_User().SelectUserByUserId(FieldName, FilterValue, UserId, Top);
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region UpdateActiveUser
        public string UpdateActiveUser(int Id, bool Active_Deactive, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_User().UpdateActiveUser(Id, Active_Deactive, out Error);
            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                // Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return "خطا";
            }
        }
        #endregion

        //Module
        #region GetModuleDetail
        public OBJ_Module GetModuleDetail(int ModuleId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Module().Detail(ModuleId,UserId, out Error);
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
        #region GetModuleWithFilter
        public List<OBJ_Module> GetModuleWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Module().Select(FieldName, FilterValue, UserId, Top);
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
        #region InsertModule
        public string InsertModule(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(330, UserId, OrganId))
                        return new BL_Module().Insert(Title, UserId, Desc, IP, out Error);
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
        #region UpdateModule
        public string UpdateModule(int ModuleId, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(331, UserId, OrganId))
                        return new BL_Module().Update(ModuleId, Title,UserId,Desc, IP, out Error);
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
        #region DeleteModule
        public string DeleteModule(int ModuleId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(332, UserId, OrganId))
                        return new BL_Module().Delete(ModuleId, UserId, IP, out Error);
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

        //Module_Organ
        #region GetModule_OrganDetail
        public OBJ_Module_Organ GetModule_OrganDetail(int Module_OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Module_Organ().Detail(Module_OrganId, out Error);
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
        #region GetModule_OrganWithFilter
        public List<OBJ_Module_Organ> GetModule_OrganWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                if (FieldName == "fldUserId")
                    FilterValue = UserId.ToString();
                try
                {
                    return new BL_Module_Organ().Select(FieldName, FilterValue, UserId, Top);
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
        #region InsertModule_Organ
        public string InsertModule_Organ(int fldOrganId, int ModuleId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(334, UserId, OrganId))
                        return new BL_Module_Organ().Insert(fldOrganId,ModuleId, UserId, Desc, IP, out Error);
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
        #region UpdateModule_Organ
        public string UpdateModule_Organ(int Id, int fldOrganId, int ModuleId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(335, UserId, OrganId))
                        return new BL_Module_Organ().Update(Id, fldOrganId, ModuleId, UserId, Desc, IP, out Error);
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
        #region DeleteModule_Organ
        public string DeleteModule_Organ(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(16, UserId))
                        return new BL_Module_Organ().Delete(Id, UserId, IP, out Error);
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

        //Masoulin
        #region GetMasoulinDetail
        public OBJ_Masoulin GetMasoulinDetail(int MasoulinId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Masoulin().Detail(MasoulinId, OrganId, out Error);
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
        #region GetMasoulinWithFilter
        public List<OBJ_Masoulin> GetMasoulinWithFilter(string FieldName, string FilterValue, int OrganId, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Masoulin().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertMasoulin
        public string InsertMasoulin(int Module_OrganId, string TarikhEjra, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(36, UserId, OrganId))
                        return new BL_Masoulin().Insert(TarikhEjra, Module_OrganId, UserId, Desc, IP, out Error);
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
        #region UpdateMasoulin
        public string UpdateMasoulin(int MasoulinId, string TarikhEjra, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(37, UserId, OrganId))
                        return new BL_Masoulin().Update(MasoulinId, TarikhEjra, Module_OrganId, UserId, Desc, IP, out Error);
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
        #region GetMasuolin_ZirList
        public List<OBJ_Masuolin_ZirList> GetMasuolin_ZirList(int headerId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Masoulin().SelectMasuolin_ZirList(headerId);
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

        //Masoulin_Detail
        #region GetMasoulin_DetailDetail
        public OBJ_Masoulin_Detail GetMasoulin_DetailDetail(int Masoulin_DetailId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Masoulin_Detail().Detail(Masoulin_DetailId, out Error);
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
        #region GetMasoulin_DetailWithFilter
        public List<OBJ_Masoulin_Detail> GetMasoulin_DetailWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Masoulin_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertMasoulin_Detail
        public string InsertMasoulin_Detail(int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(41, UserId, OrganId))
                        return new BL_Masoulin_Detail().Insert(EmployeeId, OrganPostId, MasoulinId, UserId, Desc, IP, out Error);
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
        #region UpdateMasoulin_Detail
        public string UpdateMasoulin_Detail(int Msoulin_DetailId, int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(65, UserId, OrganId))
                        return new BL_Masoulin_Detail().Update(Msoulin_DetailId, EmployeeId, OrganPostId, MasoulinId, OrderId, UserId, Desc, IP, out Error);
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
        #region DeleteMasoulin_Detail
        public string DeleteMasoulin_Detail(int Id, string FieldName, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(66, UserId, OrganId))
                        return new BL_Masoulin_Detail().Delete(FieldName, Id, UserId, IP, out Error);
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
        #region GetMasoulin_DetailList
        public List<OBJ_Masoulin_DetailList> GetMasoulin_DetailList(int HeaderId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Masoulin_Detail().Masoulin_DetailList(HeaderId);
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

        //Permission
        #region GetPermissionWithFilter
        public List<OBJ_Permission> GetPermissionWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, int OrganId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Permission().Select(FieldName, FilterValue, UserId, OrganId, Top, out Error);
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
        #region InsertPermission
        public string InsertPermission(int UserGroup_ModuleOrganID, int ApplicationPartId, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Permission().Insert(UserGroup_ModuleOrganID, ApplicationPartId, UserId, Desc, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeletePermission
        public string DeletePermission(int UserGroupId, int ModuleId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Permission().Delete(UserGroupId, ModuleId, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region CopyPermission
        public string CopyPermission(int por, int khali, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Permission().CopyPermission(por, khali, UserId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteChildUserGroupPermission
        public string DeleteChildUserGroupPermission(int UserGroup_ModuleOrganId, string appId, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_Permission().DeleteChildUserGroupPermission(UserGroup_ModuleOrganId, appId, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    //Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion


        //UserGroup
        #region GetUserGroupDetail
        public OBJ_UserGroup GetUserGroupDetail(int UserGroupId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_UserGroup().Detail(UserGroupId, out Error);
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
        #region GetUserGroupWithFilter
        public List<OBJ_UserGroup> GetUserGroupWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_UserGroup().Select(FieldName, FilterValue, UserId, Top);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region InsertUserGroup
        public int InsertUserGroup(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(72, UserId, OrganId))
                        return new BL_UserGroup().Insert(Title, UserId, Desc, IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
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
        #region UpdateUserGroup
        public string UpdateUserGroup(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(73, UserId, OrganId))
                        return new BL_UserGroup().Update(Id, Title, UserId, Desc, IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteUserGroup
        public string DeleteUserGroup(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(74, UserId, OrganId))
                        return new BL_UserGroup().Delete(Id, UserId,IP, out Error);
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
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //User_Group
        #region GetUser_GroupDetail
        public OBJ_User_Group GetUser_GroupDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_User_Group().Detail(Id, out Error);
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
        #region GetUser_GroupWithFilter
        public List<OBJ_User_Group> GetUser_GroupWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_User_Group().Select(FieldName, FilterValue, Top);
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
        #region InsertUser_Group
        public string InsertUser_Group(int UserGroupId, int UserSelectId, bool fldGrant, bool fldWithGrant, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_User_Group().Insert(UserGroupId, UserSelectId, UserId, fldGrant, fldWithGrant, Desc, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region UpdateUser_Group
        public string UpdateUser_Group(int Id, int UserGroupId, int UserSelectId, bool fldGrant, bool fldWithGrant, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_User_Group().Update(Id, UserGroupId, UserSelectId, UserId, fldGrant, fldWithGrant, Desc, IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion
        #region DeleteUser_Group
        public string DeleteUser_Group(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_User_Group().Delete(Id, UserId,IP, out Error);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        // ApplictionPart
        #region GetApplictionPartWithFilter
        public List<OBJ_ApplictionPart> GetApplictionPartWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string Username, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_ApplictionPart().Select(FieldName, FilterValue, FilterValue1, UserId, Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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

        // ZirListHa
        #region GetZirListHaDetail
        public OBJ_ZirListHa GetZirListHaDetail(int ZirListHaId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ZirListHa().Detail(ZirListHaId, out Error);
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
        #region GetZirListHaWithFilter
        public List<OBJ_ZirListHa> GetZirListHaWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ZirListHa().Select(FieldName, FilterValue, Top);
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
        #region InsertZirListHa
        public string InsertZirListHa(int fldReportId, int fldMasuolin_DetailId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(39, UserId, OrganId))
                        return new BL_ZirListHa().Insert(fldReportId,fldMasuolin_DetailId, UserId, Desc, out Error);
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
        #region UpdateZirListHa
        public string UpdateZirListHa(int fldId, int fldReportId, int fldMasuolin_DetailId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(75, UserId, OrganId))
                        return new BL_ZirListHa().Update(fldId, fldReportId, fldMasuolin_DetailId, UserId, Desc, out Error);
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
        #region DeleteZirListHa
        public string DeleteZirListHa(string FieldName, int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(76, UserId, OrganId))
                    return new BL_ZirListHa().Delete(FieldName,id, UserId, out Error);
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

        // File
        #region GetFileWithFilter
        public List<OBJ_File> GetFileWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_File().Select(FieldName, FilterValue, Top);
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

        //GetDate
        #region GetDate
        public OBJ_GetDate GetDate(string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_GetDate().GetDate();
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

        //DigitalArchiveTreeStructure
        #region GetDigitalArchiveTreeStructureDetail
        public OBJ_DigitalArchiveTreeStructure GetDigitalArchiveTreeStructureDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_DigitalArchiveTreeStructure().Detail(Id, out Error);
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
        #region GetDigitalArchiveTreeStructureWithFilter
        public List<OBJ_DigitalArchiveTreeStructure> GetDigitalArchiveTreeStructureWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_DigitalArchiveTreeStructure().Select(FieldName, FilterValue, Top);
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
        #region InsertDigitalArchiveTreeStructure
        public string InsertDigitalArchiveTreeStructure(int? PID, int? ModuleId, string Title, bool AttachFile, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                   // if (new BL().BLPermission(78, UserId))فعلا دسترسی تعریف نشده
                    return new BL_DigitalArchiveTreeStructure().Insert(PID, ModuleId, Title, AttachFile,Desc,UserId, IP, out Error);
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
        #region UpdateDigitalArchiveTreeStructure
        public string UpdateDigitalArchiveTreeStructure(int Id, int? PID, int? ModuleId, string Title, bool AttachFile, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(79, UserId))فعلا دسترسی تعریف نشده
                    return new BL_DigitalArchiveTreeStructure().Update(Id,PID, ModuleId, Title, AttachFile, Desc, UserId, IP, out Error);
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
        #region DeleteDigitalArchiveTreeStructure
        public string DeleteDigitalArchiveTreeStructure(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(80, UserId))فعلا دسترسی تعریف نشده
                    return new BL_DigitalArchiveTreeStructure().Delete(Id, UserId, IP, out Error);
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

        //GetNameOrganForFormul
        #region GetNameOrganForFormul
        public List<OBJ_GetNameOrganForFormul> GetNameOrganForFormul(string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GetNameOrganForFormul().GetNameOrganForFormul();
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

        //OrganizationalPosts
        #region GetOrganizationalPostsDetail
        public OBJ_OrganizationalPosts GetOrganizationalPostsDetail(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_OrganizationalPosts().Detail(Id, UserId, out Error);
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
        #region GetOrganizationalPostsWithFilter
        public List<OBJ_OrganizationalPosts> GetOrganizationalPostsWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_OrganizationalPosts().Select(FieldName, FilterValue, UserId, Top);
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
        #region InsertOrganizationalPosts
        public string InsertOrganizationalPosts(string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(82, UserId, OrganId))
                    return new BL_OrganizationalPosts().Insert(fldTitle, fldOrgPostCode, fldChartOrganId, fldPId, UserId, Desc, out Error);
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
        #region UpdateOrganizationalPosts
        public string UpdateOrganizationalPosts(int Id, string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(83, UserId, OrganId))
                    return new BL_OrganizationalPosts().Update(Id, fldTitle, fldOrgPostCode, fldChartOrganId, fldPId, UserId, Desc, out Error);
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
        #region DeleteOrganizationalPosts
        public string DeleteOrganizationalPosts(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(84, UserId, OrganId))
                    return new BL_OrganizationalPosts().Delete(Id, UserId, out Error);
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

        //Bank
        #region GetBankDetail
        public OBJ_Bank GetBankDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Bank().Detail(Id, out Error);
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
        #region GetBankWithFilter
        public List<OBJ_Bank> GetBankWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Bank().Select(FieldName, FilterValue, Top);
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
        #region InsertBank
        public string InsertBank(string BankName, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (Fix == true)
                    {
                        APPId = 166;
                    }
                    else
                    {
                        APPId = 86;
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                    return new BL_Bank().Insert(BankName,File,Pasvand,CentralBankCode,InfinitiveBank,Fix, UserId, Desc, out Error);
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
        #region UpdateBank
        public string UpdateBank(int Id, string BankName, int FileId, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    int APPId = 0;
                    if (Fix == true)
                    {
                        APPId = 167;
                    }
                    else
                    {
                        APPId = 87;
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                    return new BL_Bank().Update(Id, BankName, FileId, File, Pasvand,CentralBankCode,InfinitiveBank,Fix, UserId, Desc, out Error);
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
        #region DeleteBank
        public string DeleteBank(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    DL_Bank m = new DL_Bank();
                   var q= m.Detail(Id);
                    int APPId = 0;
                    if (q.fldFix == true)
                    {
                        APPId = 168;
                    }
                    else
                    {
                        APPId = 88;
                    }
                    if (new BL().BLPermission(APPId, UserId, OrganId))
                    return new BL_Bank().Delete(Id, UserId, out Error);
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

        //rptDastresiKarbaran
        #region rptDastresiKarbaran
        public List<OBJ_RptDastresiKarbaran> GetrptDastresiKarbaranWithFilter(int? appId, int? userGroup_ModuleOrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_RptDasresiKarbaran().Select(appId,userGroup_ModuleOrganId);
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
        //SHobe
        #region GetSHobeDetail
        public OBJ_SHobe GetSHobeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_SHobe().Detail(Id, out Error);
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
        #region GetSHobeWithFilter
        public List<OBJ_SHobe> GetSHobeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_SHobe().Select(FieldName, FilterValue, Top);
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
        #region InsertSHobe
        public string InsertSHobe(int BankId, string Name, int CodeSHobe, string Address, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(90, UserId, OrganId))
                    return new BL_SHobe().Insert(BankId, Name, CodeSHobe, Address, UserId, Desc, out Error);
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
        #region UpdateSHobe
        public string UpdateSHobe(int Id, int BankId, string Name, int CodeSHobe, string Address, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(91, UserId, OrganId))
                    return new BL_SHobe().Update(Id, BankId, Name, CodeSHobe, Address, UserId, Desc, out Error);
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
        #region DeleteSHobe
        public string DeleteSHobe(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(92, UserId, OrganId))
                    return new BL_SHobe().Delete(Id, UserId, out Error);
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

        //Error
        #region GetErrorWithFilter
        public List<OBJ_Error> GetErrorWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Error().Select(FieldName, FilterValue, Top);
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
        #region InsertError
        public int InsertError(string Matn, System.DateTime Tarikh, string IP, string Desc, string UserName, string Password, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(90, UserId, OrganId))
                    return new BL_Error().Insert(UserName, Matn, Tarikh, IP, UserId, Desc, out Error);
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

        //Signers
        #region GetSignersWithFilter
        public List<OBJ_Signers> GetSignersWithFilter(int Module_OrganId, string Tarikh, int reportId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Signers().Select(Module_OrganId, Tarikh, reportId);
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

        //TreeOrganPost
        #region GetTreeOrganPostWithFilter
        public List<OBJ_TreeOrganPost> GetTreeOrganPost(string FieldName, string Value, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_TreeOrganPost().Select(FieldName, Value, UserId);
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

        // NezamVazife      
        #region GetNezamVazifeDetail
        public OBJ_NezamVazife GetNezamVazifeDetail(int NezamVazifeId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_NezamVazife().Detail(NezamVazifeId, out Error);
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
        #region GetNezamVazifeWithFilter
        public List<OBJ_NezamVazife> GetNezamVazifeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_NezamVazife().Select(FieldName, FilterValue, Top);
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
        #region InsertNezamVazife
        public string InsertNezamVazife(string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(94, UserId, OrganId))
                        return new BL_NezamVazife().Insert(fldTitle, UserId, Desc, out Error);
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
        #region UpdateNezamVazife
        public string UpdateNezamVazife(byte fldId, string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(95, UserId, OrganId))
                        return new BL_NezamVazife().Update(fldId, fldTitle, UserId, Desc, out Error);
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
        #region DeleteNezamVazife
        public string DeleteNezamVazife(byte id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(96, UserId, OrganId))
                        return new BL_NezamVazife().Delete(id, UserId, out Error);
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

        // MadrakTahsili
        #region GetMadrakTahsiliDetail
        public OBJ_MadrakTahsili GetMadrakTahsiliDetail(int MadrakTahsiliId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_MadrakTahsili().Detail(MadrakTahsiliId, out Error);
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
        #region GetMadrakTahsiliWithFilter
        public List<OBJ_MadrakTahsili> GetMadrakTahsiliWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_MadrakTahsili().Select(FieldName, FilterValue, Top);
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
        #region InsertMadrakTahsili
        public string InsertMadrakTahsili(string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(98, UserId, OrganId))
                        return new BL_MadrakTahsili().Insert(fldTitle, UserId, Desc, out Error);
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
        #region UpdateMadrakTahsili
        public string UpdateMadrakTahsili(int fldId, string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(99, UserId, OrganId))
                        return new BL_MadrakTahsili().Update(fldId, fldTitle, UserId, Desc, out Error);
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
        #region DeleteMadrakTahsili
        public string DeleteMadrakTahsili(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(100, UserId, OrganId))
                        return new BL_MadrakTahsili().Delete(id, UserId, out Error);
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

        //StatusTaahol
        #region GetStatusTaaholWithFilter
        public List<OBJ_StatusTaahol> GetStatusTaaholWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_StatusTaahol().Select(FieldName, FilterValue, Top);
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

        //ReshteTahsili
        #region GetReshteTahsiliDetail
        public OBJ_ReshteTahsili GetReshteTahsiliDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ReshteTahsili().Detail(Id, out Error);
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
        #region GetReshteTahsiliWithFilter
        public List<OBJ_ReshteTahsili> GetReshteTahsiliWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_ReshteTahsili().Select(FieldName, FilterValue, Top);
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
        #region InsertReshteTahsili
        public string InsertReshteTahsili(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(158, UserId, OrganId))
                        return new BL_ReshteTahsili().Insert(Title, UserId, Desc, out Error);
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
        #region UpdateReshteTahsili
        public string UpdateReshteTahsili(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(159, UserId, OrganId))
                        return new BL_ReshteTahsili().Update(Id, Title, UserId, Desc, out Error);
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
        #region DeleteReshteTahsili
        public string DeleteReshteTahsili(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(160, UserId, OrganId))
                        return new BL_ReshteTahsili().Delete(Id, UserId, out Error);
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

        //Employee_Detail
        #region GetEmployee_DetailDetail
        public OBJ_Employee_Detail GetEmployee_DetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();

            try
            {
                return new BL_Employee_Detail().Detail(Id, out Error);
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
        #region GetEmployee_DetailWithFilter
        public List<OBJ_Employee_Detail> GetEmployee_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                return new BL_Employee_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertEmployee_Detail
        public string InsertEmployee_Detail(int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod,
            Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId,
            byte[] fldFile, string fldPassvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId, Nullable<int> fldMahalSodoorId,
            string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat, string Desc, string Username, 
            string Password, int OrganId, string IP,string fldTel,string fldMobile, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(410, UserId, OrganId))
                        return new BL_Employee_Detail().Insert(fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId, fldNezamVazifeId, fldTaaholId, fldReshteId, fldFile, fldPassvand, fldSh_Shenasname, fldMahalTavalodId
                    , fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, UserId, Desc, fldTel, fldMobile, out Error);
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
        #region UpdateEmployee_Detail
        public string UpdateEmployee_Detail(int fldId, int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat,
            string fldTarikhTavalod, Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId,
            Nullable<int> fldReshteId, Nullable<int> fldFileId, byte[] fldFile, string fldPasvand, string fldSh_Shenasname,
            Nullable<int> fldMahalTavalodId, Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress,
            string fldCodePosti, Nullable<bool> fldMeliyat, string Desc, string Username, string Password, int OrganId, 
            string IP,string fldTel,string fldMobile, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(411, UserId, OrganId))
                        return new BL_Employee_Detail().Update(fldId, fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId, fldNezamVazifeId, fldTaaholId, fldReshteId, fldFileId, fldFile
                    , fldPasvand, fldSh_Shenasname, fldMahalTavalodId, fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, UserId, Desc, fldTel, fldMobile, out Error);
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
        #region DeleteEmployee_Detail
        public string DeleteEmployee_Detail(int id, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(412, UserId))نیاز به دسترسی ندارد وقتی شخص حقیقی حذف میشود اطلاعات تکمیلی نیز حذف میشود
                        return new BL_Employee_Detail().Delete(id, UserId, out Error);
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

        // Ashkhas
        #region GetAshkhasDetail
        public OBJ_Ashkhas GetAshkhasDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Ashkhas().Detail(Id, out Error);
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
        #region GetAshkhasWithFilter
        public List<OBJ_Ashkhas> GetAshkhasWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Ashkhas().Select(FieldName, FilterValue,FilterValue1, Top);
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
        #region InsertAshkhas
        public string InsertAshkhas(Nullable<int> HaghighiId, Nullable<int> HoghoghiId, string Desc, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(418, UserId))انگار تو دیتابیس استفاده شده از پروسیجر
                        return new BL_Ashkhas().Insert(HaghighiId, HoghoghiId, UserId, Desc, out Error);
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
        #region UpdateAshkhas
        public string UpdateAshkhas(int Id, Nullable<int> HaghighiId, Nullable<int> HoghoghiId, string Desc, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(419, UserId))استفاده نشده ازش
                        return new BL_Ashkhas().Update(Id, HaghighiId, HoghoghiId, UserId, Desc, out Error);
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
        #region DeleteAshkhas
        public string DeleteAshkhas(int id, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(420, UserId))
                        return new BL_Ashkhas().Delete(id, UserId, out Error);
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

        // MaliyatArzesheAfzoode
        #region GetMaliyatArzesheAfzoodeDetail
        public OBJ_MaliyatArzesheAfzoode GetMaliyatArzesheAfzoodeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_MaliyatArzesheAfzoode().Detail(Id, out Error);
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
        #region GetMaliyatArzesheAfzoodeWithFilter
        public List<OBJ_MaliyatArzesheAfzoode> GetMaliyatArzesheAfzoodeWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MaliyatArzesheAfzoode().Select(FieldName, FilterValue, Top);
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
        #region InsertMaliyatArzesheAfzoode
        public string InsertMaliyatArzesheAfzoode(string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(422, UserId, OrganId))
                        return new BL_MaliyatArzesheAfzoode().Insert(FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, UserId, Desc, out Error);
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
        #region UpdateMaliyatArzesheAfzoode
        public string UpdateMaliyatArzesheAfzoode(int Id, string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat,decimal DarasadAmuzeshParvaresh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(423, UserId, OrganId))
                        return new BL_MaliyatArzesheAfzoode().Update(Id, FromDate, EndDate, DarsadeAvarez, DarsadeMaliyat,DarasadAmuzeshParvaresh, UserId, Desc, out Error);
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
        #region DeleteMaliyatArzesheAfzoode
        public string DeleteMaliyatArzesheAfzoode(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(424, UserId, OrganId))
                        return new BL_MaliyatArzesheAfzoode().Delete(id, UserId, out Error);
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

        // AshkhaseHoghoghi
        #region GetAshkhaseHoghoghi
        public OBJ_AshkhaseHoghoghi GetAshkhaseHoghoghiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_AshkhaseHoghoghi().Detail(Id, out Error);
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
        #region GetAshkhaseHoghoghiWithFilter
        public List<OBJ_AshkhaseHoghoghi> GetAshkhaseHoghoghiWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_AshkhaseHoghoghi().Select(FieldName, FilterValue, Top);
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
        #region InsertAshkhaseHoghoghi
        public int InsertAshkhaseHoghoghi(string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs, byte Sayer, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(426, UserId, OrganId))
                        return new BL_AshkhaseHoghoghi().Insert(fldShenaseMelli, fldName, fldShomareSabt,TypeShakhs,Sayer, UserId, Desc, out Error);
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
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region UpdateAshkhaseHoghoghi
        public string UpdateAshkhaseHoghoghi(int Id, string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs, byte Sayer, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(427, UserId, OrganId))
                        return new BL_AshkhaseHoghoghi().Update(Id, fldShenaseMelli, fldName, fldShomareSabt,TypeShakhs,Sayer, UserId, Desc, out Error);
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
        #region DeleteAshkhaseHoghoghi
        public string DeleteAshkhaseHoghoghi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(428, UserId, OrganId)){
                        DL_Ashkhas Ashkhas = new DL_Ashkhas();
                        var q = Ashkhas.Select("fldHoghoghiId", id.ToString(), "", 0).FirstOrDefault();
                        if (q != null)
                            Ashkhas.Delete(q.fldId, UserId);
                        return new BL_AshkhaseHoghoghi().Delete(id, UserId, out Error);
                    }
                        
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
                    Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
                    new BL().BLErrorMsg(Username, Er, IP, UserId);
                    return "خطا";
                }
            }
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return "خطا";
            }
        }
        #endregion

        //ShomareHesabeOmoomi
        #region GetShomareHesabeOmoomi
        public OBJ_ShomareHesabeOmoomi GetShomareHesabeOmoomiDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_ShomareHesabeOmoomi().Detail(Id, out Error);
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
        #region GetShomareHesabeOmoomiWithFilter
        public List<OBJ_ShomareHesabeOmoomi> GetShomareHesabeOmoomiWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ShomareHesabeOmoomi().Select(FieldName, FilterValue,FilterValue2,FilterValue3, Top);
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
        #region InsertShomareHesabeOmoomi
        public string InsertShomareHesabeOmoomi(int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(438, UserId, OrganId))
                        return new BL_ShomareHesabeOmoomi().Insert(ShobeId, AshkhasId, ShomareHesab, ShomareSheba, UserId, Desc, out Error);
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
        #region UpdateShomareHesabeOmoomi
        public string UpdateShomareHesabeOmoomi(int Id, int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(439, UserId, OrganId))
                        return new BL_ShomareHesabeOmoomi().Update(Id, ShobeId, AshkhasId, ShomareHesab, ShomareSheba, UserId, Desc, out Error);
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
        #region DeleteShomareHesabeOmoomi
        public string DeleteShomareHesabeOmoomi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(440, UserId, OrganId))
                        return new BL_ShomareHesabeOmoomi().Delete(id, UserId, out Error);
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

        //GetUserGroupTree
        #region GetUserGroupTreeWithFilter
        public List<OBJ_GetUserGroupTree> GetUserGroupTreeWithFilter(int UserId, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserLoginId = authorize.ExistUser(Username, Password);
            if (UserLoginId != 0)
            {
                try
                {
                    return new BL_GetUserGroupTree().Select(UserId, UserLoginId);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserLoginId);
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

        //CheckEmail
        #region CheckEmail
        public OBJ_CheckEmail CheckEmail(string Email, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_CheckEmail().CheckEmail(Email, out Error);
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

        //MeasureUnit
        #region GetMeasureUnit
        public OBJ_MeasureUnit GetMeasureUnitDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_MeasureUnit().Detail(Id, out Error);
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
        #region GetMeasureUnitWithFilter
        public List<OBJ_MeasureUnit> GetMeasureUnitWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MeasureUnit().Select(FieldName, FilterValue, Top);
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
        #region InsertMeasureUnit
        public string InsertMeasureUnit(string NameVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(434, UserId, OrganId))
                        return new BL_MeasureUnit().Insert(NameVahed, UserId, Desc, out Error);
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
        #region UpdateMeasureUnit
        public string UpdateMeasureUnit(int Id, string NameVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(435, UserId, OrganId))
                        return new BL_MeasureUnit().Update(Id, NameVahed, UserId, Desc, out Error);
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
        #region DeleteMeasureUnit
        public string DeleteMeasureUnit(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(436, UserId, OrganId))
                        return new BL_MeasureUnit().Delete(id, UserId, out Error);
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

        //AshkhaseHoghoghi_Detail
        #region GetAshkhaseHoghoghi_Detail
        public OBJ_AshkhaseHoghoghi_Detail GetAshkhaseHoghoghi_DetailDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
                try
                {
                    return new BL_AshkhaseHoghoghi_Detail().Detail(Id, out Error);
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
        #region GetAshkhaseHoghoghi_DetailWithFilter
        public List<OBJ_AshkhaseHoghoghi_Detail> GetAshkhaseHoghoghi_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            
            try
            {
                return new BL_AshkhaseHoghoghi_Detail().Select(FieldName, FilterValue, Top);
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
        #region InsertAshkhaseHoghoghi_Detail
        public string InsertAshkhaseHoghoghi_Detail(int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(574, UserId, OrganId))
                        return new BL_AshkhaseHoghoghi_Detail().Insert(AshkhaseHoghoghiId, CodEghtesadi, Address, CodePosti, ShomareTelephone, UserId, Desc, out Error);
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
        #region UpdateAshkhaseHoghoghi_Detail
        public string UpdateAshkhaseHoghoghi_Detail(int Id, int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, string Desc, string UserName, string Password,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(575, UserId, OrganId))
                        return new BL_AshkhaseHoghoghi_Detail().Update(Id, AshkhaseHoghoghiId, CodEghtesadi, Address, CodePosti, ShomareTelephone, UserId, Desc, out Error);
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
        #region DeleteAshkhaseHoghoghi_Detail
        public string DeleteAshkhaseHoghoghi_Detail(int Id, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(576, UserId))نیاز به دسترسی نداره چون وقتی خود شخص حذف میشود اطلاعات تکمیلی نیز حذف میشود
                    return new BL_AshkhaseHoghoghi_Detail().Delete(Id, UserId, out Error);
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

        //UserGroup_ModuleOrgan
        #region GetUserGroup_ModuleOrganDetail
        public OBJ_UserGroup_ModuleOrgan GetUserGroup_ModuleOrganDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_UserGroup_ModuleOrgan().Detail(Id, out Error);
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
        #region GetUserGroup_ModuleOrganWithFilter
        public List<OBJ_UserGroup_ModuleOrgan> GetUserGroup_ModuleOrganWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_UserGroup_ModuleOrgan().Select(FieldName, FilterValue, Top);
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
        #region InsertUserGroup_ModuleOrgan
        public string InsertUserGroup_ModuleOrgan(int UserGroupId, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(72, UserId, OrganId))
                        return new BL_UserGroup_ModuleOrgan().Insert(UserGroupId, Module_OrganId, UserId, Desc, out Error);
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
        #region UpdateUserGroup_ModuleOrgan
        public string UpdateUserGroup_ModuleOrgan(int Id, int UserGroupId, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(73, UserId, OrganId))
                        return new BL_UserGroup_ModuleOrgan().Update(Id, UserGroupId, Module_OrganId, UserId, Desc, out Error);
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
        #region DeleteUserGroup_ModuleOrgan
        public string DeleteUserGroup_ModuleOrgan(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(74, UserId, OrganId))
                        return new BL_UserGroup_ModuleOrgan().Delete(Id, UserId, out Error);
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

        //InputInfo
        #region GetInputInfoWithFilter
        public List<OBJ_InputInfo> GetInputInfoWithFilter(string FieldName, string FilterValue, bool LoginType, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_InputInfo().Select(FieldName, FilterValue, LoginType, Top);
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
        #region InsertInputInfo
        public string InsertInputInfo(System.DateTime fldDateTime, string fldIP, string fldMACAddress, bool fldLoginType, string Desc, string UserName, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(601, UserId))
                        return new BL_InputInfo().Insert(fldDateTime,fldIP,fldMACAddress,fldLoginType, UserId, Desc, out Error);
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

        // ChartOrganEjraee
        #region GetChartOrganEjraeeDetail
        public OBJ_ChartOrganEjraee GetChartOrganEjraeeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_ChartOrganEjraee().Detail(Id, out Error);
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
        #region GetChartOrganEjraeeWithFilter
        public List<OBJ_ChartOrganEjraee> GetChartOrganEjraeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_ChartOrganEjraee().Select(FieldName, FilterValue, UserId, Top);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region InsertChartOrganEjraee
        public string InsertChartOrganEjraee(string Title, Nullable<int> PId, Nullable<int> fldOrganId, byte NoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(678, UserId, OrganId))
                        return new BL_ChartOrganEjraee().Insert(Title, PId, fldOrganId, NoeVahed, UserId, Desc, out Error);
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
        #region UpdateChartOrganEjraee
        public string UpdateChartOrganEjraee(int fldId, string Title, Nullable<int> PId, Nullable<int> fldOrganId, byte NoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(679, UserId, OrganId))
                        return new BL_ChartOrganEjraee().Update(fldId, Title, PId, fldOrganId, NoeVahed, UserId, Desc, out Error);
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
        #region DeleteChartOrganEjraee
        public string DeleteChartOrganEjraee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(680, UserId, OrganId))
                        return new BL_ChartOrganEjraee().Delete(id, UserId,OrganId, out Error);
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
        #region GetChartEjraee_LastNode
        public List<OBJ_ChartOrganEjraee> GetChartEjraee_LastNode(int OrganId, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_ChartOrganEjraee().SelectChartEjraee_LastNode(OrganId);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion

        // OrganizationalPostsEjraee
        #region GetOrganizationalPostsEjraeeDetail
        public OBJ_OrganizationalPostsEjraee GetOrganizationalPostsEjraeeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_OrganizationalPostsEjraee().Detail(Id, out Error);
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
        #region GetOrganizationalPostsEjraeeWithFilter
        public List<OBJ_OrganizationalPostsEjraee> GetOrganizationalPostsEjraeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_OrganizationalPostsEjraee().Select(FieldName, FilterValue, UserId, Top);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion
        #region InsertOrganizationalPostsEjraee
        public string InsertOrganizationalPostsEjraee(string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(682, UserId, OrganId))
                        return new BL_OrganizationalPostsEjraee().Insert(Title, OrgPostCode, ChartOrganId, PID, UserId, Desc, out Error);
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
        #region UpdateOrganizationalPostsEjraee
        public string UpdateOrganizationalPostsEjraee(int fldId, string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(683, UserId, OrganId))
                        return new BL_OrganizationalPostsEjraee().Update(fldId, Title, OrgPostCode, ChartOrganId, PID, UserId, Desc, out Error);
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
        #region DeleteOrganizationalPostsEjraee
        public string DeleteOrganizationalPostsEjraee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(684, UserId, OrganId))
                        return new BL_OrganizationalPostsEjraee().Delete(id, UserId, out Error);
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

        //TreeOrganPostEjra
        #region GetTreeOrganPostEjra
        public List<OBJ_TreeOrganPost> GetTreeOrganPostEjra(string FieldName, string Value, string UserName, string Password,string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    return new BL_TreeOrganPost().TreeOrganPostEjra(FieldName, Value, UserId);
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
            else
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام کاربری یا رمز عبور صحیح نمی باشد.";
                return null;
            }
        }
        #endregion

        //ExpirElamAvarez
        #region ChangeLetter
        public bool ChangeLetter(string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_ExpirElamAvarez().ExpireElamAvarez();
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

        //WebServiceLog
        #region GetWebServiceLog
        public OBJ_WebServiceLog GetWebServiceLogDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_WebServiceLog().Detail(Id, out Error);
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
        #region GetWebServiceLogWithFilter
        public List<OBJ_WebServiceLog> GetWebServiceLogWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_WebServiceLog().Select(FieldName, FilterValue, Top);
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
        #region InsertWebServiceLog
        public string InsertWebServiceLog(string Matn, string user, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(434, UserId, OrganId))
                        return new BL_WebServiceLog().Insert(Matn, user, out Error);
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
        #region UpdateWebServiceLog
        public string UpdateWebServiceLog(int Id, string Matn, string user, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(435, UserId, OrganId))
                        return new BL_WebServiceLog().Update(Id, Matn, user, out Error);
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
        #region DeleteWebServiceLog
        public string DeleteWebServiceLog(int id, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(436, UserId, OrganId))
                        return new BL_WebServiceLog().Delete(id, UserId, out Error);
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

        //WarrantyType
        #region GetWarrantyTypeDetail
        public OBJ_WarrantyType GetWarrantyTypeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_WarrantyType().Detail(Id, out Error);
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
        #region GetWarrantyTypeWithFilter
        public List<OBJ_WarrantyType> GetWarrantyTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_WarrantyType().Select(FieldName, FilterValue, Top);
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
        #region InsertWarrantyType
        public string InsertWarrantyType(string Name,string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(907, UserId, OrganId))
                        return new BL_WarrantyType().Insert(Name,  UserId, IP, Desc, out Error);
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
        #region UpdateWarrantyType
        public string UpdateWarrantyType(int Id, string Name,  string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(908, UserId, OrganId))
                        return new BL_WarrantyType().Update(Id, Name, UserId, IP, Desc, out Error);
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
        #region DeleteWarrantyType
        public string DeleteWarrantyType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(909, UserId, OrganId))
                        return new BL_WarrantyType().Delete(id, UserId, out Error);
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

        //BillsType
        #region GetBillsTypeDetail
        public OBJ_BillsType GetBillsTypeDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_BillsType().Detail(Id, out Error);
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
        #region GetBillsTypeWithFilter
        public List<OBJ_BillsType> GetBillsTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_BillsType().Select(FieldName, FilterValue, Top);
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
        #region InsertBillsType
        public string InsertBillsType(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(940, UserId, OrganId))
                        return new BL_BillsType().Insert(fldName, UserId, Desc, IP, out Error);
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
        #region UpdateBillsType
        public string UpdateBillsType(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(941, UserId, OrganId))
                        return new BL_BillsType().Update(fldId, fldName, UserId, Desc, IP, out Error);
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
        #region DeleteBillsType
        public string DeleteBillsType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(942, UserId, OrganId))
                        return new BL_BillsType().Delete(id, UserId, out Error);
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

        //CaseBills
        #region GetCaseBillsDetail
        public OBJ_CaseBills GetCaseBillsDetail(int Id,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CaseBills().Detail(Id, OrganId, out Error);
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
        #region GetCaseBillsWithFilter
        public List<OBJ_CaseBills> GetCaseBillsWithFilter(string FieldName, string FilterValue,int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CaseBills().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertCaseBills
        public string InsertCaseBills(int BillsTypeId, int FileNum, int CentercoId, int OrganChartId, int? AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(944, UserId, OrganId))
                        return new BL_CaseBills().Insert(BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, UserId, Desc, IP, out Error);
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
        #region UpdateCaseBills
        public string UpdateCaseBills(int Id, int BillsTypeId, int FileNum, int CentercoId, int OrganChartId, int? AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(945, UserId, OrganId))
                        return new BL_CaseBills().Update(Id, BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, UserId, Desc, IP, out Error);
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
        #region DeleteCaseBills
        public string DeleteCaseBills(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(946, UserId, OrganId))
                        return new BL_CaseBills().Delete(id, UserId, out Error);
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

        //FormatFile
        #region GetFormatFile
        public OBJ_FormatFile GetFormatFileDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_FormatFile().Detail(Id,OrganId, out Error);
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
        #region GetFormatFileWithFilter
        public List<OBJ_FormatFile> GetFormatFileWithFilter(string FieldName, string FilterValue, int Top, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_FormatFile().Select(FieldName, FilterValue,OrganId, Top);
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
        #region InsertFormatFile
        public string InsertFormatFile(string FormatName, byte[] Icon, string Passvand, int fldSize, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(805, UserId, OrganId))
                        return new BL_FormatFile().Insert(FormatName, Icon, Passvand, fldSize, OrganId, UserId, Desc, out Error);
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
        #region UpdateFormatFile
        public string UpdateFormatFile(byte Id, string FormatName, byte[] Icon, string Passvand, int fldSize, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(806, UserId, OrganId))
                        return new BL_FormatFile().Update(Id, FormatName, Icon, Passvand,fldSize,OrganId, UserId, Desc, out Error);
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
        #region DeleteFormatFile
        public string DeleteFormatFile(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(807, UserId, OrganId))
                        return new BL_FormatFile().Delete(id, UserId, out Error);
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


        // GeneralSetting
        #region GetGeneralSettingDetail
        public OBJ_GeneralSetting GetGeneralSettingDetail(int Id,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_GeneralSetting().Detail(Id, OrganId, out Error);
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
        #region GetGeneralSettingWithFilter
        public List<OBJ_GeneralSetting> GetGeneralSettingWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GeneralSetting().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertGeneralSetting
        public int InsertGeneralSetting(string fldName, string fldValue, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1084, UserId, OrganId))
                        return new BL_GeneralSetting().Insert(fldName, fldValue,OrganId,fldModuleId, UserId, Desc, out Error);
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
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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
        #region UpdateGeneralSetting
        public string UpdateGeneralSetting(byte fldId, string fldName, string fldValue, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1085, UserId, OrganId))
                        return new BL_GeneralSetting().Update(fldId, fldName, fldValue,OrganId,fldModuleId, UserId, Desc, out Error);
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
        #region DeleteGeneralSetting
        public string DeleteGeneralSetting(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1086, UserId, OrganId))
                        return new BL_GeneralSetting().Delete(id, UserId, out Error);
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
        #region Insert_GeneralSetting
        public string Insert_GeneralSetting(string fldName, string fldValue, int fldModuleId, System.Data.DataTable ComboBox, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1084, UserId, OrganId))
                        return new BL_GeneralSetting().GeneralSettingInsert(fldName, fldValue, OrganId, fldModuleId, ComboBox, UserId, Desc, out Error);
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
        #region Update_GeneralSetting
        public string Update_GeneralSetting(int fldHeaderId, string fldName, string fldValue, int fldModuleId, System.Data.DataTable ComboBox, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1085, UserId, OrganId))
                        return new BL_GeneralSetting().GeneralSettingUpdate(fldHeaderId, fldName, fldValue, OrganId, fldModuleId, ComboBox, UserId, Desc, out Error);
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
        #region Delete_GeneralSetting
        public string Delete_GeneralSetting(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1086, UserId, OrganId))
                        return new BL_GeneralSetting().GeneralSettingDelete(id, UserId, out Error);
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

        //Kala
        #region GetKalaDetail
        public OBJ_Kala GetKalaDetail(int Id,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Kala().Detail(Id, OrganId, out Error);
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
        #region GetKalaWithFilter
        public List<OBJ_Kala> GetKalaWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Kala().Select(FieldName, FilterValue,OrganId, Top);
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
        #region InsertKala
        public string InsertKala(string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(858, UserId, OrganId))
                        return new BL_Kala().Insert(Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, UserId,OrganId, IP, Desc, out Error);
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
        #region UpdateKala
        public string UpdateKala(int Id, string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(859, UserId, OrganId))
                        return new BL_Kala().Update(Id, Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, UserId,OrganId, IP, Desc, out Error);
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
        #region DeleteKala
        public string DeleteKala(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(860, UserId, OrganId))
                        return new BL_Kala().Delete(id, UserId, out Error);
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

        //CharacterPersianPlaque
        #region GetCharacterPersianPlaqueDetail
        public OBJ_CharacterPersianPlaque GetCharacterPersianPlaqueDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CharacterPersianPlaque().Detail(Id, out Error);
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
        #region GetCharacterPersianPlaqueWithFilter
        public List<OBJ_CharacterPersianPlaque> GetCharacterPersianPlaqueWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CharacterPersianPlaque().Select(FieldName, FilterValue, Top);
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
        #region InsertCharacterPersianPlaque
        public string InsertCharacterPersianPlaque(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1134, UserId, OrganId))
                        return new BL_CharacterPersianPlaque().Insert(fldName, UserId, Desc, IP, out Error);
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
        #region UpdateCharacterPersianPlaque
        public string UpdateCharacterPersianPlaque(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1135, UserId, OrganId))
                        return new BL_CharacterPersianPlaque().Update(fldId, fldName, UserId, Desc, IP, out Error);
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
        #region DeleteCharacterPersianPlaque
        public string DeleteCharacterPersianPlaque(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1136, UserId, OrganId))
                        return new BL_CharacterPersianPlaque().Delete(id, UserId, out Error);
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

        //TypeKhodro
        #region GetTypeKhodroDetail
        public OBJ_TypeKhodro GetTypeKhodroDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_TypeKhodro().Detail(Id, out Error);
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
        #region GetTypeKhodroWithFilter
        public List<OBJ_TypeKhodro> GetTypeKhodroWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TypeKhodro().Select(FieldName, FilterValue, Top);
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
        #region InsertTypeKhodro
        public string InsertTypeKhodro(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1138, UserId, OrganId))
                        return new BL_TypeKhodro().Insert(fldName, UserId, Desc, IP, out Error);
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
        #region UpdateTypeKhodro
        public string UpdateTypeKhodro(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1139, UserId, OrganId))
                        return new BL_TypeKhodro().Update(fldId, fldName, UserId, Desc, IP, out Error);
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
        #region DeleteTypeKhodro
        public string DeleteTypeKhodro(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1140, UserId, OrganId))
                        return new BL_TypeKhodro().Delete(id, UserId, out Error);
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

        //Plaque
        #region GetPlaqueDetail
        public OBJ_Plaque GetPlaqueDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_Plaque().Detail(Id, out Error);
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
        #region GetPlaqueWithFilter
        public List<OBJ_Plaque> GetPlaqueWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Plaque().Select(FieldName, FilterValue, Top);
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
        #region InsertPlaque
        public string InsertPlaque(byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1142, UserId, OrganId))
                        return new BL_Plaque().Insert(fldSerialPlaque, harf, fldPlaque2, fldPlaque3, UserId, Desc, IP, out Error);
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
        #region UpdatePlaque
        public string UpdatePlaque(int fldId, byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1143, UserId, OrganId))
                        return new BL_Plaque().Update(fldId, fldSerialPlaque, harf, fldPlaque2, fldPlaque3, UserId, Desc, IP, out Error);
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
        #region DeletePlaque
        public string DeletePlaque(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1144, UserId, OrganId))
                        return new BL_Plaque().Delete(id, UserId, out Error);
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
        #region InsertPlaque_WebService
        public int InsertPlaque_WebService(string Harf, string Plaque2, string Plaque3, byte Serial, string IP, out ClsError Error)
        {
            Error = new ClsError();

            try
            {
                return new BL_Plaque().InsertPlaque_WebService(Harf, Plaque2, Plaque3,Serial, out Error);

            }
            catch (Exception x)
            {
                Error.ErrorType = true;
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, IP, null);
                return 0;
            }
        }
        #endregion

        // GeneralSetting_ComboBox
        #region GetGeneralSetting_ComboBoxDetail
        public OBJ_GeneralSetting_ComboBox GetGeneralSetting_ComboBoxDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_GeneralSetting_ComboBox().Detail(Id, out Error);
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
        #region GetGeneralSetting_ComboBoxWithFilter
        public List<OBJ_GeneralSetting_ComboBox> GetGeneralSetting_ComboBoxWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GeneralSetting_ComboBox().Select(FieldName, FilterValue, Top);
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
        #region InsertGeneralSetting_ComboBox
        public string InsertGeneralSetting_ComboBox(byte fldGeneralSettingId, string fldTtile, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1084, UserId, OrganId))
                        return new BL_GeneralSetting_ComboBox().Insert(fldGeneralSettingId, fldTtile, fldValue, UserId, Desc, out Error);
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
        #region UpdateGeneralSetting_ComboBox
        public string UpdateGeneralSetting_ComboBox(byte fldId, byte fldGeneralSettingId, string fldTtile, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1085, UserId, OrganId))
                        return new BL_GeneralSetting_ComboBox().Update(fldId, fldGeneralSettingId, fldTtile, fldValue, UserId, Desc, out Error);
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
        #region DeleteGeneralSetting_ComboBox
        public string DeleteGeneralSetting_ComboBox(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1086, UserId, OrganId))
                        return new BL_GeneralSetting_ComboBox().Delete(id, UserId, out Error);
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

        // GeneralSetting_Value
        #region GetGeneralSetting_ValueDetail
        public OBJ_GeneralSetting_Value GetGeneralSetting_ValueDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_GeneralSetting_Value().Detail(Id, OrganId, out Error);
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
        #region GetGeneralSetting_ValueWithFilter
        public List<OBJ_GeneralSetting_Value> GetGeneralSetting_ValueWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GeneralSetting_Value().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertGeneralSetting_Value
        public string InsertGeneralSetting_Value(byte fldGeneralSettingId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1084, UserId, OrganId))
                        return new BL_GeneralSetting_Value().Insert(fldGeneralSettingId, fldValue, UserId, OrganId, Desc, out Error);
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
        #region UpdateGeneralSetting_Value
        public string UpdateGeneralSetting_Value(byte fldId, byte fldGeneralSettingId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1085, UserId, OrganId))
                        return new BL_GeneralSetting_Value().Update(fldId, fldGeneralSettingId, fldValue, UserId, OrganId, Desc, out Error);
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
        #region DeleteGeneralSetting_Value
        public string DeleteGeneralSetting_Value(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1086, UserId, OrganId))
                        return new BL_GeneralSetting_Value().Delete(id, UserId, out Error);
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

        #region UpdateOrder
        public string UpdateOrder(string FieldName, int fldId, int OrderId, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {

                    return new BL_TypeKhodro().UpdateOrder(FieldName, fldId, OrderId, out Error);
                    
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

        //CompanyPost
        #region GetCompanyPostDetail
        public OBJ_CompanyPost GetCompanyPostDetail(short Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_CompanyPost().Detail(Id, out Error);
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
        #region GetCompanyPostWithFilter
        public List<OBJ_CompanyPost> GetCompanyPostWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CompanyPost().Select(FieldName, FilterValue, Top);
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
        #region InsertCompanyPost
        public string InsertCompanyPost(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1209, UserId, OrganId))
                        return new BL_CompanyPost().Insert(Name, UserId, Desc, out Error);
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
        #region UpdateCompanyPost
        public string UpdateCompanyPost(short Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1210, UserId, OrganId))
                        return new BL_CompanyPost().Update(Id, Name, UserId, Desc, out Error);
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
        #region DeleteCompanyPost
        public string DeleteCompanyPost(short id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1211, UserId, OrganId))
                        return new BL_CompanyPost().Delete(id, UserId, out Error);
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


        #region SelectMonth
        public List<OBJ_Month> SelectMonth(string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Month().Select();
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


        // HesabType
        #region GetHesabTypeWithFilter
        public List<OBJ_HesabType> GetHesabTypeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                try
                {
                    return new BL_HesabType().Select(FieldName, FilterValue,  Top);
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    // Error.ErrorMsg = "خطای پیش بینی نشده";
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(Username, Er, IP, UserId);
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

        //LoginFailed
        #region InsertLoginFailed
        public string InsertLoginFailed(string UserName,  string IP, out ClsError Error)
        {
            Error = new ClsError();
           try
                {
                    return new BL_LoginFailed().Insert(UserName, IP, out Error);
                   
                }
                catch (Exception x)
                {
                    Error.ErrorType = true;
                    string Er = x.Message;
                    if (x.InnerException != null)
                        Er += " " + x.InnerException.Message;
                    Error.ErrorMsg = new BL().BLErrorMsg(UserName, Er, IP, 1);
                    return "";
                }
            
           
        }
        #endregion

        //HistoryTahsilat
        #region GetHistoryTahsilatDetail
        public OBJ_HistoryTahsilat GetHistoryTahsilatDetail(int HistoryTahsilatId,  string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_HistoryTahsilat().Detail(HistoryTahsilatId, out Error);
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
        #region GetHistoryTahsilatWithFilter
        public List<OBJ_HistoryTahsilat> GetHistoryTahsilatWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_HistoryTahsilat().Select(FieldName, FilterValue, FilterValue2, Top);
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
        #region InsertHistoryTahsilat
        public string InsertHistoryTahsilat(int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc,  string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(106, UserId, OrganId))
                        return new BL_HistoryTahsilat().Insert(fldEmployeeId, fldMadrakId, fldReshteId, fldTarikh, Desc, UserId, IP, out Error);
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
        public string UpdateHistoryTahsilat(int HistoryTahsilatId, int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(107, UserId,OrganId))
                    return new BL_HistoryTahsilat().Update(HistoryTahsilatId,  fldEmployeeId, fldMadrakId, fldReshteId, fldTarikh, Desc, UserId, IP, out Error);
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
        #region DeleteHistoryTahsilat
        public string DeleteHistoryTahsilat(int HistoryTahsilatId, string UserName, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(UserName, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(108, UserId,OrganId))
                    return new BL_HistoryTahsilat().Delete(HistoryTahsilatId, UserId, IP, out Error);
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
