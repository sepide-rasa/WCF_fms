using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Contract;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContractService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IContractService
    {
        

        //RegistrationContract
        #region RegistrationContract
        [OperationContract]
        OBJ_RegistrationContract GetRegistrationContractDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_RegistrationContract> GetRegistrationContractWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRegistrationContract(int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRegistrationContract(int Id, int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRegistrationContract(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
    }
}
