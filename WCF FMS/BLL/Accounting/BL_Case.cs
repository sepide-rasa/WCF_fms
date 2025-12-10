using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_Case
    {
        DL_Case Case = new DL_Case();

        #region Detail
        public OBJ_Case Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Case.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Case> Select(string FieldName, string FilterValue, int h)
        {
            return Case.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int CaseTypeId, int SourceId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (CaseTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع پرونده ضروری است";
            }
            else if (SourceId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "SourceId ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Case.Insert(CaseTypeId, SourceId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int CaseTypeId, int SourceId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (CaseTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع پرونده ضروری است";
            }
            else if (SourceId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "SourceId ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Case.Update(Id, CaseTypeId, SourceId, UserId, IP, Desc);

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
            else if (Case.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Case.Delete(id, userId);
        }
        #endregion
    }
}