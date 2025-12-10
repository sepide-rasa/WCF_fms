using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentRecorde_File
    {
        DL_DocumentRecorde_File DocumentRecorde = new DL_DocumentRecorde_File();

        #region Detail
        public OBJ_DocumentRecorde_File Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DocumentRecorde.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecorde_File> Select(string FieldName, string FilterValue, int h)
        {
            return DocumentRecorde.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int DocumentHeaderId, byte[] Image, string Pasvand, int UserId, string IP, string Desc, out ClsError error)
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
            else if (DocumentHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecorde.Insert(DocumentHeaderId, Image, Pasvand, UserId, IP, Desc);

        }
        #endregion
        //#region Update
        //public string Update(int Id, string Name, int UserId, string IP, string Desc, out ClsError error)
        //{
        //    error = new ClsError();
        //    error.ErrorType = false;
        //    if (Desc == null)
        //        Desc = "";
        //    if (UserId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "شناسه کاربر ضروری است";
        //    }
        //    else if (Name == "" || Name == null)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "عنوان ضروری است";
        //    }
        //    else if (Id == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد انواع پرونده جهت ویرایش ضروری است";
        //    }
        //    else if (Name.Length < 2)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
        //    }
        //    else if (Name.Length > 200)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
        //    }
        //    if (error.ErrorType == true)
        //        return "خطا";

        //    return DocumentRecorde.Update(Id, Name, UserId, IP, Desc);

        //}
        //#endregion
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

            return DocumentRecorde.Delete(id, userId);
        }
        #endregion
    }
}