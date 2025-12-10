using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;


namespace WCF_FMS.BLL.Common
{
    public class BL_Masoulin_Detail
    {
        DL_Masoulin_Detail Masoulin_Detail = new DL_Masoulin_Detail();
        #region Detail
        public OBJ_Masoulin_Detail Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه جزئیات مسئول ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return Masoulin_Detail.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Masoulin_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return Masoulin_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int? EmployeeId, int? OrganPostId, int MasoulinId, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (MasoulinId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد جزئیات مسئول ضروری است";
            }
            else if (EmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (OrganPostId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            /*else if (Masoulin_Detail.CheckRepeatedRow(MasoulinId, EmployeeId, OrganPostId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }*/
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Masoulin_Detail.Insert(EmployeeId, OrganPostId, MasoulinId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (MasoulinId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد جزئیات مسئول ضروری است";
            }
            else if (EmployeeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (OrganPostId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            else if (OrderId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ترتیبی ضروری است";
            }
            /*else if (Masoulin_Detail.CheckRepeatedRow(MasoulinId, EmployeeId, OrganPostId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }*/
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Masoulin_Detail.Update(Id, EmployeeId, OrganPostId, MasoulinId, OrderId, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه جزئیات مسئول ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Masoulin_Detail.Delete(FieldName,Id, UserId);
        }
        #endregion
        #region Masoulin_DetailList
        public List<OBJ_Masoulin_DetailList> Masoulin_DetailList(int HeaderId)
        {
            return Masoulin_Detail.Masoulin_DetailList(HeaderId);
        }
        #endregion
    }
}