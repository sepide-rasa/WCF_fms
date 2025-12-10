using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_InternalAssignmentSender
    {
        DL_InternalAssignmentSender InternalAssignmentSender = new DL_InternalAssignmentSender();

        #region Detail
        public OBJ_InternalAssignmentSender Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return InternalAssignmentSender.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_InternalAssignmentSender> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return InternalAssignmentSender.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldAssignmentID, int fldSenderComisionID, int fldBoxID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldAssignmentID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع ضروری است";
            }
            else if (fldSenderComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع دهنده ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentSender.Insert(fldAssignmentID, fldSenderComisionID, fldBoxID, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldSenderComisionID, int fldBoxID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldAssignmentID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع ضروری است";
            }
            else if (fldSenderComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع دهنده ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentSender.Update(Id, fldAssignmentID, fldSenderComisionID, fldBoxID, OrganID, UserId, Desc, IP);

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

            return InternalAssignmentSender.Delete(id, userId);
        }
        #endregion

        #region UpdateInternalAssignmentSenderBox
        public string UpdateInternalAssignmentSenderBox(int Id, int fldBoxID, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentSender.UpdateInternalAssignmentSenderBox(Id, fldBoxID, UserId);

        }
        #endregion
    }
}