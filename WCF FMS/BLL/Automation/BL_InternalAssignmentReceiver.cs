using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_InternalAssignmentReceiver
    {
        DL_InternalAssignmentReceiver InternalAssignmentReceiver = new DL_InternalAssignmentReceiver();

        #region Detail
        public OBJ_InternalAssignmentReceiver Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return InternalAssignmentReceiver.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_InternalAssignmentReceiver> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return InternalAssignmentReceiver.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            else if (fldAssignmentStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ارجاع ضروری است";
            }
            else if (fldAssignmentTypeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentReceiver.Insert(fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            else if (fldAssignmentStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ارجاع ضروری است";
            }
            else if (fldAssignmentTypeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentReceiver.Update(Id, fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, OrganID, UserId, Desc, IP);

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

            return InternalAssignmentReceiver.Delete(id, userId);
        }
        #endregion
        #region UpdateInternalAssignmentReceiverBox
        public string UpdateInternalAssignmentReceiverBox(int Id, int fldBoxID, int UserId, out ClsError error)
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

            return InternalAssignmentReceiver.UpdateInternalAssignmentReceiverBox(Id, fldBoxID, UserId);

        }
        #endregion

        #region UpdateInternalAssignmentReceiverStatus
        public string UpdateInternalAssignmentReceiverStatus(int Id, int fldStatusID, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            
            else if (fldStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ارجاع ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalAssignmentReceiver.UpdateInternalAssignmentReceiverStatus(Id, fldStatusID,  UserId );

        }
        #endregion
    }
}