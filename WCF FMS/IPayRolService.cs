using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPayRolService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IPayRolService
    {
        //MaxBime
        #region MaxBime
        [OperationContract]
        List<OBJ_MaxBime> GetMaxBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //RptMaliyatSaliyane
        #region GetRptMaliyatSaliyane
        [OperationContract]
        List<OBJ_RptMaliyatSaliyane> GetRptMaliyatSaliyane(int PersonId, short Year, byte Month, int OrganId, byte type, int UserId, string IP, out ClsError Error);
        #endregion
        #region GetRptEkhtelafMaliyatBaDaraei
        [OperationContract]
        List<OBJ_RptEkhtelafMaliyatBaDaraei> GetRptEkhtelafMaliyatBaDaraei(short Year, byte Month, byte nobatPardakht, int OrganId, string IP, out ClsError Error);
        #endregion


        //OnAccount
        #region OnAccount
        [OperationContract]
        List<OBJ_OnAccount> GetOnAccountWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, string FilterValue4, int OrganId, int Top, string IP, out ClsError Error);
        #endregion


        //Parametrs
       #region Parametrs
        [OperationContract]
        OBJ_Parametrs GetParametrsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Parametrs> GetParametrsWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametrs(string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametrs(int Id, string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametrs(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MaliyatDaraei
        #region MaliyatDaraei
        [OperationContract]
        string UpdateMaliyatDaraei(short fldYear, byte fldMonth, byte fldNobatePardakht, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMaliyatDaraei(short fldYear, byte fldMonth, byte fldNobatePardakht, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CostCenter
        #region CostCenter
        [OperationContract]
        OBJ_CostCenter GetCostCenterDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CostCenter> GetCostCenterWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCostCenter(string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCostCenter(int Id, string Title, int ReportTypeId, int TypeOfCostCenterId, int EmploymentCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCostCenter(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AfradTahtePoosheshSelect_FromExcel
        #region AfradTahtePoosheshSelect_FromExcel 
        [OperationContract]
        List<OBJ_AfradTahtePoosheshSelect_FromExcel> GetAfradTahtePoosheshSelect_FromExcelWithFilter(string CodeMeli, int GharardadBimeId, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //AfradeTahtePoshesheBimeTakmily
        #region AfradeTahtePoshesheBimeTakmily
        [OperationContract]
        OBJ_AfradeTahtePoshesheBimeTakmily GetAfradeTahtePoshesheBimeTakmilyDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AfradeTahtePoshesheBimeTakmily> GetAfradeTahtePoshesheBimeTakmilyWithFilter(string FieldName, string FilterValue, int PersonalId, short sal, byte mah, byte nobat, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAfradeTahtePoshesheBimeTakmily(int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAfradeTahtePoshesheBimeTakmily(int Id, int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string CopyAfradeTahtePoshesheBimeTakmily(int GHarardadBimeId_From, int GHarardadBimeId_To, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAfradeTahtePoshesheBimeTakmily(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AfradeTahtePoshesheBimeTakmily_Details
        #region AfradeTahtePoshesheBimeTakmily_Details
        [OperationContract]
        OBJ_AfradeTahtePoshesheBimeTakmily_Details GetAfradeTahtePoshesheBimeTakmily_DetailsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AfradeTahtePoshesheBimeTakmily_Details> GetAfradeTahtePoshesheBimeTakmily_DetailsWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAfradeTahtePoshesheBimeTakmily_Details(int AfradTahtePoshehsId, int BimeTakmiliId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAfradeTahtePoshesheBimeTakmily_Details(int Id, int AfradTahtePoshehsId, int BimeTakmiliId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAfradeTahtePoshesheBimeTakmily_Details(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        //EtelaatEydi
        #region EtelaatEydi
        [OperationContract]
        OBJ_EtelaatEydi GetEtelaatEydiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_EtelaatEydi> GetEtelaatEydiWithFilter(string FieldName, string FilterValue, int Id, short Year, byte NobatePardakht, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertEtelaatEydi(int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEtelaatEydi(int Id, int PersonalId, short Year, int DayCount, int Kosurat, byte NobatePardakht, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteEtelaatEydi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_EtelaatEydi> GetEtelaatEydiGroupWithFilter(string FieldName, short Sal, byte NobatPardakht, string Value, int OrganId, int CostCenter_Chart, string IP, out ClsError Error);
        #endregion

        //EzafeKari_TatilKari
        #region EzafeKari_TatilKari
        [OperationContract]
        OBJ_EzafeKari_TatilKari GetEzafeKari_TatilKariDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_EzafeKari_TatilKari> GetEzafeKari_TatilKariWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatePardakht, byte Type, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertEzafeKari_TatilKari(int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEzafeKari_TatilKari(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, decimal Count, byte Type, bool HasBime, bool HasMaliyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteEzafeKari_TatilKari(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_EzafeKari_TatilKari> GetEzafeKari_TatilKariGroupWithFilter(string FieldName, string Sal, string Mah, byte NobatePardakht, byte Type, int OrganId, int CostCenter_Chart, string IP, out ClsError Error);
        #endregion

        //Fiscal_Detail
        #region Fiscal_Detail
        [OperationContract]
        OBJ_Fiscal_Detail GetFiscal_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Fiscal_Detail> GetFiscal_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFiscal_Detail(int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFiscal_Detail(int Id, int FiscalHeaderId, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFiscal_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertFiscal_Header_Detail(string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFiscal_Header_Detail(int Id, string EffectiveDate, string DateOfIssue, int AmountFrom, int AmountTo, decimal PercentTaxOnWorkers, decimal TaxationOfEmployees, int Tax, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFiscal_Header_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Fiscal_Header
        #region Fiscal_Header
        [OperationContract]
        OBJ_Fiscal_Header GetFiscal_HeaderDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Fiscal_Header> GetFiscal_HeaderWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertFiscal_Header(string EffectiveDate, string DateOfIssue, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFiscal_Header(int Id, string EffectiveDate, string DateOfIssue, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFiscal_Header(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //FiscalTitle
        #region FiscalTitle
        [OperationContract]
        OBJ_FiscalTitle GetFiscalTitleDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FiscalTitle> GetFiscalTitleWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFiscalTitle(int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFiscalTitle(int Id, int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFiscalTitle(string FieldName, string FilterValue, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GHarardadBime
        #region GHarardadBime
        [OperationContract]
        OBJ_GHarardadBime GetGHarardadBimeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GHarardadBime> GetGHarardadBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGHarardadBime(string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGHarardadBime(int Id, string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGHarardadBime(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TypeOfCostCenters
        #region TypeOfCostCenters
        [OperationContract]
        OBJ_TypeOfCostCenters GetTypeOfCostCentersDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TypeOfCostCenters> GetTypeOfCostCentersWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTypeOfCostCenters(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTypeOfCostCenters(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTypeOfCostCenters(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InsuranceWorkshop
        #region InsuranceWorkshop
        [OperationContract]
        OBJ_InsuranceWorkshop GetInsuranceWorkshopDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InsuranceWorkshop> GetInsuranceWorkshopWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInsuranceWorkshop(string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInsuranceWorkshop(int Id, string WorkShopName, string EmployerName, string WorkShopNum, decimal Persent, string Address, string Peyman, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInsuranceWorkshop(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TypeOfEmploymentCenter
        #region TypeOfEmploymentCenter
        [OperationContract]
        OBJ_TypeOfEmploymentCenter GetTypeOfEmploymentCenterDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TypeOfEmploymentCenter> GetTypeOfEmploymentCenterWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTypeOfEmploymentCenter(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTypeOfEmploymentCenter(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTypeOfEmploymentCenter(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ReportType
        #region ReportType

        [OperationContract]
        List<OBJ_ReportType> GetReportTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        
        #endregion

        //KarKardeMahane
        #region KarKardeMahane
        [OperationContract]
        OBJ_KarKardeMahane GetKarKardeMahaneDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KarKardeMahane> GetKarKardeMahaneWithFilter(string FieldName, string FilterValue, string Year, string Month, byte NobatPardakht, int id, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertKarKardeMahane(int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKarKardeMahane(int Id, int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKarKardeMahane(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KarKardeMahane> GetKarKardeMahaneGroupWithFilter(string FieldName, string FilterValue, short Year, byte Month, byte NobatPardakht, int OrganId, string IP, out ClsError Error);
        #endregion

        //KarKardHokm
        #region KarKardHokm
        [OperationContract]
        OBJ_KarKardHokm GetKarKardHokmDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KarKardHokm> GetKarKardHokmWithFilter(string FieldName, string FilterValue, string FilterValue2, int KarkardId, decimal Roz, decimal Gheybat, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKarKardHokm(int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKarKardHokm(int fldId, int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKarKardHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
      
        #endregion

        //PayPersonalInfo
        #region PayPersonalInfo
        [OperationContract]
        OBJ_PayPersonalInfo GetPayPersonalInfoDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PayPersonalInfo> GetPayPersonalInfoWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPayPersonalInfo(int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int StatusId, string DateTaghirVaziyat, int? fldTarikhMazad30Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePayPersonalInfo(int Id, int Prs_PersonalInfoId, int TypeBimeId, string ShomareBime, bool BimeOmr, bool BimeTakmili, bool MashagheleSakhtVaZianAvar, int CostCenterId,
            bool Mazad30Sal, bool PasAndaz, bool SanavatPayanKhedmat, string JobeCode, int InsuranceWorkShopId, bool HamsarKarmand, bool MoafDarman, int? fldTarikhMazad30Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePayPersonalInfo(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KosorateParametri_Personal
        #region KosorateParametri_Personal
        [OperationContract]
        OBJ_KosorateParametri_Personal GetKosorateParametri_PersonalDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KosorateParametri_Personal> GetKosorateParametri_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKosorateParametri_Personal(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertGroupKosorateParametri_Personal(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        [OperationContract]
        string UpdateKosorateParametri_Personal(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhePardakht, bool SumFish, bool MondeFish
            , int SumPardakhtiGHabl, int MondeGHabl, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDeactiveKosorateParametri_Personal(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht
            , bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        [OperationContract]
        string DeleteKosorateParametri_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KosuratBank
        #region KosuratBank
        [OperationContract]
        OBJ_KosuratBank GetKosuratBankDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KosuratBank> GetKosuratBankWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKosuratBank(int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish, string ShomareSheba, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKosuratBank(int Id, int PersonalId, int ShobeId, int Mablagh, short Count, string TarikhPardakht, string ShomareHesab, bool Status, int DeactiveDate, int MandeAzGhabl, bool MandeDarFish, string ShomareSheba, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKosuratBank(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_RptKosouratBank> RptKosouratBank(byte NobatPardakhtId, short Year, byte Month, int CostCenterId, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion

        //SayerPardakhts
        #region SayerPardakhts
        [OperationContract]
        OBJ_SayerPardakhts GetSayerPardakhtsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SayerPardakhts> GetSayerPardakhtsWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSayerPardakhts(int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSayerPardakhts(int Id, int PersonalId, short Year, byte Month, int Amount, string Title, byte NobatePardakt, byte MarhalePardakht, bool HasMaliyat, int Maliyat, int KhalesPardakhti, int ShomareHesabId, int? CostCenterId, byte Mostamar, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSayerPardakhts(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Mamuriyat
        #region Mamuriyat
        [OperationContract]
        OBJ_Mamuriyat GetMamuriyatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mamuriyat> GetMamuriyatWithFilter(string FieldName, string FilterValue, int Id, short Year, byte Month, byte NobatPardakht, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMamuriyat(int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30,
            byte Be10, byte Be20, byte Be30, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMamuriyat(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, byte BaBeytute, byte BeduneBeytute, byte Ba10, byte Ba20, byte Ba30
            , byte Be10, byte Be20, byte Be30, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMamuriyat(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mamuriyat> GetMamuriyatGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart, string IP, out ClsError Error);
        #endregion

        //MandehPasAndaz
        #region MandehPasAndaz
        [OperationContract]
        OBJ_MandehPasAndaz GetMandehPasAndazDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MandehPasAndaz> GetMandehPasAndazWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMandehPasAndaz(int PersonalId, int Mablagh, string TarikhSabt, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMandehPasAndaz(int Id, int PersonalId, int Mablagh, string TarikhSabt, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMandehPasAndaz(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Moavaghat_Items
        #region Moavaghat_Items
        [OperationContract]
        OBJ_Moavaghat_Items GetMoavaghat_ItemsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Moavaghat_Items> GetMoavaghat_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoavaghat_Items(int MoavaghatId, int ItemEstekhdamId, int Mablagh, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoavaghat_Items(int Id, int MoavaghatId, int ItemEstekhdamId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoavaghat_Items(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Moavaghat
        #region Moavaghat
        [OperationContract]
        OBJ_Moavaghat GetMoavaghatDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Moavaghat> GetMoavaghatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertMoavaghat(int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
             , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int Maliyat, int? HokmId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoavaghat(int Id, int MohasebatId, short Year, byte Month, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman, int BimePersonal
             , int BimeKarFarma, int BimeBikari, int BimeMashaghel, int PasAndaz, int MashmolBime, int MashmolMaliyat, int Maliyat, int? HokmId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoavaghat(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Mohasebat
        #region Mohasebat
        [OperationContract]
        OBJ_Mohasebat GetMohasebatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat> GetMohasebatWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertMohasebat(int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
             int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat,
            int HaghDarman, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari,
            decimal DarsadBimeSakht, byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, bool Flag, int KhalesPardakhti
            , int Mogharari, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, int HokmId, byte T_Asli, byte T_70, byte T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? VamId, Nullable<int> TedadBime1, Nullable<int> TedadBime2, Nullable<int> TedadBime3, byte HesabTypeId, byte MaliyatType, short fldMeetingCount, byte fldCalcType, byte fldEstelagi, int fldOrganId, int fldShift, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat(int Id, int PersonalId, short Year, byte Month, byte Karkard, byte Gheybat, decimal TedadEzafeKar, decimal TedadTatilKar, byte BaBeytute, byte BedunBeytute,
            int BimeOmrKarFarma, int BimeOmr, int BimeTakmilyKarFarma, int BimeTakmily, int HaghDarmanKarfFarma, int HaghDarmanDolat, int HaghDarman
            , int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeMashaghel, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht,
            byte TedadNobatKari, int Mosaede, int NobatPardakht, int GhestVam, int PasAndaz, int MashmolBime, int MashmolMaliyat, bool Flag, int khalesPardakhti, int Mogharari,
            int Maliyat, int fldShift, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat(int Id,byte CalcType, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Mohasebat_Items
        #region Mohasebat_Items
        [OperationContract]
        OBJ_Mohasebat_Items GetMohasebat_ItemsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_Items> GetMohasebat_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_Items(int MohasebatId, int ItemEstekhdamId, int Mablagh, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId, byte fldCalcType, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_Items(int Id, int MohasebatId, int ItemEstekhdamId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_Items(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Mohasebat_kosorat_MotalebatParam
        #region Mohasebat_kosorat_MotalebatParam
        [OperationContract]
        OBJ_Mohasebat_kosorat_MotalebatParam GetMohasebat_kosorat_MotalebatParamDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_kosorat_MotalebatParam> GetMohasebat_kosorat_MotalebatParamWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_kosorat_MotalebatParam(int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_kosorat_MotalebatParam(int Id, int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_kosorat_MotalebatParam(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Mohasebat_KosoratBank
        #region Mohasebat_KosoratBank
        [OperationContract]
        OBJ_Mohasebat_KosoratBank GetMohasebat_KosoratBankDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_KosoratBank> GetMohasebat_KosoratBankWithFilter(string FieldName, string FilterValue,string IP, int Top, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_KosoratBank(int MohasebatId, int KosoratBankId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_KosoratBank(int Id, int MohasebatId, int KosoratBankId, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_KosoratBank(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //Morakhasi
        #region Morakhasi
        [OperationContract]
        OBJ_Morakhasi GetMorakhasiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Morakhasi> GetMorakhasiWithFilter(string FieldName, string FilterValue, int id, short Year, byte Month, byte NobatPardakht, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMorakhasi(int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMorakhasi(int Id, int PersonalId, short Year, byte Month, byte NobatePardakht, short SalAkharinHokm, int Tedad, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMorakhasi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Morakhasi> GetMorakhasiGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, int OrganId, int CostCenter_Chart, string IP, out ClsError Error);
        #endregion

        //Mohasebat_Mamuriyat
        #region Mohasebat_Mamuriyat
        [OperationContract]
        OBJ_Mohasebat_Mamuriyat GetMohasebat_MamuriyatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_Mamuriyat> GetMohasebat_MamuriyatWithFilter(string FieldName, string FilterValue, int OrganId, int Top,string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_Mamuriyat(int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_Mamuriyat(int Id, int PersonalId, short Year, byte Month, byte TedadBaBeytute, byte TedadBedunBeytute, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari,
            int BimeSakht, decimal DarsadBimePersonal, decimal DarsadBimeKarFarma, decimal DarsadBimeBiKari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat,
            int KhalesPardakhti, int Maliyat, int Tashilat, byte NobatePardakht, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_Mamuriyat(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //SayerPardakhtGroup
        #region SayerPardakhtGroup
        [OperationContract]

        List<OBJ_SayerPardakhtGroup> GetSayerPardakhtGroupWithFilter(string FieldName, short Year, byte Month, byte NobatPardakht, byte MarhalePardakht, int CostCenterId, int? BankId, byte Type, int OrganId, string IP, out ClsError Error);
        #endregion

        //ShomareHesabs
        #region ShomareHesabs
        [OperationContract]
        OBJ_ShomareHesabs GetShomareHesabsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabs> GetShomareHesabsWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomareHesabs(int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareHesabs(int Id, int PersonalId, int ShobeId, string ShomareHesab, string ShomareKart, bool TypeHesab, byte HesabTypeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomareHesabs(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabs> GetShomareHesabGroupWithFilter(bool NoeHesab, int BankId, int OrganId,string IP, out ClsError Error);
        #endregion

        //Setting
        #region Setting
        [OperationContract]
        List<OBJ_Setting> GetSettingWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSetting(int Id, int? H_BankFixId, string H_NameShobe, string H_CodeOrgan, string H_CodeShobe, bool ShowBankLogo, int fldOrganId, string CodeEghtesadi, int? Prs_PersonalId,
            string CodeParvande, string CodeOrganPasAndaz, int? Sh_HesabCheckId, int? B_BankFixId, string B_NameShobe, int? B_ShomareHesabId, string B_CodeShenasaee, string CodeDastgah, int? P_BankFixId, int P_ShobeId, string Desc, byte StatusMahalKedmatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //StatusMahalKedmat
        #region StatusMahalKedmat
        [OperationContract]
        List<OBJ_StatusMahalKedmat> GetStatusMahalKedmatWithFilter(string FieldName, string FilterValue,  int Top, string IP, out ClsError Error);
     #endregion

        //Vam
        #region Vam
        [OperationContract]
        OBJ_Vam GetVamDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Vam> GetVamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertVam(int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateVam(int Id, int PersonalId, string TarikhDaryaft, byte TypeVam, int MablaghVam, string StartDate, short Count, int Mablagh, int MandeVam, bool Status, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteVam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string VamStatusUpdate(int Id, bool Status, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Mohasebat_PersonalInfo
        #region Mohasebat_PersonalInfo
        [OperationContract]
        OBJ_Mohasebat_PersonalInfo GetMohasebat_PersonalInfoDetail(int Id, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_PersonalInfo> GetMohasebat_PersonalInfoWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_PersonalInfo(int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, byte? fldT_BedonePoshesh, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, int ChartOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_PersonalInfo(int Id, int? MohasebatId, int? VamId, int? Ezafe_TatilKariId, int? MamuriyatId, int? SayerPardakhthaId, int? CostCenterId, int? InsuranceWorkShopId, string CodeShoghliBime
            , int? TypeBimeId, int? AnvaEstekhdamId, int? FiscalHeaderId, int? MoteghayerHoghoghiId, int? ShomareHesabId, string ShomareBime, string ShPasAndazPersonal, string ShPasAndazKarFarma
            , int? HokmId, int? TedadBime1, int? TedadBime2, int? TedadBime3, byte? T_Asli, byte? T_70, byte? T_60, bool HamsareKarmand, bool Mazad30Sal, int? StatusIsargariId, int? MohasebatEydiId, int? KomakGheyerNaghdiId, int? MorakhasiId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_PersonalInfo(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //MohasebatEzafeKari_TatilKari
        #region MohasebatEzafeKari_TatilKari
        [OperationContract]
        OBJ_MohasebatEzafeKari_TatilKari GetMohasebatEzafeKari_TatilKariDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MohasebatEzafeKari_TatilKari> GetMohasebatEzafeKari_TatilKariWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebatEzafeKari_TatilKari(int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int fldMashmolBimeNaKhales, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int FiscalHeaderId, int MoteghayerHoghoghiId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebatEzafeKari_TatilKari(int Id, int PersonalId, short Year, byte Month, decimal Tedad, int Mablagh, int BimePersonal, int BimeKarFarma, int BimeBikari, int BimeSakht, decimal DarsadBimePersonal
            , decimal DarsadBimeKarFarma, decimal DarsadBimeBikari, decimal DarsadBimeSakht, int MashmolBime, int MashmolMaliyat, int NobatPardakht, byte Type, int KhalesPardakhti, int Maliyat, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebatEzafeKari_TatilKari(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //MotalebateParametri_Personal
        #region MotalebateParametri_Personal
        [OperationContract]
        OBJ_MotalebateParametri_Personal GetMotalebateParametri_PersonalDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MotalebateParametri_Personal> GetMotalebateParametri_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMotalebateParametri_Personal(int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertGroupMotalebateParametri_Personal(string PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMotalebateParametri_Personal(int Id, int PersonalId, int ParametrId, bool NoePardakht, int Mablagh, int Tedad, string TarikhPardakht, bool MashmoleBime, bool fldMazayaMashmool, bool MashmoleMaliyat, bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDeactiveMotalebateParametri_Personal(string PersonalId, int ParametrId, int Mablagh, string TarikhePardakht
            , bool Status, int DateDeactive, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        [OperationContract]
        string DeleteMotalebateParametri_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MoteghayerhayeEydi
        #region MoteghayerhayeEydi
        [OperationContract]
        OBJ_MoteghayerhayeEydi GetMoteghayerhayeEydiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhayeEydi> GetMoteghayerhayeEydiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoteghayerhayeEydi(short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoteghayerhayeEydi(int Id, short Year, int MaxEydiKarmand, int MaxEydiKargar, decimal ZaribEydiKargari, bool TypeMohasebatMaliyat, int MablaghMoafiatKarmand, int MablaghMoafiatKargar, decimal DarsadMaliyatKarmand, decimal DarsadMaliyatKargar, bool TypeMohasebe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoteghayerhayeEydi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MoteghayerhayeHoghoghi_Detail
        #region MoteghayerhayeHoghoghi_Detail
        [OperationContract]
        OBJ_MoteghayerhayeHoghoghi_Detail GetMoteghayerhayeHoghoghi_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhayeHoghoghi_Detail> GetMoteghayerhayeHoghoghi_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoteghayerhayeHoghoghi_Detail(int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, bool fldMazayaMashmool, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoteghayerhayeHoghoghi_Detail(int Id, int MoteghayerhayeHoghoghiId, int ItemEstekhdamId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoteghayerhayeHoghoghi_Detail(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MoteghayerhayeHoghoghi
        #region MoteghayerhayeHoghoghi
        [OperationContract]
        OBJ_MoteghayerhayeHoghoghi GetMoteghayerhayeHoghoghiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhayeHoghoghi> GetMoteghayerhayeHoghoghiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoteghayerhayeHoghoghi(string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, string ItemEstekhdam, bool FoghTalash, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoteghayerhayeHoghoghi(int Id, string TarikhEjra, string TarikhSodur, int AnvaeEstekhdamId, int TypeBimeId, int ZaribEzafeKar, decimal SaatKari, decimal DarsadBimePersonal, decimal DarsadbimeKarfarma, decimal DarsadBimeBikari, decimal DarsadBimeJanbazan, decimal HaghDarmanKarmand, decimal HaghDarmanKarfarma, decimal HaghDarmanDolat, int HaghDarmanMazad
            , int HaghDarmanTahteTakaffol, decimal DarsadBimeMashagheleZiyanAvar, int MaxHaghDarman, int ZaribHoghoghiSal, bool Hoghogh, bool FoghShoghl, bool TafavotTatbigh, bool FoghVizhe, bool HaghJazb, bool Tadil, bool BarJastegi, bool Sanavat, bool FoghTalash, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoteghayerhayeHoghoghi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string CopyMoteghayerhayHoghoghi(string TarikhEjra, string TarikhSodur, int headerId, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhayeHoghoghi> GetMoteghayerhayeHoghopghi_Zarib(int AnvaeEstekhdamId, int TypeBimeId, string TarikhEjra, string IP, out ClsError Error);
        #endregion

        //ParameteriItemsFormul
        #region ParameteriItemsFormul
        [OperationContract]
        OBJ_ParameteriItemsFormul GetParameteriItemsFormulDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParameteriItemsFormul> GetParameteriItemsFormulWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParameteriItemsFormul(int ParametrId, string Formul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParameteriItemsFormul(int Id, int ParametrId, string Formul, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParameteriItemsFormul(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //ShomareHesabPasAndaz
        #region ShomareHesabPasAndaz
        [OperationContract]
        OBJ_ShomareHesabPasAndaz GetShomareHesabPasAndazDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabPasAndaz> GetShomareHesabPasAndazWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomareHesabPasAndaz(int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareHesabPasAndaz(int Id, int ShomareHesabPersonalId, int? ShomareHesabKarfarmaId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomareHesabPasAndaz(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KosuratParametriGroup
        #region KosuratParametriGroup
        [OperationContract]
        List<OBJ_KosuratParametriGroup> GetKosuratParametriGroupWithFilter(string FieldName, string FilterValue, int OrganId, string IP, out ClsError Error);
        #endregion

        //MotalebatParametriGroup
        #region MotalebatParametriGroup
        [OperationContract]
        List<OBJ_MotalebatParametriGroup> GetMotalebatParametriGroupWithFilter(string FieldName, string FilterValue, int OrganId, string IP, out ClsError Error);
        #endregion


        //KarkardMahane_Detail
        #region KarkardMahane_Detail
        [OperationContract]
        OBJ_KarkardMahane_Detail GetKarkardMahane_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KarkardMahane_Detail> GetKarkardMahane_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKarkardMahane_Detail(int KarkardMahaneId, int Karkard, int KargahBimeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKarkardMahane_Detail(int Id, int KarkardMahaneId, int Karkard, int KargahBimeId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKarkardMahane_Detail(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KomakGheyerNaghdi
        #region KomakGheyerNaghdi
        [OperationContract]
        OBJ_KomakGheyerNaghdi GetKomakGheyerNaghdiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KomakGheyerNaghdi> GetKomakGheyerNaghdiWithFilter(string FieldName, string FilterValue, int id, int PersonalId, short Year, byte Month, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKomakGheyerNaghdi(int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKomakGheyerNaghdi(int Id, int PersonalId, short Year, byte Month, bool NoeMostamer, int Mablagh, int KhalesPardakhti, int Maliyat, int ShomareHesabId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKomakGheyerNaghdi(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KomakGheyerNaghdi> GetKomakGheyerNaghdiGroupWithFilter(string FieldName, byte Month, short Year, bool NoeMostamer, int PersonalId, int OrganId, int CostCenter_Chart, string IP, out ClsError Error);
        #endregion

        //Mohasebat_Eydi
        #region Mohasebat_Eydi
        [OperationContract]
        OBJ_Mohasebat_Eydi GetMohasebat_EydiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_Eydi> GetMohasebat_EydiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_Eydi(int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_Eydi(int Id, int PersonalId, short Year, byte Month, int DayCount, int Mablagh, int Maliyat, int Kosurat, int KhalesPardakhti, int NobatPardakht, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_Eydi(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //CalcMaliyatGheyerNaghdi
        #region CalcMaliyatGheyerNaghdi
        [OperationContract]
        List<OBJ_CalcMaliyatGheyerNaghdi> GetCalcMaliyatGheyerNaghdiWithFilter(string Year, int Mablagh, int TypeEstekhdam, string IP, out ClsError Error);
        #endregion

        //SumKomakGheyerNaghdi
        #region SumKomakGheyerNaghdi
        [OperationContract]
        List<OBJ_SumKomakGheyerNaghdi> GetSumKomakGheyerNaghdiWithFilter(int PersonalId, bool Type, byte Mah, short Year, string IP, out ClsError Error);
        #endregion

        //ItemsEstekhdam_MoteghayerHoghoghi
        #region ItemsEstekhdam_MoteghayerHoghoghi
        [OperationContract]
        List<OBJ_ItemsEstekhdam_MoteghayerHoghoghi> GetItemsEstekhdam_MoteghayerHoghoghiWithFilter(string FieldName, string NoeEstekhdam, int HeaderId, int Top, string IP, out ClsError Error);
        #endregion

        //Mohasebat_Morakhasi
        #region Mohasebat_Morakhasi
        [OperationContract]
        OBJ_Mohasebat_Morakhasi GetMohasebat_MorakhasiDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mohasebat_Morakhasi> GetMohasebat_MorakhasiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohasebat_Morakhasi(int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, byte HesabTypeId, int fldOrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohasebat_Morakhasi(int Id, int PersonalId, byte Tedad, int Mablagh, byte Month, short Year, byte NobatPardakht, short SalHokm, int HokmId, int CostCenterId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohasebat_Morakhasi(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //PersonalInfo_Mohasebe
        #region PersonalInfo_Mohasebe
        [OperationContract]
        List<OBJ_PersonalInfo_Mohasebe> GetPersonalInfo_MohasebeWithFilter(string FieldName, short Year, byte Month, byte NobatePardakht, byte Type, byte Ezafe_Tatil, int OrganId, string CostCenterId, string AnvaEstekhdamId, string Tarikh, byte CalcType, string IP, out ClsError Error);
        #endregion

        //TabJobOfBime
        #region TabJobOfBime
        [OperationContract]
        List<OBJ_TabJobOfBime> GetTabJobOfBimeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //Disket
        #region Disket
        [OperationContract]
        OBJ_Disket GetDisketDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Disket> GetDisketWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertDisket(string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, byte[] File, string Pasvand, string NameFile, int BankFixId, string NameShobe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDisket(int Id, string Tarikh, int Tedad, bool Type, long? Jam, byte TypePardakht, string ShobeCode, string OrganCode, int FielId, byte[] File, string Pasvand, string NameFile, int BankFixId, string NameShobe, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDisket(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectVariziForBank
        #region SelectVariziForBank
        [OperationContract]
        List<OBJ_SelectVariziForBank> GetSelectVariziForBank(string FieldName,string Value, short Year, byte Mah, byte NobatePardakht, byte MarhalePardakht, int OrganId, string IP, out ClsError Error);
        #endregion

        //MaliyatManfi
        #region MaliyatManfi
        [OperationContract]
        OBJ_MaliyatManfi GetMaliyatManfiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MaliyatManfi> GetMaliyatManfiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMaliyatManfi(int Mablagh, int MohasebeId, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMaliyatManfi(int Id, int Mablagh, int MohasebeId, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMaliyatManfi(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //P_MaliyatManfi
        #region P_MaliyatManfi
        [OperationContract]
        OBJ_P_MaliyatManfi GetP_MaliyatManfiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_P_MaliyatManfi> GetP_MaliyatManfiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertP_MaliyatManfi(int MohasebeId, int Mablagh, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateP_MaliyatManfi(int Id, int MohasebeId, int Mablagh, short Sal, byte Mah, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteP_MaliyatManfi(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //RptSumMotalebat_Kosurat
        #region RptSumMotalebat_Kosurat
        [OperationContract]
        List<OBJ_RptSumMotalebat_Kosurat> RptSumMotalebat_Kosurat(string FieldName, short sal, byte Month, int CostCenter, int TypeBime, byte nobat, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectDisketMaliyatForHoghogh
        #region SelectDisketMaliyatForHoghogh
        [OperationContract]
        List<OBJ_SelectDisketMaliyatForHoghogh> GetSelectDisketMaliyatForHoghogh(short Year, byte Mah, byte Nobat, int OrganId, string IP, out ClsError Error);
        #endregion
        #region SelectDisketMaliyatForHoghogh
        [OperationContract]
        List<OBJ_SelectDisketMaliyatForHoghogh> GetSelectHoghogh_OnAccount(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion
        //DisketBazneshastegi
        #region DisketBazneshastegi
        [OperationContract]
        List<OBJ_DisketBazneshastegi> GetDisketBazneshastegi(short Year, byte Mah, byte Nobat, int OrganId, string IP, out ClsError Error);
        #endregion

        //DisketSina
        #region GetDisketSina_Karmandi
        [OperationContract]
        List<OBJ_DisketSinaKarmandi> GetDisketSina_Karmandi(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam, string IP, out ClsError Error);
        #endregion
        #region GetDisketSina_Kargari
        [OperationContract]
        List<OBJ_DisketSina> GetDisketSina_Kargari(short Year, byte Mah, byte Nobat, int OrganId, int typeEstekhdam, string IP, out ClsError Error);
        #endregion

        //DisketBime
        #region DisketBime
        [OperationContract]
        List<OBJ_DisketBime> GetDisketBime(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error);
        #endregion
        #region DisketBimeSum
        [OperationContract]
        List<OBJ_DisketBimeSum> GetDisketBimeSum(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error);
        #endregion
        
        //DisketBimeBASTAM
        #region GetDisketBimeBASTAM
        [OperationContract]
        List<OBJ_DisketBime> GetDisketBimeBASTAM(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error);
        #endregion
        //GetDisketBime_DBF
        #region GetDisketBime_DBF
        [OperationContract]
        List<OBJ_DisketBime_DBF> GetDisketBime_DBF(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error);
        #endregion
        //GetDisketBime_DBF_Header
        #region GetDisketBime_DBF_Header
        [OperationContract]
        OBJ_DisketBime_DBF_Header GetDisketBime_DBF_Header(short sal, byte mah, int kargaBime, byte nobat, string IP, out ClsError Error);
        #endregion
        //DisketBime_Moavaghe
        #region DisketBime_Moavaghe
        [OperationContract]
        List<OBJ_DisketBime_Moavaghe> GetDisketBime_Moavaghe(short sal, byte mah, int kargaBime, string IP, out ClsError Error);
        #endregion

        //DisketBime_Tatilkar_Ezafekar
        #region DisketBime_Tatilkar_Ezafekar
        [OperationContract]
        List<OBJ_DisketBime_Tatilkar_Ezafekar> GetDisketBime_Tatilkar_Ezafekar(string FieldName, short sal, byte mah, byte nobat, int kargaBime, string IP, out ClsError Error);
        #endregion

        //SelectInsuranceWorkshop
        #region SelectInsuranceWorkshop
        [OperationContract]
        List<OBJ_InsuranceWorkshop> SelectInsuranceWorkshop(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
         #endregion

        //RptSanad2
        #region RptSanad2
        [OperationContract]
        List<OBJ_RptSanad2> GetRptSanad2(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion
        //RptSanad3
        #region RptSanad3
        [OperationContract]
        List<OBJ_RptSanad3> GetRptSanad3(short Year, byte Mah, byte Nobat, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion
        //RptKosurBazneshastegi
        #region RptKosurBazneshastegi
        [OperationContract]
        List<OBJ_RptKosurBazneshastegi> GetRptKosurBazneshastegi(short Year, byte Mah, byte Nobat, int OrganId,string IP, out ClsError Error);
        #endregion

        //UpdateEzafekarKarkardMahane
        #region UpdateEzafekarKarkardMahane
        [OperationContract]
        string UpdateEzafekarKarkardMahane(decimal ezafekar, bool ghati, int personalId, byte mah, short year, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //UpdateFlag
        #region UpdateFlag
        [OperationContract]
        string UpdateFlag(string fieldName, short sal, byte mah, byte nobat, byte marhalePardaht, int OrganId, byte Type, string UserName, string Password, string IP, byte fldCalcType, out ClsError Error);
        #endregion

        //SelectPayPersonalInfo_Ezafekar
        #region SelectPayPersonalInfo_Ezafekar
        [OperationContract]
        List<OBJ_SelectPayPersonalInfo_Ezafekar> SelectPayPersonalInfo_Ezafekar(string FieldName, int costcenter_ChartOrganId, int organId, short year, byte mah, int h,string IP, out ClsError Error);
        #endregion

        //SelectFlagKarKard_Mohasebe
        #region SelectFlagKarKard_Mohasebe
        [OperationContract]
        List<OBJ_SelectFlagKarKard_Mohasebe> SelectFlagKarKard_Mohasebe(short sal, byte mah, int OrganId,string IP, out ClsError Error);
        #endregion

        //MohasebatForConvert
        #region MohasebatForConvert
        [OperationContract]
        int InsertMohasebatForConvert(OBJ_Mohasebat Mohasebat, OBJ_Mohasebat_PersonalInfo Mohasebat_PersonalInfo, int ChartOrganId, int fldShift, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //CheckMohasebat
        #region CheckMohasebat
        [OperationContract]
        List<OBJ_Mohasebat> CheckMohasebat(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string MohasebatDelete(string FieldName, int PersonalId, byte Mah, short sal, byte nobatpardakht, string CostCenter, string AnvaeEstekhdam, byte CalcType, string UserName, string Password, string IP, int OrganId, out ClsError Error);
        #endregion

        //DisketBimeKhadamatDarmani
        #region DisketBimeKhadamatDarmani
        [OperationContract]
        List<OBJ_DisketBimeKhadamatDarmani> GetDisketBimeKhadamatDarmani(short Sal, byte mah, byte nobat, int OrganId, string IP, out ClsError Error);
        #endregion

        //CheckKosorat_Motalebat
        #region CheckKosorat_Motalebat
        [OperationContract]
        List<OBJ_CheckKosorat_Motalebat> GetCheckKosorat_Motalebat(string FieldName, int id, string IP, out ClsError Error);
        #endregion

        //Operation
        #region Operation
        [OperationContract]
        List<OBJ_Operation> GetOperationWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //TavighKosurat
        #region TavighKosurat
        [OperationContract]
        OBJ_TavighKosurat GetTavighKosuratDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TavighKosurat> GetTavighKosuratWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTavighKosurat(int KosuratId, short Year, byte Month, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTavighKosurat(int Id, int KosuratId, short Year, byte Month, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTavighKosurat(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //FishLog 
        #region FishLog
        [OperationContract]
        OBJ_FishLog GetFishLogDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FishLog> GetFishLogWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFishLog(byte fldType, int? fldPersonalId, int fldOrganId, short fldYear, byte fldMonth, byte fldNobatPardakht, byte? fldFilterType, byte? fldFishType, int? fldCostCenterId, int? fldMahaleKhedmat, byte fldCalcType, byte? fldMostamar, string UserName, string Password, int OrganId, string IP, out ClsError Error);
    
        #endregion

        //SpecialPermission
        #region SpecialPermission
        [OperationContract]
        OBJ_SpecialPermission GetSpecialPermissionDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SpecialPermission> GetSpecialPermissionWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSpecialPermission(int UserSelectId, int ChartOrganId, int OpertionId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSpecialPermission(int Id, int UserSelectId, int ChartOrganId, int OpertionId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSpecialPermission(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //UpdateKosurat_Motalebat
        #region UpdateKosurat_Motalebat
        [OperationContract]
        string UpdateKosurat_Motalebat(string FieldName, bool Status, int id, int dateActive, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //UpdateKosuratBankStatus
        #region UpdateKosuratBankStatus
        [OperationContract]
        string UpdateKosuratBankStatus(bool Status, int Id, int tarikhDeactive, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetPasAndazBank
        #region GetPasAndazBank
        [OperationContract]
        int? GetPasAndazBank(short Year, byte Mah,int OrganId, string IP, out ClsError Error);
        #endregion

        //DisketPasAndaz
        #region DisketPasAndaz
        [OperationContract]
        List<OBJ_DisketPasAndaz> GetDisketPasAndaz(short sal, byte mah, byte nobat, int organId, string IP, out ClsError Error);
        #endregion

        //UpdateDescKosuratBank
        #region UpdateDescKosuratBank
        [OperationContract]
        string UpdateDescKosuratBank(int Id, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetHistoryAfradTahtePoshesheBimeTakmily
        #region MyRegion
        [OperationContract]
        List<OBJ_HistoryAfradTahtePoshesheBimeTakmily> GetHistoryAfradTahtePoshesheBimeTakmily(int PersonalId, int OrganId, string IP, out ClsError Error);
        #endregion

        //CheckShomareHesabPasAndazForMohasebat
        #region CheckShomareHesabPasAndazForMohasebat
        [OperationContract]
        List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabPasAndazForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId, string IP, out ClsError Error);
        #endregion
        //CheckConflictKarkard_Mohasebat
        #region CheckConflictKarkard_Mohasebat
        [OperationContract]
        List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckConflictKarkard_Mohasebat(short Year, byte Month, string costCenter, string anvaEstekhdam,
            int OrganId, int PersonalId, string IP, out ClsError Error);
        #endregion

        //TypeEstekhdam_UserGroup
        #region TypeEstekhdam_UserGroup
        [OperationContract]
        OBJ_TypeEstekhdam_UserGroup GetTypeEstekhdam_UserGroupDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TypeEstekhdam_UserGroup> GetTypeEstekhdam_UserGroupWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTypeEstekhdam_UserGroup(string fldTypeEstekhamId, int fldUseGroupId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTypeEstekhdam_UserGroup(int Id, string fldTypeEstekhamId, int fldUseGroupId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTypeEstekhdam_UserGroup(int UserGroupId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        
        #endregion

        #region RptListAghsatVam_Excel
        [OperationContract]
        List<OBJ_RptListAghsatVam> RptListAghsatVam_Excel(short Year, byte Month, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion

        #region RptKosourat_MotalebatParam_Excel
        [OperationContract]
        List<OBJ_RptKosourat_MotalebatParam> RptKosourat_MotalebatParam_Excel(short Year, byte Month, int ParametrId, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion

        #region InsertInsuranceJobs
        [OperationContract]
        string InsertInsuranceJobs(string UserName, string Password, string IP, out ClsError Error);
        #endregion
        #region CheckMohasebeForDisket
        [OperationContract]
        bool CheckMohasebeForDisket(short Year, byte Month, int OrganId, string IP, out ClsError Error);
        #endregion
        #region CheckShomareHesabForMohasebat
        [OperationContract]
        List<OBJ_CheckShomareHesabPasAndazForMohasebat> CheckShomareHesabForMohasebat(string Year, string Month, byte NobatPardakht, int OrganId, int PersonalId, byte HesabType, string IP, out ClsError Error);
        #endregion
        #region Rpt12Mahe
        [OperationContract]
        List<OBJ_Rpt12Mahe> Rpt12Mahe(short Year, byte NobatPardakht, byte CalcType, int OrganId, string IP, out ClsError Error);
        #endregion

        #region RptListPardakhtEydi
        [OperationContract]
        List<OBJ_RptListPardakhtEydi> RptListPardakhtEydi(int CostCenter, short Year, byte Month, byte NobatPardakht, int OrganId, string IP, out ClsError Error);
        #endregion

        #region CheckAllMohasebat
        [OperationContract]
        List<OBJ_CheckAllMohasebat> CheckAllMohasebat(int PersonalId, int OrganId, string IP, out ClsError Error);
        #endregion
        //RptFishHoghoughiDetails
        #region SelectKosourat_Details
        [OperationContract]
        List<OBJ_MotalebatDetails> SelectKosourat_Details(int PersonalId, int NobatPardakht, int AzYear, int TaYear, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error);
        #endregion
        #region SelectKosourat_Moavaghe_Details
        [OperationContract]
        List<OBJ_MotalebatDetails> SelectKosourat_Moavaghe_Details(int PersonalId, int NobatPardakht, short Year, byte Month, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error);
        #endregion
        #region SelectMotalebat_Details
        [OperationContract]
        List<OBJ_MotalebatDetails> SelectMotalebat_Details(int PersonalId, int NobatPardakht, int AzYear, int TaYear, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error);
        #endregion
        #region SelectMotalebat_Moavaghe_Details
        [OperationContract]
        List<OBJ_MotalebatDetails> SelectMotalebat_Moavaghe_Details(int PersonalId, int NobatPardakht, short Year, byte Month, byte TypeHesab, byte CalcType, string UserName, string Password,
           int OrganId, int Top, string IP, out ClsError Error);
        #endregion
        #region SelectMoavaghe_Details
        [OperationContract]
        List<OBJ_FishHoghoghi_Moavaghe> SelectMoavaghe_Details(int fldPersonalId, int nobatPardakht, short Year, byte Month, short YearPardakht, byte MonthPardakht,
            byte TypeHesab, byte CalcType, byte MoavagheType,string UserName, string Password, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Monasebat
        #region GetMonasebatDetail
        [OperationContract]
        OBJ_Monasebat GetMonasebatDetail(byte Id, string IP, out ClsError Error);
        #endregion
        #region GetMonasebatWithFilter
        [OperationContract]
        List<OBJ_Monasebat> GetMonasebatWithFilter(string FieldName, string FilterValue, string FilterValue2, bool DateType, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMonasebat
        [OperationContract]
        string InsertMonasebat(string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMonasebat
        [OperationContract]
        string UpdateMonasebat(byte Id, string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMonasebat
        [OperationContract]
        string DeleteMonasebat(byte Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MonasebatType
        #region GetMonasebatTypeWithFilter
        [OperationContract]
        List<OBJ_MonasebatType> GetMonasebatTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //MonasebatHeader
        #region GetMonasebatHeaderDetail
        [OperationContract]
        OBJ_MonasebatHeader GetMonasebatHeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetMonasebatHeaderWithFilter
        [OperationContract]
        List<OBJ_MonasebatHeader> GetMonasebatHeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMonasebatHeader
        [OperationContract]
        string InsertMonasebatHeader(int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMonasebatHeader
        [OperationContract]
        string UpdateMonasebatHeader(int Id, int? DeactiveDate, bool Active, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMonasebatHeader
        [OperationContract]
        string DeleteMonasebatHeader(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region CopyMonasebatHeader
        [OperationContract]
        string CopyMonasebatHeader(int HeaderId,int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MonasebatMablagh
        #region GetMonasebatMablaghDetail
        [OperationContract]
        OBJ_MonasebatMablagh GetMonasebatMablaghDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetMonasebatMablaghWithFilter
        [OperationContract]
        List<OBJ_MonasebatMablagh> GetMonasebatMablaghWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMonasebatMablagh
        [OperationContract]
        string InsertMonasebatMablagh(int HeaderId, byte MonasebatId, int Mablagh, byte TypeNesbatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMonasebatMablagh
        [OperationContract]
        string UpdateMonasebatMablagh(int Id, int HeaderId, byte MonasebatId, int Mablagh, byte TypeNesbatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMonasebatMablagh
        [OperationContract]
        string DeleteMonasebatMablagh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MonasebatTarikh
        #region GetMonasebatTarikhDetail
        [OperationContract]
        OBJ_MonasebatTarikh GetMonasebatTarikhDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetMonasebatTarikhWithFilter
        [OperationContract]
        List<OBJ_MonasebatTarikh> GetMonasebatTarikhWithFilter(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMonasebatTarikh
        [OperationContract]
        string InsertMonasebatTarikh(short Year, byte Month, byte Day, byte MonasebatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMonasebatTarikh
        [OperationContract]
        string UpdateMonasebatTarikh(int Id, short Year, byte Month, byte Day, byte MonasebatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMonasebatTarikh
        [OperationContract]
        string DeleteMonasebatTarikh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BudgetPayHeader
        #region GetBudgetPayHeaderDetail
        [OperationContract]
        OBJ_BudgetPayHeader GetBudgetPayHeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetBudgetPayHeaderWithFilter
        [OperationContract]
        List<OBJ_BudgetPayHeader> GetBudgetPayHeaderWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertBudgetPayHeader
        [OperationContract]
        string InsertBudgetPayHeader(int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, string fldIP, string fldDesc, string fldTypeEstekhdamId, string UserName, string Password, int OrganId, out ClsError Error);
        #endregion
        #region UpdateBudgetPayHeader
        [OperationContract]
        string UpdateBudgetPayHeader(int Id, int fldFiscalYearId, int? fldItemsHoghughiId, int? fldParametrId,int? fldKosouratId, int fldBudgetCode, string fldIP, string fldDesc, string fldTypeEstekhdamId, string UserName, string Password, int OrganId, out ClsError Error);
        #endregion
        #region DeleteBudgetPayHeader
        [OperationContract]
        string DeleteBudgetPayHeader(string FieldName, int ItemId, int FiscalYearId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BudgetPayDetail
        #region GetBudgetPayDetailDetail
        [OperationContract]
        OBJ_BudgetPayDetail GetBudgetPayDetailDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetBudgetPayDetailWithFilter
        [OperationContract]
        List<OBJ_BudgetPayDetail> GetBudgetPayDetailWithFilter(string FieldName, string FilterValue,  int Top, string IP, out ClsError Error);
        #endregion
        #region InsertBudgetPayDetail
        [OperationContract]
        string InsertBudgetPayDetail(int fldHeaderId, string TypeEstekhdamId, string UserName, string Password, int OrganId, string IP,  out ClsError Error);
        #endregion
        #region UpdateBudgetPayDetail
        [OperationContract]
        string UpdateBudgetPayDetail(int Id, int fldHeaderId, int fldTypeEstekhdamId, int fldTypeBimeId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteBudgetPayDetail
        [OperationContract]
        string DeleteBudgetPayDetail(int HeaderId, int TypeEstekhdamId, int TypeBimeId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ListNoMaliyat_BimePersonal
        #region ListNoMaliyat_BimePersonal
        [OperationContract]
        List<OBJ_ListNoMaliyat_BimePersonal> ListNoMaliyat_BimePersonal(string FieldName, int PersonelId, short sal, byte mah, byte nobat, int OrganId, string IP, out ClsError Error);
             #endregion

        //CalcHeader
        #region GetCalcHeaderDetail
        [OperationContract]
        OBJ_CalcHeader GetCalcHeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetCalcHeaderWithFilter
        [OperationContract]
        List<OBJ_CalcHeader> GetCalcHeaderWithFilter(string FieldName, string FilterValue, short Year, byte Month, int NobatPardakhtId,
            int Top, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region InsertCalcHeader
        [OperationContract]
        int InsertCalcHeader(short Year, byte Month, int NobatPardakhtId, byte Status, string PersonalId, byte CalcType, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteCalcHeader
        [OperationContract]
        string DeleteCalcHeader(short Year, byte Month, int NobatPardakhtId, string TypeEstekhdam, string CostCenterId, int OrganId, string IP, out ClsError Error);
        #endregion

        //MoteghayerhayeHoghoghiItems
        #region MoteghayerhayeHoghoghiItems
        [OperationContract]
        OBJ_MoteghayerhayeHoghoghiItems GetMoteghayerhayeHoghoghiItemsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhayeHoghoghiItems> GetMoteghayerhayeHoghoghiItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoteghayerhayeHoghoghiItems(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoteghayerhayeHoghoghiItems(int MoteghayerhayeHoghoghiId, string ItemEstekhdamId, byte fldType, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoteghayerhayeHoghoghiItems( int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ItemMablgh_Header
        #region GetItemMablgh_HeaderDetail
        [OperationContract]
        OBJ_ItemMablgh_Header GetItemMablgh_HeaderDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetItemMablgh_HeaderWithFilter
        [OperationContract]
        List<OBJ_ItemMablgh_Header> GetItemMablgh_HeaderWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertItemMablgh_Header
        [OperationContract]
        string InsertItemMablgh_Header(int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateItemMablgh_Header
        [OperationContract]
        string UpdateItemMablgh_Header(int Id, int? DeactiveDate, bool Active, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteItemMablgh_Header
        [OperationContract]
        string DeleteItemMablgh_Header(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region CopyItemMablgh_Header
        [OperationContract]
        string CopyItemMablgh_Header(int HeaderId, int ActiveDate, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion


        //ItemsMablgh
        #region GetItemsMablghDetail
        [OperationContract]
        OBJ_ItemsMablgh GetItemsMablghDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetItemsMablghWithFilter
        [OperationContract]
        List<OBJ_ItemsMablgh> GetItemsMablghWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertItemsMablgh
        [OperationContract]
        string InsertItemsMablgh(int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateItemsMablgh
        [OperationContract]
        string UpdateItemsMablgh(int Id, int HeaderId, int ItemsHoghughiId, int Mablagh, decimal PercentW_H, decimal PercentChild, byte Count, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteItemsMablgh
        [OperationContract]
        string DeleteItemsMablgh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
    }
}
