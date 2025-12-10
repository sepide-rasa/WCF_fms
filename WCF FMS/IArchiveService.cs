using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IArchiveService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IArchiveService
    {
        //ArchiveTree
        #region ArchiveTree
        [OperationContract]
        OBJ_ArchiveTree GetArchiveTreeDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ArchiveTree> GetArchiveTreeWithFilter(string FieldName, string FilterValue, string FilterValue2, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertArchiveTree(int? PID, string Title, bool FileUpload, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateArchiveTree(int Id, int? PID, string Title, bool FileUpload, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteArchiveTree(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ArchiveTree> GetArchiveTree_Module(string FilterValue, int OrganId, int ModuleId, string IP, out ClsError Error);
        #endregion

        //FileMojaz
        #region FileMojaz
        [OperationContract]
        OBJ_FileMojaz GetFileMojazDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FileMojaz> GetFileMojazWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertFileMojaz(int ArchiveTreeId, int FormatFileId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFileMojaz(int Id, int ArchiveTreeId, int FormatFileId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFileMojaz(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //ParticularProperties
        #region ParticularProperties
        [OperationContract]
        OBJ_ParticularProperties GetParticularPropertiesDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ParticularProperties> GetParticularPropertiesWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertParticularProperties(int ArchiveTreeId, int PropertiesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateParticularProperties(int Id, int ArchiveTreeId, int PropertiesId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteParticularProperties(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        

        //Properties
        #region Properties
        [OperationContract]
        OBJ_Properties GetPropertiesDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Properties> GetPropertiesWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertProperties(string NameFn, string NameEn, int Type, int? FormulId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateProperties(int Id, string NameFn, string NameEn, int Type, int? FormulId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteProperties(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //PropertiesValues
        #region PropertiesValues
        [OperationContract]
        OBJ_PropertiesValues GetPropertiesValuesDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_PropertiesValues> GetPropertiesValuesWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPropertiesValues(int ParticularId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePropertiesValues(int Id, int ParticularId, string Value, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePropertiesValues(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion
    }
}
