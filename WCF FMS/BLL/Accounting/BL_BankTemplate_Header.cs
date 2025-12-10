using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_BankTemplate_Header
    {
        DL_BankTemplate_Header BankTemplate = new DL_BankTemplate_Header();
        #region Detail
        public OBJ_BankTemplate_Header Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return BankTemplate.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_BankTemplate_Header> Select(string FieldName, string FilterValue, int h)
        {
            return BankTemplate.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string NamePattern, short StartRow, byte[] fldImage, string fldPasvand, System.Data.DataTable Details, int UserId, string IP, string Desc, out ClsError error)
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
            else if (NamePattern == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان الگو ضروری است";
            }            
            else if (StartRow == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ردیف شروع ضروری است.";
            }
            else if (fldImage == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "فایل ضروری است.";
            }
            else if (fldPasvand == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "پسوند فایل ضروری است";
            }

            for (int i = 0; i < Details.Rows.Count; i++)
            {
                if (Convert.ToInt32(Details.Rows[i]["BankId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد بانک ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return BankTemplate.Insert(NamePattern, StartRow,fldImage,fldPasvand, Details,UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id,string NamePattern, short StartRow,int? fldFileId,byte[] fldImage, string fldPasvand, System.Data.DataTable Details, int UserId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد ضروری است";
            }
            else if (NamePattern == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان الگو ضروری است";
            }
            else if (StartRow == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ردیف شروع ضروری است.";
            }

            for (int i = 0; i < Details.Rows.Count; i++)
            {
                if (Convert.ToInt32(Details.Rows[i]["BankId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد بانک ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return BankTemplate.Update(Id,NamePattern, StartRow,fldFileId,fldImage,fldPasvand, Details, UserId, IP, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
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

            if (error.ErrorType == true)
                return "خطا";

            return BankTemplate.Delete(id, userId);
        }
        #endregion
    }
}