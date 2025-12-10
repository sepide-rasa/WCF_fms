using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Module_Organ
    {
        DL_Module_Organ Module_Organ = new DL_Module_Organ();
        #region Detail
        public OBJ_Module_Organ Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول-سازمان ضروری است";
            }
            if (Error.ErrorType == true)
                return null;
            return Module_Organ.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Module_Organ> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return Module_Organ.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(int OrganId, int ModuleId, int UserId, string Desc, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه سازمان ضروری است";
            }
            else if (ModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Module_Organ.CheckRepeatedRow(ModuleId, OrganId, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Module_Organ.Insert(OrganId, ModuleId, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int OrganId, int ModuleId, int UserId, string Desc, string IP, out ClsError Error)
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
                Error.ErrorMsg = "شناسه ماژول-سازمان ضروری است";
            }
            else if (OrganId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه سازمان ضروری است";
            }
            else if (ModuleId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ماژول ضروری است";
            }
            else if (Module_Organ.CheckRepeatedRow(ModuleId, OrganId, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";

            return Module_Organ.Update(Id, OrganId, ModuleId, UserId, Desc);
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
                Error.ErrorMsg = "شناسه ماژول-سازمان ضروری است";
            }
            else if (Module_Organ.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Module_Organ.Delete(Id, UserId);
        }
        #endregion
    }
}