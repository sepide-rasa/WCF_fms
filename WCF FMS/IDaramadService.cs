using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS
{ 
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDaramadService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IDaramadService
    { 
        
        //CodhayeDaramd
        #region CodhayeDaramd
        [OperationContract]
        OBJ_CodhayeDaramd GetCodhayeDaramdDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodhayeDaramd> GetCodhayeDaramdWithFilter(string FieldName, string FilterValue, int FiscalYearId, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCodhayeDaramd(int Id, string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd, bool AmuzeshParvaresh, int? UnitId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertFromAccounting(short Year, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodhayeDaramd(int Id, string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd, bool AmuzeshParvaresh, int? UnitId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodhayeDaramd(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDaramadId(int childe, int parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFileForCodhayeDaramd(int ShomareHesabCodeDaramadId, byte[] Image, string Pasvand, string Decs, int UserId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFormolsazForCodhayeDarmd(int ShomareHesabCodeDaramdId, string Formolsaz, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ElamAvarezLog
        #region CodhayeDaramd
        
        [OperationContract]
        List<OBJ_ElamAvarezLog> GetElamAvarezLog(int ElamAvarezId, string IP, out ClsError Error);
        #endregion
        //ComboBox
        #region ComboBox
        [OperationContract]
        OBJ_ComboBox GetComboBoxDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ComboBox> GetComboBoxWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error);
        [OperationContract]
        string InsertComboBox(string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateComboBox(int Id, string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteComboBox(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ComboBoxValue
        #region ComboBoxValue
        [OperationContract]
        OBJ_ComboBoxValue GetComboBoxValueDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ComboBoxValue> GetComboBoxValueWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertComboBoxValue(int ComboBoxId, string Title, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateComboBoxValue(int Id, int ComboBoxId, string Title, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteComboBoxValue(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametreOmoomi
        #region ParametreOmoomi
        [OperationContract]
        OBJ_ParametreOmoomi GetParametreOmoomiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametreOmoomi> GetParametreOmoomiWithFilter(string FieldName, string FilterValue, int Top,string IP, out ClsError Error);
        [OperationContract]
        string InsertParametreOmoomi(string NameParametreFa, string NameParametreEn, byte NoeField, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametreOmoomi(int Id, string NameParametreFa, string NameParametreEn, byte NoeField, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametreOmoomi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametreOmoomi_Value
        #region ParametreOmoomi_Value
        [OperationContract]
        OBJ_ParametreOmoomi_Value GetParametreOmoomi_ValueDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametreOmoomi_Value> GetParametreOmoomi_ValueWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametreOmoomi_Value(int ParametreOmoomiId, string FromDate, string EndDate, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametreOmoomi_Value(int Id, int ParametreOmoomiId, string FromDate, string EndDate, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametreOmoomi_Value(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametreSabet
        #region ParametreSabet
        [OperationContract]
        OBJ_ParametreSabet GetParametreSabetDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametreSabet> GetParametreSabetWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametreSabet(int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId, bool TypeParametr, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametreSabet(int Id, int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId, bool TypeParametr, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametreSabet(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CodhayeDaramadiElamAvarez
        #region CodhayeDaramadiElamAvarez
        [OperationContract]
        OBJ_CodhayeDaramadiElamAvarez GetCodhayeDaramadiElamAvarez(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodhayeDaramadiElamAvarez> GetCodhayeDaramadiElamAvarezWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertCodhayeDaramadiElamAvarez(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodhayeDaramadiElamAvarez(int Id, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodhayeDaramadiElamAvarez(int id, string FieldName, int ElamAvarezId, int CodeDaramadId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        int InsertCodhayeDaramadiElamAvarez_External(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, long MaliyatValue, long AvarezValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodhayeDaramadiElamAvarez_External(int ID, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, long AvarezValue, long MaliyatValue, int Tedad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ElamAvarez
        #region ElamAvarez
        [OperationContract]
        OBJ_ElamAvarez GetElamAvarezDetail(int Id, string Value1, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ElamAvarez> GetElamAvarezWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertElamAvarez(int AshkhasID, bool Type, int fldOrganId, bool? IsExternal, int? DaramadGroupId, string CodeSystemMabda, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateElamAvarez(int Id, int AshkhasID, bool Type, int fldOrganId, int? DaramadGroupId, string CodeSystemMabda, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteElamAvarez(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteWithElamAvarezId(int ElamAvarezId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ElamAvarez> CheckLastIdForElamAvarez(string FieldName, int ElamAvarezId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKoliElamAvarez(int ElamAvarezId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //LetterMinut
        #region LetterMinut
        [OperationContract]
        OBJ_LetterMinut GetLetterMinutDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterMinut> GetLetterMinutWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertLetterMinut(int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterMinut(int Id, int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterMinut(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Roonevesht
        #region Roonevesht
        [OperationContract]
        OBJ_Roonevesht GetRooneveshtDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Roonevesht> GetRooneveshtWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRoonevesht(int ShomareHesabCodeDaramadId, string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRoonevesht(int Id, int ShomareHesabCodeDaramadId, string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRoonevesht(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametreSabet_Value
        #region ParametreSabet_Value
        [OperationContract]
        OBJ_ParametreSabet_Value GetParametreSabet_ValueDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametreSabet_Value> GetParametreSabet_ValueWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametreSabet_Value(int ElamAvarezId, string Value, int ParametrSabetId, int? CodeDaramadElamAvarezId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametreSabet_Value(int Id, int ElamAvarezId, string Value, int ParametrSabetId, int? CodeDaramadElamAvarezId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametreSabet_Value(int ElamAvarezId, int CodeDaramadId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //ShomareHesabCodeDaramad
        #region ShomareHesabCodeDaramad
        [OperationContract]
        OBJ_ShomareHesabCodeDaramad GetShomareHesabCodeDaramadDetail(int Id, int FiscalYearId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabCodeDaramad> GetShomareHesabCodeDaramadWithFilter(string FieldName, string FilterValue, string FilterValue1, int FiscalYearId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomareHesabCodeDaramad(int ShomareHesadId, int CodeDaramadId, int fldOrganId, byte ShorooshenaseGhabz, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareHesabCodeDaramad(int Id, int ShomareHesadId, int CodeDaramadId, int fldOrganId, byte ShorooshenaseGhabz, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomareHesabCodeDaramad(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSharhecodeDaramd(int Id, string SharhCodeDaramad, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateStatus_CodeDaramad(int Id, bool Status, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabCodeDaramad_Fomula> GetShomareHesabCodeDaramad_Fomula(string FieldName, string FilterValue, int Top,int organid, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomareHesabCodeDaramad_Fomula(int ShomareHesad_CodeId, string Formul, string TarikhEjra, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareHesabCodeDaramad_Fomula(int Id, int ShomareHesad_CodeId, string Formul, string TarikhEjra, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ListCodeDaramad_ShomareHesabWithOrganId
        #region ListCodeDaramad_ShomareHesabWithOrganId
        [OperationContract]
        List<OBJ_ListCodeDaramad_ShomareHesabWithOrganId> ListCodeDaramad_ShomareHesabWithOrganId(int OrganId, byte Type, int FiscalYearId, string IP, out ClsError Error);
        #endregion

        //SodoorFish
        #region SodoorFish
        [OperationContract]
        OBJ_SodoorFish GetSodoorFishDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SodoorFish> GetSodoorFishWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertSodoorFish(int ElamAvarezId, int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz, long JamKol, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSodoorFish(int Id, int ElamAvarezId, int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz, long JamKol, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSodoorFish(int id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SodoorFish> GetEbtal_SodoorFish(int ElamAvarezId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShenaseGhabz_Pardakht(int FishId, string ShenaseGhabz, string ShenasePardakht, string Barcode, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        int InsertSodoorFishForNaghdi_Talab(int OrganId, long Mablagh, int ElamAvarezId, int naghdiTalabId, int ShomareHesabId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DetailSodoorFish> GetDetailSodoorFish(int ElamAvarezId, int ShomareHesabId, byte ShorooShenaseGhabz, string IP, out ClsError Error);
        #endregion

        //SodoorFish_Detail
        #region SodoorFish_Detail
        [OperationContract]
        OBJ_SodoorFish_Detail GetSodoorFish_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SodoorFish_Detail> GetSodoorFish_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSodoorFish_Detail(int FishId, int CodeElamAvarezId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSodoorFish_Detail(int Id, int FishId, int CodeElamAvarezId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSodoorFish_Detail(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //ReplyTaghsit
        #region ReplyTaghsit
        [OperationContract]
        OBJ_ReplyTaghsit GetReplyTaghsitDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ReplyTaghsit> GetReplyTaghsitWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertReplyTaghsit(int MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int StatusId, byte TedadMahAghsat, int JarimeTakhir, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateReplyTaghsit(int Id, int MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, string Tarikh, int StatusId, byte TedadMahAghsat, int JarimeTakhir, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteReplyTaghsit(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //RequestTaghsit_Takhfif
        #region RequestTaghsit_Takhfif
        [OperationContract]
        OBJ_RequestTaghsit_Takhfif GetRequestTaghsit_TakhfifDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_RequestTaghsit_Takhfif> GetRequestTaghsit_TakhfifWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertRequestTaghsit_Takhfif(int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRequestTaghsit_Takhfif(int Id, int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRequestTaghsit_Takhfif(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //TanzimateDaramad
        #region TanzimateDaramad
        [OperationContract]
        OBJ_TanzimateDaramad GetTanzimateDaramadDetail(int Id,int FiscalYearId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TanzimateDaramad> GetTanzimateDaramadWithFilter(string FieldName, string FilterValue,int FiscalYearId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTanzimateDaramad(int? AvarezId, int? MaliyatId, int TakhirId, int MablaghGerdKardan, int fldOrganId, decimal Nerkh, bool ChapShenaseGhabz_Pardakht, byte ShorooshenaseGhabz, int ShomareHesabIdPishfarz, bool SumMaliyat_Avarez, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        /*[OperationContract]
        string UpdateTanzimateDaramad(int Id, int AvarezId, int MaliyatId, int TakhirId, int MablaghGerdKardan, int OrganId, string Desc, string Username, string Password, string IP, out ClsError Error);*/
        /*[OperationContract]
        string DeleteTanzimateDaramad(int id, string Username, string Password, string IP, out ClsError Error);*/
        #endregion

        //Ebtal
        #region Ebtal
        [OperationContract]
         OBJ_Ebtal GetEbtalDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Ebtal> GetEbtalWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertEbtal(Nullable<int> FishId, Nullable<int> RequestTaghsit_TakhfifId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEbtal(int Id, Nullable<int> FishId, Nullable<int> RequestTaghsit_TakhfifId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteEbtal(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //ReplyTakhfif
        #region ReplyTakhfif
        [OperationContract]
        OBJ_ReplyTakhfif GetReplyTakhfifDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ReplyTakhfif> GetReplyTakhfifWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertReplyTakhfif(decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateReplyTakhfif(int Id, decimal Darsad, int Mablagh, string ShomareMajavez, string Tarikh, int StatusId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteReplyTakhfif(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //StatusTaghsit_Takhfif
        #region StatusTaghsit_Takhfif
        [OperationContract]
        OBJ_StatusTaghsit_Takhfif GetStatusTaghsit_TakhfifDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_StatusTaghsit_Takhfif> GetStatusTaghsit_TakhfifWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertStatusTaghsit_Takhfif(int replyId, int RequestId, byte TypeMojavez, byte TypeRequest, decimal Darsad, long Mablagh, string Tarikh, long MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, byte TedadMahAghsat, long JarimeTakhir, int organId, decimal DarsadTaghsit, string DescKarmozd, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Check
        #region Check
        [OperationContract]
        OBJ_Check GetCheckDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Check> GetCheckWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCheck(out int fldId,int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCheck(int Id, int ShomareHesabId, string ShomareSanad, int ReplyTaghsitId, string TarikhSarResid, long MablaghSanad, byte Status, bool TypeSanad, int ShomareHesabIdOrgan, string DateStatus, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCheck(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Safte
        #region Safte
        [OperationContract]
        OBJ_Safte GetSafteDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Safte> GetSafteWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSafte(string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSafte(int Id, string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, string DateStatus, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSafte(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectDataForTaghsit
        #region SelectDataForTaghsit
        [OperationContract]
        List<OBJ_SelectDataForTaghsit> SelectDataForTaghsit(string FieldName, string Value, string AzTarikh, string TaTarikh, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Barat
        #region Barat
        [OperationContract]
        OBJ_Barat GetBaratDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Barat> GetBaratWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertBarat(string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, int BaratDarId, string MakanPardakht, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateBarat(int Id, string TarikhSarResid, int ReplyTaghsitId, string ShomareSanad, long MablaghSanad, byte Status, int BaratDarId, string MakanPardakht, string DateStatus, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteBarat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Naghdi_Talab
        #region Naghdi_Talab
        [OperationContract]
        OBJ_Naghdi_Talab GetNaghdi_TalabDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Naghdi_Talab> GetNaghdi_TalabWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertNaghdi_Talab(long Mablagh, int ReplyTaghsitId, byte Type, int? ShomareHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateNaghdi_Talab(int Id, long Mablagh, int ReplyTaghsitId, byte Type, int? ShomareHesabId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteNaghdi_Talab(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //UpdateStatusSanad
        #region UpdateStatusSanad
        [OperationContract]
        string UpdateStatusSanad(byte Type, int Id, byte Status, string DateStatus, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectFishSaderShode
        #region SelectFishSaderShode
        [OperationContract]
        List<OBJ_FishSaderShode> GetFishSaderShodeWithFilter(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId,int Top, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //NahvePardakht
        #region NahvePardakht
        [OperationContract]
        OBJ_NahvePardakht GetNahvePardakhtDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_NahvePardakht> GetNahvePardakhtWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertNahvePardakht(string Title, string CodePardakht, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateNahvePardakht(int Id, string Title, string CodePardakht, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteNahvePardakht(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Factor
        #region Factor
        [OperationContract]
        OBJ_Factor GetFactorDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Factor> GetFactorWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFactor(int FishId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFactor(int Id, int FishId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFactor(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //FormatShomareName
        #region FormatShomareName
        [OperationContract]
        OBJ_FormatShomareName GetFormatShomareNameDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FormatShomareName> GetFormatShomareNameWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFormatShomareName(short Year, string FormatShomareName, int ShomareShoro, bool Type, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFormatShomareName(int Id, short Year, string FormatShomareName, int ShomareShoro, bool Type, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFormatShomareName(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //pcposparametr
        #region PcPosParametr
        [OperationContract]
        OBJ_PcPosParametr GetPcPosParametrDetails(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosParametr> GetPcPosParametrWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string Insertpcposparametr(string fldFaName, string fldEnName, int PspId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string Updatepcposparametr(int Id, string fldFaName, string fldEnName, int PspId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosParametr(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosParametr> GetPcPos_Param_Value(int Value, string IP, out ClsError Error);
        #endregion

        //PardakhtFish
        #region PardakhtFish
        [OperationContract]
        OBJ_PardakhtFish GetPardakhtFishDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PardakhtFish> GetPardakhtFishWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPardakhtFish(int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId, System.DateTime DateVariz, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePardakhtFish(int Id, int FishId, System.DateTime DatePardakht, int NahvePardakhtId, Nullable<int> PardakhtFiles_DetailId, System.DateTime DateVariz, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePardakhtFish(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //PcPosInfo
        #region PcPosInfo
        [OperationContract]
        OBJ_PcPosInfo GetPcPosInfoDetail(int Id, string value1, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosInfo> GetPcPosInfoWithFilter(string FieldName, string FilterValue, string value1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPcPosInfo(int PspId, int fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosInfo(int Id, int PspId, int fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosInfo(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PcPosParam_Detail
        #region PcPosParam_Detail
        [OperationContract]
        OBJ_PcPosParam_Dtail GetPcPosParam_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosParam_Dtail> GetPcPosParam_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPcPosParam_Detail(int PcPosParamId, int PcPosInfoId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosParam_Detail(int Id, int PcPosParamId, int PcPosInfoId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosParam_Detail(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PcPosUser
        #region PcPosUser
        [OperationContract]
        OBJ_PcPosUser GetPcPosUserDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosUser> GetPcPosUserWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPcPosUser(int PosIpId, int IdUser, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosUser(int Id, int PosIpId, int IdUser, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosUser(string FieldName, int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PcPosIP
        #region PcPosIP
        [OperationContract]
        OBJ_PcPosIP GetPcPosIPDetail(int Id, string Value1, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosIP> GetPcPosIPWithFilter(string FieldName, string FilterValue, string Value1, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertPcPosIP(int PcPosInfoId, string Serial, string fldIP, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosIP(int Id, int PcPosInfoId, string Serial, string fldIP, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosIP(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
	    #endregion

        //ShomareNameHa
        #region ShomareNameHa
        [OperationContract]
        OBJ_ShomareNameHa GetShomareNameHaDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareNameHa> GetShomareNameHaWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertShomareNameHa(Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, int StartNumber, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareNameHa(int Id, Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, short Year, int Shomare, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomareNameHa(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //Mokatebat
        #region Mokatebat
        [OperationContract]
        OBJ_Mokatebat GetMokatebatDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Mokatebat> GetMokatebatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertMokatebat(int CodhayeDaramadiElamAvarezId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        int UpdateMokatebat(int Id, int CodhayeDaramadiElamAvarezId, byte[] File, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMokatebat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //LetterSigners
        #region LetterSigners
        [OperationContract]
        OBJ_LetterSigners GetLetterSignersDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_LetterSigners> GetLetterSignersWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertLetterSigners(int fldLetMiId, int fldOrgPosId, string Username, string Password, string flddesc, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateLetterSigners(int fldId, int fldLetMiId, int fldOrgPosId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteLetterSigners(int fldLetterMinutId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ListShomareHesabWithElamAvarezId
        #region ListShomareHesabWithElamAvarezId
        [OperationContract]
        List<OBJ_ShomareHesabWithElamAvarezId> GetListShomareHesabWithElamAvarezId(string FieldName, string FilterValue, string IP, out ClsError Error);
        #endregion

        //Psp
        #region Psp
        [OperationContract]
        OBJ_Psp GetPspDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Psp> GetPspWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPsp(string Title, byte[] File, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePsp(int Id, string Title, int FileId, byte[] File, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePsp(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParametreSabet_Nerkh
        #region ParametreSabet_Nerkh
        [OperationContract]
        OBJ_ParametreSabet_Nerkh GetParametreSabet_NerkhDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametreSabet_Nerkh> GetParametreSabet_NerkhWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametreSabet_Nerkh(int ParametreSabetId, string TarikhFaalSazi, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametreSabet_Nerkh(int Id, int ParametreSabetId, string TarikhFaalSazi, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametreSabet_Nerkh(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PardakhtFile
        #region PardakhtFile
        [OperationContract]
        OBJ_PardakhtFile GetPardakhtFileDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PardakhtFile> GetPardakhtFileWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertPardakhtFile(int BankId, string FileName, string DateSendFile, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePardakhtFile(int Id, int BankId, string FileName, string DateSendFile, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePardakhtFile(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PardakhtFiles_Detail
        #region PardakhtFiles_Detail
        [OperationContract]
        OBJ_PardakhtFiles_Detail GetPardakhtFiles_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PardakhtFiles_Detail> GetPardakhtFiles_DetailWithFilter(string FieldName, string FilterValue, string OrganId, string AzTarikh, string TaTarikh, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPardakhtFiles_Detail(string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int PardakhtFileId, int fldOrganId, string CodePardakht, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePardakhtFiles_Detail(int Id, string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int NahvePardakhtId, int PardakhtFileId, int fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePardakhtFiles_Detail(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PspModel
        #region PspModel
        [OperationContract]
        OBJ_PspModel GetPspModelDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PspModel> GetPspModelWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPspModel(int PspId, string Model, bool MultiHesab, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePspModel(int Id, int PspId, string Model, bool MultiHesab, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePspModel(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InfoPardakhtFTP
        #region InfoPardakhtFTP
        [OperationContract]
        List<OBJ_InfoPardakhtFTP> GetInfoPardakhtFTP(int OrganId, string ShenaseGhabz, string ShenasePardakht, string IP, out ClsError Error);
        #endregion

        //PcPosTransaction
        #region PcPosTransaction
        [OperationContract]
        OBJ_PcPosTransaction GetPcPosTransactionDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PcPosTransaction> GetPcPosTransactionWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertPcPosTransaction(int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosTransaction(int Id, int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePcPosTransaction(int id, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePcPosTransaction_Status(int Id, string TrackingCode, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, string Desc, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //DataForElamAvarez
        #region DataForElamAvarez
        [OperationContract]
        List<OBJ_DataForElamAvarez> GetDataForElamAvarezWithFilter(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, byte Type, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DataForElamAvarez> GetDataForElamAvarez_BaratWithFilter(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DataForElamAvarez> GetDataForElamAvarez_CheckWithFilter(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DataForElamAvarez> GetDataForElamAvarez_SafteWithFilter(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //Takhfif
        #region Takhfif
        [OperationContract]
        OBJ_Takhfif GetTakhfifDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Takhfif> GetTakhfifWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertTakhfif(string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTakhfif(int Id, string ShomareMojavez, string TarikhMojavez, string AzTarikh, string TaTarikh, decimal? TakhfifKoli, decimal? TakhfifNaghdi, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTakhfif(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        bool CheckTakhfif(int idElamAvarez, int ShomareHesabId, byte ShooroShenaseGhabz, string IP, out ClsError Error);
        #endregion

        //TakhfifDetail
        #region TakhfifDetail
        [OperationContract]
        OBJ_TakhfifDetail GetTakhfifDetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TakhfifDetail> GetTakhfifDetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTakhfifDetail(int TakhfifId, int ShCodeDaramad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTakhfifDetail(int Id, int TakhfifId, int ShCodeDaramad, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTakhfifDetail(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetListCodeDaramad_Donati
        #region GetListCodeDaramad_Donati
        [OperationContract]
        List<OBJ_RptListCodeDaramad_Donati> GetListCodeDaramad_Donati(string AzTarikh, string TaTarikh, int OrganId, byte DateType, string IP, out ClsError Error);
        #endregion

        //GetListCodeDaramad_GajeWithFilter
        #region GetListCodeDaramad_GajeWithFilter
        [OperationContract]
        List<OBJ_RptListCodeDaramad_Gaje> GetListCodeDaramad_GajeWithFilter(string FieldName, string AzTarikh, string TaTarikh, string Value, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetListCodeDaramad_Day
        #region GetListCodeDaramad_Day
        [OperationContract]
        List<OBJ_RptListCodeDaramad_Day> GetListCodeDaramad_Day(string AzTarikh, string TaTarikh, int OrganId, byte DateType, string IP, out ClsError Error);
        #endregion

        //GetListCodeDaramad_Month
        #region GetListCodeDaramad_Month
        [OperationContract]
        List<OBJ_RptListCodeDaramad_Day> GetListCodeDaramad_Month(string AzTarikh, string TaTarikh, int OrganId, byte DateType, string IP, out ClsError Error);
        #endregion

        //PSPModel_ShomareHesab
        #region PSPModel_ShomareHesab
        [OperationContract]
        OBJ_PSPModel_ShomareHesab GetPSPModel_ShomareHesabDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PSPModel_ShomareHesab> GetPSPModel_ShomareHesabWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPSPModel_ShomareHesab(int PSPModelId, int ShHesabId, byte Order, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePSPModel_ShomareHesab(int Id, int PSPModelId, int ShHesabId, byte Order, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePSPModel_ShomareHesab(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CopyCodeDaramd
        #region CopyCodeDaramd
        [OperationContract]
        string CopyCodeDaramd(string FieldName, int MabdaId, int MaghsadId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MahdoodiyatMohasebat
        #region MahdoodiyatMohasebat
        [OperationContract]
        OBJ_MahdoodiyatMohasebat GetMahdoodiyatMohasebatDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MahdoodiyatMohasebat> GetMahdoodiyatMohasebatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertMahdoodiyatMohasebat(string Title, string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMahdoodiyatMohasebat(int Id, string Title, string AzTarikh, string Tatarikh, bool NoeKarbar, bool NoeCodeDaramad, bool NoeAshkhas, bool Status, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMahdoodiyatMohasebat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        bool CheckMahdoodiyatMohasebat(string Tarikh, int AshkhasId, int ShomareHesabDaramad, int UserId, string IP, out ClsError Error);
        #endregion

        //MahdoodiyatMohasebat_Ashkhas
        #region MahdoodiyatMohasebat_Ashkhas
        [OperationContract]
        OBJ_MahdoodiyatMohasebat_Ashkhas GetMahdoodiyatMohasebat_AshkhasDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MahdoodiyatMohasebat_Ashkhas> GetMahdoodiyatMohasebat_AshkhasWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMahdoodiyatMohasebat_Ashkhas(int MahdoodiyatMohasebatId, int AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMahdoodiyatMohasebat_Ashkhas(int Id, int MahdoodiyatMohasebatId, int AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMahdoodiyatMohasebat_Ashkhas(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MohdoodiyatMohasebat_User
        #region MohdoodiyatMohasebat_User
        [OperationContract]
        OBJ_MohdoodiyatMohasebat_User GetMohdoodiyatMohasebat_UserDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MohdoodiyatMohasebat_User> GetMohdoodiyatMohasebat_UserWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMohdoodiyatMohasebat_User(int MahdoodiyatMohasebatId, int IdUser, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMohdoodiyatMohasebat_User(int Id, int MahdoodiyatMohasebatId, int IdUser, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMohdoodiyatMohasebat_User(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MahdoodiyatMohasebat_ShomareHesabDaramad
        #region MahdoodiyatMohasebat_ShomareHesabDaramad
        [OperationContract]
        OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad GetMahdoodiyatMohasebat_ShomareHesabDaramadDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad> GetMahdoodiyatMohasebat_ShomareHesabDaramadWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMahdoodiyatMohasebat_ShomareHesabDaramad(int MahdodiyatMohasebatId, int ShomarehesabDarmadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMahdoodiyatMohasebat_ShomareHesabDaramad(int Id, int MahdodiyatMohasebatId, int ShomarehesabDarmadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMahdoodiyatMohasebat_ShomareHesabDaramad(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CheckTaghsit
        #region CheckTaghsit
        [OperationContract]
        List<OBJ_CheckTaghsit> GetCheckTaghsit(int ElamAvarezId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTaghsit(int ElamAvarezId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PatternFish
        #region PatternFish
        [OperationContract]
        OBJ_PatternFish GetPatternFishDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PatternFish> GetPatternFishWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPatternFish(string Name, byte[] File, string pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePatternFish(int Id, string Name, int FileId, byte[] File, string pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePatternFish(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DaramadGroup
        #region DaramadGroup
        [OperationContract]
        OBJ_DaramadGroup GetDaramadGroupDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DaramadGroup> GetDaramadGroupWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDaramadGroup(string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDaramadGroup(int Id, string Title, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDaramadGroup(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DaramadGroup_Parametr
        #region DaramadGroup_Parametr
        [OperationContract]
        OBJ_DaramadGroup_Parametr GetDaramadGroup_ParametrDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DaramadGroup_Parametr> GetDaramadGroup_ParametrWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDaramadGroup_Parametr(int DaramadGroupId, string EnName, string FnName, bool Status, byte NoeField, int? ComboBoxId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDaramadGroup_Parametr(int Id, int DaramadGroupId, string EnName, string FnName, bool Status, byte NoeField, int? ComboBoxId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDaramadGroup_Parametr(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DaramadGroup_ParametrValues
        #region DaramadGroup_ParametrValues
        [OperationContract]
        OBJ_DaramadGroup_ParametrValues GetDaramadGroup_ParametrValuesDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DaramadGroup_ParametrValues> GetDaramadGroup_ParametrValuesWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDaramadGroup_ParametrValues(int ElamAvarezId, int ParametrGroupDaramadId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDaramadGroup_ParametrValues(int Id, int ElamAvarezId, int ParametrGroupDaramadId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDaramadGroup_ParametrValues(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PatternFish_DaramadGroup
        #region PatternFish_DaramadGroup
        [OperationContract]
        OBJ_PatternFish_DaramadGroup GetPatternFish_DaramadGroupDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PatternFish_DaramadGroup> GetPatternFish_DaramadGroupWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPatternFish_DaramadGroup(int PatternFishId, int DaramadGroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePatternFish_DaramadGroup(int Id, int PatternFishId, int DaramadGroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CodHayeDarAmad_Asli
        #region CodHayeDarAmad_Asli
        [OperationContract]
        List<OBJ_CodHayeDarAmad_Asli> GetCodHayeDarAmad_AsliWithFilter(string azTarikh, string taTarikh, int? shomareHesabId, int? codeDaramadId, int? organId, string fieldname, byte DateType, int Top, string IP, out ClsError Error);
        #endregion

        //CodeDarAmadAsli
        #region CodeDarAmadAsli
        [OperationContract]
        List<OBJ_ShomareHesabCodeDaramad> GetCodeDarAmadAsliWithFilter(string IP, out ClsError Error);
        #endregion

        //Company
        #region Company
        [OperationContract]
        OBJ_Company GetCompanyDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Company> GetCompanyWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCompany(string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService, int? fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCompany(int Id, string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService, int? fldOrganId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCompany(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ShomareHesab_AshkhasForXml
        #region ShomareHesab_AshkhasForXml
        [OperationContract]
        int AshkhasIdForXmlInput(byte type, string codeMeli, string name, string family, string shomareSabt, byte typeShakhs, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        int ShomareHesabIdForXml(string shomareHesab, string infBank, int ashkhasId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //FishSaderShodeForXml
        #region FishSaderShodeForXml
        [OperationContract]
        List<OBJ_FishSaderShodeForXml> GetFishSaderShodeForXmlOutWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //UpdateSendToMali_Fish
        #region UpdateSendToMali_Fish
        [OperationContract]
        string UpdateSendToMali_Fish(string FieldName, bool Flag, int id, string IP, out ClsError Error);
        #endregion

        //UpdateSendToMali_Check
        #region UpdateSendToMali_Check
        [OperationContract]
        string UpdateSendToMali_Check(int id, bool Flag, string IP, out ClsError Error);
        #endregion

        //UpdateReceive_Check
        #region UpdateReceive_Check
        [OperationContract]
        string UpdateReceive_Check(int CheckId,int Document_HeaderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        //InsertCheckIntoSanad
        #region InsertCheckIntoSanad
        [OperationContract]
        string InsertCheckIntoSanad(int CheckId,string DocDate, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
         
        //Ashkhas_Taghsit
        #region Ashkhas_Taghsit
        [OperationContract]
        List<OBJ_Ashkhas_Taghsit> GetAshkhas_Taghsit(int ElamAvarezId, string IP, out ClsError Error);
        #endregion

        //GetAshkhas_ElamAvarez
        #region GetAshkhas_ElamAvarez
        [OperationContract]
        List<OBJ_Ashkhas_ElamAvarez> GetAshkhas_ElamAvarez(string FieldName, string FilterValue, int Top,int AshkhasId, string IP, out ClsError Error);
        #endregion

        //Ashkhas_Fish
        #region Ashkhas_Fish
        [OperationContract]
        List<OBJ_Ashkhas_Fish> GetAshkhas_Fish(int ElamAvarezId, string IP, out ClsError Error);
        #endregion

        //EmalTakhfif
        #region EmalTakhfif
        [OperationContract]
        List<OBJ_EmalTakhfif> GetEmalTakhfif(int ElamAvarezId, string IP, out ClsError Error);
        #endregion

        //UpdateCodhayeDaramadiElamAvarez_Takhfif
        #region UpdateCodhayeDaramadiElamAvarez_Takhfif
        [OperationContract]
        string UpdateCodhayeDaramadiElamAvarez_Takhfif(int Id, int Tedad, long TakhfifAsliValue, int ElamAvarezId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GozareshatFile
        #region GozareshatFile
        [OperationContract]
        OBJ_GozareshatFile GetGozareshatFileDetail(int Id,string OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GozareshatFile> GetGozareshatFileWithFilter(string FieldName, string FilterValue, string OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGozareshatFile(int GozareshatId, int fldOrganId, byte[] file, string passvand, string Desc, string Username, string Password,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGozareshatFile(int Id, int GozareshatId, int fldOrganId, int ReportFileId, byte[] file, string passvand, string Desc, string Username, string Password,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGozareshatFile(int id, string Username, string Password,int OrganId, string IP, out ClsError Error);
        #endregion

        //Gozareshat
        #region Gozareshat
        [OperationContract]
        List<OBJ_GozareshatFile> GetGozareshatWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //ParametrHesabdari
        #region ParametrHesabdari
        [OperationContract]
        OBJ_ParametrHesabdari GetParametrHesabdariDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParametrHesabdari> GetParametrHesabdariWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParametrHesabdari(int ShomareHesabCodeDaramadId, string CodeHesab, Nullable<int> HesabId, int CompanyId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParametrHesabdari(int Id, int ShomareHesabCodeDaramadId, string CodeHesab, Nullable<int> HesabId, int CompanyId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParametrHesabdari(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        #region MapCodingDaramad
        [OperationContract]
        string MapCodingDaramad(string oldCode, string newCode, string title, string pcode, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
    }
}
