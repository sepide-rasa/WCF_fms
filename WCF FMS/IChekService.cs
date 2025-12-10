using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChekService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IChekService
    {
        //OlgoCheck
        #region OlgoCheck
        [OperationContract]
        OBJ_OlgoCheck GetOlgoCheckDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_OlgoCheck> GetOlgoCheckWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertOlgoCheck(string Title, byte[] File, string Pasvand, int BankId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateOlgoCheck(int fldId, string Title, byte[] File, string Pasvand, int FileId, int BankId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteOlgoCheck(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DasteCheck
        #region DasteCheck
        [OperationContract]
        OBJ_DasteCheck GetDasteCheckDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DasteCheck> GetDasteCheckWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDasteCheck(int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDasteCheck(int fldId, int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDasteCheck(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SodorCheck
        #region SodorCheck
        [OperationContract]
        OBJ_SodorCheck GetSodorCheckDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SodorCheck> GetSodorCheckWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        long GetSumMablaghCheck_Factor(string FieldName, string FilterValue, string IP, out ClsError Error);
        [OperationContract]
        string InsertSodorCheck(int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh, 
            int? FactorId,int? ContractId,int? TankhahGroupId,string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSodorCheck(int fldId, int DasteCheckId, string TarikhVosol, int AshkhasId, string CodeSerialCheck, string Babat, bool BabatFlag, long Mablagh,
            int? FactorId,int? ContractId,int? TankhahGroupId,string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSodorCheck(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AghsatCheckAmani
        #region AghsatCheckAmani
        [OperationContract]
        OBJ_AghsatCheckAmani GetAghsatCheckAmaniDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AghsatCheckAmani> GetAghsatCheckAmaniWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAghsatCheckAmani(long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAghsatCheckAmani(int fldId, long Mablagh, string Tarikh, string Nobat, int CheckHayeVaredeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAghsatCheckAmani(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateStatusAghsatCheckAmani(int fldId, string TarikhPardakht, byte Vaziat, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAghsatChckAmaniForChckVaredeId(int ChekVardeId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CheckHayeVarede
        #region CheckHayeVarede
        [OperationContract]
        OBJ_CheckHayeVarede GetCheckHayeVaredeDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CheckHayeVarede> GetCheckHayeVaredeWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCheckHayeVarede(int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCheckHayeVarede(int fldId, int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCheckHayeVarede(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ChekStatus
        #region ChekStatus
        [OperationContract]
        string InsertChekStatus(Nullable<int> SodorCheckId, Nullable<int> CheckVaredeId, Nullable<int> AghsatId, byte Status, string Tarikh, string Desc, string Username, string Password, string IP, out ClsError Error);
        #endregion


    }
}
