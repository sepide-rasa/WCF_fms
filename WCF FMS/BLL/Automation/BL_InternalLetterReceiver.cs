using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_InternalLetterReceiver
    {
        DL_InternalLetterReceiver InternalLetterReceiver = new DL_InternalLetterReceiver();

        #region Detail
        public OBJ_InternalLetterReceiver Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return InternalLetterReceiver.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_InternalLetterReceiver> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return InternalLetterReceiver.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalLetterReceiver.Insert(fldLetterId, fldMessageId, fldReceiverComisionID, fldAssignmentStatusID, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int? fldMessageId, int fldReceiverComisionID, int? fldAssignmentStatusID, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return InternalLetterReceiver.Update(Id, fldLetterId, fldMessageId, fldReceiverComisionID, fldAssignmentStatusID, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(long id, int userId, out ClsError error)
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

            return InternalLetterReceiver.Delete(id, userId);
        }
        #endregion
    }
}