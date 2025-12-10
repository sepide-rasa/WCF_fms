using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_CodingDetail_CaseType
    {
        DL_CodingDetail_CaseType CodingDetail_CaseType = new DL_CodingDetail_CaseType();

        #region Detail
        public OBJ_CodingDetail_CaseType Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingDetail_CaseType.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CodingDetail_CaseType> Select(string FieldName, string FilterValue, int h)
        {
            return CodingDetail_CaseType.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldCodingDetailId, int fldCaseTypeId, int UserId, string IP,  out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return CodingDetail_CaseType.Insert(fldCodingDetailId, fldCaseTypeId,UserId, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldCodingDetailId, int fldCaseTypeId, int UserId, string IP,  out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
           
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع پرونده جهت ویرایش ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return CodingDetail_CaseType.Update(Id, fldCodingDetailId,fldCaseTypeId, UserId, IP);

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

            return CodingDetail_CaseType.Delete(id, userId);
        }
        #endregion
    }
}