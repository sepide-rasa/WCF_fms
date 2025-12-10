using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_TabagheBandi
    {
        DL_TabagheBandi TabagheBandi = new DL_TabagheBandi();

        #region Detail
        public OBJ_TabagheBandi Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TabagheBandi.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_TabagheBandi> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            return TabagheBandi.Select(FieldName, FilterValue,FilterValue2, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldComisionID, int? fldPID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TabagheBandi.Insert(fldName, fldComisionID, fldPID, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldComisionID, int? fldPID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TabagheBandi.Update(Id, fldName, fldComisionID, fldPID, OrganID, UserId, Desc, IP);

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

            return TabagheBandi.Delete(id, userId);
        }
        #endregion
    }
}