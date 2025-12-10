using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBudgetService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IBudgetService
    {
        //EtebarType
        #region EtebarType
        [OperationContract]
        List<OBJ_EtebarType> GetEtebarTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //MasrafType
        #region MasrafType
        [OperationContract]
        List<OBJ_MasrafType> GetMasrafTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Mamoriyat
        #region Mamoriyat
        [OperationContract]
        OBJ_Mamoriyat GetMamoriyatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mamoriyat> GetMamoriyatWithFilter(string FieldName, string FilterValue, string FilterValue2, short Year, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMamoriyat(string Code,string Title,short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMamoriyat(int Id, string Code, string Title, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMamoriyat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Program
        #region Program
        [OperationContract]
        OBJ_Program GetProgramDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Program> GetProgramWithFilter(string FieldName, string FilterValue, string FilterValue2, short Year, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertProgram(int MamoriyatId, string Code, string Title, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateProgram(int Id, int MamoriyatId, string Code, string Title, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteProgram(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Tarh_Khedmat
        #region Tarh_Khedmat
        [OperationContract]
        OBJ_Tarh_Khedmat GetTarh_KhedmatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Tarh_Khedmat> GetTarh_KhedmatWithFilter(string FieldName, string FilterValue, string FilterValue2, short Year, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTarh_Khedmat(int ProgramId, string Code, string Title, byte Type, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTarh_Khedmat(int Id, int ProgramId, string Code, string Title, byte Type, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTarh_Khedmat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Project_Faaliyat
        //#region Project_Faaliyat
        //[OperationContract]
        //OBJ_Project_Faaliyat GetProject_FaaliyatDetail(int Id, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //List<OBJ_Project_Faaliyat> GetProject_FaaliyatWithFilter(string FieldName, string FilterValue, string FilterValue2, short Year, int OrganId, int Top, string IP, out ClsError Error);
        //[OperationContract]
        //string InsertProject_Faaliyat(int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //string UpdateProject_Faaliyat(int Id, int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //string DeleteProject_Faaliyat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //#endregion

        //Project_Details
        #region Project_Details
        [OperationContract]
        OBJ_Project_Details GetProject_DetailsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Project_Details> GetProject_DetailsWithFilter(string FieldName, string FilterValue, short Year, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertProject_Details(int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateProject_Details(int Id, int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteProject_Details(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TemplatCoding
        #region TemplatCoding
        [OperationContract]
        OBJ_TemplatCoding GetTemplatCodingDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TemplatCoding> GetTemplatCodingWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTemplatCoding(int? PID, string fldName, string fldPCod, int fldTemplatNameId, string fldCode, int fldCodingLevelId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTemplatCoding(int Id, string fldName, int fldTemplatNameId, string fldCode, int fldCodingLevelId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTemplatCoding(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

       

        ////CodingBudje
        //#region CodingBudje
        //[OperationContract]
        //OBJ_CodingBudje GetCodingBudjeDetail(int Id, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //List<OBJ_CodingBudje> GetCodingBudjeWithFilter(string FieldName, string FilterValue, string FilterValue1, int OrganId, int Top, string IP, out ClsError Error);
        //[OperationContract]
        //string InsertCodingBudje(int? PID, int fldTemplateCodingId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //string UpdateCodingBudje(int Id, int fldTemplateCodingId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        //string DeleteCodingBudje(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //#endregion

        //CodingLevel

        #region CodingLevel
        [OperationContract]
        OBJ_CodingLevel GetCodingLevelDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodingLevel> GetCodingLevelWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCodingLevel(string fldName, int fldFiscalBudjeId, int fldArghamNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodingLevel(int Id, string fldName, int fldFiscalBudjeId, int fldArghamNum, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodingLevel(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_BudjeLevel> GetBudjeLevel(short Year, int OrganId, string IP, out ClsError Error);
        #endregion

        //TemplatName
        #region TemplatName
        [OperationContract]
        OBJ_TemplatName GetTemplatNameDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TemplatName> GetTemplatNameWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTemplatName(string fldName,  string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTemplatName(int Id, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTemplatName(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetDefaultCodeBudje
        #region GetDefaultCodeBudje
        [OperationContract]
        List<OBJ_DefaultCode> GetDefaultCodeBudje(string PCode, int TempNameId, string IP, out ClsError Error);
        #endregion

        //CheckValidCodeBudje
        #region CheckValidCodeBudje
        [OperationContract]
        List<OBJ_CheckValidCodeBudje> CheckValidCodeBudje(string Code, string PCode, int fldId, int TempNameId, string IP, out ClsError Error);
        #endregion


        //CodingBudje_Header
        #region CodingBudje_Header
        [OperationContract]
        OBJ_CodingBudje_Header GetCodingBudje_HeaderDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodingBudje_Header> GetCodingBudje_HeaderWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertCodingBudje_Header(short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodingBudje_Header(int Id, short Year, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodingBudje_Header(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CodingBudje_Detail
        #region CodingBudje_Detail
        [OperationContract]
        OBJ_CodingBudje_Detail GetCodingBudje_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodingBudje_Detail> GetCodingBudje_DetailWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCodingBudje_Detail(int? PID, int HeaderId, string Title, string BudCode, byte? fldKhedmat_Tarh, byte? fldEtebarTypeId, byte? fldTypeMasrafId,int fldCodeingLevelId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodingBudje_Detail(int Id, int HeaderId, string Title, string BudCode, byte? fldKhedmat_Tarh, byte? fldEtebarTypeId, byte? fldTypeMasrafId,int fldCodeingLevelId,string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodingBudje_Detail(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string CopyFromTemplateCodingToCodingBudje(int HeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string CopyCodingDetail(int HeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        #region CheckValidCode_CodingDetailBudje
        [OperationContract]
        List<OBJ_CheckValidCodeBudje> CheckValidCode_CodingDetailBudje(string Code, string PCode, int fldId, int HeaderId, string IP, out ClsError Error);
        #endregion
        #region GetDefaultCode_CodingBudje
        [OperationContract]
        List<OBJ_DefaultCode> GetDefaultCode_CodingBudje(string PCode, int HeaderId, string IP, out ClsError Error);
        #endregion

        //CodingTarh_Khedmat
        #region CodingTarh_Khedmat
        [OperationContract]
        List<OBJ_CodingTarh_Khedmat> GetCodingTarh_KhedmatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Anticipation
        #region Anticipation
        [OperationContract]
        OBJ_Anticipation GetAnticipationDetail(int Id,  string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Anticipation> GetAnticipationWithFilter(string FieldName, string FilterValue,string FilterValue2,  int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnticipation(int fldCodingAccId, int? fldCodingBudId, System.Data.DataTable Pishbini, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnticipation(int Id, int? fldCodingAccId, int? fldCodingBudId, long fldMablagh, int fldTypeBudgetId, int? MotamamId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnticipation(string FieldName, int AccCodingId, int BudgetCodingId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TaahodatSanavati
        #region TaahodatSanavati
        [OperationContract]
        OBJ_TaahodatSanavati GetTaahodatSanavatiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TaahodatSanavati> GetTaahodatSanavatiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTaahodatSanavati(long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, int fldFiscalYearId,
            string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTaahodatSanavati(int Id, long fldD1, long fldD2, long fldD3, long fldH1, long fldH2, long fldH3, long fldH4, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BudgetType
        #region BudgetType
        [OperationContract]
        List<OBJ_BudgetType> GetBudgetTypeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion


        //PishbiniBudje
        #region SelectPishbiniBudje
        [OperationContract]
        List<OBJ_Pishbini_Daramad> SelectPishbiniBudje(string fieldName, string Year, int? MotamamId, int organId, string IP, out ClsError Error);
        #endregion
        #region SelectPishbiniBudje_SalGhabl
        [OperationContract]
        List<OBJ_Pishbini_Daramad> SelectPishbiniBudje_SalGhabl(string fieldName, string Year, int? MotamamId, int organId, string IP, out ClsError Error);
        #endregion
        #region SelectCodingAccNotBudje
        [OperationContract]
         List<OBJ_SelectCodingAccNotBudje> SelectCodingAccNotBudje(string fieldName, string aztarikh, string tatarikh, byte? salmaliID, byte? organId, int? azsanad, int? tasanad, byte? sanadtype, string IP, out ClsError Error);
        #endregion
        #region SelectTashimDaramadCode
        [OperationContract]
        List<OBJ_CodehayeDaramad_Tas_him> SelectTashimDaramadCode(short Year, int OrganId, string IP, out ClsError Error);
         #endregion
        #region SelectTashimDaramadCode
        [OperationContract]
        List<OBJ_CodingBudje_Detail> CheckPishbiniBudje(short Year, string IP, out ClsError Error);
        #endregion
        #region InsertTas_him
        [OperationContract]
        string InsertTas_him(int fldCodingId, string Type_TypeId, decimal percentHazine, decimal percentTamalok, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region CopytoMosavab
        [OperationContract]
        string CopytoMosavab(short Year, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        //Budje_khedmatDarsadId
        #region GetBudje_khedmatDarsadIdDetail
        [OperationContract]
         OBJ_Budje_khedmatDarsadId GetBudje_khedmatDarsadIdDetail(int Id,  string IP, out ClsError Error);
            
        [OperationContract]
         List<OBJ_Budje_khedmatDarsadId> GetBudje_khedmatDarsadIdWithFilter(string FieldName, string FilterValue,  int Top, string IP, out ClsError Error);
        [OperationContract]
         string InsertBudje_khedmatDarsadId(int fldCodingAcc_detailId, int? fldCodingBudje_DetailsId,double fldDarsad,System.Data.DataTable Pishbini, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertOnlyKhedmat(int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, double fldDarsad, string Username, string Password, int OrganId, string IP, out ClsError Error);
        //[OperationContract]
        // string UpdateBudje_khedmatDarsadId(int Id, int fldCodingAcc_detailId, int fldCodingBudje_DetailsId, double fldDarsad, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteBudje_khedmatDarsadId(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
           #endregion

        //Motammam
        #region GetMotammamDetail
         [OperationContract]
         OBJ_Motammam GetMotammamDetail(int Id, int OrganId, string IP, out ClsError Error);
        #endregion
        #region GetMotammamWithFilter
         [OperationContract]
         List<OBJ_Motammam> GetMotammamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMotammam
         [OperationContract]
         string InsertMotammam(int fldFiscalYearId, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMotammam
         [OperationContract]
         string UpdateMotammam(int Id, int fldFiscalYearId, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMotammam
         [OperationContract]
         string DeleteMotammam(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        [OperationContract]
         List<OBJ_Pishbini_Daramad> SelectProjectCoding(int fldBudgetCodingId, string IP, out ClsError Error);
    }
}
