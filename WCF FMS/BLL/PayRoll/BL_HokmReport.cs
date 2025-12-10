using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_HokmReport
    {
        DL_HokmReport HokmReport = new DL_HokmReport();
        #region Detail
        public OBJ_HokmReport Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return HokmReport.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_HokmReport> Select(string FieldName, string FilterValue, int h)
        {
            return HokmReport.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, byte[] File, string Pasvand, int AnvaEstekhdamId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            
            else if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }

            else if (AnvaEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return HokmReport.Insert(fldName,File,Pasvand,AnvaEstekhdamId,UserId,Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, string fldName,int FileId, byte[] File, string Pasvand, int AnvaEstekhdamId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            
            if (fldName == null || fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عنوان ضروری است";
            }

            else if (AnvaEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد انواع استخدام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 50)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return HokmReport.Update(Id, fldName, FileId, File, Pasvand, AnvaEstekhdamId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return HokmReport.Delete(Id, UserId);
        }
        #endregion
    }
}