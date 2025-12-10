using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_DigitalArchiveTreeStructure
    {
        DL_DigitalArchiveTreeStructure DigitalArchiveTreeStructure = new DL_DigitalArchiveTreeStructure();
        #region Detail
        public OBJ_DigitalArchiveTreeStructure Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گره ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return DigitalArchiveTreeStructure.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_DigitalArchiveTreeStructure> Select(string FieldName, string FilterValue, int h)
        {
            return DigitalArchiveTreeStructure.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int? PID, int? ModuleId,string Title,bool AttachFile, string Desc, int UserId,string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PID == null && ModuleId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا یکی از فیلدهای PID یا ModuleId را مقداردهی کنید";
            }
            else if (PID != null && ModuleId != null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تنها یکی از فیلدهای ModuleId یا PID را مقداردهی نمایید";
            }
            else if (PID == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گره پدر ضروری است";
            }
            else if (ModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Title == null || Title=="")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 400)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DigitalArchiveTreeStructure.CheckRepeatedRow(ModuleId, PID, Title,0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchiveTreeStructure.Insert(Title, PID, ModuleId, AttachFile, Desc, UserId);
        }
        #endregion
        #region Update
        public string Update(int Id,int? PID, int? ModuleId,string Title,bool AttachFile, string Desc, int UserId ,string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گره ضروری است";
            }
            else if (PID == null && ModuleId == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "لطفا یکی از فیلدهای PID یا ModuleId را مقداردهی کنید";
            }
            else if (PID != null && ModuleId != null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تنها یکی از فیلدهای ModuleId یا PID را مقداردهی نمایید";
            }
            else if (PID == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گره پدر ضروری است";
            }
            else if (ModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Title == null || Title == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 400)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DigitalArchiveTreeStructure.CheckRepeatedRow(ModuleId, PID, Title, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchiveTreeStructure.Update(Id,Title, PID, ModuleId, AttachFile, Desc, UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه گره ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return DigitalArchiveTreeStructure.Delete(Id, UserId);
        }
        #endregion
    }
}