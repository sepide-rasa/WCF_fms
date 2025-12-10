using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeighService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IWeighService
    {
        //Weighbridge
        #region Weighbridge
        [OperationContract]
        OBJ_Weighbridge GetWeighbridgeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
         List<OBJ_Weighbridge> GetWeighbridgeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertWeighbridge(int fldAshkhasHoghoghiId, string fldName, string fldAddress, string fldPassword, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateWeighbridge(int fldId, int fldAshkhasHoghoghiId, string fldName, string fldAddress, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteWeighbridge(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePassBaskool(int fldId, string newpass, string Username, string Password, int OrganId, string IP, out ClsError Error);
	#endregion

        //Remittance_Header
        #region Remittance_Header
        [OperationContract]
        OBJ_Remittance_Header GetRemittance_HeaderDetail(int Id,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Remittance_Header> GetRemittance_HeaderWithFilter(string FieldName, string FilterValue,int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRemittance_Header(string Title, int? fldAshkhasiId, bool fldStatus, byte[] fldFile, string fldPassvand, string fldStartDate, string fldEndDate, System.Data.DataTable detail,
            string DescHeader, int? OrganizationalUint, int Receiver, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRemittance_Header(int fldHeaderId, string Title, int? fldAshkhasiId, bool fldStatus, string fldStartDate, string fldEndDate, byte[] fldFile, string fldPassvand,
            int? fldFileId, System.Data.DataTable detail, string DescHeader, int? OrganizationalUint, int Receiver, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRemittance_Header(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametrBaskoolValue
        #region ParametrBaskoolValue
        [OperationContract]
        List<OBJ_ParametrBaskoolValue> GetParametrBaskoolValueWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametrBaskoolValue(int fldParametrBaskoolId, int fldBaskoolId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametrBaskoolValue(int fldId, int fldParametrBaskoolId, int fldBaskoolId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametrBaskoolValue(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_BaskoolParametr_Value> SelectBaskoolParametr_Value(int BaskoolId, string IP, out ClsError Error);
        #endregion

        //Remittance_Details
        #region Remittance_Details
        [OperationContract]
        List<OBJ_Remittance_Details> GetRemittance_DetailsWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //ParametrsBaskool
        #region ParametrsBaskool
        [OperationContract]
        List<OBJ_ParametrsBaskool> GetParametrsBaskoolWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametrsBaskool(string EnName, string FaName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Tozin
        #region Tozin
        [OperationContract]
        List<OBJ_Tozin> GetTozinWithFilter(string FieldName, string FilterValue, string FilterValue2, string AzTarikh, string TaTarikh, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTozin(int fldWeighbridgeId, int fldMaxW, int? fldPlaqueId, DateTime fldHour, DateTime fldStartDate, DateTime fldEndDate, string IP, out ClsError Error);
        
        #endregion

        //BaskolDocument
        #region BaskolDocument
        [OperationContract]
        List<OBJ_BaskolDocument> GetBaskolDocumentWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Arze
        #region Arze
        [OperationContract]
        OBJ_Arze GetArzeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Arze> GetArzeWithFilter(string FieldName, string FilterValue,int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertArze(int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId, byte Tedad, long Mablagh, int OrganizationId, byte Type,int? fldVaznVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateArze(int fldId, int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId, byte Tedad, long Mablagh, int OrganizationId, byte Type,int? fldVaznVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteArze(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Arze_Kala> SelectArze_Kala(int BaskoolId, int OrganId, string IP, out ClsError Error);
        #endregion

        //LoadingPlace
        #region LoadingPlace
        [OperationContract]
        OBJ_LoadingPlace GetLoadingPlaceDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LoadingPlace> GetLoadingPlaceWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLoadingPlace(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLoadingPlace(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLoadingPlace(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Arze_Detail
        #region Arze_Detail
        [OperationContract]
        List<OBJ_Arze_Detail> GetArze_DetailWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertArze_Detail(int fldHeaderId, int? fldParametrSabetCodeDaramd, string fldValue, bool fldFlag, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteArze_Detail(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //NoeMasraf
        #region NoeMasraf
        [OperationContract]
        List<OBJ_NoeMasraf> GetNoeMasrafWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //Vazn_Baskool
        #region Vazn_Baskool
        [OperationContract]
        List<OBJ_Vazn_Baskool> GetVazn_BaskoolWithFilter(string FieldName, string FilterValue, int ModuleId, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertVazn_Baskool(string harf, string fldPlaque2, string fldPlaque3, byte serial, int OrganizationId, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateVazn_Baskool(int Id, int PlaqueId, int OrganizationId, int fldRananadeId, byte? fldNoeMasrafId, int? fldAshkhasId, int? fldChartOrganEjraeeId, int? fldLoadingPlaceId, int? fldKalaId, decimal? fldVaznKol, int? fldRemittanceId, int fldBaskoolId, bool fldIsPor, int fldTypeKhodroId,int? fldTedad,bool fldTypeMohasebe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Vazn_Baskool> GetRannadeInPlaque(string FieldName, byte Serial, string Harf, string Plaque2, string Plaque3, int BaskoolId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Vazn_Baskool> SelectMandeHavali(int HavaleId, int KalaId, int BaskoolId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Vazn_Baskool> SelectVaznKhals_VaznKhali(byte Serial, string Harf, string Plaque2, string Plaque3, int BaskoolId, int OrganId, decimal VaznKol,bool TypeMohasebe, string IP, out ClsError Error);
        [OperationContract]
        string UpdateIsprintBaskool(int Id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEbtalBaskool(int Id, int OrganId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //TypeReport
        #region TypeReport
        [OperationContract]
        List<OBJ_TypeReport> GetTypeReportWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTypeReport(byte fldType, int fldOrganId, int fldBaskoolId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        #region MyRegion
        [OperationContract]
        List<OBJ_KalaHavale> SelectSumKalaHavale(string FieldName, string FilterValue, int HavaleId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SumKalaHavale_Detail> SelectSumKalaHavale_Detail(string FieldName, string FilterValue, int HavaleId, int IdKala, string IP, out ClsError Error);
        #endregion

        //ElameAvarez_ModuleOrgan
        #region ElameAvarez_ModuleOrgan
        [OperationContract]
        List<OBJ_ElameAvarez_ModuleOrgan> GetElamAvarez_ModuleOrgan(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertElamAvarez_ModuleOrgan(int fldElamAvarezId, int fldCodeDaramdElamAvarezId, int Id, string Desc, string Username, string Password, string IP, out ClsError Error);
        #endregion
    }
}
