using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_FMS.TOL.Common;
using WCF_FMS.TOL.Contract;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface ICommonService
    {

        [OperationContract]
        bool Permission(int AppId, int OrganId, string Username, string Password, out ClsError Error);
        [OperationContract]
        string HashPass(string Password);

        //Employee
        #region Employee
        [OperationContract]
        List<OBJ_Employee> GetEmployeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, int OrganId, out ClsError Error);
        [OperationContract]
        OBJ_Employee GetEmployeeDetail(int EmployeeId, string IP, out ClsError Error);
        [OperationContract]
        int InsertEmployee(string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateEmployee(int fldId, string fldName, string fldFamily, string fldCodemeli, bool fldStatus, byte TypeShakhs, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteEmployee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Raste
        #region
        [OperationContract]
        List<OBJ_Raste> GetRasteWithFilter(string FieldName, string FilterValue, int h,string Username, string Password, int OrganId, out ClsError Error);

        #endregion
        //State
        #region State
        [OperationContract]
        List<OBJ_State> GetStateWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_State GetStateDetail(int StateId, string IP, out ClsError Error);
        [OperationContract]
        string InsertState(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateState(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteState(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //City
        #region City
        [OperationContract]
        List<OBJ_City> GetCityWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_City GetCityDetail(int CityId, string IP, out ClsError Error);
        [OperationContract]
        string InsertCity(string fldName, int fldStateId, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCity(int fldId, string fldName, int fldStateId, string fldLatitude, string fldLongitude, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCity(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Organization
        #region Organization
        [OperationContract]
        List<OBJ_Organization> GetOrganizationWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Organization GetOrganizationDetail(int OrganizationId, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertOrganization(string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateOrganization(int fldId, string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldCityId, int fldFileId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteOrganization(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //ChartOrgan
        #region ChartOrgan
        [OperationContract]
        List<OBJ_ChartOrgan> GetChartOrganWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        OBJ_ChartOrgan GetChartOrganDetail(int ChartOrganId, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertChartOrgan(string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateChartOrgan(int fldId, string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteChartOrgan(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Module
        #region Module
        [OperationContract]
        List<OBJ_Module> GetModuleWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Module GetModuleDetail(int ModuleId, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertModule(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateModule(int ModuleId, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteModule(int ModuleId, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Module_Organ
        #region Module_Organ
        [OperationContract]
        List<OBJ_Module_Organ> GetModule_OrganWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Module_Organ GetModule_OrganDetail(int Module_OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertModule_Organ(int fldOrganId, int ModuleId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateModule_Organ(int Id, int fldOrganId, int ModuleId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteModule_Organ(int Id, string UserName, string Password, string IP, out ClsError Error);

        #endregion

        //Masoulin
        #region Masoulin
        [OperationContract]
        List<OBJ_Masoulin> GetMasoulinWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Masoulin GetMasoulinDetail(int MasoulinId, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertMasoulin(int Module_OrganId, string TarikhEjra, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMasoulin(int MasoulinId, string TarikhEjra, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Masuolin_ZirList> GetMasuolin_ZirList(int headerId, string IP, out ClsError Error);
        #endregion

        //Masoulin_Detail
        #region Masoulin_Detail
        [OperationContract]
        List<OBJ_Masoulin_Detail> GetMasoulin_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Masoulin_Detail GetMasoulin_DetailDetail(int Masoulin_DetailId, string IP, out ClsError Error);
        [OperationContract]
        string InsertMasoulin_Detail(int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMasoulin_Detail(int Msoulin_DetailId, int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMasoulin_Detail(int Id, string FieldName, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Masoulin_DetailList> GetMasoulin_DetailList(int HeaderId, string IP, out ClsError Error);
        #endregion

        //User
        #region User
        [OperationContract]
        List<OBJ_User> GetUserWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_User GetUserDetail(int User_Id, string IP, out ClsError Error);
        [OperationContract]
        int InsertUser(int EmployeeId, string fldUserName, string fldPassword, bool State, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateUser(int User_Id, int EmployeeId, string fldUserName, bool State, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteUser(int User_Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UserPassUpdate(int User_Id, string Pass, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string ChangePass(string Password, string UserName, string NewPass, out ClsError Error);
        [OperationContract]
        string ExistUser(string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_User> SelectUserByUserId(string FieldName, string FilterValue, int Top, string UserName, string Password, out ClsError Error);
        [OperationContract]
        string UpdateActiveUser(int Id, bool Active_Deactive, string IP, out ClsError Error);
        #endregion

        //Permission
        #region Permission
        [OperationContract]
        List<OBJ_Permission> GetPermissionWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertPermission(int UserGroup_ModuleOrganID, int ApplicationPartId, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeletePermission(int UserGroupId, int ModuleId, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string CopyPermission(int por, int khali, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteChildUserGroupPermission(int UserGroup_ModuleOrganId, string appId, string UserName, string Password, string IP, out ClsError Error);
        #endregion


        //UserGroup
        #region UserGroup
        [OperationContract]
        List<OBJ_UserGroup> GetUserGroupWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        OBJ_UserGroup GetUserGroupDetail(int UserGroupId, string IP, out ClsError Error);
        [OperationContract]
        int InsertUserGroup(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateUserGroup(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteUserGroup(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //User_Group
        #region User_Group
        [OperationContract]
        List<OBJ_User_Group> GetUser_GroupWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_User_Group GetUser_GroupDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        string InsertUser_Group(int UserGroupId, int UserSelectId, bool fldGrant, bool fldWithGrant, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateUser_Group(int Id, int UserGroupId, int UserSelectId, bool fldGrant, bool fldWithGrant, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteUser_Group(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //ApplictionPart
        #region ApplictionPart
        [OperationContract]
        List<OBJ_ApplictionPart> GetApplictionPartWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //ZirListHa
        #region ZirListHa
        [OperationContract]
        List<OBJ_ZirListHa> GetZirListHaWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_ZirListHa GetZirListHaDetail(int ZirListHaId, string IP, out ClsError Error);
        [OperationContract]
        string InsertZirListHa(int fldReportId, int fldMasuolin_DetailId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateZirListHa(int fldId, int fldReportId, int fldMasuolin_DetailId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteZirListHa(string FieldName, int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //File
        #region File
        [OperationContract]
        List<OBJ_File> GetFileWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);

        #endregion

        //GetDate
        #region GetDate
        [OperationContract]
        OBJ_GetDate GetDate(string IP, out ClsError Error);
        #endregion

        //DigitalArchiveTreeStructure
        #region DigitalArchiveTreeStructure
        [OperationContract]
        OBJ_DigitalArchiveTreeStructure GetDigitalArchiveTreeStructureDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_DigitalArchiveTreeStructure> GetDigitalArchiveTreeStructureWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertDigitalArchiveTreeStructure(int? PID, int? ModuleId, string Title, bool AttachFile, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateDigitalArchiveTreeStructure(int Id, int? PID, int? ModuleId, string Title, bool AttachFile, string Desc, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteDigitalArchiveTreeStructure(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //GetNameOrganForFormul
        #region GetNameOrganForFormul
        [OperationContract]
        List<OBJ_GetNameOrganForFormul> GetNameOrganForFormul(string IP, out ClsError Error);
        #endregion

        //OrganizationalPosts
        #region OrganizationalPosts
        [OperationContract]
        OBJ_OrganizationalPosts GetOrganizationalPostsDetail(int Id, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_OrganizationalPosts> GetOrganizationalPostsWithFilter(string FieldName, string FilterValue, int Top, string UserName, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertOrganizationalPosts(string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateOrganizationalPosts(int Id, string fldTitle, string fldOrgPostCode, int fldChartOrganId, int? fldPId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteOrganizationalPosts(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Bank
        #region Bank
        [OperationContract]
        OBJ_Bank GetBankDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Bank> GetBankWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertBank(string BankName, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateBank(int Id, string BankName, int FileId, byte[] File, string Pasvand, byte? CentralBankCode, string InfinitiveBank, bool Fix, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteBank(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //rptDastresiKarbaran
        #region
        [OperationContract]
        List<OBJ_RptDastresiKarbaran> GetrptDastresiKarbaranWithFilter(int? appId, int? userGroup_ModuleOrganId, string IP, out ClsError Error);
        #endregion
        //SHobe
        #region SHobe
        [OperationContract]
        OBJ_SHobe GetSHobeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_SHobe> GetSHobeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertSHobe(int BankId, string Name, int CodeSHobe, string Address, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateSHobe(int Id, int BankId, string Name, int CodeSHobe, string Address, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteSHobe(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //Error
        #region Error
        [OperationContract]
        List<OBJ_Error> GetErrorWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertError(string Matn, System.DateTime Tarikh, string IP, string Desc, string UserName, string Password, out ClsError Error);
        #endregion

        //Signers
        #region Signers
        [OperationContract]
        List<OBJ_Signers> GetSignersWithFilter(int Module_OrganId, string Tarikh, int reportId, string IP, out ClsError Error);
        #endregion

        //TreeOrganPost
        #region TreeOrganPost
        [OperationContract]
        List<OBJ_TreeOrganPost> GetTreeOrganPost(string FieldName, string Value, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //NezamVazife
        #region NezamVazife
        /// <summary>
        ///از این تابع برای دسترسی به اطلاعاتی با یک ویژگی مشخص از جدول نظام وظیفه استفاده می شود.  
        /// </summary>
        /// <param name="FieldName"><para>(معمولا این رشته نام فیلدی از جدول است که میخواهیم براساس آن فیلتر کنیم)</para>.انجام شود Select رشته ای است که نشاندهنده این است که براساس کدام فیلد از جدول نظام وظیفه</param>
        /// <param name="FilterValue"><paramref name="FieldName"/> مقدار مربوط به </param>
        /// <param name="Top">تعداد سطرهای مورد نیاز که می خواهیم برگردانده شود</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <remarks>در آنها صدق می کند برگردانده می شود <paramref name="FieldName"/> برابر با 0 باشد کلیه سطرهایی که مقدار مربوط به TOP اگر پارامتر</remarks>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>را دارا هستند، برمی گرداند <paramref name="FilterValue"/> لیستی شامل سطرهایی از جدول نظام وظیفه که مقدار موجود در پارامتر</returns>
        /// <example>
        ///در آنها برابر با معاف است را بر می گرداند Title به طور مثال تابع زیر سطر/سطرهایی از جدول نظام وظیفه که فیلد   
        /// <code>
        ///     Servic.GetNezamVazifeWithFilter("fldTitle","معاف",Top,Username,Password,Error);
        /// </code>
        /// </example>
        [OperationContract]
        List<OBJ_NezamVazife> GetNezamVazifeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        /// <summary>
        ///.از این تابع برای دسترسی به اطلاعات یک سطر خاص از جدول نظام وظیفه استفاده می شود
        /// </summary>
        /// <param name="NezamVazifeId">شناسه سطر مورد نظر از جدول نظام وظیفه</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>را از جدول مدرک تحصیلی بر می گرداند(<paramref name="NezamVazifeId">)ای شامل کلیه اطلاعات مربوط به شناسه فرستاده شده object</returns>
        [OperationContract]
        OBJ_NezamVazife GetNezamVazifeDetail(int NezamVazifeId, string IP, out ClsError Error);
        /// <summary>
        /// .از این تابع برای ثبت وضیعت های مختلف نظام وظیفه استفاده می شود
        /// </summary>
        /// <param name="fldTitle">(... عنوان وضعیت نظام وظیفه(مانند معاف، خدمت نکرده و</param>
        /// <param name="Desc"> توضیحات مربوطه که فیلدی اختیاری است</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP </param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر ذخیره با موفقیت انجام شود پیغام ذخیره موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string InsertNezamVazife(string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        /// <summary>
        /// از این تابع برای ویرایش اطلاعات یک سطر از جدول نظام وظیفه استفاده می شود
        /// </summary>
        /// <param name="fldId">شناسه سطر مورد نظر از جدول نظام وظیفه جهت ویرایش</param>
        /// <param name="fldTitle">(... عنوان وضعیت نظام وظیفه(مانند معاف، خدمت نکرده و</param>
        /// <param name="Desc">توضیحات مربوطه که فیلدی اختیاری است</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر ویرایش با موفقیت انجام شود پیغام ویرایش موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string UpdateNezamVazife(byte fldId, string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        /// <summary>
        /// از این تابع برای حذف اطلاعات یک سطر از جدول نظام وظیفه استفاده می شود
        /// </summary>
        /// <param name="id">شناسه سطر مورد نظر از جدول نظام وظیفه جهت حذف</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر حذف با موفقیت انجام شود پیغام حذف موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string DeleteNezamVazife(byte id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //MadrakTahsili
        #region MadrakTahsili
        /// <summary>
        ///از این تابع برای دسترسی به اطلاعاتی با یک ویژگی مشخص از جدول مدرک تحصیلی استفاده می شود.  
        /// </summary>
        /// <param name="FieldName"><para>(معمولا این رشته نام فیلدی از جدول است که میخواهیم براساس آن فیلتر کنیم)</para>.انجام شود Select رشته ای است که نشاندهنده این است که براساس کدام فیلد از جدول مدرک تحصیلی</param>
        /// <param name="FilterValue"><paramref name="FieldName"/> مقدار مربوط به </param>
        /// <param name="Top">تعداد سطرهای مورد نیاز که می خواهیم برگردانده شود</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <remarks>در آنها صدق می کند برگردانده می شود <paramref name="FieldName"/> برابر با 0 باشد کلیه سطرهایی که مقدار مربوط به TOP اگر پارامتر</remarks>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>را دارا هستند، برمی گرداند <paramref name="FilterValue"/> لیستی شامل سطرهایی از جدول مدرک تحصیلی که مقدار موجود در پارامتر</returns>
        /// <example>
        ///در آنها برابر با کارشناسی است را بر می گرداند Title به طور مثال تابع زیر سطر/سطرهایی از جدول مدرک تحصیلی که فیلد   
        /// <code>
        ///     Servic.GetMadrakTahsiliWithFilter("fldTitle","کارشناسی",Top,Username,Password,Error);
        /// </code>
        /// </example>
        [OperationContract]
        List<OBJ_MadrakTahsili> GetMadrakTahsiliWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        /// <summary>
        ///.از این تابع برای دسترسی به اطلاعات یک سطر خاص از جدول مدرک تحصیلی استفاده می شود
        /// </summary>
        /// <param name="MadrakTahsiliId">شناسه سطر مورد نظر از جدول مدرک تحصیلی</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>را از جدول مدرک تحصیلی بر می گرداند(<paramref name="MadrakTahsiliId">)ای شامل کلیه اطلاعات مربوط به شناسه فرستاده شده object</returns>
        [OperationContract]
        OBJ_MadrakTahsili GetMadrakTahsiliDetail(int MadrakTahsiliId, string IP, out ClsError Error);
        /// <summary>
        /// .از این تابع برای ثبت انواع مقاطع تحصیلی استفاده می شود
        /// </summary>
        /// <param name="fldTitle">(... عنوان مدرک تحصیلی(مانند کارشناسی، دکترا و</param>
        /// <param name="Desc"> توضیحات مربوطه که فیلدی اختیاری است</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP </param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر ذخیره با موفقیت انجام شود پیغام ذخیره موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string InsertMadrakTahsili(string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        /// <summary>
        /// از این تابع برای ویرایش اطلاعات یک سطر از جدول مدرک تحصیلی استفاده می شود
        /// </summary>
        /// <param name="fldId">شناسه سطر مورد نظر از جدول مدرک تحصیلی جهت ویرایش</param>
        /// <param name="fldTitle">(... عنوان مدرک تحصیلی(مانند کارشناسی، دکترا و</param>
        /// <param name="Desc">توضیحات مربوطه که فیلدی اختیاری است</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر ویرایش با موفقیت انجام شود پیغام ویرایش موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string UpdateMadrakTahsili(int fldId, string fldTitle, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        /// <summary>
        /// از این تابع برای حذف اطلاعات یک سطر از جدول مدرک تحصیلی استفاده می شود
        /// </summary>
        /// <param name="id">شناسه سطر مورد نظر از جدول مدرک تحصیلی جهت حذف</param>
        /// <param name="Username">نام کاربری</param>
        /// <param name="Password">رمز عبور کاربر</param>
        /// <param name="IP">سرور درخواست کننده IP</param>
        /// <param name="Error">این کلاس ذخیره می شود ErrorMsg که اگر تابع با خطایی مواجه شود متن خطا در فیلد <see cref="ClsError"/> نمونه ای از کلاس</param>
        /// <returns>برگردانده می شود <paramref name="Error"/> اگر حذف با موفقیت انجام شود پیغام حذف موفق و در صورت بروز خطا پیغام موجود در پارامتر</returns>
        [OperationContract]
        string DeleteMadrakTahsili(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //StatusTaahol
        #region StatusTaahol
        [OperationContract]
        List<OBJ_StatusTaahol> GetStatusTaaholWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        #endregion

        //ReshteTahsili
        #region ReshteTahsili
        [OperationContract]
        OBJ_ReshteTahsili GetReshteTahsiliDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ReshteTahsili> GetReshteTahsiliWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertReshteTahsili(string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateReshteTahsili(int Id, string Title, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteReshteTahsili(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Employee_Detail
        #region Employee_Detail
        [OperationContract]
        List<OBJ_Employee_Detail> GetEmployee_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        OBJ_Employee_Detail GetEmployee_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        string InsertEmployee_Detail(int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod, Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId, byte[] fldFile, string fldPassvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId, Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat, string Desc, string Username, string Password, int OrganId, string IP, string fldTel, string fldMobile, out ClsError Error);
        [OperationContract]
        string UpdateEmployee_Detail(int fldId, int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod, Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId, Nullable<int> fldFileId, byte[] fldFile, string fldPasvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId, Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat, string Desc, string Username, string Password, int OrganId, string IP, string fldTel, string fldMobile, out ClsError Error);
        [OperationContract]
        string DeleteEmployee_Detail(int id, string Username, string Password, string IP, out ClsError Error);

        #endregion

        //Ashkhas
        #region Ashkhas
        [OperationContract]
        OBJ_Ashkhas GetAshkhasDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Ashkhas> GetAshkhasWithFilter(string FieldName, string FilterValue, string FilterValue1, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAshkhas(Nullable<int> HaghighiId, Nullable<int> HoghoghiId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAshkhas(int Id, Nullable<int> HaghighiId, Nullable<int> HoghoghiId, string Desc, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAshkhas(int id, string Username, string Password, string IP, out ClsError Error);

        #endregion

        //MaliyatArzesheAfzoode
        #region MaliyatArzesheAfzoode
        [OperationContract]
        OBJ_MaliyatArzesheAfzoode GetMaliyatArzesheAfzoodeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MaliyatArzesheAfzoode> GetMaliyatArzesheAfzoodeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMaliyatArzesheAfzoode(string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat, decimal DarasadAmuzeshParvaresh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMaliyatArzesheAfzoode(int Id, string FromDate, string EndDate, decimal DarsadeAvarez, decimal DarsadeMaliyat, decimal DarasadAmuzeshParvaresh, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMaliyatArzesheAfzoode(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //AshkhaseHoghoghi
        #region AshkhaseHoghoghi
        [OperationContract]
        OBJ_AshkhaseHoghoghi GetAshkhaseHoghoghiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AshkhaseHoghoghi> GetAshkhaseHoghoghiWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertAshkhaseHoghoghi(string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs, byte Sayer, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateAshkhaseHoghoghi(int Id, string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs, byte Sayer, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAshkhaseHoghoghi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        //ShomareHesabeOmoomi
        #region ShomareHesabeOmoomi
        [OperationContract]
        OBJ_ShomareHesabeOmoomi GetShomareHesabeOmoomiDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ShomareHesabeOmoomi> GetShomareHesabeOmoomiWithFilter(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertShomareHesabeOmoomi(int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateShomareHesabeOmoomi(int Id, int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteShomareHesabeOmoomi(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GetUserGroupTree
        #region GetUserGroupTree
        [OperationContract]
        List<OBJ_GetUserGroupTree> GetUserGroupTreeWithFilter(int UserId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //CheckEmail
        #region CheckEmail
        [OperationContract]
        OBJ_CheckEmail CheckEmail(string Email, string IP, out ClsError Error);
        #endregion

        //MeasureUnit
        #region MeasureUnit
        [OperationContract]
        OBJ_MeasureUnit GetMeasureUnitDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_MeasureUnit> GetMeasureUnitWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertMeasureUnit(string NameVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateMeasureUnit(int Id, string NameVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteMeasureUnit(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //AshkhaseHoghoghi_Detail
        #region AshkhaseHoghoghi_Detail
        [OperationContract]
        OBJ_AshkhaseHoghoghi_Detail GetAshkhaseHoghoghi_DetailDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_AshkhaseHoghoghi_Detail> GetAshkhaseHoghoghi_DetailWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertAshkhaseHoghoghi_Detail(int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
       string UpdateAshkhaseHoghoghi_Detail(int Id, int AshkhaseHoghoghiId, string CodEghtesadi, string Address, string CodePosti, string ShomareTelephone, string Desc, string UserName, string Password,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteAshkhaseHoghoghi_Detail(int Id, string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //UserGroup_ModuleOrgan
        #region UserGroup_ModuleOrgan
        [OperationContract]
        OBJ_UserGroup_ModuleOrgan GetUserGroup_ModuleOrganDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_UserGroup_ModuleOrgan> GetUserGroup_ModuleOrganWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertUserGroup_ModuleOrgan(int UserGroupId, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateUserGroup_ModuleOrgan(int Id, int UserGroupId, int Module_OrganId, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteUserGroup_ModuleOrgan(int Id, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //InputInfo
        #region InputInfo
        [OperationContract]
        List<OBJ_InputInfo> GetInputInfoWithFilter(string FieldName, string FilterValue, bool LoginType, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertInputInfo(System.DateTime fldDateTime, string fldIP, string fldMACAddress, bool fldLoginType, string Desc, string UserName, string Password, string IP, out ClsError Error);
        #endregion


        // ChartOrganEjraee
        #region ChartOrganEjraee
        [OperationContract]
        OBJ_ChartOrganEjraee GetChartOrganEjraeeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ChartOrganEjraee> GetChartOrganEjraeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertChartOrganEjraee(string Title, Nullable<int> PId, Nullable<int> fldOrganId, byte NoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateChartOrganEjraee(int fldId, string Title, Nullable<int> PId, Nullable<int> fldOrganId, byte NoeVahed, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteChartOrganEjraee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_ChartOrganEjraee> GetChartEjraee_LastNode(int OrganId, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //OrganizationalPostsEjraee
        #region OrganizationalPostsEjraee
        [OperationContract]
        OBJ_OrganizationalPostsEjraee GetOrganizationalPostsEjraeeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_OrganizationalPostsEjraee> GetOrganizationalPostsEjraeeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string InsertOrganizationalPostsEjraee(string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateOrganizationalPostsEjraee(int fldId, string Title, string OrgPostCode, int ChartOrganId, Nullable<int> PID, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteOrganizationalPostsEjraee(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TreeOrganPostEjra
        #region TreeOrganPostEjra
        [OperationContract]
        List<OBJ_TreeOrganPost> GetTreeOrganPostEjra(string FieldName, string Value,  string UserName, string Password, string IP, out ClsError Error);
        #endregion

        //ExpirElamAvarez
        #region ChangeLetter
        [OperationContract]
        bool ChangeLetter(string IP, out ClsError Error);
        #endregion

        //WebServiceLog
        #region WebServiceLog
        [OperationContract]
        OBJ_WebServiceLog GetWebServiceLogDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_WebServiceLog> GetWebServiceLogWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertWebServiceLog(string Matn, string user, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string UpdateWebServiceLog(int Id, string Matn, string user, string Username, string Password, string IP, out ClsError Error);
        [OperationContract]
        string DeleteWebServiceLog(int id, string Username, string Password, string IP, out ClsError Error);
        #endregion

        //WarrantyType
        #region WarrantyType
        [OperationContract]
        OBJ_WarrantyType GetWarrantyTypeDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_WarrantyType> GetWarrantyTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertWarrantyType(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateWarrantyType(int Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteWarrantyType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //BillsType
        #region BillsType
        [OperationContract]
        OBJ_BillsType GetBillsTypeDetail(int StateId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_BillsType> GetBillsTypeWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertBillsType(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateBillsType(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteBillsType(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CaseBills
        #region CaseBills
        [OperationContract]
        OBJ_CaseBills GetCaseBillsDetail(int Id,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CaseBills> GetCaseBillsWithFilter(string FieldName, string FilterValue,int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCaseBills(int BillsTypeId, int FileNum, int CentercoId, int OrganChartId, int? AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCaseBills(int Id, int BillsTypeId, int FileNum, int CentercoId, int OrganChartId, int? AshkhasId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCaseBills(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //FormatFile
        #region FormatFile
        [OperationContract]
        OBJ_FormatFile GetFormatFileDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_FormatFile> GetFormatFileWithFilter(string FieldName, string FilterValue, int Top, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string InsertFormatFile(string FormatName, byte[] Icon, string Passvand, int fldSize, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateFormatFile(byte Id, string FormatName, byte[] Icon, string Passvand, int fldSize, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteFormatFile(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //GeneralSetting
        #region GeneralSetting
        [OperationContract]
        OBJ_GeneralSetting GetGeneralSettingDetail(int Id,int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GeneralSetting> GetGeneralSettingWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        int InsertGeneralSetting(string fldName, string fldValue, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGeneralSetting(byte fldId, string fldName, string fldValue, int fldModuleId, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGeneralSetting(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string Insert_GeneralSetting(string fldName, string fldValue, int fldModuleId, System.Data.DataTable ComboBox, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string Update_GeneralSetting(int fldHeaderId, string fldName, string fldValue, int fldModuleId, System.Data.DataTable ComboBox, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string Delete_GeneralSetting(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Kala
        #region Kala
        [OperationContract]
        OBJ_Kala GetKalaDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Kala> GetKalaWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertKala(string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateKala(int Id, string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteKala(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //CharacterPersianPlaque
        #region CharacterPersianPlaque
        [OperationContract]
        OBJ_CharacterPersianPlaque GetCharacterPersianPlaqueDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CharacterPersianPlaque> GetCharacterPersianPlaqueWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCharacterPersianPlaque(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCharacterPersianPlaque(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCharacterPersianPlaque(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //TypeKhodro
        #region TypeKhodro
        [OperationContract]
        OBJ_TypeKhodro GetTypeKhodroDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_TypeKhodro> GetTypeKhodroWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertTypeKhodro(string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateTypeKhodro(int fldId, string fldName, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteTypeKhodro(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        //Plaque
        #region Plaque
        [OperationContract]
        OBJ_Plaque GetPlaqueDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_Plaque> GetPlaqueWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertPlaque(byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdatePlaque(int fldId, byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeletePlaque(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        int InsertPlaque_WebService(string Harf, string Plaque2, string Plaque3, byte Serial, string IP, out ClsError Error);
        #endregion

        //GeneralSetting_ComboBox
        #region GeneralSetting_ComboBox
        [OperationContract]
        OBJ_GeneralSetting_ComboBox GetGeneralSetting_ComboBoxDetail(int Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GeneralSetting_ComboBox> GetGeneralSetting_ComboBoxWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGeneralSetting_ComboBox(byte fldGeneralSettingId, string fldTtile, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGeneralSetting_ComboBox(byte fldId, byte fldGeneralSettingId, string fldTtile, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGeneralSetting_ComboBox(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        #region GeneralSetting_Value
        [OperationContract]
        OBJ_GeneralSetting_Value GetGeneralSetting_ValueDetail(int Id, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_GeneralSetting_Value> GetGeneralSetting_ValueWithFilter(string FieldName, string FilterValue, int OrganId, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertGeneralSetting_Value(byte fldGeneralSettingId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateGeneralSetting_Value(byte fldId, byte fldGeneralSettingId, string fldValue, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteGeneralSetting_Value(int id, string Username, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

        [OperationContract]
        string UpdateOrder(string FieldName, int fldId, int OrderId, string Username, string Password, int OrganId, string IP, out ClsError Error);

         //CompanyPost
        #region GetCompany
        [OperationContract]
        OBJ_CompanyPost GetCompanyPostDetail(short Id, string IP, out ClsError Error);
        [OperationContract]
        List<OBJ_CompanyPost> GetCompanyPostWithFilter(string FieldName, string FilterValue, int Top, string IP, out ClsError Error);
        [OperationContract]
        string InsertCompanyPost(string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateCompanyPost(short Id, string Name, string Desc, string Username, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteCompanyPost(short id, string Username, string Password, int OrganId, string IP, out ClsError Error);

        #endregion

        #region SelectMonth
        [OperationContract]
         List<OBJ_Month> SelectMonth(string IP, out ClsError Error);
        #endregion

        // HesabType
        [OperationContract]
         List<OBJ_HesabType> GetHesabTypeWithFilter(string FieldName, string FilterValue, int Top, string Username, string Password, string IP, out ClsError Error);

        //LoginFailed
        [OperationContract]
        string  InsertLoginFailed(string UserName,  string IP, out ClsError Error);

        //HistoryTahsilat
        #region HistoryTahsilat
        
        [OperationContract]
        List<OBJ_HistoryTahsilat> GetHistoryTahsilatWithFilter(string FieldName, string FilterValue, string FilterValue2, int Top, string IP, out ClsError Error);
        
        [OperationContract]
        OBJ_HistoryTahsilat GetHistoryTahsilatDetail(int HistoryTahsilatId,  string IP, out ClsError Error);

        [OperationContract]
        string InsertHistoryTahsilat(int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string UpdateHistoryTahsilat(int HistoryTahsilatId, int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        [OperationContract]
        string DeleteHistoryTahsilat(int HistoryTahsilatId, string UserName, string Password, int OrganId, string IP, out ClsError Error);
        #endregion

    }

   
}
