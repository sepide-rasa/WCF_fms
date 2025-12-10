using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentRecord_Details
    {
        DL_DocumentRecord_Details DocumentRecord_Details = new DL_DocumentRecord_Details();
        #region Detail
        public OBJ_DocumentRecord_Details Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DocumentRecord_Details.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecord_Details> Select(string FieldName, string FilterValue, int h)
        {
            return DocumentRecord_Details.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region SelectHesabDaryaftani
        public List<OBJ_DocumentRecord_Details> SelectHesabDaryaftani(string FieldName,int FiscalYearId, int ShomareHesabId)
        {
            return DocumentRecord_Details.SelectHesabDaryaftani(FieldName,FiscalYearId, ShomareHesabId);
        }
        #endregion
        #region SelectEkhtetamiye
        public List<OBJ_DocumentRecord_Details> SelectEkhtetamiye(int FiscalYearId)
        {
            return DocumentRecord_Details.SelectEkhtetamiye(FiscalYearId);
        }
        #endregion
        #region SelectBastanHesabha
        public List<OBJ_DocumentRecord_Details> SelectBastanHesabha(int FiscalYearId)
        {
            return DocumentRecord_Details.SelectBastanHesabha(FiscalYearId);
        }
        #endregion
        #region SelectEftetahiye
        public List<OBJ_DocumentRecord_Details> SelectEftetahiye(int FiscalYearId)
        {
            return DocumentRecord_Details.SelectEftetahiye(FiscalYearId);
        }
        #endregion
        #region SelectDocFiles
        public List<OBJ_DocFiles> SelectDocFiles(short Year,int OrganId,int CodingId)
        {
            return DocumentRecord_Details.SelectDocFiles(Year, OrganId, CodingId);
        }
        #endregion
        //#region Insert
        //public string Insert(int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseTypeId, int SourceId, int UserId, string IP, string Desc, out ClsError error)
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
        //    else if (HeaderId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد ثبت سند ضروری است";
        //    }
        //    else if (CodingId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد Coding ضروری است";
        //    }
        //    else if (Description == "" || Description==null)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "شرح سند ضروری است";
        //    }
        //    /*else if (CenterCoId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد مراکز هزینه ضروری است";
        //    }
        //    else if (CaseTypeId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد نوع پرونده ضروری است";
        //    }
        //    else if (SourceId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد پرونده ضروری است";
        //    }*/
        //    else if (Description.Length < 2)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
        //    }
        //    if (error.ErrorType == true)
        //        return "خطا";

        //    return DocumentRecord_Details.Insert(HeaderId, CodingId, Description, BedehKar, BestanKar, CenterCoId, CaseTypeId,SourceId, UserId, IP, Desc);

        //}
        //#endregion
        //#region Update
        //public string Update(int Id, int HeaderId, int CodingId, string Description, long BedehKar, long BestanKar, int? CenterCoId, int CaseId, int CaseTypeId, int SourceId, int UserId, string IP, string Desc, out ClsError error)
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
        //    else if (Id == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد جهت ویرایش ضروری است";
        //    }
        //    else if (HeaderId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد ثبت سند ضروری است";
        //    }
        //    else if (CodingId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد Coding ضروری است";
        //    }
        //    else if (Description == "" || Description == null)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "شرح سند ضروری است";
        //    }
        //    /*else if (CenterCoId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد مراکز هزینه ضروری است";
        //    }
        //    else if (CaseId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد پرونده ضروری است";
        //    }
        //    else if (CaseTypeId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد نوع پرونده ضروری است";
        //    }
        //    else if (SourceId == 0)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "کد پرونده ضروری است";
        //    }*/
        //    else if (Description.Length < 2)
        //    {
        //        error.ErrorType = true;
        //        error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
        //    }
        //    if (error.ErrorType == true)
        //        return "خطا";

        //    return DocumentRecord_Details.Update(Id, HeaderId, CodingId, Description, BedehKar, BestanKar, CenterCoId, CaseId, CaseTypeId, SourceId, UserId, IP, Desc);

        //}
        //#endregion
        #region Delete
        public string Delete(string FieldName, int id, int userId, out ClsError error)
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

            return DocumentRecord_Details.Delete(FieldName, id, userId);
        }
        #endregion

        #region DeleteDocumentDetail
        public string DeleteDocumentDetail( int HeaderId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Details.DeleteDocumentDetail(HeaderId, userId);
        }
        #endregion
    }
}