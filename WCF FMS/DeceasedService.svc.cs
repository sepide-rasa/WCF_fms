using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.BLL;
using WCF_FMS.BLL.Deceased;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DeceasedService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DeceasedService.svc or DeceasedService.svc.cs at the Solution Explorer and start debugging.
    public class DeceasedService : IDeceasedService
    {
        //CauseOfDeath
        #region GetCauseOfDeath
        public OBJ_CauseOfDeath GetCauseOfDeathDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_CauseOfDeath().Detail(Id, out Error);
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
        #region GetCauseOfDeathWithFilter
        public List<OBJ_CauseOfDeath> GetCauseOfDeathWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CauseOfDeath().Select(FieldName, FilterValue, Top);
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
        #region InsertCauseOfDeath
        public string InsertCauseOfDeath(string fldReason, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(992, UserId, OrganId))
                        return new BL_CauseOfDeath().Insert(fldReason, UserId, Desc,IP, out Error);
                    else
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
        #region UpdateCauseOfDeath
        public string UpdateCauseOfDeath(int Id, string fldReason, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(993, UserId, OrganId))
                        return new BL_CauseOfDeath().Update(Id, fldReason, UserId, Desc,IP, out Error);
                    else
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
        #region DeleteCauseOfDeath
        public string DeleteCauseOfDeath(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(994, UserId, OrganId))
                        return new BL_CauseOfDeath().Delete(id, UserId, out Error);
                    else
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

        //VadiSalam
        #region GetVadiSalam
        public OBJ_VadiSalam GetVadiSalamDetail(int Id,int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_VadiSalam().Detail(Id, OrganId, out Error);
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
        #region GetVadiSalamWithFilter
        public List<OBJ_VadiSalam> GetVadiSalamWithFilter(string FieldName, string FilterValue,int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_VadiSalam().Select(FieldName, FilterValue,OrganId, Top);
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
        #region InsertVadiSalam
        public string InsertVadiSalam(string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(996, UserId, OrganId))
                        return new BL_VadiSalam().Insert(fldName, fldStateId, fldCityId, fldAddress, fldLatitude, fldLongitude, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region UpdateVadiSalam
        public string UpdateVadiSalam(int Id, string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(997, UserId, OrganId))
                        return new BL_VadiSalam().Update(Id, fldName, fldStateId, fldCityId, fldAddress, fldLatitude, fldLongitude, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region DeleteVadiSalam
        public string DeleteVadiSalam(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(998, UserId, OrganId))
                        return new BL_VadiSalam().Delete(id, UserId, out Error);
                    else
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

        //Ghete
        #region GetGhete
        public OBJ_Ghete GetGheteDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Ghete().Detail(Id,OrganId, out Error);
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
        #region GetGheteWithFilter
        public List<OBJ_Ghete> GetGheteWithFilter(string FieldName, string FilterValue, int id, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Ghete().Select(FieldName, FilterValue,id,OrganId, Top);
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
        #region InsertGhete
        public string InsertGhete(int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1000, UserId, OrganId))
                        return new BL_Ghete().Insert(fldVadiSalamId, fldNameGhete, Radif, Shomare, Tabaghe, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region UpdateGhete
        public string UpdateGhete(int Id, int fldVadiSalamId, string fldNameGhete, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1001, UserId, OrganId))
                        return new BL_Ghete().Update(Id, fldVadiSalamId, fldNameGhete, UserId,OrganId, Desc, IP, out Error);
                    else
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
        #region DeleteGhete
        public string DeleteGhete(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1002, UserId, OrganId))
                        return new BL_Ghete().Delete(id, UserId, out Error);
                    else
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
        #region UpdateGheteKhali
        public string UpdateGheteKhali(int fldGheteId, int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1001, UserId, OrganId))
                        return new BL_Ghete().UpdateGheteKhali(fldGheteId,fldVadiSalamId, fldNameGhete, Radif, Shomare, Tabaghe, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region SelectGheteDetail
        public List<OBJ_Ghete> SelectGheteDetail(int GheteId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Ghete().SelectGheteDetail(GheteId);
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
        #region DeleteAllTablesOnGhete
        public string DeleteAllTablesOnGhete(int GheteId, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1002, UserId, OrganId))
                        return new BL_Ghete().DeleteAllTablesOnGhete(GheteId, UserId, OrganId, IP, out Error);
                    else
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
        #region UpdateTedadTabaghat
        public string UpdateTedadTabaghat(int fldGheteId, string fldShomare, string fldNameGhete, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1001, UserId, OrganId))
                        return new BL_Ghete().UpdateTedadTabaghat(fldGheteId, fldShomare, fldNameGhete, UserId,OrganId, Desc, out Error);
                    else
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

        //Radif
        #region GetRadif
        public OBJ_Radif GetRadifDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Radif().Detail(Id,OrganId, out Error);
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
        #region GetRadifWithFilter
        public List<OBJ_Radif> GetRadifWithFilter(string FieldName, string FilterValue, int Id, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Radif().Select(FieldName, FilterValue,Id,OrganId, Top);
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
        #region InsertRadif
        public string InsertRadif(int fldGheteId, string fldNameRadif, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1004, UserId, OrganId))
                        return new BL_Radif().Insert(fldGheteId, fldNameRadif, UserId,OrganId, Desc, IP, out Error);
                    else
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
        #region UpdateRadif
        public string UpdateRadif(int Id, int fldGheteId, string fldNameRadif, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1005, UserId, OrganId))
                        return new BL_Radif().Update(Id, fldGheteId, fldNameRadif, UserId,OrganId, Desc, IP, out Error);
                    else
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
        #region DeleteRadif
        public string DeleteRadif(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1006, UserId, OrganId))
                        return new BL_Radif().Delete(id, UserId, out Error);
                    else
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

        //Shomare
        #region GetShomare
        public OBJ_Shomare GetShomareDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Shomare().Detail(Id,OrganId, out Error);
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
        #region GetShomareWithFilter
        public List<OBJ_Shomare> GetShomareWithFilter(string FieldName, string FilterValue, int Id, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Shomare().Select(FieldName, FilterValue,Id,OrganId, Top);
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
        #region InsertShomare
        public string InsertShomare(int fldRadifId, string fldShomare, byte fldTedadTabaghat, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1008, UserId, OrganId))
                        return new BL_Shomare().Insert(fldRadifId,fldShomare,fldTedadTabaghat,OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateShomare
        public string UpdateShomare(int Id, int fldRadifId, string fldShomare, byte fldTedadTabaghat, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1009, UserId, OrganId))
                        return new BL_Shomare().Update(Id, fldRadifId,fldShomare,fldTedadTabaghat,OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteShomare
        public string DeleteShomare(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1010, UserId, OrganId))
                        return new BL_Shomare().Delete(id, UserId, out Error);
                    else
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
        #region SelectTabaghe
        public List<OBJ_Tabaghe> SelectTabaghe(int ShomareId, int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Shomare().SelectTabaghe(ShomareId,Id);
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

        //GhabreAmanat
        #region GetGhabreAmanat
        public OBJ_GhabreAmanat GetGhabreAmanatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_GhabreAmanat().Detail(Id, OrganId, out Error);
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
        #region GetGhabreAmanatWithFilter
        public List<OBJ_GhabreAmanat> GetGhabreAmanatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GhabreAmanat().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertGhabreAmanat
        public string InsertGhabreAmanat(int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1012, UserId, OrganId))
                        return new BL_GhabreAmanat().Insert(fldShomareId, fldEmployeeId, fldTarikhRezerv, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region UpdateGhabreAmanat
        public string UpdateGhabreAmanat(int Id, int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1013, UserId, OrganId))
                        return new BL_GhabreAmanat().Update(Id, fldShomareId, fldEmployeeId, fldTarikhRezerv, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region DeleteGhabreAmanat
        public string DeleteGhabreAmanat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1014, UserId, OrganId))
                        return new BL_GhabreAmanat().Delete(id, UserId, out Error);
                    else
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
        #region RptGhabrPor_Khali
        public List<OBJ_GhabrPor_Khali> RptGhabrPor_Khali(string FieldName, int VadiId, int GheteId, int RadifId, int ShomareId, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GhabreAmanat().RptGhabrPor_Khali(FieldName, VadiId, GheteId, RadifId, ShomareId, OrganId);
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
        #region SelectInfoEmployeeInGhabrAmanat
        public List<OBJ_EmployeeInGhabrAmanat> SelectInfoEmployeeInGhabrAmanat(int ShomareId,byte ShomareTabaghe, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_GhabreAmanat().SelectInfoEmployeeInGhabrAmanat(ShomareId, ShomareTabaghe);
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

        //Motevaffa
        #region GetMotevaffa
        public OBJ_Motevaffa GetMotevaffaDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Motevaffa().Detail(Id, OrganId, out Error);
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
        #region GetMotevaffaWithFilter
        public List<OBJ_Motevaffa> GetMotevaffaWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Motevaffa().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertGMotevaffa
        public string InsertMotevaffa(int? ShomareId, int? EmployeeId, int? fldCauseOfDeathId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1016, UserId, OrganId))
                        return new BL_Motevaffa().Insert(ShomareId,EmployeeId,fldCauseOfDeathId, fldTarikhFot, fldTarikhDafn, fldMahalFotId, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region UpdateMotevaffa
        public string UpdateMotevaffa(int Id, int? fldCauseOfDeathId, int? fldGhabreAmanatId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1017, UserId, OrganId))
                        return new BL_Motevaffa().Update(Id, fldCauseOfDeathId, fldGhabreAmanatId, fldTarikhFot, fldTarikhDafn, fldMahalFotId, UserId, OrganId, Desc, IP, out Error);
                    else
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
        #region DeleteMotevaffa
        public string DeleteMotevaffa(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1018, UserId, OrganId))
                        return new BL_Motevaffa().Delete(id, UserId, out Error);
                    else
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

        //MahalFot
        #region GetMahalFot
        public OBJ_MahalFot GetMahalFotDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_MahalFot().Detail(Id, out Error);
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
        #region GetMahalFotWithFilter
        public List<OBJ_MahalFot> GetMahalFotWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_MahalFot().Select(FieldName, FilterValue, Top);
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
        #region InsertMahalFot
        public string InsertMahalFot(string fldNameMahal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1020, UserId, OrganId))
                        return new BL_MahalFot().Insert(fldNameMahal, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateMahalFot
        public string UpdateMahalFot(int Id, string fldNameMahal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1021, UserId, OrganId))
                        return new BL_MahalFot().Update(Id, fldNameMahal, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteMahalFot
        public string DeleteMahalFot(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1022, UserId, OrganId))
                        return new BL_MahalFot().Delete(id, UserId, out Error);
                    else
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

        #region InsertEmploye
        public int InsertEmploye(string CodeMeli, string CodeMoshakhase, string Name, string Family, string Sh_Sh, string NameFather, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                   
                    //if (new BL().BLPermission(APPId, UserId, OrganId))
                    return new BL_InsertEmploye().Insert(CodeMeli, CodeMoshakhase, Name, Family, Sh_Sh, NameFather, UserId, Desc, IP, out Error);
                    //else
                    //{
                    //    Error.ErrorType = true;
                    //    Error.ErrorMsg = "شما مجاز به دسترسی نمی باشید.";
                    //    return 0;
                    //}
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

        //CodeDaramadAramestan
        #region GetCodeDaramadAramestan
        public OBJ_CodeDaramadAramestan GetCodeDaramadAramestanDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_CodeDaramadAramestan().Detail(Id, OrganId, out Error);
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
        #region GetCodeDaramadAramestanWithFilter
        public List<OBJ_CodeDaramadAramestan> GetCodeDaramadAramestanWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_CodeDaramadAramestan().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertCodeDaramadAramestan
        public string InsertCodeDaramadAramestan(int fldCodeDaramadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1030, UserId, OrganId))
                        return new BL_CodeDaramadAramestan().Insert(fldCodeDaramadId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateCodeDaramadAramestan
        public string UpdateCodeDaramadAramestan(int Id, int fldCodeDaramadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1031, UserId, OrganId))
                        return new BL_CodeDaramadAramestan().Update(Id, fldCodeDaramadId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteCodeDaramadAramestan
        public string DeleteCodeDaramadAramestan(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1032, UserId, OrganId))
                        return new BL_CodeDaramadAramestan().Delete(id, UserId, out Error);
                    else
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

        //Actions
        #region GetActions
        public OBJ_Actions GetActionsDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Actions().Detail(Id,OrganId, out Error);
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
        #region GetActionsWithFilter
        public List<OBJ_Actions> GetActionsWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Actions().Select(FieldName, FilterValue,OrganId, Top);
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
        #region InsertActions
        public string InsertActions(string fldTitleAction, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1034, UserId, OrganId))
                        return new BL_Actions().Insert(fldTitleAction, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateActions
        public string UpdateActions(int Id, string fldTitleAction, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1035, UserId, OrganId))
                        return new BL_Actions().Update(Id, fldTitleAction, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteActions
        public string DeleteActions(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1036, UserId, OrganId))
                        return new BL_Actions().Delete(id, UserId, out Error);
                    else
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

        //Kartabl
        #region GetKartabl
        public OBJ_Kartabl GetKartablDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Kartabl().Detail(Id, OrganId, out Error);
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
        #region GetKartablWithFilter
        public List<OBJ_Kartabl> GetKartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Kartabl().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertKartabl
        public string InsertKartabl(string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1038, UserId, OrganId))
                        return new BL_Kartabl().Insert(fldTitleKartabl,fldHaveEbtal,fldHaveEtmam, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateKartabl
        public string UpdateKartabl(int Id, string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1039, UserId, OrganId))
                        return new BL_Kartabl().Update(Id, fldTitleKartabl,fldHaveEbtal,fldHaveEtmam, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteKartabl
        public string DeleteKartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1040, UserId, OrganId))
                        return new BL_Kartabl().Delete(id, UserId, out Error);
                    else
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
        #region UpdateOrderKartabl
        public string UpdateOrderKartabl(int fldKartablId, int fldOrderId, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1039, UserId, OrganId))
                        return new BL_Kartabl().UpdateOrderKartabl(fldKartablId, fldOrderId,  UserId, out Error);
                    else
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

        //Action_Kartabl
        #region GetAction_Kartabl
        public OBJ_Action_Kartabl GetAction_KartablDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Action_Kartabl().Detail(Id, OrganId, out Error);
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
        #region GetAction_KartablWithFilter
        public List<OBJ_Action_Kartabl> GetAction_KartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Action_Kartabl().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertAction_Kartabl
        public string InsertAction_Kartabl(int ActionId, int KartablId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1042, UserId, OrganId))
                        return new BL_Action_Kartabl().Insert(ActionId,KartablId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateAction_Kartabl
        public string UpdateAction_Kartabl(int Id, int ActionId, int KartablId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1043, UserId, OrganId))
                        return new BL_Action_Kartabl().Update(Id, ActionId, KartablId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteAction_Kartabl
        public string DeleteAction_Kartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1044, UserId, OrganId))
                        return new BL_Action_Kartabl().Delete(id, UserId, out Error);
                    else
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

        //NextKartabl
        #region GetNextKartabl
        public OBJ_NextKartabl GetNextKartablDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_NextKartabl().Detail(Id, OrganId, out Error);
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
        #region GetNextKartablWithFilter
        public List<OBJ_NextKartabl> GetNextKartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_NextKartabl().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertNextKartabl
        public string InsertNextKartabl(int fldKartablNextId, int ActionId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1046, UserId, OrganId))
                        return new BL_NextKartabl().Insert(fldKartablNextId, ActionId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateNextKartabl
        public string UpdateNextKartabl(int Id, int fldKartablNextId, int ActionId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1047, UserId, OrganId))
                        return new BL_NextKartabl().Update(Id, fldKartablNextId, ActionId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteNextKartabl
        public string DeleteNextKartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1048, UserId, OrganId))
                        return new BL_NextKartabl().Delete(id, UserId, out Error);
                    else
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

        //RequestAmanat
        #region GetRequestAmanat
        public OBJ_RequestAmanat GetRequestAmanatDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_RequestAmanat().Detail(Id, OrganId, out Error);
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
        #region GetRequestAmanatWithFilter
        public List<OBJ_RequestAmanat> GetRequestAmanatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RequestAmanat().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertRequestAmanat
        public string InsertRequestAmanat(int fldEmployeeId, int fldShomareId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1050, UserId, OrganId))
                        return new BL_RequestAmanat().Insert(fldEmployeeId,fldShomareId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateRequestAmanat
        public string UpdateRequestAmanat(int Id, int fldEmployeeId, int fldShomareId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1051, UserId, OrganId))
                        return new BL_RequestAmanat().Update(Id, fldEmployeeId, fldShomareId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteRequestAmanat
        public string DeleteRequestAmanat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1052, UserId, OrganId))
                        return new BL_RequestAmanat().Delete(id, UserId, out Error);
                    else
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
        #region UpdateRequestForEbtal
        public string UpdateRequestForEbtal(int Id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(1057, UserId, OrganId))
                        return new BL_RequestAmanat().UpdateRequestForEbtal(Id,  UserId, IP, out Error);
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
        #region UpdateEtmamCharkhe
        public string UpdateEtmamCharkhe(int Id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    //if (new BL().BLPermission(1057, UserId, OrganId))
                        return new BL_RequestAmanat().UpdateEtmamCharkhe(Id, UserId, IP, out Error);
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

        //Kartabl_Request
        #region GetKartabl_Request
        public OBJ_Kartabl_Request GetKartabl_RequestDetail(int Id, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();


            try
            {
                return new BL_Kartabl_Request().Detail(Id, OrganId, out Error);
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
        #region GetKartabl_RequestWithFilter
        public List<OBJ_Kartabl_Request> GetKartabl_RequestWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_Kartabl_Request().Select(FieldName, FilterValue, OrganId, Top);
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
        #region InsertKartabl_Request
        public string InsertKartabl_Request(int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1054, UserId, OrganId))
                        return new BL_Kartabl_Request().Insert(fldKartablId, fldActionId, fldRequestId, fldKartablNextId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region UpdateKartabl_Request
        public string UpdateKartabl_Request(int Id, int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1055, UserId, OrganId))
                        return new BL_Kartabl_Request().Update(Id, fldKartablId, fldActionId, fldRequestId, fldKartablNextId, OrganId, UserId, Desc, IP, out Error);
                    else
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
        #region DeleteKartabl_Request
        public string DeleteKartabl_Request(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(1056, UserId, OrganId))
                        return new BL_RequestAmanat().Delete(id, UserId, out Error);
                    else
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

        #region SelectTimeLine
        public List<OBJ_TimeLine> SelectTimeLine(int RequestId, string IP, out ClsError Error)
        {
            Error = new ClsError();

            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_TimeLine().Select(RequestId);
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
    }
}
