using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDeceasedService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IDeceasedService
    {
        //CauseOfDeath
        #region CauseOfDeath
        [OperationContract]
        OBJ_CauseOfDeath GetCauseOfDeathDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CauseOfDeath> GetCauseOfDeathWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCauseOfDeath(string fldReason, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCauseOfDeath(int Id, string fldReason, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCauseOfDeath(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //VadiSalam
        #region VadiSalam
        [OperationContract]
        OBJ_VadiSalam GetVadiSalamDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_VadiSalam> GetVadiSalamWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertVadiSalam(string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateVadiSalam(int Id, string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteVadiSalam(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Ghete
        #region Ghete
        [OperationContract]
        OBJ_Ghete GetGheteDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Ghete> GetGheteWithFilter(string FieldName, string FilterValue, int id, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGhete(int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGhete(int Id, int fldVadiSalamId, string fldNameGhete, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGhete(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGheteKhali(int fldGheteId, int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Ghete> SelectGheteDetail(int GheteId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAllTablesOnGhete(int GheteId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTedadTabaghat(int fldGheteId, string fldShomare, string fldNameGhete, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Radif
        #region Radif
        [OperationContract]
        OBJ_Radif GetRadifDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Radif> GetRadifWithFilter(string FieldName, string FilterValue, int Id, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRadif(int fldGheteId, string fldNameRadif, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRadif(int Id, int fldGheteId, string fldNameRadif, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRadif(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Shomare
        #region Shomare
        [OperationContract]
        OBJ_Shomare GetShomareDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Shomare> GetShomareWithFilter(string FieldName, string FilterValue, int Id, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomare(int fldRadifId, string fldShomare, byte fldTedadTabaghat, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomare(int Id, int fldRadifId, string fldShomare, byte fldTedadTabaghat, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomare(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Tabaghe> SelectTabaghe(int ShomareId, int Id, string IP, out ClsError Error);
        #endregion

        //GhabreAmanat
        #region GhabreAmanat
        [OperationContract]
        OBJ_GhabreAmanat GetGhabreAmanatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GhabreAmanat> GetGhabreAmanatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGhabreAmanat(int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGhabreAmanat(int Id, int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGhabreAmanat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GhabrPor_Khali> RptGhabrPor_Khali(string FieldName, int VadiId, int GheteId, int RadifId, int ShomareId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_EmployeeInGhabrAmanat> SelectInfoEmployeeInGhabrAmanat(int ShomareId, byte ShomareTabaghe, string IP, out ClsError Error);
        #endregion

        //Motevaffa
        #region Motevaffa
        [OperationContract]
        OBJ_Motevaffa GetMotevaffaDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Motevaffa> GetMotevaffaWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMotevaffa(int? ShomareId, int? EmployeeId, int? fldCauseOfDeathId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMotevaffa(int Id, int? fldCauseOfDeathId, int? fldGhabreAmanatId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMotevaffa(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //MahalFot
        #region MahalFot
        [OperationContract]
        OBJ_MahalFot GetMahalFotDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MahalFot> GetMahalFotWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMahalFot(string fldNameMahal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMahalFot(int Id, string fldNameMahal, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMahalFot(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InsertEmploye
        #region InsertEmploye
        [OperationContract]
        int InsertEmploye(string CodeMeli, string CodeMoshakhase, string Name, string Family, string Sh_Sh, string NameFather, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CodeDaramadAramestan
        #region CodeDaramadAramestan
        [OperationContract]
        OBJ_CodeDaramadAramestan GetCodeDaramadAramestanDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CodeDaramadAramestan> GetCodeDaramadAramestanWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCodeDaramadAramestan(int fldCodeDaramadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCodeDaramadAramestan(int Id, int fldCodeDaramadId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCodeDaramadAramestan(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Actions
        #region Actions
        [OperationContract]
        OBJ_Actions GetActionsDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Actions> GetActionsWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertActions(string fldTitleAction, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateActions(int Id, string fldTitleAction, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
         string DeleteActions(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Kartabl
        #region Kartabl
        [OperationContract]
          OBJ_Kartabl GetKartablDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
          List<OBJ_Kartabl> GetKartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKartabl(string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKartabl(int Id, string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
          string DeleteKartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateOrderKartabl(int fldKartablId, int fldOrderId, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Action_Kartabl
        #region Action_Kartabl
        [OperationContract]
        OBJ_Action_Kartabl GetAction_KartablDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Action_Kartabl> GetAction_KartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAction_Kartabl(int ActionId, int KartablId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAction_Kartabl(int Id, int ActionId, int KartablId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAction_Kartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //NextKartabl
        #region NextAction
        [OperationContract]
        OBJ_NextKartabl GetNextKartablDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_NextKartabl> GetNextKartablWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertNextKartabl(int fldKartablNextId, int ActionId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateNextKartabl(int Id, int fldKartablNextId, int ActionId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteNextKartabl(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //RequestAmanat
        #region RequestAmanat
        [OperationContract]
        OBJ_RequestAmanat GetRequestAmanatDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_RequestAmanat> GetRequestAmanatWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertRequestAmanat(int fldEmployeeId, int fldShomareId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRequestAmanat(int Id, int fldEmployeeId, int fldShomareId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteRequestAmanat(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateRequestForEbtal(int Id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEtmamCharkhe(int Id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Kartabl_Request
        #region Kartabl_Request
        [OperationContract]
        OBJ_Kartabl_Request GetKartabl_RequestDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Kartabl_Request> GetKartabl_RequestWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKartabl_Request(int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKartabl_Request(int Id, int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKartabl_Request(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //SelectTimeLine
        #region SelectTimeLine
        [OperationContract]
        List<OBJ_TimeLine> SelectTimeLine(int RequestId, string IP, out ClsError Error);
        #endregion
    }
}
