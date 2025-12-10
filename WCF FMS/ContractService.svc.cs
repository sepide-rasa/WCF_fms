using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.BLL;
using WCF_FMS.BLL.Contract;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Contract;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ContractService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ContractService.svc or ContractService.svc.cs at the Solution Explorer and start debugging.
    public class ContractService : IContractService
    {
        

        //RegistrationContract
        #region GetRegistrationContractDetail
        public OBJ_RegistrationContract GetRegistrationContractDetail(int Id, string IP, out ClsError Error)
        {
            Error = new ClsError();
            try
            {
                return new BL_RegistrationContract().Detail(Id, out Error);
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
        #region GetRegistrationContractWithFilter
        public List<OBJ_RegistrationContract> GetRegistrationContractWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Error.ErrorType = false;
            Error.ErrorMsg = "";
            try
            {
                return new BL_RegistrationContract().Select(FieldName, FilterValue, Top);
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
        #region InsertRegistrationContract
        public string InsertRegistrationContract(int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(911, UserId, OrganId))
                        return new BL_RegistrationContract().Insert(WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract,OrganId, UserId, IP, Desc, out Error);
                    else
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
        #region UpdateRegistrationContract
        public string UpdateRegistrationContract(int Id, int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(912, UserId, OrganId))
                        return new BL_RegistrationContract().Update(Id, WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract,OrganId, UserId, IP, Desc, out Error);
                    else
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
        #region DeleteRegistrationContract
        public string DeleteRegistrationContract(int id, string Username, string Password, int OrganId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            var UserId = authorize.ExistUser(Username, Password);
            if (UserId != 0)
            {
                try
                {
                    if (new BL().BLPermission(913, UserId, OrganId))
                        return new BL_RegistrationContract().Delete(id, UserId, out Error);
                    else
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
    }
}
