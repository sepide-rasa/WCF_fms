using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Common;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPay" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IComon_PayService
    {

        //ComputationFormula
        #region ComputationFormula
        [OperationContract]
        OBJ_ComputationFormula GetComputationFormulaDetail(int ComputationFormulaId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ComputationFormula> GetComputationFormulaWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertComputationFormula(bool? Type, string Formule, int? fldOrganId, string Library, string AzTarikh, int id, string fieldname, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateComputationFormula(string FieldName, int Id, bool? Type, string Formule, int? fldOrganId, string Library, string AzTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteComputationFormula(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

      
        //MaxPersonalEstekhdamType
        #region MaxPersonalEstekhdamType
        [OperationContract]
        List<OBJ_MaxPersonalEstekhdamType> GetMaxPersonalEstekhdamTypeWithFilter(string fieldName, int PersonalId, string tarikh, string IP, out ClsError Error);
        #endregion

        //Items_Estekhdam
        #region Items_Estekhdam
        [OperationContract]
        List<OBJ_Items_Estekhdam> GetItems_EstekhdamWithFilter(string FieldName, string NoeEstekhdam, int HokmId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string UpdateItems_Estekhdam(int Id, string Title, string Username, string Password, int OrganId, string IP, out ClsError Error);
        
        #endregion

        //TypeEstekhdam
        #region TypeEstekhdam
        [OperationContract]
        List<OBJ_TypeEstekhdam> GetTypeEstekhdamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //DiffDayMahSal
        #region DiffDayMahSal
        [OperationContract]
        List<OBJ_DiffDayMahSal> GetDiffDayMahSalWithFilter(int rozCount, string IP, out ClsError Error);
        #endregion

        //DiffDayMahSalNumber
        #region DiffDayMahSalNumber
        [OperationContract]
        List<OBJ_DiffDayMahSal> GetDiffDayMahSalNumberWithFilter(int rozCount, string IP, out ClsError Error);
        #endregion

        //TypeEstekhdam_Formul
        #region TypeEstekhdam_Formul
        [OperationContract]
        List<OBJ_TypeEstekhdam_Formul> GetTypeEstekhdam_FormulWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_TypeEstekhdam_Formul GetTypeEstekhdam_FormulDetail(int Id, string IP, out ClsError Error);
        #endregion

        //AnvaEstekhdam
        #region AnvaEstekhdam
        [OperationContract]
        List<OBJ_AnvaEstekhdam> GetAnvaEstekhdamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_AnvaEstekhdam GetAnvaEstekhdamDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnvaEstekhdam(string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnvaEstekhdam(int Id, string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnvaEstekhdam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ItemsHoghughi
        #region ItemsHoghughi
        [OperationContract]
        List<OBJ_ItemsHoghughi> GetItemsHoghughiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region UpdateItemsHoghughi
        [OperationContract]
        string UpdateItemsHoghughi(int Id, byte TypeHesabId, byte Mostamar, string UserName, string Password, int organId, string IP, out ClsError Error);
        #endregion

        //TypeBime
        #region TypeBime
        [OperationContract]
        List<OBJ_TypeBime> GetTypeBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //ItemsEstekhdam_FiscalTitle
        #region ItemsEstekhdam_FiscalTitle
        [OperationContract]
        List<OBJ_ItemsEstekhdam_FiscalTitle> GetItemsEstekhdam_FiscalTitleWithFilter(string FieldName, string NoeEstekhdam, int FiscalHeaderId, int Top, string IP, out ClsError Error);
        #endregion

        //Status
        #region Status
        [OperationContract]
        List<OBJ_Status> GetStatusWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //PersonalStatus
        #region PersonalStatus
        [OperationContract]
        OBJ_PersonalStatus GetPersonalStatusDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PersonalStatus> GetPersonalStatusWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPersonalStatus(int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePersonalStatus(int Id, int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeletePersonalStatus(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion
        
    }
}
