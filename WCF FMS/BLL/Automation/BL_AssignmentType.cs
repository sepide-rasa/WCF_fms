using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_AssignmentType
    {
        DL_AssignmentType AssignmentType = new DL_AssignmentType();

        #region Detail
        public OBJ_AssignmentType Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AssignmentType.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_AssignmentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return AssignmentType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldType == "" || fldType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع ارجاع ضروری است";
            }
            else if (fldType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldType.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AssignmentType.Insert(fldType, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldType, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldType == "" || fldType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع ارجاع ضروری است";
            }
            else if (fldType.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldType.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AssignmentType.Update(Id, fldType, OrganID, UserId, Desc, IP);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AssignmentType.Delete(id, userId);
        }
        #endregion
    }
}