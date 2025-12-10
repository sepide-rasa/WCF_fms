using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Archive;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.BLL.Archive
{
    public class BL_ArchiveTree
    {
        DL_ArchiveTree ArchiveTree = new DL_ArchiveTree();

        #region Detail
        public OBJ_ArchiveTree Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ArchiveTree.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ArchiveTree> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            return ArchiveTree.Select(FieldName, FilterValue, FilterValue2, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(int? PID, string Title, bool FileUpload, int fldModuleId, int fldOrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ArchiveTree.CheckRepeatedRow(Title, PID, fldModuleId, fldOrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return 0;

            return ArchiveTree.Insert(PID, Title, FileUpload,fldModuleId,fldOrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int? PID, string Title, bool FileUpload, int fldModuleId, int fldOrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
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
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ArchiveTree.CheckRepeatedRow(Title, PID, fldModuleId, fldOrganId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ArchiveTree.Update(Id, PID, Title, FileUpload, fldModuleId, fldOrganId, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (ArchiveTree.CheckDeleteNodeTree(id,OrganId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا ابتدا فرزندان شاخه مورد نظر را حذف نمایید.";
            }
            else if (ArchiveTree.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ArchiveTree.Delete(id, userId);
        }
        #endregion

        #region SelectArchiveTree_Module
        public List<OBJ_ArchiveTree> SelectArchiveTree_Module(string FilterValue, int OrganId, int ModuleId)
        {
            return ArchiveTree.SelectArchiveTree_Module(FilterValue, OrganId, ModuleId);
        }
        #endregion
    }
}