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
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IPersoneliService
    {
        

        //VaziyatEsargari
        #region VaziyatEsargari
        [OperationContract]
        List<OBJ_VaziyatEsargari> GetVaziyatEsargariWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_VaziyatEsargari GetVaziyatEsargariDetail(int VaziyatEsargariId, string IP, out ClsError Error);
        [OperationContract]
        string InsertVaziyatEsargari(string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateVaziyatEsargari(int fldId, string fldTitle, bool fldMoafAsBime, bool fldMoafAsMaliyat, bool fldMoafAsBimeOmr, bool fldMoafAsBimeTakmili, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteVaziyatEsargari(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //PersonalStatus
        #region PersonalStatus
        [OperationContract]
        List<OBJ_PersonalStatus> GetPersonalStatusWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_PersonalStatus GetPersonalStatusDetail(int PersonalStatusId, string IP, out ClsError Error);
        [OperationContract]
        string InsertPersonalStatus(int StatusId, int? PrsPesonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePersonalStatus(int PersonalStatusId, int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeletePersonalStatus(int PersonalStatusId, string UserName, string Password, string IP, out ClsError Error);
        #endregion


        //HistoryNoeEstekhdam
        #region HistoryNoeEstekhdam
        /// <summary>
        ///.خاص بر میگرداند fieldname تمامی اطلاعات جدول نظام وظیفه را با یک
        /// </summary>
        /// <param name="FieldName">.انجام می شود select نام فیلدی که بر اساس آن</param>
        /// <param name="FilterValue">fieldname مقدار مربوط به </param>
        /// <param name="Top"> تعداد دلخواه برای برگرداندن سطرهای مورد نیاز</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="Error">ذخیره می شود<see cref="ClsError"/>کلاس ErrorMsg اگر تابع با خطایی مواجه شود متن خطا در فیلد</param>
        /// <returns></returns>
        [OperationContract]
        List<OBJ_HistoryNoeEstekhdam> GetHistoryNoeEstekhdamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        /// <summary>
        /// از این تابع برای دسترسی به اطلاعات یک سطر از جدول نظام وظیفه استفاده می شود.
        /// </summary>
        /// <param name="NezamVazifeId">کد جدول نظام وظیفه</param>
        /// <param name="Username">نام کاربری </param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سیستم کاربر IP</param>
        /// <param name="Error">ذخیره می شود<see cref="ClsError"/>کلاس ErrorMsg اگر تابع با خطایی مواجه شود متن خطا در فیلد</param>
        /// <returns>اطلاعات مربوط به هر کد فرستاده شده از جدول نظام وظیفه را برمی گرداند.</returns>
        [OperationContract]
        OBJ_HistoryNoeEstekhdam GetHistoryNoeEstekhdamDetail(int HistoryNoeEstekhdamId, int OrganId, string IP, out ClsError Error);
        /// <summary>
        /// .برای ثبت اطلاعات جدید در جدول نظام وظیفه استفاده می شود
        /// </summary>
        /// <param name="fldTitle"> عنوان نظام وظیفه </param>
        /// <param name="Desc"> توضیحات مربوطه که فیلدی اختیاری است</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سیستم کاربر IP </param>
        /// <param name="Error">ذخیره می شود<see cref="ClsError"/>کلاس ErrorMsg اگر تابع با خطایی مواجه شود متن خطا در فیلد</param>
        /// <returns></returns>
        [OperationContract]
        string InsertHistoryNoeEstekhdam(int PrsPersonalInfoId, int NoeEstekhdamId, string Tarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHistoryNoeEstekhdam(int HistoryNoeEstekhdamId, int PrsPersonalInfoId, int NoeEstekhdamId, string Tarikh, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHistoryNoeEstekhdam(int HistoryNoeEstekhdamId, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //PersonalInfo
        #region PersonalInfo
        [OperationContract]
        List<OBJ_PersonalInfo> GetPersoneliInfoWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_PersonalInfo GetPersoneliInfoDetail(int PersonalInfoId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertPersoneliInfo(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, byte[] Image, string Pasvand, string DateTaghirVaziyat, int NoeEstekhdamId, string Tarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePersonelilInfo(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, int FileId, byte[] Image, string Pasvand, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePersoneliInfo(int PersoneliInfoId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PersonalInfo> GetPersoneliInfo_HokmWithFilter(string FieldName, string FilterValue, int OrganId, int UserId, int Top, string IP, out ClsError Error);
        #endregion

        

        //SavabeghGroupTashvighi
        #region SavabeghGroupTashvighi
        [OperationContract]
        List<OBJ_SavabeghGroupTashvighi> GetSavabeghGroupTashvighiWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_SavabeghGroupTashvighi GetSavabeghGroupTashvighiDetail(int SavabeghGroupTashvighiId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertSavabeghGroupTashvighi(int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSavabeghGroupTashvighi(int fldId, int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSavabeghGroupTashvighi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AnvaGroupTashvighi
        #region AnvaGroupTashvigh
        [OperationContract]
        List<OBJ_AnvaGroupTashvighi> GetAnvaGroupTashvighiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_AnvaGroupTashvighi GetAnvaGroupTashvighiDetail(byte Id, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnvaGroupTashvighi(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnvaGroupTashvighi(byte AnvaGroupTashvighiId, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnvaGroupTashvighi(byte AnvaGroupTashvighiId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        

        //MaxPersonalEstekhdamType
        #region MaxPersonalEstekhdamType
        [OperationContract]
        List<OBJ_MaxPersonalEstekhdamType> GetMaxPersonalEstekhdamType(string fieldName, int PersonalId, string tarikh, string IP, out ClsError Error);
        #endregion

        //SavabegheSanavateKHedmat
        #region SavabegheSanavateKHedmat
        [OperationContract]
        List<OBJ_SavabegheSanavateKHedmat> GetSavabegheSanavateKHedmatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_SavabegheSanavateKHedmat GetSavabegheSanavateKHedmatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertSavabegheSanavateKHedmat(int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSavabegheSanavateKHedmat(int Id, int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSavabegheSanavateKHedmat(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion


        //DigitalArchive
       /* #region DigitalArchive
        [OperationContract]
        OBJ_DigitalArchive GetDigitalArchiveDetail(int Id, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DigitalArchive> GetDigitalArchiveWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, out ClsError Error);
        [OperationContract]
        string InsertDigitalArchive(int PersonalId, int TreeId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertMainDigitalArchive(int PersonalId, int TreeId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateForBookMarkDigitalArchive(string ImageFile, int TreeId, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDigitalArchive(int PersonalId, string ImageName, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string RotateDigitalArchive(int Id, int PersonalId, byte[] ImageFile, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string MoveDigitalArchive(int TreeId, string ImageFile, string UserName, string Password, string IP, out ClsError Error);

        #endregion*/

        //HoghoghMabna
        #region HoghoghMabna
        [OperationContract]
        OBJ_HoghoghMabna GetHoghoghMabnaDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_HoghoghMabna> GetHoghoghMabnaWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertHoghoghMabna(int Year, bool Type, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHoghoghMabna(int Id, int Year, bool Type, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHoghoghMabna(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DetailHoghoghMabna
        #region DetailHoghoghMabna
        [OperationContract]
        OBJ_DetailHoghoghMabna GetDetailHoghoghMabnaDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DetailHoghoghMabna> GetDetailHoghoghMabnaWithFilter(string FieldName, string FilterValue, bool Type, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDetailHoghoghMabna(int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDetailHoghoghMabna(int Id, int HoghoghMabnaId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDetailHoghoghMabna(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PersonalHokm
        #region PersonalHokm
        [OperationContract]
        OBJ_PersonalHokm GetPersonalHokmDetail(int Id, int OrganId, int UserId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PersonalHokm> GetPersonalHokmWithFilter(string FieldName, string FilterValue, string FilterValue1, int OrganId, int UserId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertPersonalHokm(int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, string fldDesc,byte fldHokmType, string UserName, string Password, int OrganId, int IP, out ClsError Error);
        [OperationContract]
        string UpdatePersonalHokm(int Id, int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, int? FileId, byte[] File, string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, string fldDesc, byte fldHokmType, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePersonalHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AfradTahtePooshesh
        #region AfradTahtePooshesh
        [OperationContract]
        OBJ_AfradTahtePooshesh GetAfradTahtePoosheshDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AfradTahtePooshesh> GetAfradTahtePoosheshWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAfradTahtePooshesh(int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAfradTahtePooshesh(int Id, int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAfradTahtePoosheshMohasel(int Id, byte fldStatus, string fldTarikhTalagh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAfradTahtePooshesh(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

       

        //HokmReport
        #region HokmReport
        [OperationContract]
        OBJ_HokmReport GetHokmReportDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_HokmReport> GetHokmReportWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertHokmReport(string Name, byte[] File, string Pasvand, int AnvaEstekhdamId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHokmReport(int Id, string Name, int FileId, byte[] File, string Pasvand, int AnvaEstekhdamId, string Desc, int UserId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHokmReport(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //DetailPayeSanavati
        #region DetailPayeSanavati
        [OperationContract]
        OBJ_DetailPayeSanavati GetDetailPayeSanavatiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DetailPayeSanavati> GetDetailPayeSanavatiFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDetailPayeSanavati(int PayeSanavatiId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDetailPayeSanavati(int Id, int PayeSanavatiId, byte Groh, int Mablagh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDetailPayeSanavati(string FieldName, int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Hokm_Item
        #region Hokm_Item
        [OperationContract]
        OBJ_Hokm_Item GetHokm_ItemDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Hokm_Item> GetHokm_ItemFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertHokm_Item(int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHokm_Item(int Id, int PersonalHokmId, int Items_EstekhdamId, int Mablagh, decimal Zarib, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHokm_Item(string FieldName, int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //MoteghayerhaAhkam
        #region MoteghayerhaAhkam
        [OperationContract]
        OBJ_MoteghayerhaAhkam GetMoteghayerhaAhkamDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MoteghayerhaAhkam> GetMoteghayerhaAhkamFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMoteghayerhaAhkam(short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMoteghayerhaAhkam(int Id, short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMoteghayerhaAhkam(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AkharinHokmSal
        #region AkharinHokmSal
        [OperationContract]
        List<OBJ_AkharinHokmSal> GetAkharinHokmSalFilter(int PersonalId, string Year, string IP, out ClsError Error);
        #endregion

        //PayeSanavati
        #region PayeSanavati
        [OperationContract]
        OBJ_PayeSanavati GetPayeSanavatiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PayeSanavati> GetPayeSanavatiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertPayeSanavati(int Year, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePayeSanavati(int Id, int Year, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePayeSanavati(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PatternSharhHokm
        #region PatternSharhHokm
        [OperationContract]
        OBJ_PatternSharhHokm GetPatternSharhHokmDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PatternSharhHokm> GetPatternSharhHokmWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPatternSharhHokm(string PatternText, string HokmType, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePatternSharhHokm(int Id, string PatternText, string HokmType, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePatternSharhHokm(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //FileForHokm
        #region FileForHokm
        [OperationContract]
        string InsertFileForHokm(int fldPersonalHokmId, byte[] fldImage, string fldPasvand, string Desc, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //GetNesbatWithPersonalInfoId
        #region GetNesbatWithPersonalInfoId
        [OperationContract]
        List<OBJ_NesbatWithPersonalInfoId> GetNesbatWithPersonalInfoId(string FieldName, int PersonalId, string IP, out ClsError Error);
        #endregion

        //SavabeghJebhe_Items
        #region SavabeghJebhe_Items
        [OperationContract]
        OBJ_SavabeghJebhe_Items GetSavabeghJebhe_ItemsDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SavabeghJebhe_Items> GetSavabeghJebhe_ItemsWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSavabeghJebhe_Items(string Title, decimal Darsad_Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSavabeghJebhe_Items(int Id, string Title, decimal Darsad_Sal, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSavabeghJebhe_Items(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SavabeghJebhe_Personal
        #region SavabeghJebhe_Personal
        [OperationContract]
        OBJ_SavabeghJebhe_Personal GetSavabeghJebhe_PersonalDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SavabeghJebhe_Personal> GetSavabeghJebhe_PersonalWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSavabeghJebhe_Personal(int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSavabeghJebhe_Personal(int Id, int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSavabeghJebhe_Personal(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectSavabegheSanavateKHedmatWithFilter
        #region SelectSavabegheSanavateKHedmatWithFilter
        [OperationContract]
        List<OBJ_SavabegheSanavateKHedmat> SelectSavabegheSanavateKHedmatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        #endregion

        //TasviehHesab
        #region TasviehHesab
      
        [OperationContract]
        List<OBJ_TasviehHesab> GetTasviehHesabWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_TasviehHesab GetTasviehHesabDetail(int TasviehHesabId, int OrganId, string IP, out ClsError Error);
       [OperationContract]
        string InsertTasviehHesab(int PrsPersonalInfoId,  string Tarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTasviehHesab(int TasviehHesabId, int PrsPersonalInfoId, string Tarikh, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTasviehHesab(int TasviehHesabId, string UserName, string Password, string IP, out ClsError Error);
        #endregion


        #region PersonalSign
        [OperationContract]
        List<OBJ_PersonalSign> GetPersonalSignWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPersonalSign(int CommitionId, byte[] FileEmza, string Passvand, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Mohaseleen
        #region GetMohaseleenDetail
        [OperationContract]
        OBJ_Mohaseleen GetMohaseleenDetail(int Id, string IP, out ClsError Error);
        #endregion
        #region GetMohaseleenWithFilter
        [OperationContract]
        List<OBJ_Mohaseleen> GetMohaseleenWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion
        #region InsertMohaseleen
        [OperationContract]
        string InsertMohaseleen(int fldAfradTahtePoosheshId, int fldTarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region UpdateMohaseleen
        [OperationContract]
        string UpdateMohaseleen(int Id, int fldAfradTahtePoosheshId, int fldTarikh, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
        #region DeleteMohaseleen
        [OperationContract]
        string DeleteMohaseleen(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

    }
}
