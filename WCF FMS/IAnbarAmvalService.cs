using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAnbarAmvalService" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IAnbarAmvalService
    {
        //InsuranceType
        #region InsuranceType
        [OperationContract]
        OBJ_InsuranceType GetInsuranceTypeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InsuranceType> GetInsuranceTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInsuranceType(string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInsuranceType(int fldId, string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInsuranceType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InsuranceCompany
        #region InsuranceCompany
        [OperationContract]
        OBJ_InsuranceCompany GetInsuranceCompanyDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_InsuranceCompany> GetInsuranceCompanyWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInsuranceCompany(string Name, byte[] File, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateInsuranceCompany(int Id, string Name, int FileId, byte[] File, string Pasvand, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteInsuranceCompany(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Anbar
        #region Anbar
        [OperationContract]
        OBJ_Anbar GetAnbarDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Anbar> GetAnbarWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnbar(string Name, string Address, string Phone, string AnbarTreeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnbar(int Id, string Name, string Address, string Phone,string AnbarTreeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnbar(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePID_Anbar(int Child, int Parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePID_Anbar_Tree(int Anbar_TreeId, int Parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //UpdatePID_kala
        #region UpdatePID_kala
        [OperationContract]
        string UpdatePID_kala(int Child, int Parent, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AnbarTree
        #region AnbarTree
        [OperationContract]
        OBJ_AnbarTree GetAnbarTreeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AnbarTree> GetAnbarTreeWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnbarTree(int? PID, string Name,int GroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnbarTree(int Id, string Name, int GroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnbarTree(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KalaTree
        #region KalaTree
        [OperationContract]
        OBJ_KalaTree GetKalaTreeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KalaTree> GetKalaTreeWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKalaTree(int? PID, string Name, int GroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKalaTree(int Id, string Name, int GroupId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKalaTree(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AnbarGroup
        #region AnbarGroup
        [OperationContract]
        OBJ_AnbarGroup GetAnbarGroupDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AnbarGroup> GetAnbarGroupWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAnbarGroup(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAnbarGroup(int Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnbarGroup(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //KalaGroup
        #region KalaGroup
        [OperationContract]
        OBJ_KalaGroup GetKalaGroupDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_KalaGroup> GetKalaGroupWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKalaGroup(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKalaGroup(int Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKalaGroup(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Anbar_Tree
        #region Anbar_Tree
        [OperationContract]
        string InsertAnbar_Tree(int AnbarId, int AnbarTreeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAnbar_Tree(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Kala_Tree
        #region Kala_Tree
        [OperationContract]
        string InsertKala_Tree(int KalaId, int KalaTreeId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //kala_TarifNashode
        #region kala_TarifNashode
        [OperationContract]
        List<OBJ_kala_TarifNashode> Getkala_TarifNashode(int GorupId, string IP, out ClsError Error);
        #endregion

        //Anbar_TarifNashode
        #region Anbar_TarifNashode
        [OperationContract]
        List<OBJ_Anbar_TarifNashode> GetAnbar_TarifNashode(int GorupId, string IP, out ClsError Error);
        #endregion

    }
}
