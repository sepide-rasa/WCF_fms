using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_Coding_Details
    {
        DL_Coding_Details Coding_Details = new DL_Coding_Details();
        #region Detail
        public OBJ_Coding_Details Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Coding_Details.Detail(id);
        }
        #endregion
        #region GetItemId
        public int GetItemId(int HeaderId,int PId, out ClsError error)
        {
            error = new ClsError();
            if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جدول پدر است";
            }
            else if (PId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گره پدر است";
            }
            if (error.ErrorType == true)
                return 0;
            return Coding_Details.GetItemId(HeaderId, PId);
        }
        #endregion
        #region Select
        public List<OBJ_Coding_Details> Select(string FieldName, string FilterValue, string FilterValue2,string FilterValue3, int h)
        {
            return Coding_Details.Select(FieldName, FilterValue, FilterValue2, FilterValue3, h);
        }
        #endregion
        #region SelectCoding_Project
        public List<OBJ_Coding_ProjeFaaliat> SelectCoding_Project(string FieldName, string FilterValue, int h)
        {
            return Coding_Details.SelectCoding_Project(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId, Nullable<int> PID, string PCod, int? TempCodingId, string Title, string Code,string CodeDaramad, int AccountLevelId, int MahiyatId,int? Mahiyat_GardeshId, byte TypeHesabId, int UserId,int OrganId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AccountLevelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطح ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد Header ضروری است";
            }
            else if (Code.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (TypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (Coding_Details.CheckAllowedInsert_Update(PCod, HeaderId,0) == false)
            {
                if (new BL().BLPermission(1260, UserId, OrganId) == false)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "امکان اضافه کردن زیرشاخه برای این سرفصل وجود ندارد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Details.Insert(HeaderId, PID, PCod, TempCodingId, Title, Code,CodeDaramad, AccountLevelId, MahiyatId,Mahiyat_GardeshId, TypeHesabId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, int? TempCodingId, string Title, string Code,string CodeDaramad, int AccountLevelId, int MahiyatId,int? Mahiyat_GardeshId, byte TypeHesabId, int UserId,int OrganId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (AccountLevelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطح ضروری است";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد Header ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Code.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MahiyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماهیت ضروری است";
            }
            else if (TypeHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع حساب ضروری است";
            }
            else if (Coding_Details.CheckAllowedInsert_Update(Code, HeaderId,Id) == false)
            {
                if (new BL().BLPermission(1260, UserId, OrganId) == false)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "امکان ویرایش این سرفصل وجود ندارد.";
                }                
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Details.Update(Id, HeaderId, TempCodingId, Title, Code,CodeDaramad, AccountLevelId, MahiyatId,Mahiyat_GardeshId, TypeHesabId, UserId, IP, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId,int OrganId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Coding_Details.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            else if (Coding_Details.CheckDelete2(id)==false)
            {
                if (new BL().BLPermission(1260, userId, OrganId) == false)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "امکان حذف سرفصل موردنظر وجود ندارد.";
                }                  
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Details.Delete(id, userId);
        }
        #endregion
        #region GetDefaultCode_Coding
        public List<OBJ_Coding_Details> GetDefaultCode_Coding(int HeaderId, string PCode)
        {
            return Coding_Details.GetDefaultCode_Coding(HeaderId, PCode);
        }
        #endregion
        #region CheckValidCode_CodingDetail
        public int CheckValidCode_CodingDetail(int HeaderId, string Code, string PCode, int Id)
        {
            return Coding_Details.CheckValidCode_CodingDetail(HeaderId, Code, PCode, Id);
        }
        #endregion
        #region RptByCoding
        public OBJ_RptByCoding RptByCoding(int CodingId, int OrganId, short Year, byte ModuleId)
        {
            return Coding_Details.RptByCoding(CodingId, OrganId, Year, ModuleId);
        }
        #endregion
        #region CheckMahiyatGardesh_Mande
        public List<OBJ_CheckMahiyatGardesh_Mande> CheckMahiyatGardesh_Mande(int Id, int organid, short year, long bed, long best, int idDetail, int moduleSaveId)
        {
            return Coding_Details.CheckMahiyatGardesh_Mande(Id,organid, year, bed, best, idDetail, moduleSaveId);
        }
        #endregion
    }
}