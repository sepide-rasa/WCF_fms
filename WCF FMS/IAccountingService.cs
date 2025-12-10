using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Accounting;
using WCF_FMS.TOL.Archive;

using WCF_FMS.TOL.Contract;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccountingService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IAccountingService
    {
        //AccountingType
        #region AccountingType
        [OperationContract]
        OBJ_AccountingType GetAccountingTypeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AccountingType> GetAccountingTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAccountingType(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAccountingType(int Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAccountingType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CenterCost
        #region CenterCost
        [OperationContract]
        OBJ_CenterCost GetCenterCostDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CenterCost> GetCenterCostWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCenterCost(string NameCenter, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCenterCost(int Id, string NameCenter, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCenterCost(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePID_Cost_Tree(int Cost_TreeId, int Parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        int IsCostCenter(int CodingId, string IP, out ClsError Error);
        #endregion

        //AccountingLevel
        #region AccountingLevel
        [OperationContract]
        OBJ_AccountingLevel GetAccountingLevelDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AccountingLevel> GetAccountingLevelWithFilter(string FieldName, string FilterValue,string value2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAccountingLevel(string Name,short Year, int ArghamNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAccountingLevel(int Id,string Name, short Year, int ArghamNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAccountingLevel(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AccountingLevel> SelectAccountingLevel(short Year, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string AccountingLevelDelete(short Year, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AccountingLevel> CheckAccountingLevel(int AccountingTypeId, int OrganPostId, short Year, string IP, out ClsError Error);
        #endregion

        //GroupCenterCost
        #region GroupCenterCost
        [OperationContract]
        OBJ_GroupCenterCost GetGroupCenterCostDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GroupCenterCost> GetGroupCenterCostWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGroupCenterCost(string NameGroup, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGroupCenterCost(int Id, string NameGroup, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGroupCenterCost(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Tree_CenterCost
        #region Tree_CenterCost
        [OperationContract]
        string InsertTree_CenterCost(int CenterCoId, int CostTreeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TreeCenterCost
        #region TreeCenterCost
        [OperationContract]
        OBJ_TreeCenterCost GetTreeCenterCostDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TreeCenterCost> GetTreeCenterCostWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTreeCenterCost(string Name, int? PID, int GroupCenterCoId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTreeCenterCost(int Id, string Name, int GroupCenterCoId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTreeCenterCost(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePID_CostCenter(int Child, int Parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Centerco_TarifNashodeh
        #region Centerco_TarifNashodeh
        [OperationContract]
        List<OBJ_Centerco_TarifNashodeh> GetCenterco_TarifNashodeh(int GroupCenterCoId, string IP, out ClsError Error);
        #endregion

        //TemplateCoding
        #region TemplateCoding
        [OperationContract]
        OBJ_TemplateCoding GetTemplateCodingDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TemplateCoding> GetTemplateCodingWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int HeaderCodingId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTemplateCoding(Nullable<int> PID, Nullable<int> ItemId, string Name, string PCod, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId, Boolean? AddChildNode, string CodeBudget, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTemplateCoding(int Id, Nullable<int> ItemId, string Name, int MahiyatId,int? Mahiyat_GardeshId, string Code, int TempNameId, int LevelsAccountTypId, byte fldTypeHesabId, Boolean? AddChildNode, string CodeBudget, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTemplateCoding(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        int CheckValidCode(int AccountTypId, string Code, string PCod, int Id, int TempNameId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TemplateCoding> GetDefaultCode(int AccountTypId, string PCod, int TempNameId, string IP, out ClsError Error);
        #endregion

        //ItemNecessary
        #region ItemNecessary
        [OperationContract]
        OBJ_ItemNecessary GetItemNecessaryDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ItemNecessary> GetItemNecessaryWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertItemNecessary(Nullable<int> PID, string NameItem, int MahiyatId, int? Mahiyat_GardeshId, byte fldTypeHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateItemNecessary(int Id, string NameItem, int MahiyatId, int? Mahiyat_GardeshId, byte fldTypeHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteItemNecessary(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePID_ItemNecessary(int ChildId, int ParentId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TemplateName
        #region TemplateName
        [OperationContract]
        OBJ_TemplateName GetTemplateNameDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TemplateName> GetTemplateNameWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTemplateName(string Name, int AccountingTypeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTemplateName(int Id, string Name, int AccountingTypeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTemplateName(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Mahiyat
        #region Mahiyat
        [OperationContract]
        List<OBJ_Mahiyat> GetMahiyatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //LevelsAccountingType
        #region LevelsAccountingType
        [OperationContract]
        OBJ_LevelsAccountingType GetLevelsAccountingTypeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LevelsAccountingType> GetLevelsAccountingTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLevelsAccountingType(string Name, int AccountTypeId, int ArghumNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLevelsAccountingType(int Id, string Name, int AccountTypeId, int ArghumNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLevelsAccountingType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LevelsAccountingType> selectAccountingTypeLevel(int AccountTypeId, string IP, out ClsError Error);
        #endregion

        //DocumentDesc
        #region DocumentDesc
        [OperationContract]
        OBJ_DocumentDesc GetDocumentDescDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentDesc> GetDocumentDescWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDocumentDesc(string Name, string DocDesc, bool flag, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDocumentDesc(int Id, string Name, string DocDesc, bool flag, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentDesc(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParamDocumentDesc> GetParamDocumentDesc(string DocDesc, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Details> SelectEkhtetamiye(int FiscalYearId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Details> SelectBastanHesabha(int FiscalYearId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Details> SelectHesabDaryaftani(string FieldName,int FiscalYearId, int ShomareHesabId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Details> SelectEftetahiye(int FiscalYearId, string IP, out ClsError Error);
        #endregion


        //CaseType
        #region CaseType
        [OperationContract]
        OBJ_CaseType GetCaseTypeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CaseType> GetCaseTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCaseType(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCaseType(int Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCaseType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Coding_Header
        #region Coding_Header
        [OperationContract]
         OBJ_Coding_Header GetCoding_HeaderDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Coding_Header> GetCoding_HeaderWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCoding_Header( short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCoding_Header(int Id, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCoding_Header(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string CopyFromTemplateCodingToCoding(int HeaderId, int TempNameId,System.Data.DataTable IncomeCodes, int OrganId, string IP, string Username, string Password, out ClsError Error);
        #endregion

        //Coding_Details
        #region Coding_Details
        [OperationContract]
        OBJ_Coding_Details GetCoding_DetailsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        int GetItemId(int HeaderId, int PId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Coding_Details> GetCoding_DetailsWithFilter(string FieldName, string FilterValue, string FilterValue2,string FilterValue3, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCoding_Details(int HeaderId, Nullable<int> PID, string PCod, int? TempCodingId, string Title, string Code, string CodeDaramad, int AccountLevelId, int MahiyatId,int? Mahiyat_GardeshId, byte TypeHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCoding_Details(int Id, int HeaderId, int? TempCodingId, string Title, string Code, string CodeDaramad, int AccountLevelId, int MahiyatId,int? Mahiyat_GardeshId, byte TypeHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCoding_Details(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Coding_Details> GetDefaultCode_Coding(int HeaderId, string PCode, string IP, out ClsError Error);
        [OperationContract]
        int CheckValidCode_CodingDetail(int HeaderId, string Code, string PCode, int Id, string IP, out ClsError Error);
        [OperationContract]
        OBJ_RptByCoding GetRptByCoding(int CodingId, int OrganId, short Year,byte ModuleId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Coding_ProjeFaaliat> SelectCoding_Project(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
       [OperationContract]
        List<OBJ_CheckMahiyatGardesh_Mande> CheckMahiyatGardesh_Mande(int Id, int organid, short year, long bed, long best, int idDetail, int moduleSaveId, string IP, out ClsError Error);
        #endregion

        //DocumentRecord_Header
        #region DocumentRecord_Header
        [OperationContract]
        OBJ_DocumentRecord_Header GetDocumentRecord_HeaderDetail(int Id, int OrganId, short Year, int Madule, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Header> GetDocumentRecord_HeaderWithFilter(string FieldName, string FilterValue, string value2, string value3, int OrganId, short Year, int Madule, byte OrderType, int Top, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Header> SelectMortabet(int HeaderId, int MaduleSaveId, string IP, out ClsError Error);
        [OperationContract]
        int InsertDocumentRecord_Header(int DocumentNum, string ArchiveNum, string DescriptionDocu, string TarikhDocument, byte Accept, byte Type, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDocumentRecord_Header(int Id, string ArchiveNum, string DescriptionDocu, string TarikhDocument, byte Accept, byte Type, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentRecord_Header(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Header> GetLastNum_AtfDocumentRecord(short Year, int OrganId, int ModuleDocId, string IP, out ClsError Error);
        [OperationContract]
        int InsertDocument(string ArchiveNum, string DescriptionDocu, string TarikhDocument, byte Accept, byte Type, System.Data.DataTable detail, int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldFiscalYearId, int fldTypeSanad, int? fldPid,byte? fldEdit, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDocument(int fldHeaderId, int DocumentNum, string ArchiveNum, string DescriptionDocu, string TarikhDocument, byte Accept, byte Type, System.Data.DataTable detail, int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldTypeSanad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertDocumentFishDaramad(int FiscalYearId, int FishId, int ModuleSaveId, int ModuleErsalId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoratabSaziTarikhSanad(short Year, int moduleId, int OrganId, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGhati(int fldHeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DisableGhati(int fldHeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateArchive_FareiNum(int fldHeaderId, string ArchiveNum, int FareiNum, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        bool CheckDocStatus(int DocHeaderId, string IP, out int Id, out ClsError Error);
        [OperationContract]
        string Document_CopyInsert(int DocHeaderId, int OrganId, byte ModuleErsalId, byte ModuleSaveId, byte Type, string TarikhDocument, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //DocumentRecord_Details
        #region DocumentRecord_Details
        [OperationContract] 
        OBJ_DocumentRecord_Details GetDocumentRecord_DetailsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecord_Details> GetDocumentRecord_DetailsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocFiles> GetDocFiles(short Year, int OrganId, int CodingId, string IP, out ClsError Error);
        //[OperationContract]
        //string InsertDocumentRecord_Details(int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseTypeId, int SourceId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //string UpdateDocumentRecord_Details(int Id, int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseId, int CaseTypeId, int SourceId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentRecord_Details(string FieldName, int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentDetail(int HeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Case
        #region Case
        [OperationContract]
        OBJ_Case GetCaseDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Case> GetCaseWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCase(int CaseTypeId, int SourceId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCase(int Id, int CaseTypeId, int SourceId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCase(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        #region ParvandeInfo
        [OperationContract]
        List<OBJ_ParvandeInfo> GetParvandeInfo(string FieldName, string FilterValue, byte ParvandeType, int OrganId, short Year, int Top, string IP, out ClsError Error);
        #endregion

        //FiscalYear
        #region FiscalYear
        [OperationContract]
        OBJ_FiscalYear GetFiscalYearDetail(int Id,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FiscalYear> GetFiscalYearWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFiscalYear(short fldYear, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFiscalYear(int Id, short fldYear, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFiscalYear(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //RptCodingStatus
        #region RptCodingStatus
        [OperationContract]
        List<OBJ_RptCodingStatus> RptCodingStatus(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId,byte Type, string IP, out ClsError Error);
        #endregion
        #region RptCodingTurnover_Tarikh
        [OperationContract]
        List<OBJ_RptCodingTurnover> RptCodingTurnover_Tarikh(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId,
            string IP, string AzTarikh, string TaTarikh, out ClsError Error);
        #endregion
        #region RptCodingStatus_Parvande
        [OperationContract]
        List<OBJ_RptCodingStatus> RptCodingStatus_Parvande(int CodingDetailId, byte flag, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId, byte Type, string IP, out ClsError Error);
        #endregion

        //RptCodingTurnover
        #region RptCodingTurnover
        [OperationContract]
        List<OBJ_RptCodingTurnover> RptCodingTurnover(int CodingDetailId, int CaseTypeId, int SourceId, short Year, int OrganId, int moduleSaveId, string IP, out ClsError Error);
        #endregion

        //TypeHesab
        #region TypeHesab
        [OperationContract]
        OBJ_TypeHesab GetTypeHesabDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TypeHesab> GetTypeHesabWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion


        //DocumentType
        #region DocumentType
        [OperationContract]
        List<OBJ_DocumentType> GetDocumentTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //DocumentRecorde_File
        #region DocumentRecorde_File
        [OperationContract]
        OBJ_DocumentRecorde_File GetDocumentRecorde_FileDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecorde_File> GetDocumentRecorde_FileWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDocumentRecorde_File(int DocumentHeaderId, byte[] Image, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentRecorde_File(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DocumentBookMark
        #region DocumentBookMark
        [OperationContract]
        OBJ_DocumentBookMark GetDocumentBookMarkDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentBookMark> GetDocumentBookMarkWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDocumentBookMark(int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDocumentBookMark(int Id, int fldDocumentRecordeId, int fldArchiveTreeId, int fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDocumentBookMark(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertDocumentRecorde_File_BookMark(int fldDocumentRecordeId, string Desc, System.Data.DataTable tblRecorde_File, string fldDocumentRecordeId_Del, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DocumentRecorde_File_BookMark> SelectDocumentRecorde_File_BookMark(string FieldName, int DocumentHeaderId,int ArchiveTreeId, string IP, out ClsError Error);
        [OperationContract]

        OBJ_ArchiveTree SelectBookmarkPath(int DocumentHeaderId, string IP, out ClsError Error);
        #endregion

        //
        #region MyRegion
        [OperationContract]
        List<OBJ_CheckRemain> CheckRemain(int Coding_DetailsId, int id, long Bedehkar, long Bestankar, int OrganId, short Year, int MaduleSaveId, string IP, out ClsError Error);
        #endregion

        #region CopyDocumentWithHeaderId
        [OperationContract]
        string CopyDocumentWithHeaderId(int DocHeaderId, int OrganId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //CodingDetail_CaseType
        #region GetCodingDetail_CaseTypeDetail
        [OperationContract]
        OBJ_CodingDetail_CaseType GetCodingDetail_CaseTypeDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetCodingDetail_CaseTypeWithFilter
        [OperationContract]
        List<OBJ_CodingDetail_CaseType> GetCodingDetail_CaseTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertCodingDetail_CaseType
        [OperationContract]
        string InsertCodingDetail_CaseType(int fldCodingDetailId, int fldCaseTypeId, string Username, string Password, int OrganId, string IP, out ClsError Error);
         #endregion
        #region UpdateCodingDetail_CaseType
        [OperationContract]
        string UpdateCodingDetail_CaseType(int Id, int fldCodingDetailId, int fldCaseTypeId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteCodingDetail_CaseType
        [OperationContract]
        string DeleteCodingDetail_CaseType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BankTemplate_Header
        #region GetBankTemplate_HeaderDetail
        [OperationContract]
        OBJ_BankTemplate_Header GetBankTemplate_HeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetBankTemplate_HeaderWithFilter
        [OperationContract]
        List<OBJ_BankTemplate_Header> GetBankTemplate_HeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertBankTemplate
        [OperationContract]
        string InsertBankTemplate(string NamePattern, short StartRow,byte[] fldImage, string fldPasvand, System.Data.DataTable Details, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateBankTemplate
        [OperationContract]
        string UpdateBankTemplate(int Id, string NamePattern, short StartRow,int? fldFileId,byte[] fldImage, string fldPasvand, System.Data.DataTable Details, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteBankTemplate
        [OperationContract]
        string DeleteBankTemplate(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BankBill_Header
        #region GetBankBill_HeaderDetail
        [OperationContract]
        OBJ_BankBillHeader GetBankBill_HeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetBankBill_HeaderWithFilter
        [OperationContract]
        List<OBJ_BankBillHeader> GetBankBill_HeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region CheckCountData
        [OperationContract]
        bool? CheckCountData(int HeaderId, string IP, out ClsError Error);
        #endregion
        #region SelectMoghayeratBanki
        [OperationContract]
        List<OBJ_MoghayeratBanki> SelectMoghayeratBanki(string FieldName, int FiscalYearId, string AzTarikh, string TaTarikh,int ShomareHesabId, string IP, out ClsError Error);
        #endregion
        #region InsertBankBill
        [OperationContract]
        int InsertBankBill(string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, string IP, string Desc, string Username, string Password, int OrganId, out ClsError Error);
        #endregion
        #region UpdateBankBill
        [OperationContract]
        string UpdateBankBill(int Id, string fldName, int fldPatternId, int fldShomareHesabId, int fldFiscalYearId, string fldJsonFile, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteBankBill
        [OperationContract]
        string DeleteBankBill(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BankBill_Detials
        #region GetBankBill_DetailsDetail
        [OperationContract]
        OBJ_BankBillDetails GetBankBill_DetailsDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetBankBill_DetailsWithFilter
        [OperationContract]
        List<OBJ_BankBillDetails> GetBankBill_DetailsWithFilter(string FieldName, string FilterValue, string FilterValue2,int Top, string IP, out ClsError Error);
        #endregion
        #region SelectBankBill_Tarikh
        [OperationContract]
        OBJ_BankBill_Tarikh SelectBankBill_Tarikh(int FiscalYearId,int shomareHesabId, string IP, out ClsError Error);
        #endregion
        #region BankBillMap
        [OperationContract]
        string BankBillMap(int BankBillId, int Document_HeaderId,byte Type,string SourceIds, string IP, string Desc, string Username, string Password, out ClsError Error);
        #endregion

        #region RptDafater
        [OperationContract]
        List<OBJ_Dafater> RptDafater(string AzCode, string TaCode, int AzSanad, int TaSanad, byte Group, int FiscalYearId,int CaseTypeId,int SourceId, string IP, out ClsError Error);
        #endregion
         
    }
}
