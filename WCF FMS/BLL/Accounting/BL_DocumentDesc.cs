using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentDesc
    {
        DL_DocumentDesc DocumentDesc = new DL_DocumentDesc();

        #region Detail
        public OBJ_DocumentDesc Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DocumentDesc.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_DocumentDesc> Select(string FieldName, string FilterValue, int h)
        {
            return DocumentDesc.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, string DocDesc, bool flag, int UserId, string IP, string Desc, out ClsError error)
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
            else if (DocDesc == "" || DocDesc==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح سند ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DocDesc.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (DocumentDesc.CheckRepeatedRow(Name, 0,flag))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentDesc.Insert(Name, DocDesc,flag, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, string DocDesc, bool flag, int UserId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد شرح سند جهت ویرایش ضروری است";
            }
            else if (DocDesc == "" || DocDesc == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح سند ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DocDesc.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (DocumentDesc.CheckRepeatedRow(Name, Id, flag))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentDesc.Update(Id, Name, DocDesc,flag, UserId, IP, Desc);

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

            return DocumentDesc.Delete(id, userId);
        }
        #endregion
        #region GetParamDocumentDesc
        public List<OBJ_ParamDocumentDesc> GetParamDocumentDesc(string DocDesc)
        {
            return DocumentDesc.GetParamDocumentDesc(DocDesc);
        }
        #endregion
    }
}